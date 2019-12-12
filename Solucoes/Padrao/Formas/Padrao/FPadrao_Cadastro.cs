using System;
using System.Windows.Forms;
using Utilidades;

namespace Formas.Padrao
{
    public partial class FPadrao_Cadastro : FPadrao
    {
        public Operacao Operacao = new Operacao();

        public FPadrao_Cadastro()
        {
            InitializeComponent();

            Operacao = Operacao.Normal;
        }

        public virtual void Salvar()
        {
        }

        public void Finalizar(DialogResult resultado = DialogResult.OK)
        {
            this.DialogResult = resultado;
            this.Dispose();
        }

        public virtual void Cancelar()
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                this.Dispose();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
    }
}