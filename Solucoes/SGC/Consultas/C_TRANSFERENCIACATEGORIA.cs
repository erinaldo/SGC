using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilidades;

namespace Consultas
{
    public class C_TRANSFERENCIACATEGORIA
    {
        public static bool Salvar(E_TRANSF_CATEGORIA transferencia, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_transferencia = (int?)transferencia.ID_TRANSF_CATEGORIA;

                Conexao.Banco.CAD_DIV_TRANSF_CATEGORIA(transferencia.OPERACAO.Value(),
                                                       transferencia.ID_CHAMADO,                                   
                                                       ref id_transferencia,
                                                       transferencia.LOGIN,
                                                       transferencia.ID_CATEGORIA_OLD,
                                                       transferencia.ID_CATEGORIA_NEW);

                Conexao.Enviar();

                transferencia.ID_TRANSF_CATEGORIA = (int)id_transferencia;
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