using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;
using Utilidades;
using System.Linq;
using DevExpress.XtraReports.Parameters;
using System.Collections.Generic;

namespace Formas.Padrao
{
    public partial class FPadrao_Relatorio : FPadrao
    {
        public static string Identificador = "";
        public static bool RelatorioAlterar;
        public static XtraReport RelatorioArquivo = new XtraReport();

        public FPadrao_Relatorio()
        {
            InitializeComponent();
        }

        public virtual void Gerar()
        {
            Relatorio();
        }

        public virtual void Relatorio()
        {
            var consulta = Conexao.Banco.TB_DIV_RELATORIOs.Where(a => a.ID_MENU == Identificador.Treat()).OrderByDescending(a => a.ID_RELATORIO);
            RelatorioArquivo = consulta.Count() > 0 ? consulta.First().ARQUIVO.ToXtraReport() : new XtraReport();
        }

        private void csb_Gerar_Click(object sender = null, EventArgs e = null)
        {
            this.Gerar();
        }

        private void csb_Cancelar_Click(object sender = null, EventArgs e = null)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        public static void RelatorioGerar(object data, List<Parameter> parametros = null)
        {
            Relatorios.Gerar(RelatorioArquivo, data, RelatorioAlterar, parametros);
        }

        public static void RelatorioSalvar()
        {
            if (RelatorioAlterar)
                Relatorios.Salvar(RelatorioArquivo, Identificador);

            RelatorioAlterar = false;
        }

        private void FPadrao_Relatorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.R)
            {
                RelatorioAlterar = true;
                Mensagens.Sucesso("Clique em gerar para editar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.KeyCode == Keys.F2)
                csb_Gerar_Click();
            else if (e.KeyCode == Keys.Escape)
                csb_Cancelar_Click();
        }
    }
}