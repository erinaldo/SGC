using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Utilidades
{
    public static class Extensoes
    {
        public static T GetSelectedRow<T>(this GridView grid)
        {
            return GetSelectedRows<T>(grid).FirstOrDefault();
        }

        public static List<T> GetSelectedRows<T>(this GridView grid)
        {
            var selecteds = grid.GetSelectedRows();

            var retorno = new List<T>();

            foreach (var selected in selecteds)
                retorno.Add((T)grid.GetRow(selected));

            return retorno;
        }

        public static DateTime GetDate(this BancoDataContext banco)
        {
            return banco.ExecuteQuery<DateTime>("SELECT GETDATE()").First();
        }

        public static string GetValue(this string s)
        {
            return s.Treat().Split('-').FirstOrDefault().Treat().Trim();
        }

        public static void Layout(this Form form, List<Control> controls, bool restore = false)
        {
            if (form != null && controls != null && controls.Count > 0)
                foreach (var control in controls)
                {
                    if (control.HasChildren)
                        Layout(form, control.Controls.Cast<Control>().ToList(), restore);
                    if (control is GridControl)
                    {
                        if (restore)
                            (control as GridControl).MainView.RestoreLayoutFromRegistry(String.Format("SGC\\{0}\\{1}", form.Name, (control as GridControl).Name));
                        else
                            (control as GridControl).MainView.SaveLayoutToRegistry(String.Format("SGC\\{0}\\{1}", form.Name, (control as GridControl).Name));
                    }
                }
        }

        public static void Layout(this Form form, bool restore = false)
        {
            if (form != null && form.Controls.Count > 0)
                Layout(form, form.Controls.Cast<Control>().ToList(), restore);
        }
    }
}