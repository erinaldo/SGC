using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_STATUS
    {
        public Operacao OPERACAO { get; set; }
        public string SIGLA_STATUS { get; set; }
        public string DS_STATUS { get; set; }
        public bool ST_TEMPORIZAR { get; set; }
        public bool ST_AUTORIZAR { get; set; }
        public bool ST_INICIAR { get; set; }
        public bool ST_FINALIZAR { get; set; }
        public bool ST_INTERNO { get; set; }
        public bool ST_SOLICITANTE { get; set; }
        public string ST_REGISTRO { get; set; }

        public E_STATUS(TB_DIV_STATUS status = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (status != null)
            {
                this.SIGLA_STATUS = status.SIGLA_STATUS.Treat();
                this.DS_STATUS = status.DS_STATUS.Treat();
                this.ST_TEMPORIZAR = status.ST_TEMPORIZAR.Treat() == "S";
                this.ST_AUTORIZAR = status.ST_AUTORIZAR.Treat() == "S";
                this.ST_INICIAR = status.ST_INICIAR.Treat() == "S";
                this.ST_FINALIZAR = status.ST_FINALIZAR.Treat() == "S";
                this.ST_INTERNO = status.ST_INTERNO.Treat() == "S";
                this.ST_SOLICITANTE = status.ST_SOLICITANTE.Treat() == "S";
                this.ST_REGISTRO = status.ST_REGISTRO.Treat() == "A" ? "ATIVO" : "CANCELADO";
            }
        }
    }
}