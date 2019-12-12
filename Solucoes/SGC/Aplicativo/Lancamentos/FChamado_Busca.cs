using Componentes;
using Consultas;
using DevExpress.XtraEditors;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Lancamentos
{
    public partial class FChamado_Busca : Formas.Padrao.FPadrao_Busca
    {
        #region Declarações

        private List<string> randomFiles = new List<string>();

        #endregion

        #region Métodos

        public FChamado_Busca()
        {
            InitializeComponent();

            Identificador = "L1";

            Parametros.AcessoBotoes(Identificador, csb_Adicionar, new SimpleButton(), new SimpleButton(), csb_Relatorio);
        }
        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FChamado_Lancamento { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        cse_Identificador.Value = forma.chamado.ID_CHAMADO;
                        Buscar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public IQueryable<TB_DIV_CHAMADO> Buscar_Chamados()
        {
            return (from a in Conexao.Banco.TB_DIV_CHAMADOs
                    join usersol in Conexao.Banco.TB_DIV_USUARIOs on new { LOGIN = a.LOGIN_SOLICITANTE } equals new { LOGIN = usersol.LOGIN }
                    join useraten in Conexao.Banco.TB_DIV_USUARIOs on new { LOGIN = a.LOGIN_ATENDENTE } equals new { LOGIN = useraten.LOGIN } into useraten_join
                    from useraten in useraten_join.DefaultIfEmpty()
                    join dptoaten in Conexao.Banco.TB_DIV_DEPARTAMENTOs on new { ID_DEPARTAMENTO = Convert.ToInt32(useraten.ID_DEPARTAMENTO) } equals new { ID_DEPARTAMENTO = dptoaten.ID_DEPARTAMENTO } into dptoaten_join
                    from dptoaten in dptoaten_join.DefaultIfEmpty()
                    where !Parametros.IsAdministrator() ? ((from x in Conexao.Banco.TB_DIV_USUARIOs where x.LOGIN == Parametros.Usuario && x.ID_DEPARTAMENTO == a.ID_DEPARTAMENTO select new { }).Single() != null || usersol.ID_DEPARTAMENTO == ((from x in Conexao.Banco.TB_DIV_USUARIOs where x.LOGIN == Parametros.Usuario select new { x.ID_DEPARTAMENTO }).First().ID_DEPARTAMENTO)) : true
                    select a).ToList().AsQueryable();
        }

        public override void Buscar()
        {
            try
            {
                base.Buscar();

               var chamados = Buscar_Chamados();

                if (cce_ChamadosAbertos.Checked)
                    chamados = chamados.Where(a => a.ST_CHAMADO == "A");

                if (cse_Identificador.Value > 0)
                    chamados = chamados.Where(a => a.ID_CHAMADO == cse_Identificador.Value);

                var atendentes = cccbe_Atendente.GetCheckedValues();
                if (atendentes.Any())
                    chamados = chamados.Where(a => atendentes.Any(b => a.LOGIN_ATENDENTE == b.GetValue()));

                var solicitantes = cccbe_Solicitante.GetCheckedValues();
                if (solicitantes.Any())
                    chamados = chamados.Where(a => solicitantes.Any(b => a.LOGIN_SOLICITANTE == b.GetValue()));

                var status = cccbe_Status.GetCheckedValues();
                if (status.Any())
                    chamados = chamados.Where(a => status.Any(b => a.ST_CHAMADO == b));

                var prioridade = cccbe_Prioridade.GetCheckedValues();
                if (prioridade.Any())
                    chamados = chamados.Where(a => prioridade.Any(b => a.PRIORIDADE != null && a.PRIORIDADE == b));

                var categorias = cccbe_Categoria.GetCheckedValues();
                if (categorias.Any())
                    chamados = chamados.Where(a => categorias.Any(b => a.TB_DIV_CATEGORIA != null && a.ID_CATEGORIA == b.ToInt()));

                var departamentos = cccbe_Departamento.GetCheckedValues();
                if (departamentos.Any())
                    chamados = chamados.Where(a => departamentos.Any(b => a.TB_DIV_DEPARTAMENTO != null && a.ID_DEPARTAMENTO == b.ToInt()));

                var gravidades = ccbe_Gravidade.GetCheckedValues();
                if (gravidades.Any())
                    chamados = chamados.Where(a => gravidades.Any(b => a.TB_DIV_CATEGORIA != null && a.TB_DIV_CATEGORIA.GRAVIDADE == b));

                if (FiltrarDatas())
                {
                    if (cce_Lancamento.Checked)
                        chamados = chamados.Where(a => a.DT_CHAMADO != null && (a.DT_CHAMADO >= cde_DataInicial.DateTime) && (a.DT_CHAMADO <= cde_DataFinal.DateTime));
                    if (cce_Atendimento.Checked)
                        chamados = chamados.Where(a => a.DT_ATENDIMENTO != null && (a.DT_ATENDIMENTO.Value >= cde_DataInicial.DateTime) && (a.DT_ATENDIMENTO.Value <= cde_DataFinal.DateTime));
                    if (cce_Previsto.Checked)
                        chamados = chamados.Where(a => a.DT_PREVISTA != null && (a.DT_PREVISTA.Value >= cde_DataInicial.DateTime) && (a.DT_PREVISTA.Value <= cde_DataFinal.DateTime));
                    if (cce_Finalizado.Checked)
                        chamados = chamados.Where(a => a.DT_FINALIZADO != null && (a.DT_FINALIZADO.Value >= cde_DataInicial.DateTime) && (a.DT_FINALIZADO.Value <= cde_DataFinal.DateTime));
                }

                if (Quantidade > 0)
                    chamados = chamados.Take(Quantidade);

                gc_Chamado.DataSource = chamados.Select(a => new E_CHAMADO(a)).ToList();
                gv_Chamado.ExpandAllGroups();
                gv_Chamado.BestFitColumns();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        public override void Relatorio()
        {
            try
            {
                base.Relatorio();

                RelatorioGerar(gv_Chamado.ToGridList<E_CHAMADO>());
                RelatorioSalvar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private bool FiltrarDatas()
        {
            return cce_Atendimento.Checked || cce_Lancamento.Checked || cce_Previsto.Checked || cce_Finalizado.Checked;
        }
        private void Evoluir(bool finalizar = false)
        {
            try
            {
                if (gv_Chamado.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro("um chamado");

                var chamado = gv_Chamado.GetSelectedRow<E_CHAMADO>();

                if (finalizar && chamado.LOGIN_SOLICITANTE != Parametros.Usuario && !Parametros.IsAdministrator())
                    throw new Exception("Somente o solicitante ou o administrador podem finalizar o chamado!");

                if (!finalizar && chamado.LOGIN_ATENDENTE.Treat().Length == 0)
                    throw new Exception("Não é permitido evoluir um chamado sem atendimento!");

                if ((!finalizar && chamado.LOGIN_ATENDENTE != Parametros.Usuario) && !Parametros.IsAdministrator())
                    throw new Exception("Somente o solicitante, atendente ou o administrador podem evoluir o chamado!");

                if (finalizar)
                {
                    if (Parametros.IsAdministrator() && !Conexao.Banco.TB_DIV_USUARIOs.Any(a => a.LOGIN == Parametros.Usuario))
                        throw new Exception("É necessário cadastrar o usuário administrador para efetuar o lançamento da evolução!");

                    var siglaFinalizar = Conexao.Banco.TB_DIV_STATUS.FirstOrDefault(a => a.ST_FINALIZAR == "S");
                    if (siglaFinalizar == null)
                        throw new Exception("É necessário cadastrar a sigla de finalização para efetuar o lançamento da evolução!");

                    var evento = new E_EVENTO
                    {
                        OPERACAO = Operacao.Cadastrar,
                        ID_CHAMADO = chamado.ID_CHAMADO,
                        DT_EVENTO = Conexao.Banco.GetDate(),
                        STATUS = siglaFinalizar.SIGLA_STATUS,
                        DS_EVENTO = "FINALIZADO PELO USUÁRIO: " + Parametros.Usuario,
                        TP_EVENTO = "I",
                        ANEXOS = new List<E_ANEXO>(),
                        LOGIN_FINALIZADOR = Parametros.Usuario
                    };

                    var formaAvaliacao = new FAvaliacao_Lancamento();
                    if (formaAvaliacao.ShowDialog() != DialogResult.OK)
                        return;

                    var transacao = 0;

                    C_EVENTO.Salvar(evento, ref transacao, finalizar, formaAvaliacao.tbc_Nota.Value, formaAvaliacao.cme_Sugestao.Text.Treat());

                    Email.Enviar(Conexao.Banco.TB_DIV_CHAMADOs.FirstOrDefault(a => a.ID_CHAMADO == chamado.ID_CHAMADO), OperacaoEmail.Finalizacao);
                }
                else
                    using (var forma = new FEvolucao_Lancamento { id_chamado = chamado.ID_CHAMADO, loginAtendente = (string)gv_Chamado.GetRowCellValue(gv_Chamado.FocusedRowHandle, colLOGIN_ATENDENTE) })
                    {
                        if (forma.ShowDialog() == DialogResult.OK)
                        {
                            cse_Identificador.Value = chamado.ID_CHAMADO;

                            
                        }
                    }

                Buscar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void AbrirAnexos(BindingSource bs)
        {
            try
            {
                if (bs.HasValue())
                {
                    var arquivo = Path.GetTempPath() + Path.GetRandomFileName() + (bs.Current as E_ANEXO).EXTENSAO;
                    randomFiles.Add(arquivo);

                    File.WriteAllBytes(arquivo, (bs.Current as E_ANEXO).ANEXO.ToArray());
                    Process.Start(arquivo);
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FChamado_Busca_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                csb_AtualizarFiltros_Click();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void FChamado_Busca_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                randomFiles.ForEach(a =>
                {
                    if (File.Exists(a))
                        File.Delete(a);
                });

                Dispose();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void FChamado_Busca_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F2: csb_Adicionar_Click(); return;
                    case Keys.F5: csb_Buscar_Click(); return;
                    case Keys.F7: csb_Relatorio_Click(); return;
                    case Keys.F9: csb_Atender_Click(); return;
                    case Keys.F10: csb_Evoluir_Click(); return;
                    case Keys.F11: csb_Finalizar_Click(); return;
                    case Keys.F12: csb_AtualizarFiltros_Click(); return;
                    case Keys.Escape: csb_Sair_Click(); return;
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void csb_Adicionar_Click(object sender = null, EventArgs e = null)
        {
            this.Adicionar();
        }
        private void csb_Buscar_Click(object sender = null, EventArgs e = null)
        {
            this.Buscar();
        }
        private void csb_Relatorio_Click(object sender = null, EventArgs e = null)
        {
            this.Relatorio();
        }
        private void csb_Atender_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                if (gv_Chamado.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro("um chamado");

                var chamado = gv_Chamado.GetSelectedRow<E_CHAMADO>();

                if (chamado.ST_CHAMADO == "C")
                    throw new Exception("Não é permitido atender um chamado já cancelado!");
                if (chamado.ST_CHAMADO == "F")
                    throw new Exception("Não é permitido atender um chamado já finalizado!");
                if (Conexao.Banco.TB_DIV_EVENTOs.Any(a => a.ID_CHAMADO == chamado.ID_CHAMADO))
                    throw new Exception("Não é permitido atender um chamado já em atendimento!");

                using (var forma = new FAtendimento_Lancamento { Operacao = Operacao.Alterar, chamado = chamado })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        cse_Identificador.Value = forma.chamado.ID_CHAMADO;
                        Buscar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void csb_Evoluir_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                Evoluir();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void csb_Finalizar_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                Evoluir(true);
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void csb_AtualizarFiltros_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                cse_Identificador.Value = 0;
                cce_Atendimento.Checked = false;
                cce_Lancamento.Checked = false;
                cce_Previsto.Checked = false;
                cce_Finalizado.Checked = false;

                Datas_CheckedChanged(null, null);

                cccbe_Atendente.Properties.Items.Clear();
                cccbe_Solicitante.Properties.Items.Clear();

                var logins = from a in Conexao.Banco.TB_DIV_USUARIOs select new E_USUARIO(a, true);
                bs_Atendente.DataSource = logins;
                bs_Solicitante.DataSource = logins;

                bs_Status.DataSource = from a in Conexao.Banco.TB_DIV_STATUS select new E_STATUS(a);
                bs_Prioridade.DataSource = C_PRIORIDADE.Buscar();
                bs_Categoria.DataSource = from a in Conexao.Banco.TB_DIV_CATEGORIAs select new E_CATEGORIA(a);
                bs_Departamento.DataSource = from a in Conexao.Banco.TB_DIV_DEPARTAMENTOs select new E_DEPARTAMENTO(a);

                cse_Identificador.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void csb_Sair_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                Close();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void Datas_CheckedChanged(object sender = null, EventArgs e = null)
        {
            try
            {
                cde_DataInicial.Enabled = FiltrarDatas();
                cde_DataFinal.Enabled = cde_DataInicial.Enabled;

                if (cde_DataInicial.Enabled && cde_DataFinal.Enabled)
                {
                    var primeiraData = Conexao.Banco.TB_DIV_CHAMADOs.Where(a => a.DT_CAD != null).OrderBy(a => a.DT_CAD).FirstOrDefault();

                    cde_DataInicial.DateTime = primeiraData != null ? primeiraData.DT_CAD.Value : cde_DataInicial.DataMinima;
                    cde_DataFinal.DateTime = cde_DataInicial.DateTime;
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void gv_Chamado_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gv_Chamado.GetSelectedRows().Count() != 0)
                {
                    xtp_ChamadoDetalhes.PageVisible = true;

                    var row = gv_Chamado.GetSelectedRow<E_CHAMADO>();
                    cte_DetalhesApartamento.Text = row.DEPARTAMENTO.Treat();
                    cte_DetalhesCategoria.Text = row.CATEGORIA.Treat();
                    cde_DetalhesDataRequerida.DateTime = row.DT_REQUERIDA.GetValueOrDefault();
                    cme_DetalhesDescricao.Text = row.DS_CHAMADO.Treat();
                    bs_DetalhesAnexos.DataSource = row.ANEXOS;

                    var evolucoes = Conexao.Banco.TB_DIV_EVENTOs.Where(a => a.ID_CHAMADO == row.ID_CHAMADO).Select(a => new E_EVENTO(a));

                    xtp_ChamadoEvolucoes.PageVisible = evolucoes.Count() > 0;
                    gc_Evolucoes.DataSource = evolucoes.Count() > 0 ? evolucoes : null;
                    gv_Evolucoes.BestFitColumns();

                    if (evolucoes.Count() > 0)
                        gv_Evolucoes_RowClick(null, null);

                    row = null;
                    evolucoes = null;
                }
                else
                {
                    bs_EvolucoesAnexos.DataSource = null;
                    bs_DetalhesAnexos.DataSource = null;

                    xtp_ChamadoEvolucoes.PageVisible = false;
                    xtp_ChamadoDetalhes.PageVisible = false;
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void gv_Evolucoes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gv_Evolucoes.GetSelectedRows().Count() > 0)
                {
                    var row = gv_Evolucoes.GetSelectedRow<E_EVENTO>();

                    cde_EvolucaoData.DateTime = row.DT_EVENTO;
                    cte_EvolucaoStatus.Text = row.STATUS;
                    cme_EvolucaoObservacao.Text = row.DS_EVENTO.Treat();
                    bs_EvolucoesAnexos.DataSource = row.ANEXOS;
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void lbc_DetalhesAnexos_DoubleClick(object sender, EventArgs e)
        {
            AbrirAnexos(bs_DetalhesAnexos);
        }
        private void lbc_DoubleClick(object sender, EventArgs e)
        {
            AbrirAnexos(bs_EvolucoesAnexos);
        }

        #endregion
    }
}