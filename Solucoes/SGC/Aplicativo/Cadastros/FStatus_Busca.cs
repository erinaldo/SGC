using Consultas;
using DevExpress.XtraGrid.Views.Base;
using Entidades;
using Formas.Padrao;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FStatus_Busca : FPadrao_Busca_Menu
    {
        #region Declarações

        private E_STATUS status = new E_STATUS();

        #endregion

        #region Métodos

        public FStatus_Busca()
        {
            InitializeComponent();

            Identificador = "C11";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FStatus_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        status = forma.status;
                        Buscar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Alterar()
        {
            try
            {
                base.Alterar();

                if (gv_Status.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FStatus_Cadastro { Operacao = Operacao.Alterar, status = gv_Status.GetSelectedRow<E_STATUS>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        status = forma.status;
                        Buscar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Deletar()
        {
            try
            {
                base.Deletar();

                foreach (var indiceSelecionado in gv_Status.GetSelectedRows())
                {
                    var registro = gv_Status.GetRow(indiceSelecionado) as E_STATUS;

                    if (registro != null)
                    {
                        registro.OPERACAO = Operacao.Deletar;

                        var transacao = 0;

                        C_STATUS.Salvar(registro, ref transacao);
                        Buscar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Buscar()
        {
            try
            {
                base.Buscar();

                var usuarios = from a in Conexao.Banco.TB_DIV_STATUS
                               where a.SIGLA_STATUS == (status.SIGLA_STATUS.HasValue() ? status.SIGLA_STATUS : a.SIGLA_STATUS)
                               select a;

                if (Quantidade > 0)
                    usuarios = usuarios.Take(Quantidade);

                gc_Status.DataSource = usuarios.Select(a => new E_STATUS(a)).ToList();
                gv_Status.BestFitColumns();

                status = new E_STATUS();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Status.ToGridList<E_STATUS>());
            RelatorioSalvar();
        }

        #endregion

        #region Eventos

        private void gv_Status_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            try
            {
                switch (e.Column.Name)
                {
                    case "colST_TEMPORIZAR":
                    case "colST_AUTORIZAR":
                    case "colST_INICIAR":
                    case "colST_FINALIZAR": e.DisplayText = (e.CellValue != null) ? (e.CellValue.ToString().Treat() == "S" ? "Sim" : e.CellValue.ToString().Treat() == "N" ? "Não" : e.CellValue.ToString()) : ""; break;
                    default: return;
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion
    }
}