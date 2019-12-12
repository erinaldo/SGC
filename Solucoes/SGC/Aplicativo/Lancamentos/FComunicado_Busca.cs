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
    public partial class FComunicado_Busca : FPadrao_Busca_Menu
    {
        #region Declarações

        private E_COMUNICADO comunicado = new E_COMUNICADO();

        private List<string> randomFiles = new List<string>();

        #endregion

        #region Métodos
        public FComunicado_Busca()
        {
            InitializeComponent();
            Identificador = "L6";
            DefinirPermissoes();

            csb_Alterar.Enabled = false;
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FComunicado_Lancamento { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        comunicado = forma.comunicado;
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

                if (gv_Comunicado.GetSelectedRows().Count() > 0 && Mensagens.Deletar() == DialogResult.Yes)
                {
                    foreach (var indiceSelecionado in gv_Comunicado.GetSelectedRows())
                    {
                        var registro = gv_Comunicado.GetRow(indiceSelecionado) as E_COMUNICADO;

                        var transacao = 0;

                        if (registro != null)
                        {
                            registro.OPERACAO = Operacao.Deletar;
                            C_COMUNICADO.Salvar(registro, ref transacao);
                        }
                    }

                    Buscar();
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

                var comunicados = from a in Conexao.Banco.TB_DIV_COMUNICADOs
                                  where
                                  a.ID_COMUNICADO == (comunicado.ID_COMUNICADO > 0 ? comunicado.ID_COMUNICADO : a.ID_COMUNICADO)
                                  select a;

                if (!Parametros.IsAdministrator())
                    comunicados = from a in comunicados
                                  where
                                  Conexao.Banco.TB_DIV_COMUNICADO_X_USUARIOs.Where(b=>b.ID_COMUNICADO == a.ID_COMUNICADO).Select(b => b.LOGIN).ToList().Contains(Parametros.Usuario) ||
                                  (from c in Conexao.Banco.TB_DIV_COMUNICADO_X_GRUPOUSUARIOs.Where(b => b.ID_COMUNICADO == a.ID_COMUNICADO).Select(b => b.ID_GRUPOUSUARIO)
                                   join d in Conexao.Banco.TB_DIV_USUARIO_X_GRUPOs.Where(b => b.LOGIN == Parametros.Usuario).Select(b => b.ID_GRUPOUSUARIO) on new { ID_GRUPOUSUARIO = c } equals new { ID_GRUPOUSUARIO = d }
                                   select new { }).Count() > 0
                                  select a;

                if (Quantidade > 0)
                    comunicados = comunicados.Take(Quantidade);

                gc_Comunicado.DataSource = comunicados.Select(a => new E_COMUNICADO(a)).ToList();
                gv_Comunicado.BestFitColumns();

                comunicado = new E_COMUNICADO();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Comunicado.ToGridList<E_COMUNICADO>());
            RelatorioSalvar();
        }

        #endregion

        #region Eventos

        private void gv_Comunicado_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            xtp_GruposComunicados.PageVisible = false;
            xtp_UsuariosComunicados.PageVisible = false;
            xtp_Anexos.PageVisible = false;

            bs_Anexos.DataSource = new E_COMUNICADO();

            if (e != null && gv_Comunicado.GetRow(e.RowHandle) != null)
            {
                var row = (E_COMUNICADO)gv_Comunicado.GetRow(e.RowHandle);
                if (row != null)
                {
                    xtp_GruposComunicados.PageVisible = row.GRUPOUSUARIOS.Count > 0;
                    gc_Grupos.DataSource = from a in row.GRUPOUSUARIOS
                                             join b in Conexao.Banco.TB_DIV_GRUPOUSUARIOs on new { a.ID_GRUPOUSUARIO } equals new {b.ID_GRUPOUSUARIO }
                                             select new
                                             {
                                                 GRUPO = b.ID_GRUPOUSUARIO + " - " + b.DS_GRUPO.Treat()
                                             };

                    xtp_UsuariosComunicados.PageVisible = row.USUARIOS.Count > 0;
                    gc_Usuarios.DataSource = from a in row.USUARIOS
                                             join b in Conexao.Banco.TB_DIV_USUARIOs on new { a.LOGIN } equals new { b.LOGIN }
                                             select new
                                             {
                                                 USUARIO = b.LOGIN + " - " + b.NM_USUARIO.Treat()
                                             };

                    xtp_Anexos.PageVisible = row.ANEXOS.Count > 0;
                    bs_Anexos.DataSource = row.ANEXOS;
                }
            }

            gv_Grupos.BestFitColumns();
            gv_Usuarios.BestFitColumns();
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

        private void FComunicado_Busca_FormClosing(object sender, FormClosingEventArgs e)
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