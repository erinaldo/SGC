using Entidades;
using System;
using System.Linq;
using Utilidades;

namespace Consultas
{
    public static class C_USUARIO
    {
        public static bool Salvar(E_USUARIO usuario, int transacao = 0)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                #region Usuário

                Conexao.Banco.CAD_DIV_USUARIO(usuario.OPERACAO.Value(),
                                              usuario.LOGIN,
                                              usuario.CARGO != null ? (usuario.CARGO.ID_CARGO as int?) : null,
                                              usuario.CLIFOR != null ? (usuario.CLIFOR.ID_CLIFOR as int?) : null,
                                              usuario.DEPARTAMENTO != null ? (usuario.DEPARTAMENTO.ID_DEPARTAMENTO as int?) : null,
                                              usuario.DS_OBSERVACAO,
                                              usuario.NM_USUARIO,
                                              usuario.NR_CELULAR,
                                              usuario.NR_TELEFONE,
                                              usuario.SENHA,
                                              usuario.EMAIL,
                                              usuario.SKYPE,
                                              usuario.ST_REGISTRO,
                                              usuario.ST_ADMINISTRADOR);

                Conexao.Enviar();

                #endregion

                #region Acessos

                var acessosExistentes = Conexao.Banco.TB_DIV_ACESSOs.Where(a => a.LOGIN == usuario.LOGIN);

                // Cadastrar
                (from a in usuario.ACESSOS where !acessosExistentes.Select(b => b.ID_MENU).Contains(a.ID_MENU) select a).ToList().ForEach(a =>
                {
                    Conexao.Banco.CAD_DIV_ACESSO(Operacao.Cadastrar.Value(),
                                                 usuario.LOGIN,
                                                 a.ID_MENU,
                                                 a.ST_CADASTRAR,
                                                 a.ST_ALTERAR,
                                                 a.ST_DELETAR,
                                                 a.ST_RELATORIO);
                    Conexao.Enviar();
                });

                // Alterar
                (from a in usuario.ACESSOS where acessosExistentes.Select(b => b.ID_MENU).Contains(a.ID_MENU) select a).ToList().ForEach(a =>
                {
                    Conexao.Banco.CAD_DIV_ACESSO(Operacao.Alterar.Value(),
                                                 usuario.LOGIN,
                                                 a.ID_MENU,
                                                 a.ST_CADASTRAR,
                                                 a.ST_ALTERAR,
                                                 a.ST_DELETAR,
                                                 a.ST_RELATORIO);

                    Conexao.Enviar();
                });

                // Deletar
                (from a in acessosExistentes where !usuario.ACESSOS.Select(b => b.ID_MENU).Contains(a.ID_MENU) select a).ToList().ForEach(a =>
                {
                    Conexao.Banco.CAD_DIV_ACESSO(Operacao.Deletar.Value(),
                                                 usuario.LOGIN,
                                                 a.ID_MENU,
                                                 a.ST_CADASTRAR,
                                                 a.ST_ALTERAR,
                                                 a.ST_DELETAR,
                                                 a.ST_RELATORIO);

                    Conexao.Enviar();
                });

                #endregion

                #region Regras especiais

                var regrasExistentes = Conexao.Banco.TB_DIV_LOGIN_X_REGRAACESSOs.Where(a => a.LOGIN == usuario.LOGIN);

                // Cadastrar
                (from a in usuario.REGRASACESSO where !regrasExistentes.Select(b => b.ID_REGRAACESSO).Contains(a.ID_REGRAACESSO) select a).ToList().ForEach(a =>
                {
                    Conexao.Banco.CAD_DIV_LOGIN_X_REGRAACESSO(Operacao.Cadastrar.Value(),
                                                              a.ID_REGRAACESSO,
                                                              usuario.LOGIN);
                    Conexao.Enviar();
                });

                // Alterar
                (from a in usuario.REGRASACESSO where regrasExistentes.Select(b => b.ID_REGRAACESSO).Contains(a.ID_REGRAACESSO) select a).ToList().ForEach(a =>
                {
                    Conexao.Banco.CAD_DIV_LOGIN_X_REGRAACESSO(Operacao.Alterar.Value(),
                                                              a.ID_REGRAACESSO,
                                                              usuario.LOGIN);
                    Conexao.Enviar();
                });

                // Deletar
                (from a in regrasExistentes where !usuario.REGRASACESSO.Select(b => b.ID_REGRAACESSO).Contains(a.ID_REGRAACESSO) select a).ToList().ForEach(a =>
                {
                    Conexao.Banco.CAD_DIV_LOGIN_X_REGRAACESSO(Operacao.Deletar.Value(),
                                                              a.ID_REGRAACESSO,
                                                              usuario.LOGIN);
                    Conexao.Enviar();
                });

                #endregion

                #region Grupo usuário

                var gruposExistentes = Conexao.Banco.TB_DIV_USUARIO_X_GRUPOs.Where(a => a.LOGIN == usuario.LOGIN);

                // Cadastrar
                (from a in usuario.GRUPOUSUARIO where !gruposExistentes.Select(b => b.ID_GRUPOUSUARIO).Contains(a.ID_GRUPOUSUARIO) select a).ToList().ForEach(a =>
                {
                    Conexao.Banco.CAD_DIV_USUARIO_X_GRUPO(Operacao.Cadastrar.Value(),
                                                          a.ID_GRUPOUSUARIO,
                                                          usuario.LOGIN);

                    Conexao.Enviar();
                });

                // Deletar
                (from a in gruposExistentes where !usuario.GRUPOUSUARIO.Select(b => b.ID_GRUPOUSUARIO).Contains(a.ID_GRUPOUSUARIO) select a).ToList().ForEach(a =>
                {
                    Conexao.Banco.CAD_DIV_USUARIO_X_GRUPO(Operacao.Deletar.Value(),
                                                          a.ID_GRUPOUSUARIO,
                                                          usuario.LOGIN);
                    Conexao.Enviar();
                });

                #endregion
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