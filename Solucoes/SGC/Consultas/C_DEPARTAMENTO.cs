using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_DEPARTAMENTO
    {
        public static bool Salvar(E_DEPARTAMENTO departamento, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_departamento = (int?)departamento.ID_DEPARTAMENTO;

                Conexao.Banco.CAD_DIV_DEPARTAMENTO(departamento.OPERACAO.Value(),
                                                   ref id_departamento,
                                                   departamento.DS_DEPARTAMENTO);

                Conexao.Enviar();

                departamento.ID_DEPARTAMENTO = (int)id_departamento;
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