﻿namespace rcloneExplorer
{
  partial class rcloneExplorer
  {
    /// <summary>
    /// Required designer variable.
    /// syncingHandler = rcloneExplorer.syncingHandler;
    /// uploadsHandler = rcloneExplorer.uploadsHandler;
    /// downloadsHandler = rcloneExplorer.downloadsHandler;
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    ///
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rcloneExplorer));
            this.txtRawOut = new System.Windows.Forms.TextBox();
            this.lblFooter = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFile_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripQuitKill = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripView_ToggleConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripView_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripView_RcloneConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMainUI = new System.Windows.Forms.TabControl();
            this.tabRemote = new System.Windows.Forms.TabPage();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lstExplorer = new System.Windows.Forms.ListView();
            this.colfileBytes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colfileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colfilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabDownloads = new System.Windows.Forms.TabPage();
            this.lstDownloads = new System.Windows.Forms.ListView();
            this.colDPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabUploads = new System.Windows.Forms.TabPage();
            this.lstUploads = new System.Windows.Forms.ListView();
            this.colPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSyncing = new System.Windows.Forms.TabPage();
            this.btnSyncStart = new System.Windows.Forms.Button();
            this.txtSyncLog = new System.Windows.Forms.TextBox();
            this.btnSyncSave = new System.Windows.Forms.Button();
            this.grpSyncOptions = new System.Windows.Forms.GroupBox();
            this.btnSyncDestinationSelect = new System.Windows.Forms.Button();
            this.btnSyncSourceSelect = new System.Windows.Forms.Button();
            this.txtSyncDestination = new System.Windows.Forms.TextBox();
            this.lblSyncDestination = new System.Windows.Forms.Label();
            this.lblSyncSource = new System.Windows.Forms.Label();
            this.txtSyncSource = new System.Windows.Forms.TextBox();
            this.numSyncOptionsBandwidthLimit = new System.Windows.Forms.NumericUpDown();
            this.lblSyncOptionsMaxSize = new System.Windows.Forms.Label();
            this.numSyncOptionsMaxSize = new System.Windows.Forms.NumericUpDown();
            this.lblSyncOptionsMinSize = new System.Windows.Forms.Label();
            this.numSyncOptionsMinSize = new System.Windows.Forms.NumericUpDown();
            this.lblSyncOptionsBandwidthLimit = new System.Windows.Forms.Label();
            this.cmbSyncOptionsEnabled = new System.Windows.Forms.ComboBox();
            this.lblSyncOptionsEnabled = new System.Windows.Forms.Label();
            this.llblSyncOptionsHelp = new System.Windows.Forms.LinkLabel();
            this.cmbSyncOptionsSvC = new System.Windows.Forms.ComboBox();
            this.lblSyncOptionsSvC = new System.Windows.Forms.Label();
            this.lblSyncOptionsFrequency = new System.Windows.Forms.Label();
            this.numSyncOptionsFrequency = new System.Windows.Forms.NumericUpDown();
            this.ctxtDownloadContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxtDownloadContext_Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtUploadContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxtUploadContext_Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxtExplorerContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.streamMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtExplorerContext_NewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtExplorerContext_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtExplorerContext_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tabMainUI.SuspendLayout();
            this.tabRemote.SuspendLayout();
            this.tabDownloads.SuspendLayout();
            this.tabUploads.SuspendLayout();
            this.tabSyncing.SuspendLayout();
            this.grpSyncOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSyncOptionsBandwidthLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSyncOptionsMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSyncOptionsMinSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSyncOptionsFrequency)).BeginInit();
            this.ctxtDownloadContext.SuspendLayout();
            this.ctxtUploadContext.SuspendLayout();
            this.ctxtExplorerContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRawOut
            // 
            this.txtRawOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRawOut.Location = new System.Drawing.Point(16, 401);
            this.txtRawOut.Margin = new System.Windows.Forms.Padding(4);
            this.txtRawOut.Multiline = true;
            this.txtRawOut.Name = "txtRawOut";
            this.txtRawOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRawOut.Size = new System.Drawing.Size(745, 0);
            this.txtRawOut.TabIndex = 1;
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooter.AutoSize = true;
            this.lblFooter.BackColor = System.Drawing.SystemColors.Control;
            this.lblFooter.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFooter.Location = new System.Drawing.Point(12, 479);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(0, 17);
            this.lblFooter.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile,
            this.menuStripView,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(779, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuStripFile
            // 
            this.menuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile_Quit,
            this.menuStripQuitKill});
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(44, 24);
            this.menuStripFile.Text = "File";
            // 
            // menuStripFile_Quit
            // 
            this.menuStripFile_Quit.Name = "menuStripFile_Quit";
            this.menuStripFile_Quit.Size = new System.Drawing.Size(247, 26);
            this.menuStripFile_Quit.Text = "Quit (Continue Transfers)";
            this.menuStripFile_Quit.Click += new System.EventHandler(this.menuStripFile_Quit_Click);
            // 
            // menuStripQuitKill
            // 
            this.menuStripQuitKill.Name = "menuStripQuitKill";
            this.menuStripQuitKill.Size = new System.Drawing.Size(247, 26);
            this.menuStripQuitKill.Text = "Quit";
            this.menuStripQuitKill.Click += new System.EventHandler(this.menuStripFile_QuitKill_Click);
            // 
            // menuStripView
            // 
            this.menuStripView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripView_ToggleConsole,
            this.menuStripView_Refresh});
            this.menuStripView.Name = "menuStripView";
            this.menuStripView.Size = new System.Drawing.Size(53, 24);
            this.menuStripView.Text = "View";
            // 
            // menuStripView_ToggleConsole
            // 
            this.menuStripView_ToggleConsole.Name = "menuStripView_ToggleConsole";
            this.menuStripView_ToggleConsole.Size = new System.Drawing.Size(187, 26);
            this.menuStripView_ToggleConsole.Text = "Toggle Console";
            this.menuStripView_ToggleConsole.Click += new System.EventHandler(this.menuStripView_ToggleConsole_Click);
            // 
            // menuStripView_Refresh
            // 
            this.menuStripView_Refresh.Name = "menuStripView_Refresh";
            this.menuStripView_Refresh.Size = new System.Drawing.Size(187, 26);
            this.menuStripView_Refresh.Text = "Refresh";
            this.menuStripView_Refresh.Click += new System.EventHandler(this.menuStripView_Refresh_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripView_RcloneConfig,
            this.settingsToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // menuStripView_RcloneConfig
            // 
            this.menuStripView_RcloneConfig.Name = "menuStripView_RcloneConfig";
            this.menuStripView_RcloneConfig.Size = new System.Drawing.Size(230, 26);
            this.menuStripView_RcloneConfig.Text = "Rclone Config (Alpha)";
            this.menuStripView_RcloneConfig.Click += new System.EventHandler(this.menuStripView_RcloneConfig_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(230, 26);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // tabMainUI
            // 
            this.tabMainUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMainUI.Controls.Add(this.tabRemote);
            this.tabMainUI.Controls.Add(this.tabDownloads);
            this.tabMainUI.Controls.Add(this.tabUploads);
            this.tabMainUI.Controls.Add(this.tabSyncing);
            this.tabMainUI.Location = new System.Drawing.Point(17, 34);
            this.tabMainUI.Margin = new System.Windows.Forms.Padding(4);
            this.tabMainUI.Name = "tabMainUI";
            this.tabMainUI.SelectedIndex = 0;
            this.tabMainUI.Size = new System.Drawing.Size(745, 441);
            this.tabMainUI.TabIndex = 4;
            // 
            // tabRemote
            // 
            this.tabRemote.Controls.Add(this.lblLoading);
            this.tabRemote.Controls.Add(this.lstExplorer);
            this.tabRemote.Location = new System.Drawing.Point(4, 25);
            this.tabRemote.Margin = new System.Windows.Forms.Padding(4);
            this.tabRemote.Name = "tabRemote";
            this.tabRemote.Padding = new System.Windows.Forms.Padding(4);
            this.tabRemote.Size = new System.Drawing.Size(737, 412);
            this.tabRemote.TabIndex = 0;
            this.tabRemote.Text = "Remote";
            this.tabRemote.UseVisualStyleBackColor = true;
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(0, 0);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(735, 409);
            this.lblLoading.TabIndex = 5;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoading.Visible = false;
            // 
            // lstExplorer
            // 
            this.lstExplorer.AllowDrop = true;
            this.lstExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstExplorer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colfileBytes,
            this.colfileSize,
            this.colModified,
            this.colfilePath});
            this.lstExplorer.FullRowSelect = true;
            this.lstExplorer.Location = new System.Drawing.Point(0, 0);
            this.lstExplorer.Margin = new System.Windows.Forms.Padding(4);
            this.lstExplorer.Name = "lstExplorer";
            this.lstExplorer.Size = new System.Drawing.Size(733, 408);
            this.lstExplorer.TabIndex = 0;
            this.lstExplorer.UseCompatibleStateImageBehavior = false;
            this.lstExplorer.View = System.Windows.Forms.View.Details;
            this.lstExplorer.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstExplorer_ColumnClick);
            this.lstExplorer.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstExplorer_DragDrop);
            this.lstExplorer.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstExplorer_DragEnter);
            this.lstExplorer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstExplorer_MouseClick);
            this.lstExplorer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstExplorer_MouseDoubleClick);
            // 
            // colfileBytes
            // 
            this.colfileBytes.Text = "File Size (Bytes)";
            this.colfileBytes.Width = 70;
            // 
            // colfileSize
            // 
            this.colfileSize.Text = "File Size";
            // 
            // colModified
            // 
            this.colModified.Text = "Modified";
            // 
            // colfilePath
            // 
            this.colfilePath.Text = "File Path";
            // 
            // tabDownloads
            // 
            this.tabDownloads.Controls.Add(this.lstDownloads);
            this.tabDownloads.Location = new System.Drawing.Point(4, 25);
            this.tabDownloads.Margin = new System.Windows.Forms.Padding(4);
            this.tabDownloads.Name = "tabDownloads";
            this.tabDownloads.Padding = new System.Windows.Forms.Padding(4);
            this.tabDownloads.Size = new System.Drawing.Size(737, 412);
            this.tabDownloads.TabIndex = 1;
            this.tabDownloads.Text = "Downloads";
            this.tabDownloads.UseVisualStyleBackColor = true;
            // 
            // lstDownloads
            // 
            this.lstDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDownloads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDPID,
            this.colDPath,
            this.colDProgress,
            this.colDSpeed});
            this.lstDownloads.FullRowSelect = true;
            this.lstDownloads.Location = new System.Drawing.Point(0, 0);
            this.lstDownloads.Margin = new System.Windows.Forms.Padding(4);
            this.lstDownloads.Name = "lstDownloads";
            this.lstDownloads.Size = new System.Drawing.Size(739, 408);
            this.lstDownloads.TabIndex = 0;
            this.lstDownloads.UseCompatibleStateImageBehavior = false;
            this.lstDownloads.View = System.Windows.Forms.View.Details;
            this.lstDownloads.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstDownloads_MouseClick);
            // 
            // colDPID
            // 
            this.colDPID.Text = "PID";
            // 
            // colDPath
            // 
            this.colDPath.Text = "Path";
            // 
            // colDProgress
            // 
            this.colDProgress.Text = "Progress";
            // 
            // colDSpeed
            // 
            this.colDSpeed.Text = "Speed";
            // 
            // tabUploads
            // 
            this.tabUploads.Controls.Add(this.lstUploads);
            this.tabUploads.Location = new System.Drawing.Point(4, 25);
            this.tabUploads.Margin = new System.Windows.Forms.Padding(4);
            this.tabUploads.Name = "tabUploads";
            this.tabUploads.Padding = new System.Windows.Forms.Padding(4);
            this.tabUploads.Size = new System.Drawing.Size(737, 412);
            this.tabUploads.TabIndex = 2;
            this.tabUploads.Text = "Uploads";
            this.tabUploads.UseVisualStyleBackColor = true;
            // 
            // lstUploads
            // 
            this.lstUploads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUploads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPID,
            this.colUPath,
            this.colUProgress,
            this.colUSpeed});
            this.lstUploads.FullRowSelect = true;
            this.lstUploads.Location = new System.Drawing.Point(0, 0);
            this.lstUploads.Margin = new System.Windows.Forms.Padding(4);
            this.lstUploads.Name = "lstUploads";
            this.lstUploads.Size = new System.Drawing.Size(739, 408);
            this.lstUploads.TabIndex = 1;
            this.lstUploads.UseCompatibleStateImageBehavior = false;
            this.lstUploads.View = System.Windows.Forms.View.Details;
            this.lstUploads.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstUploads_MouseClick);
            // 
            // colPID
            // 
            this.colPID.Text = "PID";
            // 
            // colUPath
            // 
            this.colUPath.Text = "Path";
            // 
            // colUProgress
            // 
            this.colUProgress.Text = "Progress";
            // 
            // colUSpeed
            // 
            this.colUSpeed.Text = "Speed";
            // 
            // tabSyncing
            // 
            this.tabSyncing.Controls.Add(this.btnSyncStart);
            this.tabSyncing.Controls.Add(this.txtSyncLog);
            this.tabSyncing.Controls.Add(this.btnSyncSave);
            this.tabSyncing.Controls.Add(this.grpSyncOptions);
            this.tabSyncing.Location = new System.Drawing.Point(4, 25);
            this.tabSyncing.Margin = new System.Windows.Forms.Padding(4);
            this.tabSyncing.Name = "tabSyncing";
            this.tabSyncing.Padding = new System.Windows.Forms.Padding(4);
            this.tabSyncing.Size = new System.Drawing.Size(737, 412);
            this.tabSyncing.TabIndex = 3;
            this.tabSyncing.Text = "Syncing";
            this.tabSyncing.UseVisualStyleBackColor = true;
            // 
            // btnSyncStart
            // 
            this.btnSyncStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSyncStart.Location = new System.Drawing.Point(8, 373);
            this.btnSyncStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnSyncStart.Name = "btnSyncStart";
            this.btnSyncStart.Size = new System.Drawing.Size(719, 28);
            this.btnSyncStart.TabIndex = 9;
            this.btnSyncStart.Text = "Start Sync";
            this.btnSyncStart.UseVisualStyleBackColor = true;
            this.btnSyncStart.Click += new System.EventHandler(this.btnSyncStart_Click);
            // 
            // txtSyncLog
            // 
            this.txtSyncLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSyncLog.Location = new System.Drawing.Point(9, 217);
            this.txtSyncLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtSyncLog.Multiline = true;
            this.txtSyncLog.Name = "txtSyncLog";
            this.txtSyncLog.ReadOnly = true;
            this.txtSyncLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSyncLog.Size = new System.Drawing.Size(716, 123);
            this.txtSyncLog.TabIndex = 8;
            // 
            // btnSyncSave
            // 
            this.btnSyncSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSyncSave.Location = new System.Drawing.Point(8, 347);
            this.btnSyncSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSyncSave.Name = "btnSyncSave";
            this.btnSyncSave.Size = new System.Drawing.Size(719, 28);
            this.btnSyncSave.TabIndex = 7;
            this.btnSyncSave.Text = "Save Settings";
            this.btnSyncSave.UseVisualStyleBackColor = true;
            this.btnSyncSave.Click += new System.EventHandler(this.btnSyncSave_Click);
            // 
            // grpSyncOptions
            // 
            this.grpSyncOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSyncOptions.Controls.Add(this.btnSyncDestinationSelect);
            this.grpSyncOptions.Controls.Add(this.btnSyncSourceSelect);
            this.grpSyncOptions.Controls.Add(this.txtSyncDestination);
            this.grpSyncOptions.Controls.Add(this.lblSyncDestination);
            this.grpSyncOptions.Controls.Add(this.lblSyncSource);
            this.grpSyncOptions.Controls.Add(this.txtSyncSource);
            this.grpSyncOptions.Controls.Add(this.numSyncOptionsBandwidthLimit);
            this.grpSyncOptions.Controls.Add(this.lblSyncOptionsMaxSize);
            this.grpSyncOptions.Controls.Add(this.numSyncOptionsMaxSize);
            this.grpSyncOptions.Controls.Add(this.lblSyncOptionsMinSize);
            this.grpSyncOptions.Controls.Add(this.numSyncOptionsMinSize);
            this.grpSyncOptions.Controls.Add(this.lblSyncOptionsBandwidthLimit);
            this.grpSyncOptions.Controls.Add(this.cmbSyncOptionsEnabled);
            this.grpSyncOptions.Controls.Add(this.lblSyncOptionsEnabled);
            this.grpSyncOptions.Controls.Add(this.llblSyncOptionsHelp);
            this.grpSyncOptions.Controls.Add(this.cmbSyncOptionsSvC);
            this.grpSyncOptions.Controls.Add(this.lblSyncOptionsSvC);
            this.grpSyncOptions.Controls.Add(this.lblSyncOptionsFrequency);
            this.grpSyncOptions.Controls.Add(this.numSyncOptionsFrequency);
            this.grpSyncOptions.Location = new System.Drawing.Point(9, 7);
            this.grpSyncOptions.Margin = new System.Windows.Forms.Padding(4);
            this.grpSyncOptions.Name = "grpSyncOptions";
            this.grpSyncOptions.Padding = new System.Windows.Forms.Padding(4);
            this.grpSyncOptions.Size = new System.Drawing.Size(717, 202);
            this.grpSyncOptions.TabIndex = 4;
            this.grpSyncOptions.TabStop = false;
            this.grpSyncOptions.Text = "Sync Options";
            // 
            // btnSyncDestinationSelect
            // 
            this.btnSyncDestinationSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSyncDestinationSelect.Location = new System.Drawing.Point(609, 90);
            this.btnSyncDestinationSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSyncDestinationSelect.Name = "btnSyncDestinationSelect";
            this.btnSyncDestinationSelect.Size = new System.Drawing.Size(100, 28);
            this.btnSyncDestinationSelect.TabIndex = 19;
            this.btnSyncDestinationSelect.Text = "Use Current";
            this.btnSyncDestinationSelect.UseVisualStyleBackColor = true;
            this.btnSyncDestinationSelect.Click += new System.EventHandler(this.btnSyncDestinationSelect_Click);
            // 
            // btnSyncSourceSelect
            // 
            this.btnSyncSourceSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSyncSourceSelect.Location = new System.Drawing.Point(609, 37);
            this.btnSyncSourceSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSyncSourceSelect.Name = "btnSyncSourceSelect";
            this.btnSyncSourceSelect.Size = new System.Drawing.Size(100, 28);
            this.btnSyncSourceSelect.TabIndex = 18;
            this.btnSyncSourceSelect.Text = "Browse";
            this.btnSyncSourceSelect.UseVisualStyleBackColor = true;
            this.btnSyncSourceSelect.Click += new System.EventHandler(this.btnSyncSourceSelect_Click);
            // 
            // txtSyncDestination
            // 
            this.txtSyncDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSyncDestination.Enabled = false;
            this.txtSyncDestination.Location = new System.Drawing.Point(12, 92);
            this.txtSyncDestination.Margin = new System.Windows.Forms.Padding(4);
            this.txtSyncDestination.Name = "txtSyncDestination";
            this.txtSyncDestination.Size = new System.Drawing.Size(588, 22);
            this.txtSyncDestination.TabIndex = 17;
            // 
            // lblSyncDestination
            // 
            this.lblSyncDestination.AutoSize = true;
            this.lblSyncDestination.Location = new System.Drawing.Point(8, 73);
            this.lblSyncDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSyncDestination.Name = "lblSyncDestination";
            this.lblSyncDestination.Size = new System.Drawing.Size(175, 17);
            this.lblSyncDestination.TabIndex = 16;
            this.lblSyncDestination.Text = "Sync destination directory:";
            // 
            // lblSyncSource
            // 
            this.lblSyncSource.AutoSize = true;
            this.lblSyncSource.Location = new System.Drawing.Point(8, 20);
            this.lblSyncSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSyncSource.Name = "lblSyncSource";
            this.lblSyncSource.Size = new System.Drawing.Size(149, 17);
            this.lblSyncSource.TabIndex = 15;
            this.lblSyncSource.Text = "Sync source directory:";
            // 
            // txtSyncSource
            // 
            this.txtSyncSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSyncSource.Enabled = false;
            this.txtSyncSource.Location = new System.Drawing.Point(12, 39);
            this.txtSyncSource.Margin = new System.Windows.Forms.Padding(4);
            this.txtSyncSource.Name = "txtSyncSource";
            this.txtSyncSource.Size = new System.Drawing.Size(588, 22);
            this.txtSyncSource.TabIndex = 14;
            // 
            // numSyncOptionsBandwidthLimit
            // 
            this.numSyncOptionsBandwidthLimit.Location = new System.Drawing.Point(400, 121);
            this.numSyncOptionsBandwidthLimit.Margin = new System.Windows.Forms.Padding(4);
            this.numSyncOptionsBandwidthLimit.Name = "numSyncOptionsBandwidthLimit";
            this.numSyncOptionsBandwidthLimit.Size = new System.Drawing.Size(67, 22);
            this.numSyncOptionsBandwidthLimit.TabIndex = 13;
            // 
            // lblSyncOptionsMaxSize
            // 
            this.lblSyncOptionsMaxSize.AutoSize = true;
            this.lblSyncOptionsMaxSize.Location = new System.Drawing.Point(233, 174);
            this.lblSyncOptionsMaxSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSyncOptionsMaxSize.Name = "lblSyncOptionsMaxSize";
            this.lblSyncOptionsMaxSize.Size = new System.Drawing.Size(146, 17);
            this.lblSyncOptionsMaxSize.TabIndex = 12;
            this.lblSyncOptionsMaxSize.Text = "Ignore files over (kb): ";
            // 
            // numSyncOptionsMaxSize
            // 
            this.numSyncOptionsMaxSize.Location = new System.Drawing.Point(400, 174);
            this.numSyncOptionsMaxSize.Margin = new System.Windows.Forms.Padding(4);
            this.numSyncOptionsMaxSize.Name = "numSyncOptionsMaxSize";
            this.numSyncOptionsMaxSize.Size = new System.Drawing.Size(67, 22);
            this.numSyncOptionsMaxSize.TabIndex = 11;
            // 
            // lblSyncOptionsMinSize
            // 
            this.lblSyncOptionsMinSize.AutoSize = true;
            this.lblSyncOptionsMinSize.Location = new System.Drawing.Point(233, 149);
            this.lblSyncOptionsMinSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSyncOptionsMinSize.Name = "lblSyncOptionsMinSize";
            this.lblSyncOptionsMinSize.Size = new System.Drawing.Size(151, 17);
            this.lblSyncOptionsMinSize.TabIndex = 10;
            this.lblSyncOptionsMinSize.Text = "Ignore files under (kb):";
            // 
            // numSyncOptionsMinSize
            // 
            this.numSyncOptionsMinSize.Location = new System.Drawing.Point(400, 146);
            this.numSyncOptionsMinSize.Margin = new System.Windows.Forms.Padding(4);
            this.numSyncOptionsMinSize.Name = "numSyncOptionsMinSize";
            this.numSyncOptionsMinSize.Size = new System.Drawing.Size(67, 22);
            this.numSyncOptionsMinSize.TabIndex = 9;
            // 
            // lblSyncOptionsBandwidthLimit
            // 
            this.lblSyncOptionsBandwidthLimit.AutoSize = true;
            this.lblSyncOptionsBandwidthLimit.Location = new System.Drawing.Point(233, 124);
            this.lblSyncOptionsBandwidthLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSyncOptionsBandwidthLimit.Name = "lblSyncOptionsBandwidthLimit";
            this.lblSyncOptionsBandwidthLimit.Size = new System.Drawing.Size(158, 17);
            this.lblSyncOptionsBandwidthLimit.TabIndex = 8;
            this.lblSyncOptionsBandwidthLimit.Text = "Bandwidth Limit (kbps): ";
            // 
            // cmbSyncOptionsEnabled
            // 
            this.cmbSyncOptionsEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSyncOptionsEnabled.FormattingEnabled = true;
            this.cmbSyncOptionsEnabled.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbSyncOptionsEnabled.Location = new System.Drawing.Point(159, 121);
            this.cmbSyncOptionsEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSyncOptionsEnabled.Name = "cmbSyncOptionsEnabled";
            this.cmbSyncOptionsEnabled.Size = new System.Drawing.Size(65, 24);
            this.cmbSyncOptionsEnabled.TabIndex = 6;
            // 
            // lblSyncOptionsEnabled
            // 
            this.lblSyncOptionsEnabled.AutoSize = true;
            this.lblSyncOptionsEnabled.Location = new System.Drawing.Point(8, 124);
            this.lblSyncOptionsEnabled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSyncOptionsEnabled.Name = "lblSyncOptionsEnabled";
            this.lblSyncOptionsEnabled.Size = new System.Drawing.Size(132, 17);
            this.lblSyncOptionsEnabled.TabIndex = 5;
            this.lblSyncOptionsEnabled.Text = "Auto Sync Enabled:";
            // 
            // llblSyncOptionsHelp
            // 
            this.llblSyncOptionsHelp.AutoSize = true;
            this.llblSyncOptionsHelp.Location = new System.Drawing.Point(564, 182);
            this.llblSyncOptionsHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblSyncOptionsHelp.Name = "llblSyncOptionsHelp";
            this.llblSyncOptionsHelp.Size = new System.Drawing.Size(154, 17);
            this.llblSyncOptionsHelp.TabIndex = 4;
            this.llblSyncOptionsHelp.TabStop = true;
            this.llblSyncOptionsHelp.Text = "Help with these options";
            this.llblSyncOptionsHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSyncOptionsHelp_LinkClicked);
            // 
            // cmbSyncOptionsSvC
            // 
            this.cmbSyncOptionsSvC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSyncOptionsSvC.FormattingEnabled = true;
            this.cmbSyncOptionsSvC.Items.AddRange(new object[] {
            "sync",
            "copy"});
            this.cmbSyncOptionsSvC.Location = new System.Drawing.Point(159, 170);
            this.cmbSyncOptionsSvC.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSyncOptionsSvC.Name = "cmbSyncOptionsSvC";
            this.cmbSyncOptionsSvC.Size = new System.Drawing.Size(65, 24);
            this.cmbSyncOptionsSvC.TabIndex = 3;
            // 
            // lblSyncOptionsSvC
            // 
            this.lblSyncOptionsSvC.AutoSize = true;
            this.lblSyncOptionsSvC.Location = new System.Drawing.Point(8, 174);
            this.lblSyncOptionsSvC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSyncOptionsSvC.Name = "lblSyncOptionsSvC";
            this.lblSyncOptionsSvC.Size = new System.Drawing.Size(100, 17);
            this.lblSyncOptionsSvC.TabIndex = 2;
            this.lblSyncOptionsSvC.Text = "Sync or Copy: ";
            // 
            // lblSyncOptionsFrequency
            // 
            this.lblSyncOptionsFrequency.AutoSize = true;
            this.lblSyncOptionsFrequency.Location = new System.Drawing.Point(8, 149);
            this.lblSyncOptionsFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSyncOptionsFrequency.Name = "lblSyncOptionsFrequency";
            this.lblSyncOptionsFrequency.Size = new System.Drawing.Size(152, 17);
            this.lblSyncOptionsFrequency.TabIndex = 1;
            this.lblSyncOptionsFrequency.Text = "Sync Frequency (hrs): ";
            // 
            // numSyncOptionsFrequency
            // 
            this.numSyncOptionsFrequency.Location = new System.Drawing.Point(159, 146);
            this.numSyncOptionsFrequency.Margin = new System.Windows.Forms.Padding(4);
            this.numSyncOptionsFrequency.Name = "numSyncOptionsFrequency";
            this.numSyncOptionsFrequency.Size = new System.Drawing.Size(67, 22);
            this.numSyncOptionsFrequency.TabIndex = 0;
            // 
            // ctxtDownloadContext
            // 
            this.ctxtDownloadContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtDownloadContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxtDownloadContext_Cancel});
            this.ctxtDownloadContext.Name = "ctxtDownloadContext";
            this.ctxtDownloadContext.Size = new System.Drawing.Size(129, 30);
            // 
            // ctxtDownloadContext_Cancel
            // 
            this.ctxtDownloadContext_Cancel.Name = "ctxtDownloadContext_Cancel";
            this.ctxtDownloadContext_Cancel.Size = new System.Drawing.Size(128, 26);
            this.ctxtDownloadContext_Cancel.Text = "Cancel";
            this.ctxtDownloadContext_Cancel.Click += new System.EventHandler(this.ctxtDownloadContext_Cancel_Click);
            // 
            // ctxtUploadContext
            // 
            this.ctxtUploadContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtUploadContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxtUploadContext_Cancel});
            this.ctxtUploadContext.Name = "ctxtUploadContext";
            this.ctxtUploadContext.Size = new System.Drawing.Size(129, 30);
            // 
            // ctxtUploadContext_Cancel
            // 
            this.ctxtUploadContext_Cancel.Name = "ctxtUploadContext_Cancel";
            this.ctxtUploadContext_Cancel.Size = new System.Drawing.Size(128, 26);
            this.ctxtUploadContext_Cancel.Text = "Cancel";
            this.ctxtUploadContext_Cancel.Click += new System.EventHandler(this.ctxtUploadContext_Cancel_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "rcloneExplorer";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // ctxtExplorerContext
            // 
            this.ctxtExplorerContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtExplorerContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.streamMediaToolStripMenuItem,
            this.ctxtExplorerContext_NewFolder,
            this.ctxtExplorerContext_Rename,
            this.ctxtExplorerContext_Delete});
            this.ctxtExplorerContext.Name = "ctxtExplorerContext";
            this.ctxtExplorerContext.Size = new System.Drawing.Size(224, 136);
            // 
            // streamMediaToolStripMenuItem
            // 
            this.streamMediaToolStripMenuItem.Enabled = false;
            this.streamMediaToolStripMenuItem.Name = "streamMediaToolStripMenuItem";
            this.streamMediaToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.streamMediaToolStripMenuItem.Text = "Stream Media";
            this.streamMediaToolStripMenuItem.Click += new System.EventHandler(this.streamMediaToolStripMenuItem_Click);
            // 
            // ctxtExplorerContext_NewFolder
            // 
            this.ctxtExplorerContext_NewFolder.Name = "ctxtExplorerContext_NewFolder";
            this.ctxtExplorerContext_NewFolder.Size = new System.Drawing.Size(223, 26);
            this.ctxtExplorerContext_NewFolder.Text = "New Folder";
            this.ctxtExplorerContext_NewFolder.Click += new System.EventHandler(this.ctxtExplorerContext_NewFolder_Click);
            // 
            // ctxtExplorerContext_Delete
            // 
            this.ctxtExplorerContext_Delete.Name = "ctxtExplorerContext_Delete";
            this.ctxtExplorerContext_Delete.Size = new System.Drawing.Size(223, 26);
            this.ctxtExplorerContext_Delete.Text = "Delete Selected Item";
            this.ctxtExplorerContext_Delete.Click += new System.EventHandler(this.ctxtExplorerContext_Delete_Click);
            // 
            // ctxtExplorerContext_Rename
            // 
            this.ctxtExplorerContext_Rename.Name = "ctxtExplorerContext_Rename";
            this.ctxtExplorerContext_Rename.Size = new System.Drawing.Size(223, 26);
            this.ctxtExplorerContext_Rename.Text = "Rename";
            this.ctxtExplorerContext_Rename.Click += new System.EventHandler(this.ctxtExplorerContext_Rename_Click);
            // 
            // rcloneExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 506);
            this.Controls.Add(this.tabMainUI);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.txtRawOut);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(794, 479);
            this.Name = "rcloneExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rcloneExplorer";
            this.Resize += new System.EventHandler(this.rcloneExplorer_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabMainUI.ResumeLayout(false);
            this.tabRemote.ResumeLayout(false);
            this.tabDownloads.ResumeLayout(false);
            this.tabUploads.ResumeLayout(false);
            this.tabSyncing.ResumeLayout(false);
            this.tabSyncing.PerformLayout();
            this.grpSyncOptions.ResumeLayout(false);
            this.grpSyncOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSyncOptionsBandwidthLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSyncOptionsMaxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSyncOptionsMinSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSyncOptionsFrequency)).EndInit();
            this.ctxtDownloadContext.ResumeLayout(false);
            this.ctxtUploadContext.ResumeLayout(false);
            this.ctxtExplorerContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox txtRawOut;
    private System.Windows.Forms.Label lblFooter;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem menuStripFile;
    private System.Windows.Forms.ToolStripMenuItem menuStripView;
    private System.Windows.Forms.ToolStripMenuItem menuStripView_ToggleConsole;
    private System.Windows.Forms.TabControl tabMainUI;
    private System.Windows.Forms.TabPage tabDownloads;
    private System.Windows.Forms.ListView lstDownloads;
    private System.Windows.Forms.ColumnHeader colDProgress;
    private System.Windows.Forms.ColumnHeader colDPath;
    private System.Windows.Forms.ContextMenuStrip ctxtDownloadContext;
    private System.Windows.Forms.ToolStripMenuItem ctxtDownloadContext_Cancel;
    private System.Windows.Forms.ToolStripMenuItem menuStripFile_Quit;
    private System.Windows.Forms.ToolStripMenuItem menuStripQuitKill;
    private System.Windows.Forms.ToolStripMenuItem menuStripView_Refresh;
    private System.Windows.Forms.TabPage tabUploads;
    private System.Windows.Forms.ListView lstUploads;
    private System.Windows.Forms.ColumnHeader colUProgress;
    private System.Windows.Forms.ColumnHeader colUPath;
    private System.Windows.Forms.ContextMenuStrip ctxtUploadContext;
    private System.Windows.Forms.ToolStripMenuItem ctxtUploadContext_Cancel;
    private System.Windows.Forms.TabPage tabSyncing;
    private System.Windows.Forms.GroupBox grpSyncOptions;
    private System.Windows.Forms.Label lblSyncOptionsFrequency;
    private System.Windows.Forms.NumericUpDown numSyncOptionsFrequency;
    private System.Windows.Forms.LinkLabel llblSyncOptionsHelp;
    private System.Windows.Forms.ComboBox cmbSyncOptionsSvC;
    private System.Windows.Forms.Label lblSyncOptionsSvC;
    private System.Windows.Forms.ComboBox cmbSyncOptionsEnabled;
    private System.Windows.Forms.Label lblSyncOptionsEnabled;
    private System.Windows.Forms.Button btnSyncSave;
    private System.Windows.Forms.Label lblSyncOptionsBandwidthLimit;
    private System.Windows.Forms.Label lblSyncOptionsMaxSize;
    private System.Windows.Forms.NumericUpDown numSyncOptionsMaxSize;
    private System.Windows.Forms.Label lblSyncOptionsMinSize;
    private System.Windows.Forms.NumericUpDown numSyncOptionsMinSize;
    private System.Windows.Forms.NumericUpDown numSyncOptionsBandwidthLimit;
    private System.Windows.Forms.NotifyIcon notifyIcon;
    private System.Windows.Forms.TextBox txtSyncLog;
    private System.Windows.Forms.Button btnSyncStart;
    private System.Windows.Forms.ContextMenuStrip ctxtExplorerContext;
    private System.Windows.Forms.ToolStripMenuItem ctxtExplorerContext_NewFolder;
    private System.Windows.Forms.ToolStripMenuItem ctxtExplorerContext_Delete;
    private System.Windows.Forms.TabPage tabRemote;
    private System.Windows.Forms.ListView lstExplorer;
    private System.Windows.Forms.ColumnHeader colfileBytes;
    private System.Windows.Forms.ColumnHeader colfileSize;
    private System.Windows.Forms.ColumnHeader colModified;
    private System.Windows.Forms.ColumnHeader colfilePath;
    private System.Windows.Forms.Label lblLoading;
    private System.Windows.Forms.Button btnSyncDestinationSelect;
    private System.Windows.Forms.Button btnSyncSourceSelect;
    private System.Windows.Forms.TextBox txtSyncDestination;
    private System.Windows.Forms.Label lblSyncDestination;
    private System.Windows.Forms.Label lblSyncSource;
    private System.Windows.Forms.TextBox txtSyncSource;
    private System.Windows.Forms.ToolStripMenuItem streamMediaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuStripView_RcloneConfig;
        private System.Windows.Forms.ColumnHeader colUSpeed;
        private System.Windows.Forms.ColumnHeader colDSpeed;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader colPID;
        private System.Windows.Forms.ColumnHeader colDPID;
        private System.Windows.Forms.ToolStripMenuItem ctxtExplorerContext_Rename;
    }
}

