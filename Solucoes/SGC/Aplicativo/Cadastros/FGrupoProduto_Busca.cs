using Consultas;
using Entidades;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FGrupoProduto_Busca : Formas.Padrao.FPadrao_Busca_Menu
    {
        #region Declarações

        public E_GRUPOPRODUTO grupoproduto = new E_GRUPOPRODUTO();

        #endregion

        #region Métodos

        public FGrupoProduto_Busca()
        {
            InitializeComponent();

            Identificador = "C5";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FGrupoProduto_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        grupoproduto = forma.grupoproduto;
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

                if (gv_GrupoProduto.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FGrupoProduto_Cadastro { Operacao = Operacao.Alterar, grupoproduto = gv_GrupoProduto.GetSelectedRow<E_GRUPOPRODUTO>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        grupoproduto = forma.grupoproduto;
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

                foreach (var indiceSelecionado in gv_GrupoProduto.GetSelectedRows())
                {
                    var registro = gv_GrupoProduto.GetRow(indiceSelecionado) as E_GRUPOPRODUTO;

                    if (registro != null)
                    {
                        registro.OPERACAO = Operacao.Deletar;

                        var transacao = 0;

                        C_GRUPOPRODUTO.Salvar(registro, ref transacao);
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

                var grupos = from a in Conexao.Banco.TB_DIV_GRUPOPRODUTOs
                             where a.ID_GRUPO == (grupoproduto.ID_GRUPO > 0 ? grupoproduto.ID_GRUPO : a.ID_GRUPO)
                               select a;

                if (Quantidade > 0)
                    grupos = grupos.Take(Quantidade);

                gc_GrupoProduto.DataSource = grupos.Select(a => new E_GRUPOPRODUTO(a)).ToList();
                gv_GrupoProduto.BestFitColumns();

                grupoproduto = new E_GRUPOPRODUTO();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_GrupoProduto.ToGridList<E_GRUPOPRODUTO>());
            RelatorioSalvar();
        }

        #endregion

        #region Eventos

        #endregion
    }
}
