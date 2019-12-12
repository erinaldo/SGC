using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Entidades
{
    public class E_EQUIPAMENTO
    {
        public Operacao OPERACAO { get; set; }
        public int ID_EQUIPAMENTO { get; set; }
        public E_GRUPOPRODUTO GRUPO { get; set; }
        public E_MODELO MODELO { get; set; }

        public string DS_MODELO { get; set; }
        public string DS_MARCA { get; set; }
        public string DS_GRUPO { get; set; }

        public string NR_IDENTIFICACAO { get; set; }
        public string DS_OBSERVACAO { get; set; }

        public string ST_ATIVO { get; set; }
        public DateTime? DT_VALIDADE { get; set; }
        public DateTime? DT_AQUISICAO { get; set; }

        public List<E_ITEM> ITEMS { get; set; }
        public List<E_ANEXO> ANEXOS { get; set; }

        public E_EQUIPAMENTO(TB_DIV_EQUIPAMENTO equipamento = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (equipamento != null)
            {
                ID_EQUIPAMENTO = equipamento.ID_EQUIPAMENTO;

                var grupo = Conexao.Banco.TB_DIV_GRUPOPRODUTOs.FirstOrDefault(a => a.ID_GRUPO == equipamento.ID_GRUPO);
                if (grupo != null)
                {
                    GRUPO = new E_GRUPOPRODUTO(grupo);
                    DS_GRUPO = string.Format("{0} - {1}", grupo.ID_GRUPO, grupo.DS_GRUPO.Treat());
                }

                var modelo = Conexao.Banco.TB_DIV_MODELOs.FirstOrDefault(a => a.ID_MODELO == equipamento.ID_MODELO);
                if (modelo != null)
                {
                    MODELO = new E_MODELO(modelo);
                    DS_MODELO = string.Format("{0} - {1}", modelo.ID_MODELO, modelo.DS_MODELO.Treat());

                    if (modelo.TB_DIV_MARCA != null)
                        DS_MARCA = string.Format("{0} - {1}", modelo.TB_DIV_MARCA.ID_MARCA, modelo.TB_DIV_MARCA.DS_MARCA.Treat());
                }

                NR_IDENTIFICACAO = equipamento.NR_IDENTIFICACAO.Treat();
                DS_OBSERVACAO = equipamento.DS_OBSERVACAO.Treat();

                ST_ATIVO = equipamento.ST_ATIVO.Treat() == "S" ? "SIM" : "NÃO";
                DT_VALIDADE = equipamento.DT_VALIDADE.GetValueOrDefault(); ;
                DT_AQUISICAO = equipamento.DT_AQUISICAO.GetValueOrDefault();

                if (equipamento.TB_DIV_EQUIPAMENTO_X_ITEMs != null && equipamento.TB_DIV_EQUIPAMENTO_X_ITEMs.Count > 0)
                    ITEMS = equipamento.TB_DIV_EQUIPAMENTO_X_ITEMs.Select(a => new E_ITEM(a.TB_DIV_ITEM)).ToList();

                if (equipamento.TB_DIV_EQUIPAMENTO_X_ANEXOs != null && equipamento.TB_DIV_EQUIPAMENTO_X_ANEXOs.Count > 0)
                    ANEXOS = equipamento.TB_DIV_EQUIPAMENTO_X_ANEXOs.Select(a => new E_ANEXO(a.TB_DIV_ANEXO)).ToList();
            }
        }
    }
}