namespace SiebelLogAnalyser
{
    partial class FormSiebelLogViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxLogPath = new System.Windows.Forms.TextBox();
            this.fastObjectListViewMessages = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLineNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnComponentName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEventName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnErrorLevel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMessageDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMessageCode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMessageText = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.buttonLogFile = new System.Windows.Forms.Button();
            this.buttonLogFolder = new System.Windows.Forms.Button();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.fastObjectListViewLogFile = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnLogFileLineNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLogFileLine = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBoxMessageDetail = new System.Windows.Forms.GroupBox();
            this.labelMessageTExt = new System.Windows.Forms.Label();
            this.textBoxMessageText = new System.Windows.Forms.TextBox();
            this.textBoxSuggestedAction = new System.Windows.Forms.TextBox();
            this.textBoxOracleDefinition = new System.Windows.Forms.TextBox();
            this.labelSuggestedAction = new System.Windows.Forms.Label();
            this.labelOracleDefinition = new System.Windows.Forms.Label();
            this.textBoxMessageCode = new System.Windows.Forms.TextBox();
            this.labelMessageCode = new System.Windows.Forms.Label();
            this.automaticUpdater = new wyDay.Controls.AutomaticUpdater();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogLogFile = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogLogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerResults = new System.Windows.Forms.SplitContainer();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorkerAnalyse = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewMessages)).BeginInit();
            this.groupBoxSource.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewLogFile)).BeginInit();
            this.groupBoxMessageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater)).BeginInit();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerResults)).BeginInit();
            this.splitContainerResults.Panel1.SuspendLayout();
            this.splitContainerResults.Panel2.SuspendLayout();
            this.splitContainerResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogPath
            // 
            this.textBoxLogPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogPath.Location = new System.Drawing.Point(7, 19);
            this.textBoxLogPath.Name = "textBoxLogPath";
            this.textBoxLogPath.Size = new System.Drawing.Size(566, 20);
            this.textBoxLogPath.TabIndex = 0;
            this.toolTipMain.SetToolTip(this.textBoxLogPath, "Source log file or folder");
            // 
            // fastObjectListViewMessages
            // 
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnFileName);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnLineNumber);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnComponentName);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnEventName);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnErrorLevel);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnMessageDate);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnMessageCode);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnMessageText);
            this.fastObjectListViewMessages.AllowColumnReorder = true;
            this.fastObjectListViewMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fastObjectListViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnFileName,
            this.olvColumnLineNumber,
            this.olvColumnComponentName,
            this.olvColumnEventName,
            this.olvColumnErrorLevel,
            this.olvColumnMessageDate,
            this.olvColumnMessageCode,
            this.olvColumnMessageText});
            this.fastObjectListViewMessages.FullRowSelect = true;
            this.fastObjectListViewMessages.GridLines = true;
            this.fastObjectListViewMessages.HideSelection = false;
            this.fastObjectListViewMessages.Location = new System.Drawing.Point(7, 46);
            this.fastObjectListViewMessages.Name = "fastObjectListViewMessages";
            this.fastObjectListViewMessages.ShowGroups = false;
            this.fastObjectListViewMessages.ShowItemCountOnGroups = true;
            this.fastObjectListViewMessages.Size = new System.Drawing.Size(638, 463);
            this.fastObjectListViewMessages.TabIndex = 4;
            this.fastObjectListViewMessages.UseCompatibleStateImageBehavior = false;
            this.fastObjectListViewMessages.UseFiltering = true;
            this.fastObjectListViewMessages.View = System.Windows.Forms.View.Details;
            this.fastObjectListViewMessages.VirtualMode = true;
            this.fastObjectListViewMessages.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.fastObjectListViewMessages_FormatRow);
            this.fastObjectListViewMessages.SelectedIndexChanged += new System.EventHandler(this.objectListViewMessages_SelectedIndexChanged);
            this.fastObjectListViewMessages.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fastObjectListViewMessages_MouseUp);
            // 
            // olvColumnFileName
            // 
            this.olvColumnFileName.AspectName = "FileName";
            this.olvColumnFileName.Text = "File Name";
            this.olvColumnFileName.Width = 85;
            // 
            // olvColumnLineNumber
            // 
            this.olvColumnLineNumber.AspectName = "LineNumber";
            this.olvColumnLineNumber.Text = "Line #";
            this.olvColumnLineNumber.Width = 89;
            // 
            // olvColumnComponentName
            // 
            this.olvColumnComponentName.AspectName = "ComponentName";
            this.olvColumnComponentName.Text = "Component";
            // 
            // olvColumnEventName
            // 
            this.olvColumnEventName.AspectName = "EventName";
            this.olvColumnEventName.Text = "Event";
            // 
            // olvColumnErrorLevel
            // 
            this.olvColumnErrorLevel.AspectName = "ErrorLevel";
            this.olvColumnErrorLevel.Text = "Level";
            // 
            // olvColumnMessageDate
            // 
            this.olvColumnMessageDate.AspectName = "MessageDate";
            this.olvColumnMessageDate.Text = "Date/Time";
            // 
            // olvColumnMessageCode
            // 
            this.olvColumnMessageCode.AspectName = "MessageCode";
            this.olvColumnMessageCode.Text = "Code";
            // 
            // olvColumnMessageText
            // 
            this.olvColumnMessageText.AspectName = "MessageText";
            this.olvColumnMessageText.Text = "Text";
            // 
            // groupBoxSource
            // 
            this.groupBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSource.Controls.Add(this.textBoxLogPath);
            this.groupBoxSource.Controls.Add(this.buttonLogFile);
            this.groupBoxSource.Controls.Add(this.buttonLogFolder);
            this.groupBoxSource.Controls.Add(this.fastObjectListViewMessages);
            this.groupBoxSource.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(655, 520);
            this.groupBoxSource.TabIndex = 5;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "Source";
            // 
            // buttonLogFile
            // 
            this.buttonLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogFile.Image = global::SiebelLogAnalyser.Properties.Resources.LOGAN_document_text_import_16;
            this.buttonLogFile.Location = new System.Drawing.Point(579, 17);
            this.buttonLogFile.Name = "buttonLogFile";
            this.buttonLogFile.Size = new System.Drawing.Size(29, 23);
            this.buttonLogFile.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.buttonLogFile, "Open log file");
            this.buttonLogFile.UseVisualStyleBackColor = true;
            this.buttonLogFile.Click += new System.EventHandler(this.buttonLogFile_Click);
            // 
            // buttonLogFolder
            // 
            this.buttonLogFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogFolder.Enabled = false;
            this.buttonLogFolder.Image = global::SiebelLogAnalyser.Properties.Resources.LOGAN_folder_open_16;
            this.buttonLogFolder.Location = new System.Drawing.Point(614, 17);
            this.buttonLogFolder.Name = "buttonLogFolder";
            this.buttonLogFolder.Size = new System.Drawing.Size(28, 23);
            this.buttonLogFolder.TabIndex = 2;
            this.toolTipMain.SetToolTip(this.buttonLogFolder, "Open log folder");
            this.buttonLogFolder.UseVisualStyleBackColor = true;
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLog.Controls.Add(this.fastObjectListViewLogFile);
            this.groupBoxLog.Location = new System.Drawing.Point(2, 3);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(623, 712);
            this.groupBoxLog.TabIndex = 6;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Log";
            // 
            // fastObjectListViewLogFile
            // 
            this.fastObjectListViewLogFile.AllColumns.Add(this.olvColumnLogFileLineNumber);
            this.fastObjectListViewLogFile.AllColumns.Add(this.olvColumnLogFileLine);
            this.fastObjectListViewLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fastObjectListViewLogFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnLogFileLineNumber,
            this.olvColumnLogFileLine});
            this.fastObjectListViewLogFile.FullRowSelect = true;
            this.fastObjectListViewLogFile.GridLines = true;
            this.fastObjectListViewLogFile.HideSelection = false;
            this.fastObjectListViewLogFile.Location = new System.Drawing.Point(8, 20);
            this.fastObjectListViewLogFile.Name = "fastObjectListViewLogFile";
            this.fastObjectListViewLogFile.ShowGroups = false;
            this.fastObjectListViewLogFile.Size = new System.Drawing.Size(609, 681);
            this.fastObjectListViewLogFile.TabIndex = 2;
            this.fastObjectListViewLogFile.UseCompatibleStateImageBehavior = false;
            this.fastObjectListViewLogFile.View = System.Windows.Forms.View.Details;
            this.fastObjectListViewLogFile.VirtualMode = true;
            // 
            // olvColumnLogFileLineNumber
            // 
            this.olvColumnLogFileLineNumber.AspectName = "LineNumber";
            this.olvColumnLogFileLineNumber.Text = "Line #";
            this.olvColumnLogFileLineNumber.Width = 80;
            // 
            // olvColumnLogFileLine
            // 
            this.olvColumnLogFileLine.AspectName = "Line";
            this.olvColumnLogFileLine.Text = "Line";
            this.olvColumnLogFileLine.Width = 1200;
            // 
            // groupBoxMessageDetail
            // 
            this.groupBoxMessageDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMessageDetail.Controls.Add(this.labelMessageTExt);
            this.groupBoxMessageDetail.Controls.Add(this.textBoxMessageText);
            this.groupBoxMessageDetail.Controls.Add(this.textBoxSuggestedAction);
            this.groupBoxMessageDetail.Controls.Add(this.textBoxOracleDefinition);
            this.groupBoxMessageDetail.Controls.Add(this.labelSuggestedAction);
            this.groupBoxMessageDetail.Controls.Add(this.labelOracleDefinition);
            this.groupBoxMessageDetail.Controls.Add(this.textBoxMessageCode);
            this.groupBoxMessageDetail.Controls.Add(this.labelMessageCode);
            this.groupBoxMessageDetail.Location = new System.Drawing.Point(0, 1);
            this.groupBoxMessageDetail.Name = "groupBoxMessageDetail";
            this.groupBoxMessageDetail.Size = new System.Drawing.Size(655, 186);
            this.groupBoxMessageDetail.TabIndex = 7;
            this.groupBoxMessageDetail.TabStop = false;
            this.groupBoxMessageDetail.Text = "Message Detail";
            // 
            // labelMessageTExt
            // 
            this.labelMessageTExt.AutoSize = true;
            this.labelMessageTExt.Location = new System.Drawing.Point(16, 51);
            this.labelMessageTExt.Name = "labelMessageTExt";
            this.labelMessageTExt.Size = new System.Drawing.Size(77, 13);
            this.labelMessageTExt.TabIndex = 7;
            this.labelMessageTExt.Text = "Message Text:";
            // 
            // textBoxMessageText
            // 
            this.textBoxMessageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessageText.Location = new System.Drawing.Point(99, 48);
            this.textBoxMessageText.Multiline = true;
            this.textBoxMessageText.Name = "textBoxMessageText";
            this.textBoxMessageText.ReadOnly = true;
            this.textBoxMessageText.Size = new System.Drawing.Size(546, 40);
            this.textBoxMessageText.TabIndex = 6;
            // 
            // textBoxSuggestedAction
            // 
            this.textBoxSuggestedAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSuggestedAction.Location = new System.Drawing.Point(99, 140);
            this.textBoxSuggestedAction.Multiline = true;
            this.textBoxSuggestedAction.Name = "textBoxSuggestedAction";
            this.textBoxSuggestedAction.ReadOnly = true;
            this.textBoxSuggestedAction.Size = new System.Drawing.Size(546, 40);
            this.textBoxSuggestedAction.TabIndex = 5;
            this.toolTipMain.SetToolTip(this.textBoxSuggestedAction, "Recommended action");
            // 
            // textBoxOracleDefinition
            // 
            this.textBoxOracleDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOracleDefinition.Location = new System.Drawing.Point(99, 94);
            this.textBoxOracleDefinition.Multiline = true;
            this.textBoxOracleDefinition.Name = "textBoxOracleDefinition";
            this.textBoxOracleDefinition.ReadOnly = true;
            this.textBoxOracleDefinition.Size = new System.Drawing.Size(546, 40);
            this.textBoxOracleDefinition.TabIndex = 4;
            this.toolTipMain.SetToolTip(this.textBoxOracleDefinition, "Oracle message definition");
            // 
            // labelSuggestedAction
            // 
            this.labelSuggestedAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSuggestedAction.AutoSize = true;
            this.labelSuggestedAction.Location = new System.Drawing.Point(2, 143);
            this.labelSuggestedAction.Name = "labelSuggestedAction";
            this.labelSuggestedAction.Size = new System.Drawing.Size(94, 13);
            this.labelSuggestedAction.TabIndex = 3;
            this.labelSuggestedAction.Text = "Suggested Action:";
            // 
            // labelOracleDefinition
            // 
            this.labelOracleDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOracleDefinition.AutoSize = true;
            this.labelOracleDefinition.Location = new System.Drawing.Point(5, 97);
            this.labelOracleDefinition.Name = "labelOracleDefinition";
            this.labelOracleDefinition.Size = new System.Drawing.Size(88, 13);
            this.labelOracleDefinition.TabIndex = 2;
            this.labelOracleDefinition.Text = "Oracle Definition:";
            // 
            // textBoxMessageCode
            // 
            this.textBoxMessageCode.Location = new System.Drawing.Point(99, 22);
            this.textBoxMessageCode.Name = "textBoxMessageCode";
            this.textBoxMessageCode.ReadOnly = true;
            this.textBoxMessageCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxMessageCode.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.textBoxMessageCode, "Selected message code");
            // 
            // labelMessageCode
            // 
            this.labelMessageCode.AutoSize = true;
            this.labelMessageCode.Location = new System.Drawing.Point(12, 25);
            this.labelMessageCode.Name = "labelMessageCode";
            this.labelMessageCode.Size = new System.Drawing.Size(81, 13);
            this.labelMessageCode.TabIndex = 0;
            this.labelMessageCode.Text = "Message Code:";
            // 
            // automaticUpdater
            // 
            this.automaticUpdater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.automaticUpdater.ContainerForm = this;
            this.automaticUpdater.Location = new System.Drawing.Point(1266, 6);
            this.automaticUpdater.Name = "automaticUpdater";
            this.automaticUpdater.Size = new System.Drawing.Size(16, 16);
            this.automaticUpdater.TabIndex = 8;
            this.automaticUpdater.ToolStripItem = this.checkForUpdatesToolStripMenuItem;
            this.automaticUpdater.wyUpdateCommandline = null;
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Image = global::SiebelLogAnalyser.Properties.Resources.LOGAN_application_update_16;
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates...";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(1294, 24);
            this.menuStripMain.TabIndex = 9;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.selectFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = global::SiebelLogAnalyser.Properties.Resources.LOGAN_document_text_import_16;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // selectFolderToolStripMenuItem
            // 
            this.selectFolderToolStripMenuItem.Enabled = false;
            this.selectFolderToolStripMenuItem.Image = global::SiebelLogAnalyser.Properties.Resources.LOGAN_folder_open_16;
            this.selectFolderToolStripMenuItem.Name = "selectFolderToolStripMenuItem";
            this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.selectFolderToolStripMenuItem.Text = "Select Folder...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SiebelLogAnalyser.Properties.Resources.LOGAN_close_window_16;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp,
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Image = global::SiebelLogAnalyser.Properties.Resources.LOGAN_help2_16;
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemHelp.Text = "Help...";
            this.toolStripMenuItemHelp.Click += new System.EventHandler(this.toolStripMenuItemHelp_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::SiebelLogAnalyser.Properties.Resources.LOGAN_NEWCASE_info_16;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.Location = new System.Drawing.Point(0, 27);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerResults);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.groupBoxLog);
            this.splitContainerMain.Size = new System.Drawing.Size(1284, 715);
            this.splitContainerMain.SplitterDistance = 655;
            this.splitContainerMain.TabIndex = 10;
            // 
            // splitContainerResults
            // 
            this.splitContainerResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerResults.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerResults.Location = new System.Drawing.Point(4, 4);
            this.splitContainerResults.Name = "splitContainerResults";
            this.splitContainerResults.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerResults.Panel1
            // 
            this.splitContainerResults.Panel1.Controls.Add(this.groupBoxSource);
            // 
            // splitContainerResults.Panel2
            // 
            this.splitContainerResults.Panel2.Controls.Add(this.groupBoxMessageDetail);
            this.splitContainerResults.Size = new System.Drawing.Size(648, 706);
            this.splitContainerResults.SplitterDistance = 515;
            this.splitContainerResults.TabIndex = 0;
            // 
            // backgroundWorkerAnalyse
            // 
            this.backgroundWorkerAnalyse.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAnalyse_DoWork);
            this.backgroundWorkerAnalyse.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAnalyse_RunWorkerCompleted);
            // 
            // FormSiebelLogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 749);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.automaticUpdater);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormSiebelLogViewer";
            this.Text = "Siebel Log Analyser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewMessages)).EndInit();
            this.groupBoxSource.ResumeLayout(false);
            this.groupBoxSource.PerformLayout();
            this.groupBoxLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewLogFile)).EndInit();
            this.groupBoxMessageDetail.ResumeLayout(false);
            this.groupBoxMessageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerResults.Panel1.ResumeLayout(false);
            this.splitContainerResults.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerResults)).EndInit();
            this.splitContainerResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogPath;
        private System.Windows.Forms.Button buttonLogFile;
        private System.Windows.Forms.Button buttonLogFolder;
        private System.Windows.Forms.GroupBox groupBoxSource;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.GroupBox groupBoxMessageDetail;
        private wyDay.Controls.AutomaticUpdater automaticUpdater;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLogFolder;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerResults;
        private BrightIdeasSoftware.OLVColumn olvColumnFileName;
        private BrightIdeasSoftware.OLVColumn olvColumnLineNumber;
        private BrightIdeasSoftware.OLVColumn olvColumnComponentName;
        private BrightIdeasSoftware.OLVColumn olvColumnEventName;
        private BrightIdeasSoftware.OLVColumn olvColumnErrorLevel;
        private BrightIdeasSoftware.OLVColumn olvColumnMessageDate;
        private BrightIdeasSoftware.OLVColumn olvColumnMessageCode;
        private BrightIdeasSoftware.OLVColumn olvColumnMessageText;
        private System.Windows.Forms.TextBox textBoxMessageCode;
        private System.Windows.Forms.Label labelMessageCode;
        private System.Windows.Forms.TextBox textBoxOracleDefinition;
        private System.Windows.Forms.Label labelSuggestedAction;
        private System.Windows.Forms.Label labelOracleDefinition;
        private System.Windows.Forms.TextBox textBoxSuggestedAction;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAnalyse;
        private BrightIdeasSoftware.FastObjectListView fastObjectListViewMessages;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private BrightIdeasSoftware.FastObjectListView fastObjectListViewLogFile;
        private BrightIdeasSoftware.OLVColumn olvColumnLogFileLineNumber;
        private BrightIdeasSoftware.OLVColumn olvColumnLogFileLine;
        private System.Windows.Forms.TextBox textBoxMessageText;
        private System.Windows.Forms.Label labelMessageTExt;
    }
}

