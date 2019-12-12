using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_CATEGORIA
    {
        public static bool Salvar(E_CATEGORIA categoria, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_categoria = (int?)categoria.ID_CATEGORIA;

                Conexao.Banco.CAD_DIV_CATEGORIA(categoria.OPERACAO.Value(),
                                                ref id_categoria,
                                                categoria.DEPARTAMENTO != null ? (int?)categoria.DEPARTAMENTO.ID_DEPARTAMENTO : null,
                                                categoria.DS_CATEGORIA.Treat(),
                                                categoria.CLASSIFICACAO.Treat(),
                                                categoria.GRAVIDADE.Treat(),
                                                categoria.TEMPO_HORA_MIN.GetValueOrDefault(),
                                                categoria.TEMPO_HORA_MAX.GetValueOrDefault(),
                                                categoria.TIPO);
                Conexao.Enviar();

                categoria.ID_CATEGORIA = (int)id_categoria;
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