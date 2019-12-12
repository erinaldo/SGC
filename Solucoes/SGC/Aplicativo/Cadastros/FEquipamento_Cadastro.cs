using Componentes;
using Consultas;
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

namespace Aplicativo.Cadastros
{
    public partial class FEquipamento_Cadastro : FPadrao_Cadastro_Menu
    {
        #region Declarações

        private List<string> randomFiles = new List<string>();
        public E_EQUIPAMENTO equipamento = new E_EQUIPAMENTO();

        #endregion

        #region Métodos

        public FEquipamento_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cbe_Grupo_Leave();

                cpc_DadosGerais.Controls.Validate();

                if (cde_DataAquisicao.DateTime > Conexao.Banco.GetDate())
                {
                    cde_DataAquisicao.Select();
                    throw new Exception("É necessário que a data de aquisição seja menor que a data atual!");
                }

                var itemsSelecionados = new List<E_ITEM>();
                clbc_ItemsCadastrados.Items.Cast<CComboBoxEditValue>().ToList().ForEach(a => itemsSelecionados.Add(new E_ITEM { ID_ITEM = a.ID.ToInt() }));

                equipamento = new E_EQUIPAMENTO
                {
                    OPERACAO = Operacao,
                    ID_EQUIPAMENTO = cte_Identificador.Text.Trim().ToInt(),
                    NR_IDENTIFICACAO = cte_NR_Identificacao.Text.Treat(),
                    DT_AQUISICAO = cde_DataAquisicao.DateTime,
                    DT_VALIDADE = cde_DataValidade.DateTime,
                    ST_ATIVO = cce_Status.Checked ? "S" : "N",
                    DS_GRUPO = cbe_Grupo.Text.Treat(),
                    DS_MODELO = cbe_Modelo.Text.Treat(),
                    DS_OBSERVACAO = cte_DS_Observacao.Text.Treat(),
                    ITEMS = itemsSelecionados,
                    ANEXOS = bs_Anexos.List.Cast<E_ANEXO>().ToList()
                };

                var transacao = 0;

