using Entidades;
using System;
using System.Linq;
using Utilidades;

namespace Consultas
{
    public static class C_TRANSFERENCIAUSUARIO
    {
        public static bool Salvar(E_TRANSF_ATENDENTE transferencia, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_transferencia = (int?)transferencia.ID_TRANSF_ATENDENTE;

                if (transferencia.LOGIN_OLD.Treat().GetValue() != transferencia.LOGIN_NEW.Treat().GetValue())
                {
                    Conexao.Banco.CAD_DIV_TRANSF_ATENDENTE(transferencia.OPERACAO.Value(),
                                                           transferencia.ID_CHAMADO,
                                                           ref id_transferencia,
                                                           transferencia.LOGIN_OLD.Treat().GetValue(),
                                                           transferencia.LOGIN_NEW.Treat().GetValue(),
                                                           transferencia.DS_MOTIVO.Treat());

                    Conexao.Enviar();

                    transferencia.ID_TRANSF_ATENDENTE = (int)id_transferencia;

                    Conexao.Banco.TB_DIV_CHAMADOs.FirstOrDefault(a => a.ID_CHAMADO == transferencia.ID_CHAMADO).LOGIN_ATENDENTE = transferencia.LOGIN_NEW;
                }
                
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
