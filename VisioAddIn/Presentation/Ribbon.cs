using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace VisioAddIn
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click_1(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show("Button1_Click");
        }

        private void button2_Click_1(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show("Button2_Click");
        }

        private void btnDebugWindow_Click(object sender, RibbonControlEventArgs e)
        {
            //MessageBox.Show("btnDebugWindow_Click");
            DisplayDebugWindow();
        }

        private void DisplayDebugWindow()
        {
            VNC.VSTOAddIn.Common.DebugWindow.Visible = !VNC.VSTOAddIn.Common.DebugWindow.Visible;
        }

        private void btnWatchWindow_Click(object sender, RibbonControlEventArgs e)
        {
            //MessageBox.Show("btnWatchWindow_Click");
            DisplayWatchWindow();
        }

        private void DisplayWatchWindow()
        {
            VNC.VSTOAddIn.Common.WatchWindow.Visible = !VNC.VSTOAddIn.Common.WatchWindow.Visible;
        }

        private void rcbEnableAppEvents_Click_1(object sender, RibbonControlEventArgs e)
        {
            //MessageBox.Show("rcbEnableAppEvents_Click");
            Common.EnableAppEvents = rcbEnableAppEvents.Checked;
        }

        private void rcbDisplayEvents_Click(object sender, RibbonControlEventArgs e)
        {
            //MessageBox.Show("rcbDisplayEvents_Click");
            Common.DisplayEvents = rcbDisplayEvents.Checked;
        }

        private void rcbDisplayChattyEvents_Click_1(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show("rcbDisplayChattyEvents_Click");
        }

        private void btnDisplayAddinInfo_Click(object sender, RibbonControlEventArgs e)
        {
            DisplayAddinInfo();
        }
        private void DisplayAddinInfo()
        {
            VNC.VSTOAddIn.AddInInfo.DisplayInfo();
        }

        private void btnToggleDeveloperMode_Click_1(object sender, RibbonControlEventArgs e)
        {
            VNC.VSTOAddIn.Common.DeveloperMode = !VNC.VSTOAddIn.Common.DeveloperMode;
            Globals.Ribbons.Ribbon.rgDebug.Visible = VNC.VSTOAddIn.Common.DeveloperMode;

        }
    }
}
