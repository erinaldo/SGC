using System.Windows.Forms;

namespace Utilidades
{
    public static class Mensagens
    {
        public static void Sucesso()
        {
            MessageBox.Show("Registro gravado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Sucesso(string mensagem, MessageBoxButtons botoes, MessageBoxIcon icone)
        {
            MessageBox.Show(mensagem, "Sucesso!", botoes, icone);
        }

        public static void Alerta(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult Pergunta(string mensagem) 
        {
            return MessageBox.Show(mensagem, "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult Deletar()
        {
            return MessageBox.Show("Deseja realmente deletar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
