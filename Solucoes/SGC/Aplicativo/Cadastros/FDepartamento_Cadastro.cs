using Componentes;
using Consultas;
using Entidades;
using System;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FDepartamento_Cadastro : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_DEPARTAMENTO departamento = new E_DEPARTAMENTO();

        #endregion

        #region Métodos

        public FDepartamento_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                departamento = new E_DEPARTAMENTO
                {
                    OPERACAO = Operacao,
                    ID_DEPARTAMENTO = cte_Identificador.Text.ToInt(),
                    DS_DEPARTAMENTO = cte_Descricao.Text.Treat(),
                };

                var transacao = 0;

                if (C_DEPARTAMENTO.Salvar(departamento, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FDepartamento_Cadastro_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                if (Operacao == Utilidades.Operacao.Alterar)
                {
                    cte_Identificador.Text = departamento.ID_DEPARTAMENTO.ToString();
                    cte_Descricao.Text = departamento.DS_DEPARTAMENTO.Treat();
                }

                cte_Descricao.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion
    }
}