                if (C_EQUIPAMENTO.Salvar(equipamento, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void AplicarTrava(bool inicializando = false)
        {
            if (inicializando || (cbe_Grupo.Text.ToInt() > 0 && !cbe_Grupo.Properties.ReadOnly && MessageBox.Show("Deseja utilizar esse grupo de produto para o restante das operações?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                cbe_Grupo.Properties.ReadOnly = true;
                cbe_Grupo.Properties.Buttons[0].Enabled = false;

                var items = Conexao.Banco.TB_DIV_ITEMs.Where(a => a.ID_GRUPO == cbe_Grupo.Text.ToInt()).ToList();

                if (items.Count == 0)
                    throw new Exception("Não existem items cadastrados com o grupo informado!");

                items = items.Where(a => !clbc_ItemsCadastrados.Items.Cast<CComboBoxEditValue>().Select(b => b.ID).Any(b => b == a.ID_ITEM.ToString())).ToList();
                items.ForEach(a => clbc_ItemsDisponiveis.Items.Add(new CComboBoxEditValue { ID = a.ID_ITEM.ToString(), DS = a.DS_ITEM.Treat() }));
            }
        }

        #endregion

        #region Eventos

        private void FEquipamento_Cadastro_Load(object sender, EventArgs e)
        {
            try
            {
                cde_DataAquisicao.DateTime = Conexao.Banco.GetDate();
                cde_DataValidade.DateTime = cde_DataAquisicao.DateTime;

                if (Operacao == Operacao.Alterar)
                {
                    cte_Identificador.Text = equipamento.ID_EQUIPAMENTO.ToString();
                    cte_NR_Identificacao.Text = equipamento.NR_IDENTIFICACAO.Treat();
                    cde_DataAquisicao.DateTime = equipamento.DT_AQUISICAO.GetValueOrDefault();
                    cde_DataValidade.DateTime = equipamento.DT_VALIDADE.GetValueOrDefault();
                    cte_DS_Observacao.Text = equipamento.DS_OBSERVACAO.Treat();
                    cce_Status.Checked = equipamento.ST_ATIVO.Treat() == "SIM";

                    (equipamento.ITEMS ?? new List<E_ITEM>()).ForEach(a => clbc_ItemsCadastrados.Items.Add(new CComboBoxEditValue { ID = a.ID_ITEM.ToString(), DS = a.DS_ITEM.Treat() }));

                    cbe_Grupo.Text = equipamento.GRUPO.ID_GRUPO.ToString();
                    cbe_Grupo_Leave();

                    cbe_Modelo.Text = equipamento.MODELO.ID_MODELO.ToString();
                    cbe_Modelo_Leave();

                    bs_Anexos.DataSource = (equipamento.ANEXOS ?? new List<E_ANEXO>());
                    bs_Anexos.MoveFirst();
                }

                cte_NR_Identificacao.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void FEquipamento_Cadastro_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cbe_Grupo_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                if (!cbe_Grupo.Properties.ReadOnly)
                {
                    var id = cbe_Grupo.Text.ToInt();

                    cbe_Grupo.Text = "";
                    cte_DS_Grupo.Text = "";

                    if (id > 0)
                    {
                        var grupo = (from a in Conexao.Banco.TB_DIV_GRUPOPRODUTOs
                                     where a.ID_GRUPO == id
                                     select new
                                     {
                                         a.ID_GRUPO,
                                         a.DS_GRUPO
                                     }).FirstOrDefault();

                        if (grupo != null)
                        {
                            cbe_Grupo.Text = grupo.ID_GRUPO.ToString();
                            cte_DS_Grupo.Text = grupo.DS_GRUPO.Treat();
                        }
                    }

                    AplicarTrava(Operacao == Operacao.Alterar);
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void cbe_Grupo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    formaPesquisa.Filtros = new List<FPesquisa.Filtro>
                    {
                        new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_GRUPO", Tamanho = 100 },
                        new FPesquisa.Filtro { Descricao = "Nome", Nome = "DS_GRUPO", Tamanho = 350 }
                    };

                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_GRUPOPRODUTOs
                                             select new E_GRUPOPRODUTO(a);

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Grupo.Text = formaPesquisa.Selecionados.Cast<E_GRUPOPRODUTO>().First().ID_GRUPO.ToString();
                        cte_DS_Grupo.Text = formaPesquisa.Selecionados.Cast<E_GRUPOPRODUTO>().First().DS_GRUPO.Treat();

                        AplicarTrava();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_Modelo_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                var id = cbe_Modelo.Text.ToInt();

                cbe_Modelo.Text = "";
                cte_DS_Modelo.Text = "";
                cte_DS_Marca.Text = "";

                if (id > 0)
                {
                    var modelo = (from a in Conexao.Banco.TB_DIV_MODELOs
                                  where a.ID_MODELO == id
                                  select new
                                  {
                                      a.ID_MODELO,
                                      a.DS_MODELO,
                                      a.TB_DIV_MARCA.DS_MARCA
                                  }).FirstOrDefault();

                    if (modelo != null)
                    {
                        cbe_Modelo.Text = modelo.ID_MODELO.ToString();
                        cte_DS_Modelo.Text = modelo.DS_MODELO.Treat();
                        cte_DS_Marca.Text = modelo.DS_MARCA.Treat();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void cbe_Modelo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    formaPesquisa.Filtros = new List<FPesquisa.Filtro>
                    {
                       new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_MODELO", Tamanho = 100 },
                       new FPesquisa.Filtro { Descricao = "Modelo", Nome = "DS_MODELO", Tamanho = 350 },
                       new FPesquisa.Filtro { Descricao = "Marca", Nome = "DS_MARCA", Tamanho = 350 },
                    };

                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_MODELOs
                                             select new
                                             {
                                                 a.ID_MODELO,
                                                 a.DS_MODELO,
                                                 a.TB_DIV_MARCA.DS_MARCA
                                             };

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Modelo.Text = formaPesquisa.SelecionadosDataTable.Rows[0]["ID_MODELO"].ToString();
                        cte_DS_Modelo.Text = formaPesquisa.SelecionadosDataTable.Rows[0]["DS_MODELO"].ToString();
                        cte_DS_Marca.Text = formaPesquisa.SelecionadosDataTable.Rows[0]["DS_MARCA"].ToString();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void clbc_ItemsDisponiveis_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selecionado = clbc_ItemsDisponiveis.Items.Cast<CComboBoxEditValue>().FirstOrDefault(a => a.ID == clbc_ItemsDisponiveis.GetSelectedValue());

                if (selecionado == null)
                    return;

                clbc_ItemsCadastrados.Items.Add(selecionado);
                clbc_ItemsDisponiveis.Items.Remove(selecionado);
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void clbc_ItemsCadastrados_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selecionado = clbc_ItemsCadastrados.Items.Cast<CComboBoxEditValue>().FirstOrDefault(a => a.ID == clbc_ItemsCadastrados.GetSelectedValue());

                if (selecionado == null)
                    return;

                clbc_ItemsDisponiveis.Items.Add(selecionado);
                clbc_ItemsCadastrados.Items.Remove(selecionado);
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion
    }
}