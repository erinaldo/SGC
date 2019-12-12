using Consultas;
using Entidades;
using Formas.Padrao;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FEquipamento_Busca : FPadrao_Busca_Menu
    {
        #region Declarações

        public E_EQUIPAMENTO equipamento = new E_EQUIPAMENTO();

        #endregion

        #region Métodos

        public FEquipamento_Busca()
        {
            InitializeComponent();

            Identificador = "C14";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FEquipamento_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        equipamento = forma.equipamento;
                        Buscar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Alterar()
        {
            try
            {
                base.Alterar();

                if (gv_Equipamento.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FEquipamento_Cadastro { Operacao = Operacao.Alterar, equipamento = gv_Equipamento.GetSelectedRow<E_EQUIPAMENTO>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        equipamento = forma.equipamento;
                        Buscar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Deletar()
        {
            try
            {
                base.Deletar();

                foreach (var indiceSelecionado in gv_Equipamento.GetSelectedRows())
                {
                    var registro = gv_Equipamento.GetRow(indiceSelecionado) as E_EQUIPAMENTO;

                    if (registro != null)
                    {
                        registro.OPERACAO = Operacao.Deletar;

                        var transacao = 0;

                        C_EQUIPAMENTO.Salvar(registro, ref transacao);

                        Buscar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Buscar()
        {
            try
            {
                base.Buscar();

                var equipamentos = from a in Conexao.Banco.TB_DIV_EQUIPAMENTOs
                              where a.ID_EQUIPAMENTO == (equipamento.ID_EQUIPAMENTO > 0 ? equipamento.ID_EQUIPAMENTO : a.ID_EQUIPAMENTO)
                              select a;

                if (Quantidade > 0)
                    equipamentos = equipamentos.Take(Quantidade);

                gc_Equipamento.DataSource = equipamentos.Select(a => new E_EQUIPAMENTO(a)).ToList();
                gv_Equipamento.BestFitColumns();

                equipamento = new E_EQUIPAMENTO();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Equipamento.ToGridList<E_EQUIPAMENTO>());
            RelatorioSalvar();
        }

        #endregion

        #region Eventos

        #endregion
    }
}