using Consultas;
using Entidades;
using Formas.Padrao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Lancamentos
{
    public partial class FEquipamentoUsuario_Busca : FPadrao_Busca_Menu
    {
        #region Declarações

        public E_EQUIPAMENTOUSUARIO equipamentoUsuario = new E_EQUIPAMENTOUSUARIO();

        #endregion

        #region Métodos

        public FEquipamentoUsuario_Busca()
        {
            InitializeComponent();

            Identificador = "L5";

            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FEquipamentoUsuario_Lancamento { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        equipamentoUsuario = forma.equipamentoUsuario;
                        Buscar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }

        public override void Alterar()
        {
            try
            {
                base.Alterar();

                if (gv_Equipamento_x_Usuario.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                var row = gv_Equipamento_x_Usuario.GetSelectedRow<E_EQUIPAMENTOUSUARIO>();

                using (var forma = new FEquipamentoUsuario_Lancamento { Operacao = Operacao.Alterar, equipamentoUsuario = row })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        equipamentoUsuario = forma.equipamentoUsuario;
                        Buscar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }

        public override void Deletar()
        {
            try
            {
                base.Deletar();

                foreach (var indiceSelecionado in gv_Equipamento_x_Usuario.GetSelectedRows())
                {
                    var registro = gv_Equipamento_x_Usuario.GetRow(indiceSelecionado) as E_EQUIPAMENTOUSUARIO;

                    if (registro != null)
                    {
                        registro.OPERACAO = Operacao.Deletar;

                        var transacao = 0;

                        C_EQUIPAMENTOUSUARIO.Salvar(registro, ref transacao);
                        Buscar();
                    }
                }
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }

        public override void Buscar()
        {
            try
            {
                base.Buscar();

                var deptos = from a in Conexao.Banco.TB_DIV_EQUIPAMENTO_X_USUARIOs
                             where
                             a.ID_EQUIPAMENTO == (equipamentoUsuario.EQUIPAMENTO.GetValue().HasValue() ? equipamentoUsuario.EQUIPAMENTO.GetValue().ToInt() : a.ID_EQUIPAMENTO) &&
                             a.LOGIN == (equipamentoUsuario.USUARIO.GetValue().HasValue() ? equipamentoUsuario.USUARIO.GetValue() : a.LOGIN)
                             select new E_EQUIPAMENTOUSUARIO(a);

                if (Quantidade > 0)
                    deptos = deptos.Take(Quantidade);

                gc_Equipamento_x_Usuario.DataSource = deptos;
                gv_Equipamento_x_Usuario.BestFitColumns();

                equipamentoUsuario = new E_EQUIPAMENTOUSUARIO();
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Equipamento_x_Usuario.ToGridList<E_EQUIPAMENTOUSUARIO>());
            RelatorioSalvar();
        }

        #endregion

        #region Eventos

        private void gv_Equipamento_x_Usuario_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == colST_USOCOMPARTILHADO.Name && e.CellValue != null)
                e.DisplayText = e.CellValue.ToString() == "S" ? "SIM" : (e.CellValue.ToString() == "N" ? "NÃO" : "");
        }

        #endregion
    }
}