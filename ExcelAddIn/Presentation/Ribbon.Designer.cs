namespace ExcelAddIn
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon));
            this.tabAddins = this.Factory.CreateRibbonTab();
            this.tabMyCoolStuff = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.rgDebug = this.Factory.CreateRibbonGroup();
            this.grpDebugWindow = this.Factory.CreateRibbonButton();
            this.grpWatchWindow = this.Factory.CreateRibbonButton();
            this.rcbLogToDebugWindow = this.Factory.CreateRibbonCheckBox();
            this.rcbEnableAppEvents = this.Factory.CreateRibbonCheckBox();
            this.rcnDisplayEvents = this.Factory.CreateRibbonCheckBox();
            this.rcbDisplayChattyEvents = this.Factory.CreateRibbonCheckBox();
            this.rgHelp = this.Factory.CreateRibbonGroup();
            this.grpDisplayAddinInfo = this.Factory.CreateRibbonButton();
            this.btnToggleDeveloperMode = this.Factory.CreateRibbonButton();
            this.tabAddins.SuspendLayout();
            this.tabMyCoolStuff.SuspendLayout();
            this.group1.SuspendLayout();
            this.rgDebug.SuspendLayout();
            this.rgHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAddins
            // 
            this.tabAddins.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabAddins.Label = "TabAddins";
            this.tabAddins.Name = "tabAddins";
            // 
            // tabMyCoolStuff
            // 
            this.tabMyCoolStuff.Groups.Add(this.group1);
            this.tabMyCoolStuff.Groups.Add(this.rgDebug);
            this.tabMyCoolStuff.Groups.Add(this.rgHelp);
            this.tabMyCoolStuff.Label = "MyCoolStuff";
            this.tabMyCoolStuff.Name = "tabMyCoolStuff";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.button2);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.Label = "button1";
            this.button1.Name = "button1";
            // 
            // button2
            // 
            this.button2.Label = "button2";
            this.button2.Name = "button2";
            // 
            // rgDebug
            // 
            this.rgDebug.Items.Add(this.grpDebugWindow);
            this.rgDebug.Items.Add(this.grpWatchWindow);
            this.rgDebug.Items.Add(this.rcbLogToDebugWindow);
            this.rgDebug.Items.Add(this.rcbEnableAppEvents);
            this.rgDebug.Items.Add(this.rcnDisplayEvents);
            this.rgDebug.Items.Add(this.rcbDisplayChattyEvents);
            this.rgDebug.Label = "Debug";
            this.rgDebug.Name = "rgDebug";
            // 
            // grpDebugWindow
            // 
            this.grpDebugWindow.Image = ((System.Drawing.Image)(resources.GetObject("grpDebugWindow.Image")));
            this.grpDebugWindow.Label = "Debug Window";
            this.grpDebugWindow.Name = "grpDebugWindow";
            this.grpDebugWindow.ShowImage = true;
            // 
            // grpWatchWindow
            // 
            this.grpWatchWindow.Image = ((System.Drawing.Image)(resources.GetObject("grpWatchWindow.Image")));
            this.grpWatchWindow.Label = "Watch Window";
            this.grpWatchWindow.Name = "grpWatchWindow";
            this.grpWatchWindow.ShowImage = true;
            // 
            // rcbLogToDebugWindow
            // 
            this.rcbLogToDebugWindow.Label = "Log to Debug Window";
            this.rcbLogToDebugWindow.Name = "rcbLogToDebugWindow";
            // 
            // rcbEnableAppEvents
            // 
            this.rcbEnableAppEvents.Label = "Enable App Events";
            this.rcbEnableAppEvents.Name = "rcbEnableAppEvents";
            // 
            // rcnDisplayEvents
            // 
            this.rcnDisplayEvents.Label = "Display Events";
            this.rcnDisplayEvents.Name = "rcnDisplayEvents";
            // 
            // rcbDisplayChattyEvents
            // 
            this.rcbDisplayChattyEvents.Label = "Display Chatty Events";
            this.rcbDisplayChattyEvents.Name = "rcbDisplayChattyEvents";
            // 
            // rgHelp
            // 
            this.rgHelp.Items.Add(this.grpDisplayAddinInfo);
            this.rgHelp.Items.Add(this.btnToggleDeveloperMode);
            this.rgHelp.Label = "Help";
            this.rgHelp.Name = "rgHelp";
            // 
            // grpDisplayAddinInfo
            // 
            this.grpDisplayAddinInfo.Label = "Display AddinInfo";
            this.grpDisplayAddinInfo.Name = "grpDisplayAddinInfo";
            // 
            // btnToggleDeveloperMode
            // 
            this.btnToggleDeveloperMode.Label = "Toggle Developer Mode";
            this.btnToggleDeveloperMode.Name = "btnToggleDeveloperMode";
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabAddins);
            this.Tabs.Add(this.tabMyCoolStuff);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tabAddins.ResumeLayout(false);
            this.tabAddins.PerformLayout();
            this.tabMyCoolStuff.ResumeLayout(false);
            this.tabMyCoolStuff.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.rgDebug.ResumeLayout(false);
            this.rgDebug.PerformLayout();
            this.rgHelp.ResumeLayout(false);
            this.rgHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabAddins;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabMyCoolStuff;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup rgDebug;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton grpDebugWindow;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton grpWatchWindow;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox rcbLogToDebugWindow;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox rcbEnableAppEvents;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox rcnDisplayEvents;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox rcbDisplayChattyEvents;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup rgHelp;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton grpDisplayAddinInfo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnToggleDeveloperMode;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
