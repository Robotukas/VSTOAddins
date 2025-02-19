using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using Microsoft.Office.Interop.Visio;


namespace VisioAddIn
{
    public class Common : VNC.VSTOAddIn.Common
    {
        new public const string LOG_CATEGORY = "VisioAddin";
        public static VNC.Visio.Addin.Events.VisioAppEvents AppEvents;
    }
}
