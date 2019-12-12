using Entidades;
using System;
using System.Linq;
using Utilidades;

namespace Consultas
{
    public class C_EQUIPAMENTO
    {
        public static bool Salvar(E_EQUIPAMENTO equipamento, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_equipamento = (int?)equipamento.ID_EQUIPAMENTO;

                Conexao.Banco.CAD_DIV_EQUIPAMENTO(equipamento.OPERACAO.Value(),
                                                  ref id_equipamento,
                                                  equipamento.DS_GRUPO.GetValue().HasValue() ? (int?)equipamento.DS_GRUPO.GetValue().ToInt() : null,
                                                  equipamento.NR_IDENTIFICACAO,
                                                  equipamento.DS_OBSERVACAO,
                                                  equipamento.ST_ATIVO,
                                                  equipamento.DT_VALIDADE,
                                                  equipamento.DT_AQUISICAO,
                                                  equipamento.DS_MODELO.GetValue().HasValue() ? (int?)equipamento.DS_MODELO.GetValue().ToInt() : null);

                Conexao.Enviar();

                equipamento.ID_EQUIPAMENTO = (int)id_equipamento;

                if (equipamento.OPERACAO != Operacao.Deletar)
                {
                    var itemsExistentes = Conexao.Banco.TB_DIV_EQUIPAMENTO_X_ITEMs.Where(a => a.ID_EQUIPAMENTO == equipamento.ID_EQUIPAMENTO);

                    // Deletar
                    (from a in itemsExistentes where !equipamento.ITEMS.Select(b => b.ID_ITEM).Contains(a.ID_ITEM) select a).ToList().ForEach(a =>
                    {
                        Conexao.Banco.CAD_DIV_EQUIPAMENTO_X_ITEM(Operacao.Deletar.Value(),
                                                                 a.ID_ITEM,
                                                                 equipamento.ID_EQUIPAMENTO);

                        Conexao.Enviar();
                    });

                    // Cadastrar
                    (from a in equipamento.ITEMS where !itemsExistentes.Select(b => b.ID_ITEM).Contains(a.ID_ITEM) select a).ToList().ForEach(a =>
                    {
                        Conexao.Banco.CAD_DIV_EQUIPAMENTO_X_ITEM(Operacao.Cadastrar.Value(),
                                                                 a.ID_ITEM,
                                                                 equipamento.ID_EQUIPAMENTO);
                        Conexao.Enviar();
                    });

                    var anexosExistentes = Conexao.Banco.TB_DIV_EQUIPAMENTO_X_ANEXOs.Where(a => a.ID_EQUIPAMENTO == equipamento.ID_EQUIPAMENTO);

                    // Deletar
                    (from a in anexosExistentes where !equipamento.ANEXOS.Select(b => b.ID_ANEXO).Contains(a.ID_ANEXO) select a).ToList().ForEach(a =>
                    {
                        Conexao.Banco.CAD_DIV_EQUIPAMENTO_X_ANEXO(Operacao.Deletar.Value(),
                                                                  equipamento.ID_EQUIPAMENTO,
                                                                  a.ID_ANEXO);

                        Conexao.Enviar();
                    });

                    // Cadastrar
                    (from a in equipamento.ANEXOS where !anexosExistentes.Select(b => b.ID_ANEXO).Contains(a.ID_ANEXO) select a).ToList().ForEach(a =>
                    {
                        var id_anexo = (int?)0;

                        Conexao.Banco.CAD_DIV_ANEXO(Operacao.Cadastrar.Value(),
                                                    ref id_anexo,
                                                    a.ANEXO,
                                                    a.NM_ANEXO,
                                                    a.EXTENSAO);
                        Conexao.Enviar();

                        Conexao.Banco.CAD_DIV_EQUIPAMENTO_X_ANEXO(Operacao.Cadastrar.Value(),
                                                                  equipamento.ID_EQUIPAMENTO,
                                                                  id_anexo);
                        Conexao.Enviar();
                    });
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