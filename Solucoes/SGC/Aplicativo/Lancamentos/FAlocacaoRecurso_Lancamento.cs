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

namespace Aplicativo.Lancamentos
{
    public partial class FAlocacaoRecurso_Lancamento : FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_ALOCACAORECURSO alocacaoRecurso = new E_ALOCACAORECURSO();

        #endregion

        #region Métodos

        public FAlocacaoRecurso_Lancamento()
        {
            InitializeComponent();
        }
        public override void Salvar()
        {
            try
            {
                cbe_Equipamento_Leave();
                cbe_Grupo_Leave();

                cpc_DadosGerais.Controls.Validate();

                var data_inicio = cde_DT_INICIO_HMS.DateTime.AddSeconds(-cde_DT_INICIO_HMS.DateTime.Second);
                var data_final = cde_DT_FINAL_HMS.DateTime.AddSeconds(-cde_DT_FINAL_HMS.DateTime.Second).AddSeconds(59);
                
                alocacaoRecurso = new E_ALOCACAORECURSO
                {
                    OPERACAO = Operacao,
                    ID_ALOCACAO = cte_Identificador.Text.ToInt(),
                    DS_OBSERVACAO = cte_Descricao.Text.Treat(),
                    ST_REGISTRO = cce_Status.Checked ? "S" : "N",
                    EQUIPAMENTO = cbe_Equipamento.Text.Treat(),
                    GRUPOUSUARIO = cbe_Grupo.Text.Treat(),
                    DT_INICIO_HMS = data_inicio,
                    DT_FINAL_HMS =  data_final
                };

                var transacao = 0;

                if (C_ALOCACAORECURSO.Salvar(alocacaoRecurso, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FAlocacaoRecurso_Lancamento_Load(object sender, EventArgs e)
        {
            try
            {
                cde_DT_INICIO_HMS.DateTime = Conexao.Banco.GetDate();
                cde_DT_FINAL_HMS.DateTime = cde_DT_INICIO_HMS.DateTime;

                if (Operacao == Operacao.Alterar)
                {
                    cte_Identificador.Text = alocacaoRecurso.ID_ALOCACAO.ToString();
                    cte_Descricao.Text = alocacaoRecurso.DS_OBSERVACAO.Treat();
                    cce_Status.Checked = alocacaoRecurso.ST_REGISTRO.Treat() == "S";
                    cbe_Equipamento.Text = alocacaoRecurso.EQUIPAMENTO.GetValue();
                    cbe_Equipamento_Leave();
                    cbe_Grupo.Text = alocacaoRecurso.GRUPOUSUARIO.GetValue();
                    cbe_Grupo_Leave();
                    cde_DT_INICIO_HMS.DateTime = alocacaoRecurso.DT_INICIO_HMS.GetValueOrDefault();
                    cde_DT_FINAL_HMS.DateTime = alocacaoRecurso.DT_FINAL_HMS.GetValueOrDefault();
                }

                cte_Descricao.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_Equipamento_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_DS_Observacao.Text = "";
                cbe_Equipamento.Text.ToInt();

                if (cbe_Equipamento.Text.ToInt() <= 0)
                    cbe_Equipamento.Text = "";
                else
                {
                    var equipamento = (from a in Conexao.Banco.TB_DIV_EQUIPAMENTOs
                                       where a.ID_EQUIPAMENTO == cbe_Equipamento.Text.ToInt()
                                       select new
                                       {
                                           DS_OBSERVACAO = (a.DS_OBSERVACAO ?? "")
                                       }).Take(1);

                    if (equipamento == null || equipamento.Count() == 0)
                        cbe_Equipamento.Text = "";
                    else
                        cte_DS_Observacao.Text = equipamento.First().DS_OBSERVACAO.Treat();
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void cbe_Equipamento_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    formaPesquisa.Filtros = new List<FPesquisa.Filtro>()
                    {
                        new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_EQUIPAMENTO", Tamanho = 100 },
                        new FPesquisa.Filtro { Descricao = "Observação", Nome = "DS_OBSERVACAO", Tamanho = 350 },
                        new FPesquisa.Filtro { Descricao = "Aquisição", Nome = "DT_AQUISICAO", Tamanho = 75 },
                        new FPesquisa.Filtro { Descricao = "Identificação", Nome = "NR_IDENTIFICACAO", Tamanho = 75 },
                        new FPesquisa.Filtro { Descricao = "Grupo", Nome = "GRUPO", Tamanho = 75 },
                        new FPesquisa.Filtro { Descricao = "Status", Nome = "STATUS", Tamanho = 75 },
                    };
                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_EQUIPAMENTOs
                                             select new
                                             {
                                                 a.ID_EQUIPAMENTO,
                                                 a.DS_OBSERVACAO,
                                                 a.DT_AQUISICAO,
                                                 a.NR_IDENTIFICACAO,
                                                 GRUPO = a.TB_DIV_GRUPOPRODUTO != null ? (a.TB_DIV_GRUPOPRODUTO.ID_GRUPO + " - " + a.TB_DIV_GRUPOPRODUTO.DS_GRUPO) : "",
                                                 STATUS = ((a.ST_ATIVO ?? "A") == "A") ? "ATIVO" : "CANCELADO"
                                             };

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Equipamento.Text = formaPesquisa.SelecionadosDataTable.Rows[0]["ID_EQUIPAMENTO"].ToString();
                        cte_DS_Observacao.Text = formaPesquisa.SelecionadosDataTable.Rows[0]["DS_OBSERVACAO"].ToString();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_Grupo_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_DS_Grupo.Text = "";
                cbe_Grupo.Text.ToInt();

                if (cbe_Grupo.Text.ToInt() <= 0)
                    cbe_Grupo.Text = "";
                else
                {
                    var grupo = (from a in Conexao.Banco.TB_DIV_GRUPOUSUARIOs
                                 where a.ID_GRUPOUSUARIO == cbe_Grupo.Text.ToInt()
                                 select new
                                 {
                                     DS_GRUPO = (a.DS_GRUPO ?? "")
                                 }).Take(1);

                    if (grupo == null || grupo.Count() == 0)
                        cbe_Grupo.Text = "";
                    else
                        cte_DS_Grupo.Text = grupo.First().DS_GRUPO.Treat();
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void cbe_Grupo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    formaPesquisa.Filtros = new List<FPesquisa.Filtro>()
                    {
                        new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_GRUPOUSUARIO", Tamanho = 100 },
                        new FPesquisa.Filtro { Descricao = "Observação", Nome = "DS_GRUPO", Tamanho = 350 }
                    };
                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_GRUPOUSUARIOs select new E_GRUPOUSUARIO(a);

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Grupo.Text = formaPesquisa.Selecionados.Cast<E_GRUPOUSUARIO>().First().ID_GRUPOUSUARIO.ToString();
                        cte_DS_Grupo.Text = formaPesquisa.Selecionados.Cast<E_GRUPOUSUARIO>().First().DS_GRUPO.Treat();
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