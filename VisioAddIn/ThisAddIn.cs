using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Visio = Microsoft.Office.Interop.Visio;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using VNC.VSTOAddIn;

namespace VisioAddIn
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //MessageBox.Show("Visio - ThisAddin_Startup");
            InitializeRibbonUI();
            
            if (Common.HasAppEvents)
            {
                if (Common.AppEvents == null)
                {
                    Common.AppEvents = new VNC.Visio.Addin.Events.VisioAppEvents();
                    Common.AppEvents.VisioApplication = Globals.ThisAddIn.Application;
                }
            }
            else
            {
                Common.AppEvents = null;                     
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            //MessageBox.Show("Visio - ThisAddin_Shutdown");
        }

        void InitializeRibbonUI()
        {
            Globals.Ribbons.Ribbon.rgDebug.Visible = Common.DeveloperMode = false;

            // Note(Robertas Suminskas)
            // This is a workaround to get the ribbon to show up in Visio.
            // Needed for several events handled by this Addin
            Globals.Ribbons.Ribbon.rcbEnableAppEvents.Checked = Common.HasAppEvents = true;

            // Note(Robertas Suminskas)
            // No need to display during normal operation.
            // More for understanding what Visio is doing durig development.
            Globals.Ribbons.Ribbon.rcbDisplayEvents.Checked = Common.DisplayEvents = false;
            Globals.Ribbons.Ribbon.rcbDisplayChattyEvents.Checked = Common.DisplayChattyEvents = false;

        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
