using Modelo;
using System;
using System.Linq;
using Utilidades;

namespace Entidades
{
    public class E_EQUIPAMENTOUSUARIO
    {
        public Operacao OPERACAO { get; set; }
        public string USUARIO { get; set; }
        public string EQUIPAMENTO { get; set; }
        public string DS_OBSERVACAO { get; set; }
        public string ST_USOCOMPARTILHADO { get; set; }
        public string ST_REGISTRO { get; set; }
        public string DS_ST_REGISTRO { get; set; }

        public E_EQUIPAMENTO DETALHE { get; set; }
        public string DEPARTAMENTO { get; set; }

        public string LOGIN_CANCELAMENTO { get; set; }
        public string DS_CANCELAMENTO { get; set; }

        public E_EQUIPAMENTOUSUARIO(TB_DIV_EQUIPAMENTO_X_USUARIO equipamentoUsuario = null)
        {
            OPERACAO = Operacao.Normal;

            if (equipamentoUsuario != null)
            {
                if (equipamentoUsuario.LOGIN != null)
                {
                    var usuario = Conexao.Banco.TB_DIV_USUARIOs.FirstOrDefault(a => a.LOGIN == equipamentoUsuario.LOGIN);

                    USUARIO = String.Format("{0} - {1}", usuario.LOGIN, usuario.NM_USUARIO.Treat());

                    if (usuario.TB_DIV_DEPARTAMENTO != null)
                        DEPARTAMENTO = String.Format("{0} - {1}", usuario.TB_DIV_DEPARTAMENTO.ID_DEPARTAMENTO, usuario.TB_DIV_DEPARTAMENTO.DS_DEPARTAMENTO.Treat());
                }

                if (equipamentoUsuario.TB_DIV_EQUIPAMENTO != null)
                {
                    EQUIPAMENTO = String.Format("{0} - {1}", equipamentoUsuario.ID_EQUIPAMENTO, equipamentoUsuario.TB_DIV_EQUIPAMENTO.DS_OBSERVACAO.Treat());
                    DETALHE = new E_EQUIPAMENTO(equipamentoUsuario.TB_DIV_EQUIPAMENTO);
                }

                DS_OBSERVACAO = equipamentoUsuario.DS_OBSERVACAO.Treat();
                ST_USOCOMPARTILHADO = equipamentoUsuario.ST_USOCOMPARTILHADO.Treat() == "S" ? "SIM" : "NÃO";
                ST_REGISTRO = equipamentoUsuario.ST_REGISTRO.Treat();
                DS_ST_REGISTRO = ST_REGISTRO == "A" ? "ATIVO" : (ST_REGISTRO == "C" ? "CANCELADO" : "");

                if (equipamentoUsuario.LOGIN_CANCELAMENTO != null)
                {
                    var login_cancelamento = Conexao.Banco.TB_DIV_USUARIOs.FirstOrDefault(a => a.LOGIN == equipamentoUsuario.LOGIN_CANCELAMENTO);

                    LOGIN_CANCELAMENTO = string.Format("{0} - {1}", login_cancelamento.LOGIN, login_cancelamento.NM_USUARIO.Treat());
                    DS_CANCELAMENTO = equipamentoUsuario.DS_CANCELAMENTO.Treat();
                }
            }
        }
    }
}