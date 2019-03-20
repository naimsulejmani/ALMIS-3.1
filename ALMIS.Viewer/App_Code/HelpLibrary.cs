using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ALMIS.Viewer.App_Code
{
    public class HelpLibrary : RadForm
    {
        public static Cursor ControllHelp(Form frm, Control control)
        {
            if (control is ComboBox)
            {
                GetHelpProvider(frm, control.Name == "cbRowKey" ? "filtratcelesi.htm" : "filtrat.htm");
            }
            else if (control is CheckBox)
            {
                if (control.Name == "chbOccuredAfter" || control.Name == "chbOccuredBefore")
                {
                    GetHelpProvider(frm, "datetimefilters.htm");
                }
                else
                    GetHelpProvider(frm, "iudfilters.htm");
            }
            else if (control is Button)
            {
                GetHelpProvider(frm, "filtratcelesi.htm");
            }
            else if (control is RadButton)
            {
                if (control.Name == "btnFind")
                {
                    GetHelpProvider(frm, "kerko.htm");
                }
                else if (control.Name == "btnExcel" || control.Name == "rbtnExportToCsv")
                {
                    GetHelpProvider(frm, "excelexcport.htm");
                }
                else if (control.Name == "btnPrintPriview")
                {
                    GetHelpProvider(frm, "printpriview.htm");
                }
            }
            else if (control is RadGridView)
            {
                GetHelpProvider(frm, "kerko.htm");
            }
            else if (control is RadDateTimePicker)
            {
                GetHelpProvider(frm, "datetimefilters.htm");
            }
            else if (control is RadTimePicker)
            {
                GetHelpProvider(frm, "datetimefilters.htm");
            }
            else if (control is NumericUpDown)
            {
                GetHelpProvider(frm, "iudfilters.htm");
            }
            else if (control is RadMenu)
            {
                GetHelpProvider(frm, "iudfilters.htm");
            }
            return Cursors.Default;
        }
        public static void GetHelpProvider(Form frm, string topic)
        {
            //HelpProvider hp = new HelpProvider();
            //hp.SetHelpNavigator(frm, HelpNavigator.Topic);
            //hp.SetHelpKeyword(frm, topic);
            //hp.HelpNamespace = Application.StartupPath + @"\NewProject.chm";
            ////hp.SetShowHelp(frm, true);



            //Help.ShowHelp(frm, Application.StartupPath + @"\Fixed Assets.chm", HelpNavigator.TopicId, "rev_journal.htm");

            Help.ShowHelp(frm, Application.StartupPath + "\\Help\\Almis.Viewer.chm", HelpNavigator.Topic, topic);
            // "Second_topic.htm");

        }

        public static bool IsClicked = false;
    }

}
