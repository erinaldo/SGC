using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_SALVASENHA
    {
        public Operacao OPERACAO { get; set; }
        public int ID_SALVASENHA { get; set; }
        public E_USUARIO LOGIN { get; set; }
        public string DS_OBSERVACAO{ get; set; }
        public string SENHA { get; set; }

        public E_SALVASENHA(TB_DIV_SALVASENHA salvasenha = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (salvasenha != null)
            {
                this.ID_SALVASENHA = salvasenha.ID_SALVASENHA;
                this.LOGIN = salvasenha.TB_DIV_USUARIO != null ? new E_USUARIO(salvasenha.TB_DIV_USUARIO) : null;
                this.DS_OBSERVACAO = salvasenha.DS_OBSERVACAO;
                this.SENHA = salvasenha.SENHA;
            }
        }
    }
}
