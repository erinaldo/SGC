using Consultas;
using Entidades;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FDepartamento_Busca : Formas.Padrao.FPadrao_Busca_Menu
    {
        #region Declarações

        public E_DEPARTAMENTO departamento = new E_DEPARTAMENTO();

        #endregion

        #region Métodos

        public FDepartamento_Busca()
        {
            InitializeComponent();

            Identificador = "C4";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FDepartamento_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        departamento = forma.departamento;
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

                if (gv_Departamento.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FDepartamento_Cadastro { Operacao = Operacao.Alterar, departamento = gv_Departamento.GetSelectedRow<E_DEPARTAMENTO>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        departamento = forma.departamento;
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

                foreach (var indiceSelecionado in gv_Departamento.GetSelectedRows())
                {
                    var registro = gv_Departamento.GetRow(indiceSelecionado) as E_DEPARTAMENTO;

                    if (registro != null)
                    {
                        registro.OPERACAO = Operacao.Deletar;

                        var transacao = 0;

                        C_DEPARTAMENTO.Salvar(registro, ref transacao);
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

                var departamentos = from a in Conexao.Banco.TB_DIV_DEPARTAMENTOs
                             where a.ID_DEPARTAMENTO == (departamento.ID_DEPARTAMENTO > 0 ? departamento.ID_DEPARTAMENTO : a.ID_DEPARTAMENTO)
                               select a;

                if (Quantidade > 0)
                    departamentos = departamentos.Take(Quantidade);

                gc_Departamento.DataSource = departamentos.Select(a => new E_DEPARTAMENTO(a)).ToList();
                gv_Departamento.BestFitColumns();

                departamento = new E_DEPARTAMENTO();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Departamento.ToGridList<E_DEPARTAMENTO>());
            RelatorioSalvar();
        }

        #endregion

        #region Eventos

        #endregion
    }
}
