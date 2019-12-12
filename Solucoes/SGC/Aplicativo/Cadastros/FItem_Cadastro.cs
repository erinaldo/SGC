using Componentes;
using Consultas;
using Entidades;
using Formas.Padrao;
using Formas.Pesquisa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FItem_Cadastro : FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_ITEM item = new E_ITEM();

        #endregion

        #region Métodos

        public FItem_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cbe_Modelo_Leave();
                cbe_GrupoProduto_Leave();

                cpc_DadosGerais.Controls.Validate();

                item = new E_ITEM
                {
                    OPERACAO = Operacao,
                    ID_ITEM = cte_Identificador.Text.ToInt(),
                    DS_ITEM = cte_Descricao.Text.Treat(),
                    GRUPOPRODUTO = cbe_GrupoProduto.Text.HasValue() ? new E_GRUPOPRODUTO { ID_GRUPO = cbe_GrupoProduto.Text.ToInt() } : null,
                    MODELO = cbe_Modelo.Text.HasValue() ? new E_MODELO { ID_MODELO = cbe_Modelo.Text.ToInt() } : null
                };

                var transacao = 0;

                if (C_ITEM.Salvar(item, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FItem_Cadastro_Load(object sender, EventArgs e)
        {
            try
            {
                if (Operacao == Utilidades.Operacao.Alterar)
                {
                    cte_Identificador.Text = item.ID_ITEM.ToString();
                    cte_Descricao.Text = item.DS_ITEM.Treat();
                    cbe_Modelo.Text = item.MODELO != null ? item.MODELO.ID_MODELO.ToString() : "";
                    cbe_Modelo_Leave();
                    cbe_GrupoProduto.Text = item.GRUPOPRODUTO != null ? item.GRUPOPRODUTO.ID_GRUPO.ToString() : "";
                    cbe_GrupoProduto_Leave();
                }

                cte_Descricao.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_Modelo_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                var id = cbe_Modelo.Text.ToInt();

                cbe_Modelo.Text = "";
                cte_DS_Modelo.Text = "";
                cte_DS_Marca.Text = "";

                if (id > 0)
                {
                    var modelo = (from a in Conexao.Banco.TB_DIV_MODELOs
                                  where a.ID_MODELO == id
                                  select new
                                  {
                                      a.ID_MODELO,
                                      a.DS_MODELO,
                                      a.TB_DIV_MARCA.DS_MARCA
                                  }).FirstOrDefault();

                    if (modelo != null)
                    {
                        cbe_Modelo.Text = modelo.ID_MODELO.ToString();
                        cte_DS_Modelo.Text = modelo.DS_MODELO.Treat();
                        cte_DS_Marca.Text = modelo.DS_MARCA.Treat();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void cbe_Modelo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    formaPesquisa.Filtros = new List<FPesquisa.Filtro>
                    {
                       new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_MODELO", Tamanho = 100 },
                       new FPesquisa.Filtro { Descricao = "Modelo", Nome = "DS_MODELO", Tamanho = 350 },
                       new FPesquisa.Filtro { Descricao = "Marca", Nome = "DS_MARCA", Tamanho = 350 },
                    };

                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_MODELOs
                                             select new
                                             {
                                                 a.ID_MODELO,
                                                 a.DS_MODELO,
                                                 a.TB_DIV_MARCA.DS_MARCA
                                             };

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Modelo.Text = formaPesquisa.SelecionadosDataTable.Rows[0]["ID_MODELO"].ToString();
                        cte_DS_Modelo.Text = formaPesquisa.SelecionadosDataTable.Rows[0]["DS_MODELO"].ToString();
                        cte_DS_Marca.Text = formaPesquisa.SelecionadosDataTable.Rows[0]["DS_MARCA"].ToString();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_GrupoProduto_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                var id = cbe_GrupoProduto.Text.ToInt();

                cbe_GrupoProduto.Text = "";
                cte_DS_GrupoProduto.Text = "";

                if (id > 0)
                {
                    var grupo = (from a in Conexao.Banco.TB_DIV_GRUPOPRODUTOs
                                 where a.ID_GRUPO == id
                                 select new
                                 {
                                     a.ID_GRUPO,
                                     a.DS_GRUPO
                                 }).FirstOrDefault();

                    if (grupo != null)
                    {
                        cbe_GrupoProduto.Text = grupo.ID_GRUPO.ToString();
                        cte_DS_GrupoProduto.Text = grupo.DS_GRUPO.Treat();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void cbe_GrupoProduto_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    var filtros = new List<FPesquisa.Filtro>();

                    var id_grupo = new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_GRUPO", Tamanho = 100 };
                    var ds_grupo = new FPesquisa.Filtro { Descricao = "Nome", Nome = "DS_GRUPO", Tamanho = 350 };

                    filtros.Add(id_grupo);
                    filtros.Add(ds_grupo);

                    formaPesquisa.Filtros = filtros;
                    formaPesquisa.Multiplos = false;
                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_GRUPOPRODUTOs select new E_GRUPOPRODUTO(a);

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_GrupoProduto.Text = formaPesquisa.Selecionados.Cast<E_GRUPOPRODUTO>().First().ID_GRUPO.ToString();
                        cte_DS_GrupoProduto.Text = formaPesquisa.Selecionados.Cast<E_GRUPOPRODUTO>().First().DS_GRUPO.Treat();
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