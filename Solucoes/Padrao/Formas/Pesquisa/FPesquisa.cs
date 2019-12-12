using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Formas.Pesquisa
{
    public partial class FPesquisa : Formas.Padrao.FPadrao
    {
        public class Filtro
        {
            public String Nome { get; set; }
            public String Descricao { get; set; }
            public Int32 Tamanho { get; set; }
        }

        public List<Filtro> Filtros = new List<Filtro>();
        public DataTable SelecionadosDataTable;
        public List<Object> Selecionados = new List<Object>();
        public IQueryable Consulta = null;
        public Boolean Multiplos = false;

        public FPesquisa()
        {
            InitializeComponent();
        }

        private void FPesquisa_Load(object sender = null, EventArgs e = null)
        {
            var posicao = 0;
            gv_Pesquisa.OptionsSelection.MultiSelect = Multiplos;

            Filtros.ForEach(a =>
            {
                var coluna = new GridColumn
                {
                    Name = string.Format(@"col{0}_{1}", posicao, a.Nome.Treat()),
                    FieldName = a.Nome.Treat(),
                    Caption = a.Descricao.Treat(),
                    Width = a.Tamanho,
                    Visible = true
                };

                coluna.OptionsColumn.AllowEdit = false;
                coluna.OptionsColumn.AllowFocus = false;

                gv_Pesquisa.Columns.Add(coluna);

                posicao++;
            });

            gc_Pesquisa.DataSource = Consulta;
            gv_Pesquisa.BestFitColumns();
        }

        private void gv_Pesquisa_DoubleClick(object sender = null, EventArgs e = null)
        {
            var selecteds = gv_Pesquisa.GetSelectedRows();

            if (selecteds.Count() > 0)
                foreach (var selected in selecteds)
                    Selecionados.Add(gv_Pesquisa.GetRow(selected));

            SelecionadosDataTable = Selecionados.AsQueryable().ToDataTable();
            
            this.DialogResult = Selecionados.Count > 0 ? DialogResult.OK : DialogResult.Cancel;
            this.Dispose();
        }

        private void FPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gv_Pesquisa_DoubleClick(null, null);
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Dispose();
            }
        }

        private void gv_Pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            FPesquisa_KeyDown(null, e);
        }
    }
}