﻿using System;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ALMIS.Viewer.App_Code
{
    public class GridColumnTranslator
    {
        public static void TranslateColumns(DataGridView grid, Form form)
        {
            Type type1 = form.GetType();
            var culture = Thread.CurrentThread.CurrentCulture;
            var resman = new ResourceManager(type1.FullName, Assembly.GetExecutingAssembly());
            try
            {
                foreach (var item in grid.Columns)
                {
                    var col = (item as DataGridViewColumn);
                    if (col != null)
                    {
                        string p = resman.GetString(col.Name + ".HeaderText", culture);
                        col.HeaderText = p;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void TranslateColumns(RadGridView grid, Form form)
        {
            Type type1 = form.GetType();
            var culture = Thread.CurrentThread.CurrentCulture;
            var resman = new ResourceManager(type1.FullName, Assembly.GetExecutingAssembly());
            try
            {
                foreach (var item in grid.Columns)
                {
                    var col = (item as GridViewColumn);
                    if (col != null)
                    {
                        string p = resman.GetString(col.Name + ".HeaderText", culture);
                        col.HeaderText = p;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
