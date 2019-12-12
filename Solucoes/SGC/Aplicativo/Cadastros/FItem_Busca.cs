using Consultas;
using Entidades;
using Formas.Padrao;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FItem_Busca : FPadrao_Busca_Menu
    {
        #region Declarações

        public E_ITEM item = new E_ITEM();

        #endregion

        #region Métodos
        public FItem_Busca()
        {
            InitializeComponent();

            Identificador = "C6";
            DefinirPermissoes();
        }

        public override void Adicionar()
        {
            try
            {
                base.Adicionar();

                using (var forma = new FItem_Cadastro { Operacao = Operacao.Cadastrar })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        item = forma.item;
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

                if (gv_Item.GetSelectedRows().Count() == 0)
                    throw Excessoes.AlterandoSemRegistro();

                using (var forma = new FItem_Cadastro { Operacao = Operacao.Alterar, item = gv_Item.GetSelectedRow<E_ITEM>() })
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        item = forma.item;
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

                foreach (var indiceSelecionado in gv_Item.GetSelectedRows())
                {
                    var registro = gv_Item.GetRow(indiceSelecionado) as E_ITEM;

                    if (registro != null)
                    {
                        registro.OPERACAO = Operacao.Deletar;

                        var transacao = 0;

                        C_ITEM.Salvar(registro, ref transacao);

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

                var itens = from a in Conexao.Banco.TB_DIV_ITEMs
                             where a.ID_ITEM == (item.ID_ITEM > 0 ? item.ID_ITEM : a.ID_ITEM)
                               select a;

                if (Quantidade > 0)
                    itens = itens.Take(Quantidade);

                gc_Item.DataSource = itens.Select(a => new E_ITEM(a)).ToList();
                gv_Item.BestFitColumns();

                item = new E_ITEM();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        public override void Relatorio()
        {
            base.Relatorio();

            RelatorioGerar(gv_Item.ToGridList<E_ITEM>());
            RelatorioSalvar();
        }

        #endregion
    }
}
