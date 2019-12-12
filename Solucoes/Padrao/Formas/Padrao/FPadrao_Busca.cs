using DevExpress.XtraReports.UI;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Formas.Padrao
{
    public partial class FPadrao_Busca : FPadrao
    {
        public FPadrao_Busca()
        {
            InitializeComponent();
        }

        public string Identificador = "";
        public int Quantidade = 0;
        public bool RelatorioAlterar;
        public XtraReport RelatorioArquivo = new XtraReport();

        public virtual void Adicionar()
        {
        }

        public virtual void Alterar()
        {
        }

        public virtual void Deletar()
        {
        }

        public virtual void Buscar()
        {
            Conexao.Reiniciar();
        }

        public virtual void Relatorio()
        {
            var consulta = Conexao.Banco.TB_DIV_RELATORIOs.Where(a => a.ID_MENU == Identificador.Treat()).OrderByDescending(a => a.ID_RELATORIO);
            RelatorioArquivo = consulta.Count() > 0 ? consulta.First().ARQUIVO.ToXtraReport() : new XtraReport();
        }

        public virtual void Sair()
        {
            Close();
            Dispose();
        }

        public virtual void RelatorioGerar(object data)
        {
            Relatorios.Gerar(RelatorioArquivo, data, RelatorioAlterar);
        }

        public virtual void RelatorioSalvar()
        {
            if (RelatorioAlterar)
                if (!Parametros.IsAdministrator())
                    throw new Exception("É necessário ser administrador para salvar a alteração do relatório!");
                else
                    Relatorios.Salvar(RelatorioArquivo, Identificador.Treat());

            RelatorioAlterar = false;
        }

        private void FPadrao_Busca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.R && Parametros.IsAdministrator())
            {
                RelatorioAlterar = true;
                Mensagens.Sucesso("Clique em relatório para editar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}