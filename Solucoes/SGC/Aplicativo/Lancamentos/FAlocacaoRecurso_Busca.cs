using Consultas;
using Entidades;
using Formas.Padrao;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Lancamentos
{
    public partial class FAlocacaoRecurso_Busca : FPadrao_Busca_Menu
    {
        #region Declarações

        public E_ALOCACAORECURSO alocacaoRecurso = new E_ALOCACAORECURSO();

        #endregion

        #region Métodos

        public FAlocacaoRecurso_Busca()
        {
            InitializeComponent();
            Identificador = "L3";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FAlocacaoRecurso_Lancamento { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        alocacaoRecurso = forma.alocacaoRecurso;
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

                if (gv_AlocacaoRecurso.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FAlocacaoRecurso_Lancamento { Operacao = Operacao.Alterar, alocacaoRecurso = gv_AlocacaoRecurso.GetSelectedRow<E_ALOCACAORECURSO>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        alocacaoRecurso = forma.alocacaoRecurso;
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

                foreach (var indiceSelecionado in gv_AlocacaoRecurso.GetSelectedRows())
                {
                    var registro = gv_AlocacaoRecurso.GetRow(indiceSelecionado) as E_ALOCACAORECURSO;

                    if (registro != null)
                    {
                        registro.OPERACAO = Operacao.Deletar;

                        var transacao = 0;

                        C_ALOCACAORECURSO.Salvar(registro, ref transacao);

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

                var itens = from a in Conexao.Banco.TB_DIV_ALOCACAORECURSOs
                            where a.ID_ALOCACAO == (alocacaoRecurso.ID_ALOCACAO > 0 ? alocacaoRecurso.ID_ALOCACAO : a.ID_ALOCACAO)
                            select a;

                if (Quantidade > 0)
                    itens = itens.Take(Quantidade);

                gc_AlocacaoRecurso.DataSource = itens.Select(a => new E_ALOCACAORECURSO(a)).ToList();
                gv_AlocacaoRecurso.BestFitColumns();

                alocacaoRecurso = new E_ALOCACAORECURSO();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_AlocacaoRecurso.ToGridList<E_ALOCACAORECURSO>());
            RelatorioSalvar();
        }

        #endregion
    }
}