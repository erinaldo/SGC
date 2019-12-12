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
    public partial class FCategoria_Cadastro : FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_CATEGORIA categoria = new E_CATEGORIA();

        #endregion

        #region Métodos

        public FCategoria_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cbe_Departamento_Leave();

                cpc_DadosGerais.Controls.Validate();

                categoria = new E_CATEGORIA
                {
                    OPERACAO = Operacao,
                    ID_CATEGORIA = cte_Identificador.Text.ToInt(),
                    DS_CATEGORIA = cte_Descricao.Text.Treat(),
                    DEPARTAMENTO = new E_DEPARTAMENTO { ID_DEPARTAMENTO = cbe_Departamento.Text.ToInt() },
                    GRAVIDADE = ccbe_Gravidade.GetSelectedValue(),
                    CLASSIFICACAO = cte_Classificacao.Text,
                    TEMPO_HORA_MAX = (int?)cse_TempoMax.Value,
                    TEMPO_HORA_MIN = (int?)cse_TempoMin.Value,
                };

                var transacao = 0;

                if (C_CATEGORIA.Salvar(categoria, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FCategoria_Cadastro_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                ccbe_Gravidade.SetValue(new CComboBoxEditValue { ID = "1", DS = "ALTA" });
                ccbe_Gravidade.SetValue(new CComboBoxEditValue { ID = "2", DS = "MÉDIA" });
                ccbe_Gravidade.SetValue(new CComboBoxEditValue { ID = "3", DS = "BAIXA" });
                ccbe_Gravidade.SetFirst();

                if (Operacao == Operacao.Alterar)
                {
                    cte_Identificador.Text = categoria.ID_CATEGORIA.ToString();
                    cte_Descricao.Text = categoria.DS_CATEGORIA.Treat();
                    cbe_Departamento.Text = categoria.DEPARTAMENTO.ID_DEPARTAMENTO.ToString();
                    cbe_Departamento_Leave();
                    ccbe_Gravidade.SetSelected(categoria.GRAVIDADE);
                    cte_Classificacao.Text = categoria.CLASSIFICACAO.Treat();
                    cse_TempoMin.Value = categoria.TEMPO_HORA_MIN.GetValueOrDefault();
                    cse_TempoMax.Value = categoria.TEMPO_HORA_MAX.GetValueOrDefault();
                }

                cte_Descricao.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_Departamento_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_DS_Departamento.Text = "";
                cbe_Departamento.Text.ToInt();

                if (cbe_Departamento.Text.ToInt() <= 0)
                    cbe_Departamento.Text = "";
                else
                {
                    var departamento = (from a in Conexao.Banco.TB_DIV_DEPARTAMENTOs where a.ID_DEPARTAMENTO == cbe_Departamento.Text.ToInt() select new E_DEPARTAMENTO(a)).Take(1);

                    if (departamento == null || departamento.Count() == 0)
                        cbe_Departamento.Text = "";
                    else
                        cte_DS_Departamento.Text = departamento.First().DS_DEPARTAMENTO.Treat();
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void cbe_Departamento_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    var filtros = new List<FPesquisa.Filtro>();

                    var id_departamento = new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_DEPARTAMENTO", Tamanho = 100 };
                    var ds_departamento = new FPesquisa.Filtro { Descricao = "Nome", Nome = "DS_DEPARTAMENTO", Tamanho = 350 };

                    filtros.Add(id_departamento);
                    filtros.Add(ds_departamento);

                    formaPesquisa.Filtros = filtros;
                    formaPesquisa.Multiplos = false;
                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_DEPARTAMENTOs select new E_DEPARTAMENTO(a);

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Departamento.Text = formaPesquisa.Selecionados.Cast<E_DEPARTAMENTO>().First().ID_DEPARTAMENTO.ToString();
                        cte_DS_Departamento.Text = formaPesquisa.Selecionados.Cast<E_DEPARTAMENTO>().First().DS_DEPARTAMENTO.Treat();
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