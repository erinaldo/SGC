using Consultas;
using Entidades;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FGrupoUsuario_Busca : Formas.Padrao.FPadrao_Busca_Menu
    {
        #region Declarações

        public E_GRUPOUSUARIO grupousuario = new E_GRUPOUSUARIO();

        #endregion

        #region Métodos

        public FGrupoUsuario_Busca()
        {
            InitializeComponent();

            Identificador = "C2";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FGrupoUsuario_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        grupousuario = forma.grupousuario;
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

                if (gv_GrupoUsuario.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FGrupoUsuario_Cadastro { Operacao = Operacao.Alterar, grupousuario = gv_GrupoUsuario.GetSelectedRow<E_GRUPOUSUARIO>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        grupousuario = forma.grupousuario;
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

                foreach (var indiceSelecionado in gv_GrupoUsuario.GetSelectedRows())
                {
                    var registro = gv_GrupoUsuario.GetRow(indiceSelecionado) as E_GRUPOUSUARIO;

                    if (registro != null)
                    {
                        registro.OPERACAO = Operacao.Deletar;

                        var transacao = 0;

                        C_GRUPOUSUARIO.Salvar(registro, ref transacao);
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

                var grupos = from a in Conexao.Banco.TB_DIV_GRUPOUSUARIOs
                             where a.ID_GRUPOUSUARIO == (grupousuario.ID_GRUPOUSUARIO > 0 ? grupousuario.ID_GRUPOUSUARIO : a.ID_GRUPOUSUARIO)
                             select a;

                if (Quantidade > 0)
                    grupos = grupos.Take(Quantidade);

                gc_GrupoUsuario.DataSource = grupos.Select(a => new E_GRUPOUSUARIO(a)).ToList();
                gv_GrupoUsuario.BestFitColumns();

                grupousuario = new E_GRUPOUSUARIO();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_GrupoUsuario.ToGridList<E_GRUPOUSUARIO>());
            RelatorioSalvar();
        }

        #endregion

        #region Eventos

        #endregion
    }
}