using Consultas;
using Entidades;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FModelo_Busca : Formas.Padrao.FPadrao_Busca_Menu
    {
        #region Declarações

        public E_MODELO modelo = new E_MODELO();

        #endregion

        #region Métodos

        public FModelo_Busca()
        {
            InitializeComponent();

            Identificador = "C10";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FModelo_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        modelo = forma.modelo;
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

                if (gv_Modelo.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FModelo_Cadastro { Operacao = Operacao.Alterar, modelo = gv_Modelo.GetSelectedRow<E_MODELO>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        modelo = forma.modelo;
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

                foreach (var indiceSelecionado in gv_Modelo.GetSelectedRows())
                {
                    var registro = gv_Modelo.GetRow(indiceSelecionado) as E_MODELO;

                    if (registro != null)
                    {
                        registro.OPERACAO = Operacao.Deletar;

                        var transacao = 0;

                        C_MODELO.Salvar(registro, ref transacao);
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

                var modelos = from a in Conexao.Banco.TB_DIV_MODELOs
                               where a.ID_MODELO == (modelo.ID_MODELO > 0 ? modelo.ID_MODELO : a.ID_MODELO)
                               select a;

                if (Quantidade > 0)
                    modelos = modelos.Take(Quantidade);

                gc_Modelo.DataSource = modelos.Select(a => new E_MODELO(a)).ToList();
                gv_Modelo.BestFitColumns();

                modelo = new E_MODELO();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Modelo.ToGridList<E_MODELO>());
            RelatorioSalvar();
        }
        
        #endregion

        #region Eventos

        #endregion
    }
}
