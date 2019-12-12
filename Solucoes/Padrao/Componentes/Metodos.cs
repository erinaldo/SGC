using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Componentes
{
    public static class Metodos
    {
        public static string Prefixo = "É necessário informar ";

        public static void Validate(this Control.ControlCollection controls, Control.ControlCollection controlsToIgnore)
        {
            if (controls == null || controls.Count == 0)
                return;

            var controlsConverted = controls.Cast<Control>().Where(a => controlsToIgnore != null ? !controlsToIgnore.Contains(a) : true).OrderBy(a => a.TabIndex).ToList<Control>();

            foreach (var control in controlsConverted)
            {
                if (control.Controls.Count > 0)
                    control.Controls.Validate();

                if (control is CButtonEdit)
                    (control as CButtonEdit).Validate();
                else if (control is CComboBoxEdit)
                    (control as CComboBoxEdit).Validate();
                else if (control is CTextEdit)
                    (control as CTextEdit).Validate();
                else if (control is CMemoEdit)
                    (control as CMemoEdit).Validate();
                else if (control is CSpinEdit)
                    (control as CSpinEdit).Validate();
            }
        }

        public static void Validate(this Control.ControlCollection controls)
        {
            Validate(controls, null);
        }

        public static IQueryable<string> GetCheckedValues(this CCheckedComboBoxEdit cCheckedComboBoxEdit)
        {
            return cCheckedComboBoxEdit.Properties.GetCheckedItems().ToString().Split(',').Select(a=> a.Trim()).Where(a => a.HasValue()).AsQueryable();
        }

        public static void SetValue(this CComboBoxEdit cComboBoxEdit, CComboBoxEditValue value)
        {
            if (value == null)
                return;

            var rows = cComboBoxEdit.Properties.Items;
            rows.BeginUpdate();

            try
            {
                rows.Add(value);
            }
            finally
            {
                rows.EndUpdate();
            }

            cComboBoxEdit.SelectedIndex = -1;
        }

        public static void SetValues(this CComboBoxEdit cComboBoxEdit, List<CComboBoxEditValue> values)
        {
            if (values != null && values.Count == 0)
                return;

            values.ForEach(a => cComboBoxEdit.SetValue(a));
        }

        public static string GetSelectedValue(this CComboBoxEdit cComboBoxEdit)
        {
            try
            {
                return (cComboBoxEdit.SelectedItem as CComboBoxEditValue).ID;
            }
            catch
            {
                return null;
            }
        }

        public static string GetSelectedValue(this CListBoxControl cListBoxControl)
        {
            try
            {
                return (cListBoxControl.SelectedItem as CComboBoxEditValue).ID;
            }
            catch
            {
                return null;
            }
        }

        public static void SetFirst(this CComboBoxEdit cComboBoxEdit)
        {
            SetSelected(cComboBoxEdit, "", true);
        }

        public static void SetSelected(this CComboBoxEdit cComboBoxEdit, string id, bool first = false)
        {
            if (cComboBoxEdit.Properties.Items.Count == 0)
                cComboBoxEdit.SelectedIndex = -1;
            else if (first)
                cComboBoxEdit.SelectedIndex = cComboBoxEdit.Properties.Items.Count > 0 ? 0 : -1;
            else
                for (int i = 0; i < cComboBoxEdit.Properties.Items.Count; i++)
                    if ((cComboBoxEdit.Properties.Items[i] as CComboBoxEditValue).ID == id)
                        cComboBoxEdit.SelectedIndex = i;
        }

        public static void RemoveSelected(this BindingSource bindingSource)
        {
            if (bindingSource.HasValue())
                bindingSource.RemoveCurrent();
        }

        public static bool HasValue(this BindingSource bindingSource)
        {
            return bindingSource != null && bindingSource.List.Count > 0 && bindingSource.Current != null;
        }
    }
}