using Componentes;
using Consultas;
using DevExpress.XtraEditors.Controls;
using Entidades;
using Formas.Padrao;
using Formas.Pesquisa;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Lancamentos
{
    public partial class FConhecimento_Lancamento : FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_CONHECIMENTO conhecimento = new E_CONHECIMENTO();

        private List<string> randomFiles = new List<string>();

        #endregion

        #region Métodos

        public FConhecimento_Lancamento()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                conhecimento = new E_CONHECIMENTO
                {
                    OPERACAO = Operacao,
                    ID_CONHECIMENTO = cte_Identificador.Text.ToInt(),
                    DS_TITULO = cte_Titulo.Text.Treat(),
                    CATEGORIA = cbe_Categoria.Text.Treat(),
                    DS_CONHECIMENTO = cme_Descricao.Text.Treat(),
                    LOGIN_CAD = Parametros.Usuario,
                    DT_LANCTO = Conexao.Banco.GetDate(),
                    ST_REGISTRO = "A",
                    ANEXOS = bs_Anexos.List.Cast<E_ANEXO>().ToList()
                };

                var transacao = 0;

                if (C_CONHECIMENTO.Salvar(conhecimento, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos
        private void FConhecimento_Lancamento_Load(object sender, EventArgs e)
        {
            try
            {
                if (Operacao == Operacao.Alterar)
                {
                    cte_Identificador.Text = conhecimento.ID_CONHECIMENTO.ToString();
                    cte_Titulo.Text = conhecimento.DS_TITULO.Treat();
                    cce_Ativo.Checked = conhecimento.ST_REGISTRO.Treat() == "S";
                    cbe_Categoria.Text = conhecimento.CATEGORIA.GetValue();
                    cbe_Categoria_Leave();
                    cme_Descricao.Text = conhecimento.DS_CONHECIMENTO.Treat();

                    bs_Anexos.DataSource = conhecimento.ANEXOS;
                    bs_Anexos.MoveFirst();
                }

                cte_Titulo.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void FConhecimento_Lancamento_FormClosing(object sender, FormClosingEventArgs e)
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

        private void csb_AdicionarAnexo_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    foreach (var fileName in ofd.FileNames)
                        bs_Anexos.Add(new E_ANEXO
                        {
                            NM_ANEXO = Path.GetFileNameWithoutExtension(fileName),
                            EXTENSAO = Path.GetExtension(fileName),
                            ANEXO = new Binary(File.ReadAllBytes(fileName))
                        });
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void csb_DeletarAnexo_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                bs_Anexos.RemoveSelected();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_Categoria_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_DS_Categoria.Text = "";

                if (cbe_Categoria.Text.ToInt() <= 0)
                    cbe_Categoria.Text = "";
                else
                {
                    var categoria = (from a in Conexao.Banco.TB_DIV_CATEGORIAs where a.ID_CATEGORIA == cbe_Categoria.Text.ToInt() select new E_CATEGORIA(a)).Take(1);

                    if (categoria == null || categoria.Count() == 0)
                        cbe_Categoria.Text = "";
                    else
                        cte_DS_Categoria.Text = categoria.First().DS_CATEGORIA.Treat();
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void cbe_Categoria_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    var filtros = new List<FPesquisa.Filtro>();

                    var id_categoria = new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_CATEGORIA", Tamanho = 100 };
                    var ds_categoria = new FPesquisa.Filtro { Descricao = "Descrição", Nome = "DS_CATEGORIA", Tamanho = 350 };

                    filtros.Add(id_categoria);
                    filtros.Add(ds_categoria);

                    formaPesquisa.Filtros = filtros;
                    formaPesquisa.Multiplos = false;
                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_CATEGORIAs select new E_CATEGORIA(a);

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Categoria.Text = formaPesquisa.Selecionados.Cast<E_CATEGORIA>().First().ID_CATEGORIA.ToString();
                        cte_DS_Categoria.Text = formaPesquisa.Selecionados.Cast<E_CATEGORIA>().First().DS_CATEGORIA.Treat();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
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
        private void FConhecimento_Lancamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5: csb_AdicionarAnexo_Click(); return;
                case Keys.F6: csb_DeletarAnexo_Click(); return;
            }
        }

        #endregion
    }
}