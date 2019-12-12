using Componentes;
using Consultas;
using Entidades;
using Formas.Pesquisa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FModelo_Cadastro : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_MODELO modelo = new E_MODELO();

        #endregion

        #region Métodos

        public FModelo_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cbe_Marca_Leave();

                cpc_DadosGerais.Controls.Validate();

                modelo = new E_MODELO
                {
                    OPERACAO = Operacao,
                    ID_MODELO = cte_Identificador.Text.ToInt(),
                    DS_MODELO = cte_Descricao.Text.Treat(),
                    MARCA = cbe_Marca.Text.HasValue() ? new E_MARCA { ID_MARCA = cbe_Marca.Text.ToInt() } : null
                };

                var transacao = 0;

                if (C_MODELO.Salvar(modelo, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FModelo_Cadastro_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                if (Operacao == Utilidades.Operacao.Alterar)
                {
                    cte_Identificador.Text = modelo.ID_MODELO.ToString();
                    cte_Descricao.Text = modelo.DS_MODELO.Treat();
                    if (modelo.MARCA != null)
                    {
                        cbe_Marca.Text = modelo.MARCA.ID_MARCA.ToString();
                        cte_DS_Marca.Text = modelo.MARCA.DS_MARCA.Treat();
                    }
                }

                cte_Descricao.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_Marca_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_DS_Marca.Text = "";
                cbe_Marca.Text.ToInt();

                if (cbe_Marca.Text.ToInt() <= 0)
                    cbe_Marca.Text = "";
                else
                {
                    var marca = (from a in Conexao.Banco.TB_DIV_MARCAs where a.ID_MARCA == cbe_Marca.Text.ToInt() select a.DS_MARCA).Take(1);

                    if (marca == null || marca.Count() == 0)
                        cbe_Marca.Text = "";
                    else
                        cte_DS_Marca.Text = marca.First().Treat();
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_Marca_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    var filtros = new List<FPesquisa.Filtro>();

                    var id_marca = new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_MARCA", Tamanho = 100 };
                    var ds_marca = new FPesquisa.Filtro { Descricao = "Descrição", Nome = "DS_MARCA", Tamanho = 350 };

                    filtros.Add(id_marca);
                    filtros.Add(ds_marca);

                    formaPesquisa.Filtros = filtros;
                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_MARCAs select new E_MARCA(a);

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Marca.Text = formaPesquisa.Selecionados.Cast<E_MARCA>().First().ID_MARCA.ToString();
                        cte_DS_Marca.Text = formaPesquisa.Selecionados.Cast<E_MARCA>().First().DS_MARCA.Treat();
                    }
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