using Extras.Extras;
using Extras.Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo
{
    public partial class FTabelas : Formas.Padrao.FPadrao
    {
        public FTabelas()
        {
            InitializeComponent();
        }

        private void csb_ConectarBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Reiniciar();
                Conexao.Parametros.Servidor = cte_Servidor.Text.Trim();
                Conexao.Parametros.Banco = cte_BancoDados.Text.Trim();
                Conexao.Parametros.Usuario = cte_Usuario.Text.Trim();
                Conexao.Parametros.Senha = cte_Senha.Text.Trim();

                gc_Tabela.DataSource = N_Tabela.Buscar(false, "");
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }

        private void csb_Gerar_Click(object sender, EventArgs e)
        {
            try
            {
                var selecionados = gv_Tabela.GetSelectedRows();
                var linhas = new List<string>();
                foreach (var selecionado in selecionados)
                    linhas.Add(gv_Tabela.GetRowCellValue(selecionado, colName).ToString());

                if (linhas.Count == 0)
                    throw new Exception("É necessário selecionar ao menos uma tabela!");

                if (fbd_Arquivos.ShowDialog() == DialogResult.OK)
                {
                    foreach (var linha in linhas)
                        System.IO.File.WriteAllText(String.Format("{0}\\CAD_{1}.SQL", fbd_Arquivos.SelectedPath, linha.Substring(3)), Fontes.Procedure(linha));
                }
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }
    }
}