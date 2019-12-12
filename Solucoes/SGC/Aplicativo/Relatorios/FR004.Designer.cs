namespace Aplicativo.Relatorios
{
    partial class FR004
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cpc_Dados = new Componentes.CPanelControl(this.components);
            this.cde_DataInicial = new Componentes.CDateEdit(this.components);
            this.cde_DataFinal = new Componentes.CDateEdit(this.components);
            this.clc_DataInicial = new Componentes.CLabelControl(this.components);
            this.clc_DataFinal = new Componentes.CLabelControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Dados)).BeginInit();
            this.cpc_Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataFinal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_Dados
            // 
            this.cpc_Dados.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_Dados.Appearance.Options.UseBackColor = true;
            this.cpc_Dados.Appearance.Options.UseTextOptions = true;
            this.cpc_Dados.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cpc_Dados.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_Dados.Controls.Add(this.cde_DataInicial);
            this.cpc_Dados.Controls.Add(this.cde_DataFinal);
            this.cpc_Dados.Controls.Add(this.clc_DataInicial);
            this.cpc_Dados.Controls.Add(this.clc_DataFinal);
            this.cpc_Dados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_Dados.Location = new System.Drawing.Point(0, 0);
            this.cpc_Dados.Name = "cpc_Dados";
            this.cpc_Dados.Size = new System.Drawing.Size(734, 377);
            this.cpc_Dados.TabIndex = 11;
            // 
            // cde_DataInicial
            // 
            this.cde_DataInicial.DataMaxima = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.cde_DataInicial.DataMinima = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.cde_DataInicial.Descricao = "a data inicial";
            this.cde_DataInicial.EditValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.cde_DataInicial.Location = new System.Drawing.Point(12, 22);
            this.cde_DataInicial.Name = "cde_DataInicial";
            this.cde_DataInicial.NaoVazio = true;
            this.cde_DataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DataInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DataInicial.Size = new System.Drawing.Size(80, 20);
            this.cde_DataInicial.TabIndex = 6;
            // 
            // cde_DataFinal
            // 
            this.cde_DataFinal.DataMaxima = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.cde_DataFinal.DataMinima = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.cde_DataFinal.Descricao = "a data final";
            this.cde_DataFinal.EditValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.cde_DataFinal.Location = new System.Drawing.Point(95, 22);
            this.cde_DataFinal.Name = "cde_DataFinal";
            this.cde_DataFinal.NaoVazio = true;
            this.cde_DataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DataFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DataFinal.Size = new System.Drawing.Size(80, 20);
            this.cde_DataFinal.TabIndex = 8;
            // 
            // clc_DataInicial
            // 
            this.clc_DataInicial.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_DataInicial.Location = new System.Drawing.Point(12, 8);
            this.clc_DataInicial.Name = "clc_DataInicial";
            this.clc_DataInicial.Size = new System.Drawing.Size(51, 13);
            this.clc_DataInicial.TabIndex = 5;
            this.clc_DataInicial.Text = "Data inicial";
            // 
            // clc_DataFinal
            // 
            this.clc_DataFinal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_DataFinal.Location = new System.Drawing.Point(95, 8);
            this.clc_DataFinal.Name = "clc_DataFinal";
            this.clc_DataFinal.Size = new System.Drawing.Size(46, 13);
            this.clc_DataFinal.TabIndex = 7;
            this.clc_DataFinal.Text = "Data final";
            // 
            // FR004
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.cpc_Dados);
            this.Name = "FR004";
            this.Text = "Relatório - (REL004) Chamados por Categoria";
            this.Controls.SetChildIndex(this.cpc_Dados, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Dados)).EndInit();
            this.cpc_Dados.ResumeLayout(false);
            this.cpc_Dados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataFinal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_Dados;
        private Componentes.CDateEdit cde_DataInicial;
        private Componentes.CDateEdit cde_DataFinal;
        private Componentes.CLabelControl clc_DataInicial;
        private Componentes.CLabelControl clc_DataFinal;
    }
}