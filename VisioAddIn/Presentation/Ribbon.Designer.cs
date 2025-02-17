namespace VisioAddIn
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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.tabMyCoolStuff = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.grpDebug = this.Factory.CreateRibbonGroup();
            this.grpDebugWindow = this.Factory.CreateRibbonButton();
            this.grpWatchWindow = this.Factory.CreateRibbonButton();
            this.rcbLogToDebugWindow = this.Factory.CreateRibbonCheckBox();
            this.rcbEnableAppEvents = this.Factory.CreateRibbonCheckBox();
            this.rcnDisplayEvents = this.Factory.CreateRibbonCheckBox();
            this.rcbDisplayChattyEvents = this.Factory.CreateRibbonCheckBox();
            this.grpHelp = this.Factory.CreateRibbonGroup();
            this.grpDisplayAddinInfo = this.Factory.CreateRibbonButton();
            this.btnToggleDeveloperMode = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.tabMyCoolStuff.SuspendLayout();
            this.group2.SuspendLayout();
            this.grpDebug.SuspendLayout();
            this.grpHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // tabMyCoolStuff
            // 
            this.tabMyCoolStuff.Groups.Add(this.group2);
            this.tabMyCoolStuff.Groups.Add(this.grpDebug);
            this.tabMyCoolStuff.Groups.Add(this.grpHelp);
            this.tabMyCoolStuff.Label = "MyCoolStuff";
            this.tabMyCoolStuff.Name = "tabMyCoolStuff";
            // 
            // group2
            // 
            this.group2.Items.Add(this.button1);
            this.group2.Items.Add(this.button2);
            this.group2.Label = "group1";
            this.group2.Name = "group2";
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
            // grpDebug
            // 
            this.grpDebug.Items.Add(this.grpDebugWindow);
            this.grpDebug.Items.Add(this.grpWatchWindow);
            this.grpDebug.Items.Add(this.rcbLogToDebugWindow);
            this.grpDebug.Items.Add(this.rcbEnableAppEvents);
            this.grpDebug.Items.Add(this.rcnDisplayEvents);
            this.grpDebug.Items.Add(this.rcbDisplayChattyEvents);
            this.grpDebug.Label = "Debug";
            this.grpDebug.Name = "grpDebug";
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
            // grpHelp
            // 
            this.grpHelp.Items.Add(this.grpDisplayAddinInfo);
            this.grpHelp.Items.Add(this.btnToggleDeveloperMode);
            this.grpHelp.Label = "Help";
            this.grpHelp.Name = "grpHelp";
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
            this.RibbonType = "Microsoft.Visio.Drawing";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tabMyCoolStuff);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabMyCoolStuff.ResumeLayout(false);
            this.tabMyCoolStuff.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.grpDebug.ResumeLayout(false);
            this.grpDebug.PerformLayout();
            this.grpHelp.ResumeLayout(false);
            this.grpHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabMyCoolStuff;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpDebug;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton grpDebugWindow;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton grpWatchWindow;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox rcbLogToDebugWindow;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox rcbEnableAppEvents;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox rcnDisplayEvents;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox rcbDisplayChattyEvents;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpHelp;
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
