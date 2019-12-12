using Consultas;
using Entidades;
using Formas.Padrao;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FUsuario_Busca : FPadrao_Busca_Menu
    {
        #region Declarações

        private E_USUARIO usuario = new E_USUARIO();

        #endregion

        #region Métodos

        public FUsuario_Busca()
        {
            InitializeComponent();

            Identificador = "C1";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FUsuario_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        usuario = forma.usuario;
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

                if (gv_Usuario.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FUsuario_Cadastro { Operacao = Operacao.Alterar, usuario = gv_Usuario.GetSelectedRow<E_USUARIO>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        usuario = forma.usuario;
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

                if (gv_Usuario.GetSelectedRows().Count() > 0 && Mensagens.Deletar() == DialogResult.Yes)
                {
                    foreach (var indiceSelecionado in gv_Usuario.GetSelectedRows())
                    {
                        var registro = gv_Usuario.GetRow(indiceSelecionado) as E_USUARIO;

                        if (registro != null)
                        {
                            registro.OPERACAO = Operacao.Deletar;
                            C_USUARIO.Salvar(registro, 0);
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

                var usuarios = from a in Conexao.Banco.TB_DIV_USUARIOs
                               where a.LOGIN == (usuario.LOGIN.HasValue() ? usuario.LOGIN : a.LOGIN)
                               select new E_USUARIO(a, false);

                if (Quantidade > 0)
                    usuarios = usuarios.Take(Quantidade);

                gc_Usuario.DataSource = usuarios;
                gv_Usuario.BestFitColumns();

                usuario = new E_USUARIO();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Usuario.ToGridList<E_USUARIO>());
            RelatorioSalvar();
        }

        #endregion

        #region Eventos

        #endregion
    }
}