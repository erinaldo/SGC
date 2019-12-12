using Entidades;
using System;
using System.Linq;
using Utilidades;

namespace Consultas
{
    public static class C_CONHECIMENTO
    {
        public static bool Salvar(E_CONHECIMENTO conhecimento, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_conhecimento = (int?)conhecimento.ID_CONHECIMENTO;
                var id_categoria = (int?)conhecimento.CATEGORIA.GetValue().ToInt();
                var login_cad = conhecimento.LOGIN_CAD.GetValue();

                if (conhecimento.OPERACAO == Operacao.Deletar)
                    (from a in Conexao.Banco.TB_DIV_CONHECIMENTO_X_ANEXOs.Where(a => a.ID_CONHECIMENTO == conhecimento.ID_CONHECIMENTO) select a).ToList().ForEach(a =>
                    {
                        var id_anexo = (int?)a.ID_ANEXO;

                        Conexao.Banco.CAD_DIV_CONHECIMENTO_X_ANEXO(Operacao.Deletar.Value(),
                                                                   conhecimento.ID_CONHECIMENTO,
                                                                   id_anexo);

                        Conexao.Enviar();

                        Conexao.Banco.CAD_DIV_ANEXO(Operacao.Deletar.Value(),
                                                    ref id_anexo,
                                                    null,
                                                    null,
                                                    null);
                        Conexao.Enviar();
                    });

                Conexao.Banco.CAD_DIV_CONHECIMENTO(conhecimento.OPERACAO.Value(),
                                                   ref id_conhecimento,
                                                   id_categoria,
                                                   login_cad,
                                                   conhecimento.DS_CONHECIMENTO,
                                                   conhecimento.DS_TITULO,
                                                   conhecimento.ST_REGISTRO,
                                                   conhecimento.DT_LANCTO);
                Conexao.Enviar();

                conhecimento.ID_CONHECIMENTO = (int)id_conhecimento;

                if (conhecimento.OPERACAO != Operacao.Deletar)
                    (from a in conhecimento.ANEXOS where !Conexao.Banco.TB_DIV_CONHECIMENTO_X_ANEXOs.Select(b => b.ID_ANEXO).Contains(a.ID_ANEXO) select a).ToList().ForEach(a=>
                    {
                        var id_anexo = (int?)a.ID_ANEXO;

                        Conexao.Banco.CAD_DIV_ANEXO(Operacao.Cadastrar.Value(),
                                                    ref id_anexo,
                                                    a.ANEXO,
                                                    a.NM_ANEXO,
                                                    a.EXTENSAO);
                        Conexao.Enviar();

                        Conexao.Banco.CAD_DIV_CONHECIMENTO_X_ANEXO(Operacao.Cadastrar.Value(),
                                                                   conhecimento.ID_CONHECIMENTO,
                                                                   id_anexo);
                        Conexao.Enviar();
                    });
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