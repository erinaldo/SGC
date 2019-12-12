﻿namespace Componentes
{
    partial class CDateEdit
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
            this.fProperties = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // fProperties
            // 
            this.fProperties.Appearance.Options.UseTextOptions = true;
            this.fProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.AppearanceDisabled.Options.UseTextOptions = true;
            this.fProperties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.AppearanceDropDown.Options.UseTextOptions = true;
            this.fProperties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.fProperties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.AppearanceDropDownHeaderHighlight.Options.UseTextOptions = true;
            this.fProperties.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.AppearanceDropDownHighlight.Options.UseTextOptions = true;
            this.fProperties.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.AppearanceFocused.Options.UseTextOptions = true;
            this.fProperties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.fProperties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.AppearanceWeekNumber.Options.UseTextOptions = true;
            this.fProperties.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fProperties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fProperties.Name = "fProperties";
            ((System.ComponentModel.ISupportInitialize)(this.fProperties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit fProperties;

    }
}
