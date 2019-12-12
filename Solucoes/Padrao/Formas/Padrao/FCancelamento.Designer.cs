namespace Formas.Padrao
{
    partial class FCancelamento
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
            this.cte_Motivo = new Componentes.CTextEdit();
            this.clc_Motivo = new Componentes.CLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Motivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cte_Motivo
            // 
            this.cte_Motivo.Descricao = "o motivo do cancelamento";
            this.cte_Motivo.Location = new System.Drawing.Point(12, 26);
            this.cte_Motivo.Mascara_IPv4 = false;
            this.cte_Motivo.Mascara_PortaIPv4 = false;
            this.cte_Motivo.Name = "cte_Motivo";
            this.cte_Motivo.NaoVazio = true;
            this.cte_Motivo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Motivo.Properties.MaxLength = 256;
            this.cte_Motivo.SemAcentuacao = false;
            this.cte_Motivo.SemPontuacao = false;
            this.cte_Motivo.Size = new System.Drawing.Size(412, 20);
            this.cte_Motivo.SomenteNumeros = false;
            this.cte_Motivo.TabIndex = 1;
            // 
            // clc_Motivo
            // 
            this.clc_Motivo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_Motivo.Location = new System.Drawing.Point(12, 12);
            this.clc_Motivo.Name = "clc_Motivo";
            this.clc_Motivo.Size = new System.Drawing.Size(32, 13);
            this.clc_Motivo.TabIndex = 0;
            this.clc_Motivo.Text = "Motivo";
            // 
            // FCancelamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(436, 91);
            this.Controls.Add(this.clc_Motivo);
            this.Controls.Add(this.cte_Motivo);
            this.Name = "FCancelamento";
            this.Text = "Por favor, informe o motivo do cancelamento!";
            this.Controls.SetChildIndex(this.cte_Motivo, 0);
            this.Controls.SetChildIndex(this.clc_Motivo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cte_Motivo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.CTextEdit cte_Motivo;
        private Componentes.CLabelControl clc_Motivo;
    }
}
