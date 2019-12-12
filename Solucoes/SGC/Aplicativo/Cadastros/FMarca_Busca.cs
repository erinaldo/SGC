using Consultas;
using Entidades;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FMarca_Busca : Formas.Padrao.FPadrao_Busca_Menu
    {
        #region Declarações

        public E_MARCA marca = new E_MARCA();

        #endregion

        public FMarca_Busca()
        {
            InitializeComponent();

            Identificador = "C9";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FMarca_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        marca = forma.marca;
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

                if (gv_Marca.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FMarca_Cadastro { Operacao = Operacao.Alterar, marca = gv_Marca.GetSelectedRow<E_MARCA>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        marca = forma.marca;
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

                if (gv_Marca.GetSelectedRows().Count() > 0 && Mensagens.Deletar() == DialogResult.Yes)
                {
                    foreach (var indiceSelecionado in gv_Marca.GetSelectedRows())
                    {
                        var registro = gv_Marca.GetRow(indiceSelecionado) as E_MARCA;

                        if (registro != null)
                        {
                            registro.OPERACAO = Operacao.Deletar;

                            var transacao = 0;

                            C_MARCA.Salvar(registro, ref transacao);
                        }
                    }

                    Buscar();
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

                var marcas = from a in Conexao.Banco.TB_DIV_MARCAs
                             where a.ID_MARCA == (marca.ID_MARCA > 0 ? marca.ID_MARCA : a.ID_MARCA)
                             select a;

                if (Quantidade > 0)
                    marcas = marcas.Take(Quantidade);

                gc_Marca.DataSource = marcas.Select(a => new E_MARCA(a)).ToList();
                gv_Marca.BestFitColumns();

                marca = new E_MARCA();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Marca.ToGridList<E_MARCA>());
            RelatorioSalvar();
        }
    }
}