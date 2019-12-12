using Componentes;
using Consultas;
using Entidades;
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
    public partial class FChamado_Lancamento : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_CHAMADO chamado = new E_CHAMADO();
        private List<string> randomFiles = new List<string>();

        #endregion

        #region Métodos

        public FChamado_Lancamento()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cde_DT_Requerida.DataMinima = Conexao.Banco.GetDate();

                cpc_DadosGerais.Controls.Validate();

                if (Parametros.Usuario == Parametros.Administrador && !Conexao.Banco.TB_DIV_USUARIOs.Any(a => a.LOGIN == Parametros.Usuario))
                    throw new Exception("É necessário cadastrar o usuário administrador para efetuar o lançamento do chamado!");

                chamado = new E_CHAMADO
                {
                    OPERACAO = Operacao,
                    DEPARTAMENTO = ccbe_Departamento.GetSelectedValue(),
                    CATEGORIA = ccbe_Categoria.GetSelectedValue(),
                    DT_REQUERIDA = cde_DT_Requerida.DateTime,
                    DS_CHAMADO = cme_Descricao.Text.Treat(),
                    LOGIN_SOLICITANTE = Parametros.Usuario,
                    LOGIN_ATENDENTE = ccbe_Atendente.GetSelectedValue().HasValue() ? ccbe_Atendente.GetSelectedValue() : null,
                    DS_RESUMO = cte_Resumo.Text.Treat(),
                    ST_CHAMADO = "A",
                    ANEXOS = bs_Anexos.List.Cast<E_ANEXO>().ToList()
                };

                var transacao = 0;

                if (C_CHAMADO.Salvar(chamado, ref transacao))
                {
                    Finalizar();

                    Conexao.Reiniciar(); // Usada para remapear o DataContext.
                    Email.Enviar(Conexao.Banco.TB_DIV_CHAMADOs.FirstOrDefault(a => a.ID_CHAMADO == chamado.ID_CHAMADO), OperacaoEmail.Envio);
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FChamado_Cadastro_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                ccbe_Departamento.SetValues(Conexao.Banco.TB_DIV_DEPARTAMENTOs.Select(a => new CComboBoxEditValue { ID = a.ID_DEPARTAMENTO.ToString(), DS = a.DS_DEPARTAMENTO }).ToList());
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

        private void FChamado_Cadastro_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5: csb_AdicionarAnexo_Click(); return;
                case Keys.F6: csb_DeletarAnexo_Click(); return;
            }
        }

        private void ccbe_Departamento_SelectedIndexChanged(object sender = null, EventArgs e = null)
        {
            try
            {
                ccbe_Atendente.Enabled = false;
                ccbe_Atendente.Properties.Items.Clear();
                ccbe_Categoria.Enabled = false;
                ccbe_Categoria.Properties.Items.Clear();
                cde_DT_Requerida.Enabled = false;

                if (ccbe_Departamento.GetSelectedValue().HasValue())
                {
                    ccbe_Categoria.Enabled = true;
                    ccbe_Categoria.SetValues(Conexao.Banco.TB_DIV_CATEGORIAs.Where(a => a.ID_DEPARTAMENTO.ToString() == ccbe_Departamento.GetSelectedValue()).Select(a => new CComboBoxEditValue { ID = a.ID_CATEGORIA.ToString(), DS = a.DS_CATEGORIA }).ToList());
                    ccbe_Categoria.SetFirst();

                    if (ccbe_Categoria.Properties.Items.Count == 0)
                        throw new Exception("Não existem categorias cadastradas para o departamento selecionado!");

                    cde_DT_Requerida.Enabled = true;
                    cde_DT_Requerida.DateTime = Conexao.Banco.GetDate();
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

        private void FChamado_Cadastro_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ccbe_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ccbe_Atendente.Enabled = false;
                ccbe_Atendente.Properties.Items.Clear();

                if (ccbe_Categoria.GetSelectedValue().HasValue())
                {
                    ccbe_Atendente.Enabled = true;
                    ccbe_Atendente.SetValue(new CComboBoxEditValue { ID = "", DS = "AGUARDAR POR UM ATENDENTE APÓS ABERTURA DESTE CHAMADO!" });
                    ccbe_Atendente.SetValues(Conexao.Banco.TB_DIV_USUARIOs.Where(b => b.ID_DEPARTAMENTO == Conexao.Banco.TB_DIV_CATEGORIAs.FirstOrDefault(a => a.ID_CATEGORIA == ccbe_Categoria.GetSelectedValue().ToInt()).ID_DEPARTAMENTO).Select(a => new CComboBoxEditValue { ID = a.LOGIN, DS = a.NM_USUARIO.Treat() }).ToList());
                    ccbe_Atendente.SetFirst();
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
    }
}