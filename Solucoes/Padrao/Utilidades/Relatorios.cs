using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Utilidades
{
    public class Relatorios
    {
        private static XtraReport report;
        private static object dataSource;

        public static void Gerar(XtraReport xtraReport, object data, bool edit, List<Parameter> parametros = null)
        {
            if (xtraReport != null || xtraReport != new XtraReport())
                report = xtraReport;

            dataSource = data;
            report.DataSource = dataSource;
            report.RequestParameters = false;

            if (parametros != null)
                foreach (var parametro in parametros)
                    if (report.Parameters != null)
                    {
                        var parametroAtual = report.Parameters[parametro.Name];

                        if (parametroAtual == null)
                            report.Parameters.Add(parametro);
                        else
                            parametroAtual.Value = parametro.Value;
                    }

            if (edit)
            {
                using (var xrDesignForm = new XRDesignForm())
                {
                    var mdiController = xrDesignForm.DesignMdiController;

                    mdiController.DesignPanelLoaded += (s, e) => mdiController.AddCommandHandler(new CommandHandler((XRDesignPanel)s));
                    mdiController.OpenReport(report);
                    xrDesignForm.ShowDialog();

                    if (mdiController.ActiveDesignPanel != null)
                        mdiController.ActiveDesignPanel.CloseReport();
                }
            }
            else
                using (var reportPrintTool = new ReportPrintTool(report))
                {
                    reportPrintTool.AutoShowParametersPanel = false;
                    reportPrintTool.PreviewForm.WindowState = FormWindowState.Maximized;
                    reportPrintTool.ShowPreviewDialog();
                }

            xtraReport = report;
        }

        public static void Salvar(XtraReport xtraReport, string IdentificadorTela)
        {
            xtraReport.DisplayName = (xtraReport.DisplayName.Length > 0 ? xtraReport.DisplayName : IdentificadorTela).Treat();

            var transacao = 0;

            Conexao.Iniciar(ref transacao);

            if (!Conexao.Banco.TB_DIV_MENUs.Any(a => a.ID_MENU == IdentificadorTela))
            {
                Conexao.Banco.TB_DIV_MENUs.InsertOnSubmit(new TB_DIV_MENU { ID_MENU = IdentificadorTela, DS_MENU = xtraReport.DisplayName });
                Conexao.Enviar();
            }

            Conexao.Banco.CAD_DIV_RELATORIO(0, IdentificadorTela, xtraReport.DisplayName, xtraReport.Save());
            Conexao.Finalizar(ref transacao);
        }

        private class CommandHandler : ICommandHandler
        {
            XRDesignPanel panel;

            public CommandHandler(XRDesignPanel panel)
            {
                this.panel = panel;
            }

            public void HandleCommand(ReportCommand command, object[] args)
            {
                switch (command)
                {
                    case ReportCommand.SaveFile:
                    case ReportCommand.SaveFileAs:
                    case ReportCommand.Closing: Save(); return;
                    case ReportCommand.OpenFile: Open(); return;
                    default: return;
                }
            }

            public bool CanHandleCommand(ReportCommand command, ref bool useNextHandler)
            {
                useNextHandler = !(command == ReportCommand.SaveFile || command == ReportCommand.SaveFileAs || command == ReportCommand.Closing || command == ReportCommand.OpenFile);
                return !useNextHandler;
            }

            void Save()
            {
                report = panel.Report;
                panel.ReportState = ReportState.Saved;
            }

            void Open()
            {
                panel.OpenReportFile();
                report = panel.Report;
                report.DataSource = dataSource;
                panel.ReportState = ReportState.Opened;
            }
        }
    }
}