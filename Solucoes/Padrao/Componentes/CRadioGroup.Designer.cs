﻿namespace Componentes
{
    partial class CRadioGroup
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fProperties = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // fProperties
            // 
            this.fProperties.Appearance.Options.UseTextOptions = true;
            this.fProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.AppearanceDisabled.Options.UseTextOptions = true;
            this.fProperties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.AppearanceFocused.Options.UseTextOptions = true;
            this.fProperties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.fProperties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.Name = "fProperties";
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup fProperties;

    }
}
