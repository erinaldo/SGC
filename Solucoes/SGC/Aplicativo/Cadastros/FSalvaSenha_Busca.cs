using Consultas;
using Entidades;
using Formas.Padrao;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FSalvaSenha_Busca : FPadrao_Busca_Menu
    {
        #region Declarações

        public E_SALVASENHA salvaSenha = new E_SALVASENHA();

        #endregion

        #region Métodos

        public FSalvaSenha_Busca()
        {
            InitializeComponent();

            Identificador = "C8";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FSalvaSenha_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        salvaSenha = forma.salvaSenha;
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

                if (gv_SalvaSenha.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FSalvaSenha_Cadastro { Operacao = Operacao.Alterar, salvaSenha = gv_SalvaSenha.GetSelectedRow<E_SALVASENHA>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        salvaSenha = forma.salvaSenha;
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

                if (gv_SalvaSenha.GetSelectedRows().Count() > 0 && Mensagens.Deletar() == DialogResult.Yes)
                {
                    foreach (var indiceSelecionado in gv_SalvaSenha.GetSelectedRows())
                    {
                        var registro = gv_SalvaSenha.GetRow(indiceSelecionado) as E_SALVASENHA;

                        if (registro != null)
                        {
                            registro.OPERACAO = Operacao.Deletar;

                            var transacao = 0;

                            C_SALVASENHA.Salvar(registro, ref transacao);
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

                var senhas = from a in Conexao.Banco.TB_DIV_SALVASENHAs
                             where a.LOGIN == Parametros.Usuario
                             select a;

                if (salvaSenha.ID_SALVASENHA > 0)
                    senhas = senhas.Where(a => a.ID_SALVASENHA == salvaSenha.ID_SALVASENHA);

                if (Quantidade > 0)
                    senhas = senhas.Take(Quantidade);

                gc_SalvaSenha.DataSource = senhas.Select(a => new E_SALVASENHA(a)).ToList();
                gv_SalvaSenha.BestFitColumns();

                salvaSenha = new E_SALVASENHA();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_SalvaSenha.ToGridList<E_SALVASENHA>());
            RelatorioSalvar();
        }

        #endregion
    }
}