using Componentes;
using Consultas;
using Entidades;
using Formas.Padrao;
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
    public partial class FComunicado_Lancamento : FPadrao_Cadastro_Menu
    {
        #region Declarações

        private List<string> randomFiles = new List<string>();

        public E_COMUNICADO comunicado = new E_COMUNICADO();

        #endregion

        #region Métodos

        public FComunicado_Lancamento()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                var grupoUsuarios = new List<E_COMUNICADO_X_GRUPOUSUARIO>();
                var usuarios = new List<E_COMUNICADO_X_USUARIO>();

                clbc_GruposUsuariosCadastrados.Items.Cast<CComboBoxEditValue>().Select(a => a.ID).ToList().ForEach(a => grupoUsuarios.Add(new E_COMUNICADO_X_GRUPOUSUARIO { ID_GRUPOUSUARIO = a.ToInt() }));
                clbc_UsuariosCadastrados.Items.Cast<CComboBoxEditValue>().Select(a => a.ID).ToList().ForEach(a => usuarios.Add(new E_COMUNICADO_X_USUARIO { LOGIN = a }));

                comunicado = new E_COMUNICADO
                {
                    OPERACAO = Operacao,
                    DS_COMUNICADO = cme_Descricao.Text.Treat(),
                    LOGIN_COMUNICADOR = Parametros.Usuario,
                    ST_REGISTRO = "A",
                    ANEXOS = bs_Anexos.List.Cast<E_ANEXO>().ToList(),
                    USUARIOS = usuarios,
                    GRUPOUSUARIOS = grupoUsuarios
                };

                var transacao = 0;

                if (C_COMUNICADO.Salvar(comunicado, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FComunicado_Lancamento_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Banco.TB_DIV_GRUPOUSUARIOs.ToList().ForEach(a => clbc_GruposUsuariosDisponiveis.Items.Add(new CComboBoxEditValue { ID = a.ID_GRUPOUSUARIO.ToString(), DS = a.DS_GRUPO.Treat() }));
                Conexao.Banco.TB_DIV_USUARIOs.ToList().ForEach(a => clbc_UsuariosDisponiveis.Items.Add(new CComboBoxEditValue { ID = a.LOGIN.ToString(), DS = a.NM_USUARIO.Treat() }));
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void FComunicado_Lancamento_FormClosing(object sender, FormClosingEventArgs e)
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

        private void clbc_GruposUsuariosDisponiveis_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selecionado = clbc_GruposUsuariosDisponiveis.Items.Cast<CComboBoxEditValue>().FirstOrDefault(a => a.ID == clbc_GruposUsuariosDisponiveis.GetSelectedValue());

                if (selecionado == null)
                    return;

                clbc_GruposUsuariosCadastrados.Items.Add(selecionado);
                clbc_GruposUsuariosDisponiveis.Items.Remove(selecionado);

                var usuarios = Conexao.Banco.TB_DIV_USUARIO_X_GRUPOs.Where(a => a.ID_GRUPOUSUARIO == selecionado.ID.ToInt()).Select(a => a.TB_DIV_USUARIO.LOGIN);

                foreach (var usuario in usuarios)
                {
                    var usuarioDisponivel = clbc_UsuariosDisponiveis.Items.Cast<CComboBoxEditValue>().FirstOrDefault(a => a.ID == usuario);
                    if (usuarioDisponivel != null)
                        clbc_UsuariosDisponiveis.Items.Remove(usuarioDisponivel);

                    var usuarioCadastrado = clbc_UsuariosCadastrados.Items.Cast<CComboBoxEditValue>().FirstOrDefault(a => a.ID == usuario);
                    if (usuarioCadastrado != null)
                        clbc_UsuariosCadastrados.Items.Remove(usuarioCadastrado);
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void clbc_GruposUsuariosCadastrados_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selecionado = clbc_GruposUsuariosCadastrados.Items.Cast<CComboBoxEditValue>().FirstOrDefault(a => a.ID == clbc_GruposUsuariosCadastrados.GetSelectedValue());

                if (selecionado == null)
                    return;

                clbc_GruposUsuariosDisponiveis.Items.Add(selecionado);
                clbc_GruposUsuariosCadastrados.Items.Remove(selecionado);

                var usuarios = Conexao.Banco.TB_DIV_USUARIO_X_GRUPOs.Where(a => a.ID_GRUPOUSUARIO == selecionado.ID.ToInt()).Select(a => a.TB_DIV_USUARIO);

                foreach (var usuario in usuarios)
                    clbc_UsuariosDisponiveis.Items.Add(new CComboBoxEditValue { ID = usuario.LOGIN, DS = usuario.NM_USUARIO.Treat() });
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void clbc_UsuariosDisponiveis_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selecionado = clbc_UsuariosDisponiveis.Items.Cast<CComboBoxEditValue>().FirstOrDefault(a => a.ID == clbc_UsuariosDisponiveis.GetSelectedValue());

                if (selecionado == null)
                    return;

                clbc_UsuariosCadastrados.Items.Add(selecionado);
                clbc_UsuariosDisponiveis.Items.Remove(selecionado);
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void clbc_UsuariosCadastrados_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selecionado = clbc_UsuariosCadastrados.Items.Cast<CComboBoxEditValue>().FirstOrDefault(a => a.ID == clbc_UsuariosCadastrados.GetSelectedValue());

                if (selecionado == null)
                    return;

                clbc_UsuariosDisponiveis.Items.Add(selecionado);
                clbc_UsuariosCadastrados.Items.Remove(selecionado);
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion
    }
}