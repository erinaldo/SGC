using Modelo;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Entidades
{
    public class E_USUARIO
    {
        public Operacao OPERACAO { get; set; }
        public string LOGIN { get; set; }
        public E_CARGO CARGO { get; set; }
        public E_CLIFOR CLIFOR { get; set; }
        public E_DEPARTAMENTO DEPARTAMENTO { get; set; }
        public List<E_ACESSO> ACESSOS { get; set; }
        public List<E_REGRAACESSO> REGRASACESSO { get; set; }
        public List<E_GRUPOUSUARIO> GRUPOUSUARIO { get; set; }
        public string DS_OBSERVACAO { get; set; }
        public string NM_USUARIO { get; set; }
        public string NR_CELULAR { get; set; }
        public string NR_TELEFONE { get; set; }
        public string SENHA { get; set; }
        public string EMAIL { get; set; }
        public string SKYPE { get; set; }
        public string ST_ADMINISTRADOR { get; set; }
        public string ST_REGISTRO { get; set; }

        public E_USUARIO(TB_DIV_USUARIO usuario = null, bool somenteNome = false)
        {
            this.OPERACAO = Operacao.Normal;

            if (usuario != null)
            {
                this.LOGIN = usuario.LOGIN;
                this.NM_USUARIO = usuario.NM_USUARIO.Treat();

                if (!somenteNome)
                {
                    this.CARGO = usuario.TB_DIV_CARGO != null ? new E_CARGO(usuario.TB_DIV_CARGO) : null;
                    this.CLIFOR = usuario.TB_DIV_CLIFOR != null ? new E_CLIFOR(usuario.TB_DIV_CLIFOR) : null;
                    this.DEPARTAMENTO = usuario.TB_DIV_DEPARTAMENTO != null ? new E_DEPARTAMENTO(usuario.TB_DIV_DEPARTAMENTO) : null;
                    this.DS_OBSERVACAO = usuario.DS_OBSERVACAO.Treat();
                    this.NR_CELULAR = usuario.NR_CELULAR.Treat();
                    this.NR_TELEFONE = usuario.NR_TELEFONE.Treat();
                    this.SENHA = usuario.SENHA.Treat();
                    this.EMAIL = usuario.EMAIL.Treat();
                    this.SKYPE = usuario.SKYPE.Treat();
                    this.ST_ADMINISTRADOR = usuario.ST_ADMIN.Treat();
                    this.ST_REGISTRO = usuario.ST_REGISTRO.Treat();

                    this.ACESSOS = new List<E_ACESSO>();
                    this.REGRASACESSO = new List<E_REGRAACESSO>();
                    this.GRUPOUSUARIO = new List<E_GRUPOUSUARIO>();

                    if (usuario.TB_DIV_ACESSOs != null && usuario.TB_DIV_ACESSOs.Count > 0)
                        this.ACESSOS = (from a in usuario.TB_DIV_ACESSOs
                                        select new E_ACESSO(a)).ToList();

                    if (usuario.TB_DIV_LOGIN_X_REGRAACESSOs != null && usuario.TB_DIV_LOGIN_X_REGRAACESSOs.Count > 0)
                        this.REGRASACESSO = (from a in usuario.TB_DIV_LOGIN_X_REGRAACESSOs select new E_REGRAACESSO(a.TB_DIV_REGRAACESSO)).ToList();

                    if (usuario.TB_DIV_USUARIO_X_GRUPOs != null && usuario.TB_DIV_USUARIO_X_GRUPOs.Count > 0)
                        this.GRUPOUSUARIO = (from a in usuario.TB_DIV_USUARIO_X_GRUPOs select new E_GRUPOUSUARIO(a.TB_DIV_GRUPOUSUARIO)).ToList();
                }
            }
        }
    }
}