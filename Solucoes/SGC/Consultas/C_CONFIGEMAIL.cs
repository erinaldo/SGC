using Modelo;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_CONFIGEMAIL
    {
        public static bool Salvar(TB_DIV_CONFIG_EMAIL config, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                Conexao.Banco.CAD_DIV_CONFIG_EMAIL(config.DS_CONFIGURACAO,
                                                   config.SMTP,
                                                   config.PORTA,
                                                   config.SSL,
                                                   config.LOGIN,
                                                   config.SENHA,
                                                   config.ST_ENVIAR);

                Conexao.Enviar();
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