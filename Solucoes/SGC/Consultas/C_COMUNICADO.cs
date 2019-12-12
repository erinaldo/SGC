using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_COMUNICADO
    {
        public static bool Salvar(E_COMUNICADO comunicado, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_comunicado = (int?)comunicado.ID_COMUNICADO;
                var login_comunicador = comunicado.LOGIN_COMUNICADOR.GetValue();

                Conexao.Banco.CAD_DIV_COMUNICADO(comunicado.OPERACAO.Value(),
                                                   ref id_comunicado,
                                                   login_comunicador.Treat().Length > 0 ? login_comunicador : null,
                                                   comunicado.DS_COMUNICADO,
                                                   comunicado.ST_REGISTRO);
                Conexao.Enviar();

                comunicado.ID_COMUNICADO = (int)id_comunicado;

                if (comunicado.OPERACAO == Operacao.Cadastrar)
                {
                    foreach (var usuario in comunicado.USUARIOS)
                    {
                        Conexao.Banco.CAD_DIV_COMUNICADO_X_USUARIO(Operacao.Cadastrar.Value(),
                                                                   comunicado.ID_COMUNICADO,
                                                                   usuario.LOGIN);

                        Conexao.Enviar();
                    }

                    foreach (var grupoUsuario in comunicado.GRUPOUSUARIOS)
                    {
                        Conexao.Banco.CAD_DIV_COMUNICADO_X_GRUPOUSUARIO(Operacao.Cadastrar.Value(),
                                                                        comunicado.ID_COMUNICADO,
                                                                        grupoUsuario.ID_GRUPOUSUARIO);

                        Conexao.Enviar();
                    }

                    foreach (var anexo in comunicado.ANEXOS)
                    {
                        var id_anexo = (int?)0;

                        Conexao.Banco.CAD_DIV_ANEXO(Operacao.Cadastrar.Value(),
                                                    ref id_anexo,
                                                    anexo.ANEXO,
                                                    anexo.NM_ANEXO,
                                                    anexo.EXTENSAO);

                        Conexao.Enviar();

                        Conexao.Banco.CAD_DIV_COMUNICADO_X_ANEXO(Operacao.Cadastrar.Value(),
                                                                 comunicado.ID_COMUNICADO,
                                                                 id_anexo);

                        Conexao.Enviar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Conexao.Voltar(ref transacao);
                throw excessao;
            }

            Conexao.Finalizar(ref transacao);

            return true;
        }
    }
}