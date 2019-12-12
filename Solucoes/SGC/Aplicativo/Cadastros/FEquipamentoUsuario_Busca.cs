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

            Identificador = "C15";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FEquipamentoUsuario_Cadastro { Operacao = Operacao.Cadastrar })
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
                Mensagens.Alerta(excessao.Tratar());
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

                using (var forma = new FEquipamentoUsuario_Cadastro { Operacao = Operacao.Alterar, equipamentoUsuario = row })
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
                Mensagens.Alerta(excessao.Tratar());
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
                        using (var motivo = new FCancelamento())
                        {
                            if (motivo.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                                return;

                            registro.OPERACAO = Operacao.Deletar;
                            registro.LOGIN_CANCELAMENTO = Parametros.Usuario;
                            registro.DS_CANCELAMENTO = motivo.DS_Motivo;

                            var transacao = 0;

                            C_EQUIPAMENTOUSUARIO.Salvar(registro, ref transacao);
                            Buscar();
                        }
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

                var equipamentosUsuario = from a in Conexao.Banco.TB_DIV_EQUIPAMENTO_X_USUARIOs
                                          where
                                          a.ID_EQUIPAMENTO == (equipamentoUsuario.EQUIPAMENTO.GetValue().HasValue() ? equipamentoUsuario.EQUIPAMENTO.GetValue().ToInt() : a.ID_EQUIPAMENTO) &&
                                          a.LOGIN == (equipamentoUsuario.USUARIO.GetValue().HasValue() ? equipamentoUsuario.USUARIO.GetValue() : a.LOGIN)
                                          select a;

                if (Quantidade > 0)
                    equipamentosUsuario = equipamentosUsuario.Take(Quantidade);

                gc_Equipamento_x_Usuario.DataSource = equipamentosUsuario.Select(a => new E_EQUIPAMENTOUSUARIO(a)).ToList();
                gv_Equipamento_x_Usuario.BestFitColumns();

                equipamentoUsuario = new E_EQUIPAMENTOUSUARIO();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
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


        #endregion
    }
}