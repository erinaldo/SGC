using Consultas;
using Entidades;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FClifor_Busca : Formas.Padrao.FPadrao_Busca_Menu
    {
        #region Declarações

        public E_CLIFOR clifor = new E_CLIFOR();

        #endregion

        #region Métodos

        public FClifor_Busca()
        {
            InitializeComponent();

            Identificador = "C13";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FClifor_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        clifor = forma.clifor;
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

                if (gv_Clifor.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FClifor_Cadastro { Operacao = Operacao.Alterar, clifor = gv_Clifor.GetSelectedRow<E_CLIFOR>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        clifor = forma.clifor;
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

                foreach (var indiceSelecionado in gv_Clifor.GetSelectedRows())
                {
                    var registro = gv_Clifor.GetRow(indiceSelecionado) as E_CLIFOR;

                    if (registro != null)
                    {
                        registro.OPERACAO = Operacao.Deletar;

                        var transacao = 0;

                        C_CLIFOR.Salvar(registro, ref transacao);
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

                var clifors = from a in Conexao.Banco.TB_DIV_CLIFORs
                             where a.ID_CLIFOR == (clifor.ID_CLIFOR > 0 ? clifor.ID_CLIFOR : a.ID_CLIFOR)
                               select a;

                if (Quantidade > 0)
                    clifors = clifors.Take(Quantidade);

                gc_Clifor.DataSource = clifors.Select(a => new E_CLIFOR(a)).ToList();
                gv_Clifor.BestFitColumns();

                clifor = new E_CLIFOR();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Clifor.ToGridList<E_CLIFOR>());
            RelatorioSalvar();
        }

        #endregion

        #region Eventos

        #endregion
    }
}
