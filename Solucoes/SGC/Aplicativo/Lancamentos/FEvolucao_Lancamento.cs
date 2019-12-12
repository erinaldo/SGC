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
    public partial class FEvolucao_Lancamento : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Declarações

        public int id_chamado = 0;

        private List<string> randomFiles = new List<string>();

        public string loginAtendente;

        #endregion

        #region Métodos

        public FEvolucao_Lancamento()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                if (Parametros.Usuario == Parametros.Administrador && !Conexao.Banco.TB_DIV_USUARIOs.Any(a => a.LOGIN == Parametros.Usuario))
                    throw new Exception("É necessário cadastrar o usuário administrador para efetuar o lançamento da evolução!");

                loginAtendente = ccbe_Atendente.GetSelectedValue();

                var evento = new E_EVENTO
                {
                    OPERACAO = Operacao.Cadastrar,
                    ID_CHAMADO = id_chamado,
                    DT_EVENTO = Conexao.Banco.GetDate(),
                    STATUS = ccbe_Status.GetSelectedValue(),
                    DS_EVENTO = cme_Descricao.Text.Treat(),
                    TP_EVENTO = ccbe_Tipo.GetSelectedValue(),
                    ANEXOS = bs_Anexos.List.Cast<E_ANEXO>().ToList(),
                    LOGIN_ATENDENTE = loginAtendente
                };

                var transacao = 0;

                if (C_EVENTO.Salvar(evento, ref transacao, false, 0, "",
                    new E_TRANSF_ATENDENTE
                    {
                        OPERACAO = Operacao.Cadastrar,
                        ID_CHAMADO = id_chamado,
                        LOGIN_NEW = ccbe_Atendente.GetSelectedValue(),
                        LOGIN_OLD = Conexao.Banco.TB_DIV_CHAMADOs.FirstOrDefault(a=>a.ID_CHAMADO == id_chamado).LOGIN_ATENDENTE
                    }))
                {
                    Finalizar();

                    if (evento.TP_EVENTO == "E")
                        Email.Enviar(Conexao.Banco.TB_DIV_CHAMADOs.FirstOrDefault(a => a.ID_CHAMADO == id_chamado), OperacaoEmail.Evolucao);
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

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

        private void FEvolucao_Lancamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5: csb_AdicionarAnexo_Click(); return;
                case Keys.F6: csb_DeletarAnexo_Click(); return;
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

        private void FEvolucao_Lancamento_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FEvolucao_Lancamento_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Banco.TB_DIV_STATUS.Where(a => a.ST_FINALIZAR != "S" && a.ST_INICIAR != "S").ToList().ForEach(a => ccbe_Status.SetValue(new CComboBoxEditValue { ID = a.SIGLA_STATUS, DS = a.DS_STATUS.Treat() }));
                Conexao.Banco.TB_DIV_USUARIOs.ToList().ForEach(a => ccbe_Atendente.SetValue(new CComboBoxEditValue { ID = a.LOGIN, DS = a.NM_USUARIO.Treat() }));

                ccbe_Atendente.SetSelected(loginAtendente);

                ccbe_Atendente.Properties.ReadOnly = loginAtendente != Parametros.Usuario;
                ccbe_Atendente.Properties.Buttons[0].Enabled = loginAtendente != Parametros.Usuario;

                ccbe_Tipo.SetValue(new CComboBoxEditValue { ID = "I", DS = "Interno" });
                ccbe_Tipo.SetValue(new CComboBoxEditValue { ID = "E", DS = "Externo" });
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void ccbe_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            ccbe_Tipo.SetSelected(Conexao.Banco.TB_DIV_STATUS.FirstOrDefault(a => a.SIGLA_STATUS == ccbe_Status.GetSelectedValue()).ST_INTERNO.Treat() == "N" ? "E" : "I");
        }

        #endregion
    }
}