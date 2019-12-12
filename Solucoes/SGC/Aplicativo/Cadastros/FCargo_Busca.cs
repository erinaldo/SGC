using Consultas;
using Entidades;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FCargo_Busca : Formas.Padrao.FPadrao_Busca_Menu
    {
        #region Declarações

        public E_CARGO cargo = new E_CARGO();

        #endregion

        #region Métodos

        public FCargo_Busca()
        {
            InitializeComponent();

            Identificador = "C3";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FCargo_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        cargo = forma.cargo;
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

                if (gv_Cargo.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FCargo_Cadastro { Operacao = Operacao.Alterar, cargo = gv_Cargo.GetSelectedRow<E_CARGO>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        cargo = forma.cargo;
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

                if (gv_Cargo.GetSelectedRows().Count() > 0 && Mensagens.Deletar() == DialogResult.Yes)
                {
                    foreach (var indiceSelecionado in gv_Cargo.GetSelectedRows())
                    {
                        var registro = gv_Cargo.GetRow(indiceSelecionado) as E_CARGO;

                        if (registro != null)
                        {
                            registro.OPERACAO = Operacao.Deletar;

                            var transacao = 0;

                            C_CARGO.Salvar(registro, ref transacao);
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

                var cargos = from a in Conexao.Banco.TB_DIV_CARGOs
                             where a.ID_CARGO == (cargo.ID_CARGO > 0 ? cargo.ID_CARGO : a.ID_CARGO)
                             select a;

                if (Quantidade > 0)
                    cargos = cargos.Take(Quantidade);

                gc_Cargo.DataSource = cargos.Select(a => new E_CARGO(a)).ToList();
                gv_Cargo.BestFitColumns();

                cargo = new E_CARGO();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Cargo.ToGridList<E_CARGO>());
            RelatorioSalvar();
        }

        #endregion

        #region Eventos

        #endregion
    }
}