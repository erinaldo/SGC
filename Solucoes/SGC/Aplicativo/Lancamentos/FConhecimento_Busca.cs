using Componentes;
using Consultas;
using Entidades;
using Formas.Padrao;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Lancamentos
{
    public partial class FConhecimento_Busca : FPadrao_Busca_Menu
    {
        #region Declarações

        public E_CONHECIMENTO conhecimento = new E_CONHECIMENTO();

        private List<string> randomFiles = new List<string>();

        #endregion

        #region Métodos

        public FConhecimento_Busca()
        {
            InitializeComponent();
            Identificador = "L4";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FConhecimento_Lancamento { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        conhecimento = forma.conhecimento;
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

                if (gv_Conhecimento.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FConhecimento_Lancamento { Operacao = Operacao.Alterar, conhecimento = gv_Conhecimento.GetSelectedRow<E_CONHECIMENTO>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        conhecimento = forma.conhecimento;
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

                foreach (var indiceSelecionado in gv_Conhecimento.GetSelectedRows())
                {
                    var registro = gv_Conhecimento.GetRow(indiceSelecionado) as E_CONHECIMENTO;

                    if (registro != null)
                    {
                        registro.OPERACAO = Operacao.Deletar;

                        var transacao = 0;

                        C_CONHECIMENTO.Salvar(registro, ref transacao);

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

                var conhecimentos = from a in Conexao.Banco.TB_DIV_CONHECIMENTOs
                                    where a.ID_CONHECIMENTO == (conhecimento.ID_CONHECIMENTO > 0 ? conhecimento.ID_CONHECIMENTO : a.ID_CONHECIMENTO)
                                    select a;

                if (Quantidade > 0)
                    conhecimentos = conhecimentos.Take(Quantidade);

                gc_Conhecimento.DataSource = conhecimentos.Select(a => new E_CONHECIMENTO(a)).ToList();
                gv_Conhecimento.BestFitColumns();

                conhecimento = new E_CONHECIMENTO();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Conhecimento.ToGridList<E_CONHECIMENTO>());
            RelatorioSalvar();
        }

        #endregion

        #region Eventos

        private void gv_Conhecimento_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            xtp_Anexos.PageVisible = false;
            bs_Anexos.DataSource = new E_CONHECIMENTO();

            if (e != null && gv_Conhecimento.GetRow(e.RowHandle) != null)
            {
                var conhecimentoAnexo = (E_CONHECIMENTO)gv_Conhecimento.GetRow(e.RowHandle);
                if (conhecimentoAnexo != null)
                {
                    xtp_Anexos.PageVisible = conhecimentoAnexo.ANEXOS.Count > 0;
                    bs_Anexos.DataSource = conhecimentoAnexo.ANEXOS;
                }
            }
        }

        private void lbc_Anexos_DoubleClick(object sender = null, EventArgs e = null)
        {
            try
            {
                if (bs_Anexos.HasValue())
                {
                    var arquivo = Path.GetTempPath() + Path.GetRandomFileName() + (bs_Anexos.Current as E_ANEXO).EXTENSAO;
                    randomFiles.Add(arquivo);

                    File.WriteAllBytes(arquivo, (bs_Anexos.Current as E_ANEXO).ANEXO.ToArray());
                    Process.Start(arquivo);
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void FConhecimento_Busca_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                randomFiles.ForEach(a =>
                {
                    if (File.Exists(a))
                        File.Delete(a);
                });
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion
    }
}