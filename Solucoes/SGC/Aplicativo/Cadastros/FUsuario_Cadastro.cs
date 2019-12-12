using Componentes;
using Consultas;
using Entidades;
using Formas.Padrao;
using Formas.Pesquisa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FUsuario_Cadastro : FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_USUARIO usuario = new E_USUARIO();

        #endregion

        #region Métodos

        public FUsuario_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cbe_Clifor_Leave();
                cbe_Cargo_Leave();
                cbe_Departamento_Leave();

                cpc_DadosGerais.Controls.Validate();

                usuario = new E_USUARIO
                {
                    OPERACAO = Operacao,
                    LOGIN = cte_Login.Text.Trim(),
                    SENHA = cte_Senha.Text.Trim(),
                    NM_USUARIO = cte_Nome.Text.Trim(),
                    ST_ADMINISTRADOR = cce_Administrador.Checked ? "S" : "N",
                    ST_REGISTRO = cce_Status.Checked ? "A" : "C",
                    NR_TELEFONE = cte_Telefone.Text.Trim(),
                    NR_CELULAR = cte_Celular.Text.Trim(),
                    EMAIL = cte_Email.Text.Trim(),
                    SKYPE = cte_Skype.Text.Trim(),
                    CLIFOR = cbe_Clifor.Text.HasValue() ? new E_CLIFOR { ID_CLIFOR = cbe_Clifor.Text.ToInt() } : null,
                    CARGO = cbe_Cargo.Text.HasValue() ? new E_CARGO { ID_CARGO = cbe_Cargo.Text.ToInt() } : null,
                    DEPARTAMENTO = cbe_Departamento.Text.HasValue() ? new E_DEPARTAMENTO { ID_DEPARTAMENTO = cbe_Departamento.Text.ToInt() } : null,
                    DS_OBSERVACAO = cme_Observacao.Text.Trim(),
                    ACESSOS = gv_Acessos.ToGridList<E_ACESSO>(),
                    REGRASACESSO = gv_RegrasEspeciais.ToGridList<E_REGRAACESSO>(),
                    GRUPOUSUARIO = gv_Grupos.ToGridList<E_GRUPOUSUARIO>()
                };

                if (C_USUARIO.Salvar(usuario))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FUsuario_Cadastro_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                if (Operacao == Operacao.Alterar)
                {
                    cte_Login.Text = usuario.LOGIN.Treat();
                    cte_Login.Enabled = false;

                    cte_Senha.Text = usuario.SENHA.Treat();
                    cte_Nome.Text = usuario.NM_USUARIO.Treat();

                    cce_Administrador.Checked = usuario.ST_ADMINISTRADOR.Treat().ToUpper() == "S";
                    cce_Status.Checked = usuario.ST_REGISTRO.Treat().ToUpper() == "A";

                    cte_Telefone.Text = usuario.NR_TELEFONE.Treat();
                    cte_Celular.Text = usuario.NR_CELULAR.Treat();
                    cte_Email.Text = usuario.EMAIL.Treat();
                    cte_Skype.Text = usuario.SKYPE.Treat();

                    if (usuario.CLIFOR != null)
                    {
                        cbe_Clifor.Text = usuario.CLIFOR.ID_CLIFOR.ToString();
                        cte_DS_Clifor.Text = usuario.CLIFOR.NM_CLIFOR.Treat();
                    }

                    if (usuario.CARGO != null)
                    {
                        cbe_Cargo.Text = usuario.CARGO.ID_CARGO.ToString();
                        cte_DS_Cargo.Text = usuario.CARGO.DS_CARGO.Treat();
                    }

                    if (usuario.DEPARTAMENTO != null)
                    {
                        cbe_Departamento.Text = usuario.DEPARTAMENTO.ID_DEPARTAMENTO.ToString();
                        cte_DS_Departamento.Text = usuario.DEPARTAMENTO.DS_DEPARTAMENTO.Treat();
                    }

                    if (usuario.ACESSOS != null)
                        gc_Acessos.DataSource = usuario.ACESSOS;

                    if (usuario.REGRASACESSO != null)
                        gc_RegrasEspeciais.DataSource = usuario.REGRASACESSO;

                    if (usuario.GRUPOUSUARIO != null)
                        gc_Grupos.DataSource = usuario.GRUPOUSUARIO;

                    cte_Senha.Select();
                }
                else
                    cte_Login.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void sb_CopiarInformacoes_Click(object sender, EventArgs e)
        {
            try
            {
                using (var pesquisa = new FPesquisa()
                {
                    Consulta = from a in Conexao.Banco.TB_DIV_USUARIOs
                               select new E_USUARIO(a, true),
                    Filtros = new List<FPesquisa.Filtro> 
                    { 
                        new FPesquisa.Filtro { Tamanho = 350, Nome = "LOGIN", Descricao = "Login" } ,
                        new FPesquisa.Filtro { Tamanho = 350, Nome = "NM_USUARIO", Descricao = "Nome" } 
                    },
                    Multiplos = true
                })
                {
                    if (pesquisa.ShowDialog() == DialogResult.OK)
                    {
                        var selecionado = Conexao.Banco.TB_DIV_USUARIOs.FirstOrDefault(a => a.LOGIN == pesquisa.Selecionados.Cast<E_USUARIO>().First().LOGIN);

                        cbe_Departamento.Text = selecionado.ID_DEPARTAMENTO.GetValueOrDefault().ToString();
                        cbe_Departamento_Leave();
                        cbe_Cargo.Text = selecionado.ID_CARGO.GetValueOrDefault().ToString();
                        cbe_Cargo_Leave();

                        gc_Acessos.DataSource = selecionado.TB_DIV_ACESSOs.Select(a => new E_ACESSO(a));
                        gc_RegrasEspeciais.DataSource = selecionado.TB_DIV_LOGIN_X_REGRAACESSOs.Select(a => new E_REGRAACESSO(a.TB_DIV_REGRAACESSO));
                        gc_Grupos.DataSource = selecionado.TB_DIV_USUARIO_X_GRUPOs.Select(a => new E_GRUPOUSUARIO(a.TB_DIV_GRUPOUSUARIO));
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cte_Login_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_Login.Text = cte_Login.Text.Treat();

                if (cte_Login.Text == Parametros.Administrador)
                {
                    if (Parametros.Usuario != Parametros.Administrador)
                        throw new Exception("Você não tem permissão para alterar dados do administrador!");
                    if (Conexao.Banco.TB_DIV_USUARIOs.Any(a => a.LOGIN == Parametros.Administrador) && Operacao != Operacao.Alterar)
                        throw new Exception("Não é possível cadastrar o administrador!\nCaso queira alterar, por favor, use a tela de busca e posteriormente clique em alterar!");
                }
                else if (Conexao.Banco.TB_DIV_USUARIOs.Any(a => a.LOGIN == cte_Login.Text))
                    throw new Exception("Não é possível cadastrar um usuário já cadastrado!\nCaso queira alterar, por favor, use a tela de busca e posteriormente clique em alterar!");
            }
            catch (Exception excessao)
            {
                cte_Login.Text = "";
                cte_Login.Select();
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_Clifor_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_DS_Clifor.Text = "";
                cbe_Clifor.Text.ToInt();

                if (cbe_Clifor.Text.ToInt() <= 0)
                    cbe_Clifor.Text = "";
                else
                {
                    var clifor = (from a in Conexao.Banco.TB_DIV_CLIFORs where a.ID_CLIFOR == cbe_Clifor.Text.ToInt() select new E_CLIFOR(a)).Take(1);

                    if (clifor == null || clifor.Count() == 0)
                        cbe_Clifor.Text = "";
                    else
                        cte_DS_Clifor.Text = clifor.First().NM_CLIFOR.Treat();
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void cbe_Clifor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    var filtros = new List<FPesquisa.Filtro>();

                    var id_clifor = new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_CLIFOR", Tamanho = 100 };
                    var nm_clifor = new FPesquisa.Filtro { Descricao = "Nome", Nome = "NM_CLIFOR", Tamanho = 350 };

                    filtros.Add(id_clifor);
                    filtros.Add(nm_clifor);

                    formaPesquisa.Filtros = filtros;
                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_CLIFORs select new E_CLIFOR(a);

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Clifor.Text = formaPesquisa.Selecionados.Cast<E_CLIFOR>().First().ID_CLIFOR.ToString();
                        cte_DS_Clifor.Text = formaPesquisa.Selecionados.Cast<E_CLIFOR>().First().NM_CLIFOR.Treat();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_Cargo_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_DS_Cargo.Text = "";
                cbe_Cargo.Text.ToInt();

                if (cbe_Cargo.Text.ToInt() <= 0)
                    cbe_Cargo.Text = "";
                else
                {
                    var cargo = (from a in Conexao.Banco.TB_DIV_CARGOs where a.ID_CARGO == cbe_Cargo.Text.ToInt() select new E_CARGO(a)).Take(1);

                    if (cargo == null || cargo.Count() == 0)
                        cbe_Cargo.Text = "";
                    else
                        cte_DS_Cargo.Text = cargo.First().DS_CARGO.Treat();
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void cbe_Cargo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    var filtros = new List<FPesquisa.Filtro>();

                    var id_cargo = new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_CARGO", Tamanho = 100 };
                    var ds_cargo = new FPesquisa.Filtro { Descricao = "Nome", Nome = "DS_CARGO", Tamanho = 350 };

                    filtros.Add(id_cargo);
                    filtros.Add(ds_cargo);

                    formaPesquisa.Filtros = filtros;
                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_CARGOs select new E_CARGO(a);

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Cargo.Text = formaPesquisa.Selecionados.Cast<E_CARGO>().First().ID_CARGO.ToString();
                        cte_DS_Cargo.Text = formaPesquisa.Selecionados.Cast<E_CARGO>().First().DS_CARGO.Treat();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cbe_Departamento_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_DS_Departamento.Text = "";
                cbe_Departamento.Text.ToInt();

                if (cbe_Departamento.Text.ToInt() <= 0)
                    cbe_Departamento.Text = "";
                else
                {
                    var departamento = (from a in Conexao.Banco.TB_DIV_DEPARTAMENTOs where a.ID_DEPARTAMENTO == cbe_Departamento.Text.ToInt() select new E_DEPARTAMENTO(a)).Take(1);

                    if (departamento == null || departamento.Count() == 0)
                        cbe_Departamento.Text = "";
                    else
                        cte_DS_Departamento.Text = departamento.First().DS_DEPARTAMENTO.Treat();
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void cbe_Departamento_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    var filtros = new List<FPesquisa.Filtro>();

                    var id_departamento = new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_DEPARTAMENTO", Tamanho = 100 };
                    var ds_departamento = new FPesquisa.Filtro { Descricao = "Nome", Nome = "DS_DEPARTAMENTO", Tamanho = 350 };

                    filtros.Add(id_departamento);
                    filtros.Add(ds_departamento);

                    formaPesquisa.Filtros = filtros;
                    formaPesquisa.Multiplos = false;
                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_DEPARTAMENTOs select new E_DEPARTAMENTO(a);

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Departamento.Text = formaPesquisa.Selecionados.Cast<E_DEPARTAMENTO>().First().ID_DEPARTAMENTO.ToString();
                        cte_DS_Departamento.Text = formaPesquisa.Selecionados.Cast<E_DEPARTAMENTO>().First().DS_DEPARTAMENTO.Treat();
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void csb_AdicionarAcesso_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                var registrosGrid = gv_Acessos.ToGridList<E_ACESSO>();

                using (var pesquisa = new FPesquisa()
                {
                    Consulta = from a in Conexao.Banco.TB_DIV_MENUs
                               where !registrosGrid.Select(b => b.ID_MENU).Contains(a.ID_MENU)
                               select new E_ACESSO(null, a),
                    Filtros = new List<FPesquisa.Filtro> { new FPesquisa.Filtro { Tamanho = 350, Nome = "DS_MENU", Descricao = "Descrição" } },
                    Multiplos = true
                })
                {
                    if (pesquisa.ShowDialog() == DialogResult.OK)
                    {
                        registrosGrid.AddRange(pesquisa.Selecionados.Cast<E_ACESSO>());
                        gc_Acessos.DataSource = registrosGrid;
                    }
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void csb_DeletarAcesso_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                gv_Acessos.DeleteSelectedRows();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void csb_AdicionarRegra_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                var registrosGrid = gv_RegrasEspeciais.ToGridList<E_REGRAACESSO>();

                using (var pesquisa = new FPesquisa()
                {
                    Consulta = from a in Conexao.Banco.TB_DIV_REGRAACESSOs
                               where !registrosGrid.Select(b => b.ID_REGRAACESSO).Contains(a.ID_REGRAACESSO)
                               select new E_REGRAACESSO(a),
                    Filtros = new List<FPesquisa.Filtro> { new FPesquisa.Filtro { Tamanho = 350, Nome = "DS_OBSERVACAO", Descricao = "Descrição" } }
                })
                {
                    if (pesquisa.ShowDialog() == DialogResult.OK)
                    {
                        registrosGrid.AddRange(pesquisa.Selecionados.Cast<E_REGRAACESSO>());
                        gc_RegrasEspeciais.DataSource = registrosGrid;
                    }
                }

                gv_RegrasEspeciais.BestFitColumns();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void csb_DeletarRegra_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                gv_RegrasEspeciais.DeleteSelectedRows();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void csb_AdicionarGrupo_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                var registrosGrid = gv_Grupos.ToGridList<E_GRUPOUSUARIO>();

                using (var pesquisa = new FPesquisa()
                {
                    Consulta = from a in Conexao.Banco.TB_DIV_GRUPOUSUARIOs
                               where !registrosGrid.Select(b => b.ID_GRUPOUSUARIO).Contains(a.ID_GRUPOUSUARIO)
                               select new E_GRUPOUSUARIO(a),
                    Filtros = new List<FPesquisa.Filtro> { new FPesquisa.Filtro { Tamanho = 350, Nome = "DS_GRUPO", Descricao = "Descrição" } }
                })
                {
                    if (pesquisa.ShowDialog() == DialogResult.OK)
                    {
                        registrosGrid.AddRange(pesquisa.Selecionados.Cast<E_GRUPOUSUARIO>());
                        gc_Grupos.DataSource = registrosGrid;
                    }
                }

                gv_Grupos.BestFitColumns();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
        private void csb_DeletarGrupo_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                gv_Grupos.DeleteSelectedRows();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

       
    }
}