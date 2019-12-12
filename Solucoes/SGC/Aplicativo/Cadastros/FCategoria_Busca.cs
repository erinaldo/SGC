using Consultas;
using Entidades;
using Formas.Padrao;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FCategoria_Busca : FPadrao_Busca_Menu
    {
        #region Declarações

        public E_CATEGORIA categoria = new E_CATEGORIA();

        #endregion

        public FCategoria_Busca()
        {
            InitializeComponent();

            Identificador = "C7";
            DefinirPermissoes();
        }

        #region Métodos

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FCategoria_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        categoria = forma.categoria;
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

                if (gv_Categoria.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FCategoria_Cadastro { Operacao = Operacao.Alterar, categoria = gv_Categoria.GetSelectedRow<E_CATEGORIA>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        categoria = forma.categoria;
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

                foreach (var indiceSelecionado in gv_Categoria.GetSelectedRows())
                {
                    var registro = gv_Categoria.GetRow(indiceSelecionado) as E_CATEGORIA;

                    if (registro != null)
                    {
                        var transacao = 0;

                        registro.OPERACAO = Operacao.Deletar;
                        C_CATEGORIA.Salvar(registro, ref transacao);

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

                var categorias = from a in Conexao.Banco.TB_DIV_CATEGORIAs
                                 where a.ID_CATEGORIA == (categoria.ID_CATEGORIA > 0 ? categoria.ID_CATEGORIA : a.ID_CATEGORIA)
                                 select a;

                if (Quantidade > 0)
                    categorias = categorias.Take(Quantidade);

                gc_Categoria.DataSource = categorias.Select(a => new E_CATEGORIA(a));
                gv_Categoria.BestFitColumns();

                categoria = new E_CATEGORIA();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Categoria.ToGridList<E_CATEGORIA>());
            RelatorioSalvar();
        }

        #endregion
    }
}
