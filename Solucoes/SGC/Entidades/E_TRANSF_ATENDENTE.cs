using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_TRANSF_ATENDENTE
    {
        public Operacao OPERACAO { get; set; }
        public int ID_CHAMADO { get; set; }
        public int ID_TRANSF_ATENDENTE { get; set; }
        public string LOGIN_NEW { get; set; }
        public string LOGIN_OLD { get; set; }
        public string DS_MOTIVO { get; set; }

        //public E_TRANSF_ATENDENTE(TB_DIV_TRANSF_ATENDENTE transf_atendente = null)
        //{
        //    this.OPERACAO = Operacao.Normal;

        //    if (transf_atendente != null)
        //    {
        //        this.ID_CHAMADO = transf_atendente.ID_CHAMADO;
        //        this.ID_TRANSF_ATENDENTE = transf_atendente.ID_TRANSF_ATENDENTE;
        //        this.LOGIN_NEW = transf_atendente.LOGIN_ATENDENTE_NEW;
        //        this.LOGIN_OLD = transf_atendente.LOGIN_ATENDENTE_OLD;
        //        this.DS_MOTIVO = transf_atendente.DS_MOTIVO.Treat();
        //    }
        //}
    }
}