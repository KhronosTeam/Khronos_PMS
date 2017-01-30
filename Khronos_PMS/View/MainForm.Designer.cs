using Khronos_PMS.Util;

namespace Khronos_PMS.View {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.workerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.leftTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.projectsListView = new BrightIdeasSoftware.DataListView();
            this.projectName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.projectsSearchButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.workersListView = new BrightIdeasSoftware.DataListView();
            this.workersSearchButton = new System.Windows.Forms.Button();
            this.rightTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.projectDescriptionLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.projectStatusToolStrip = new System.Windows.Forms.ToolStrip();
            this.projectStatusMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bossNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.projectRoleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.unitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.unitsTreeView = new BrightIdeasSoftware.TreeListView();
            this.unitName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.unitStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.unitPriority = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.unitDueDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.unitEstimatedManhours = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.unitSpentManhours = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.unitExpense = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.addNewUnitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.unitsSearchButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.unitEstimatedManhoursLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.unitDueDateLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.unitSpentManhoursLabel = new System.Windows.Forms.Label();
            this.assigneesListView = new BrightIdeasSoftware.DataListView();
            this.assigneeName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.unitNameLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.unitStatusMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.unitPriorityMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.sfasidofjiaosdj = new System.Windows.Forms.ToolStrip();
            this.userLabel = new System.Windows.Forms.ToolStripDropDownButton();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsSearchTextbox = new Khronos_PMS.View.CustomControls.PromptTextBox();
            this.workersSearchTextBox = new Khronos_PMS.View.CustomControls.PromptTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.promptTextBox3 = new Khronos_PMS.View.CustomControls.PromptTextBox();
            this.unitsSearchTextBox = new Khronos_PMS.View.CustomControls.PromptTextBox();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veryHighToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veryLowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.leftTableLayout.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsListView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersListView)).BeginInit();
            this.rightTableLayout.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.projectStatusToolStrip.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.unitTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsTreeView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assigneesListView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.sfasidofjiaosdj.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerName
            // 
            this.workerName.AspectName = "FullName";
            this.workerName.AutoCompleteEditor = false;
            this.workerName.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.workerName.Groupable = false;
            this.workerName.Hideable = false;
            this.workerName.ImageAspectName = "add_user";
            this.workerName.IsEditable = false;
            this.workerName.Text = "Full name";
            this.workerName.Width = 245;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.refrshToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unitToolStripMenuItem});
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // unitToolStripMenuItem
            // 
            this.unitToolStripMenuItem.Name = "unitToolStripMenuItem";
            this.unitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.unitToolStripMenuItem.Text = "Unit";
            this.unitToolStripMenuItem.Click += new System.EventHandler(this.unitToolStripMenuItem_Click);
            // 
            // refrshToolStripMenuItem
            // 
            this.refrshToolStripMenuItem.Name = "refrshToolStripMenuItem";
            this.refrshToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.refrshToolStripMenuItem.Text = "Refresh";
            this.refrshToolStripMenuItem.Click += new System.EventHandler(this.refrshToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectStatusToolStripMenuItem,
            this.financialReportToolStripMenuItem,
            this.activitiesReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // projectStatusToolStripMenuItem
            // 
            this.projectStatusToolStripMenuItem.Image = global::Khronos_PMS.Properties.Resources.project_report;
            this.projectStatusToolStripMenuItem.Name = "projectStatusToolStripMenuItem";
            this.projectStatusToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.projectStatusToolStripMenuItem.Text = "Project report";
            // 
            // financialReportToolStripMenuItem
            // 
            this.financialReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("financialReportToolStripMenuItem.Image")));
            this.financialReportToolStripMenuItem.Name = "financialReportToolStripMenuItem";
            this.financialReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.financialReportToolStripMenuItem.Text = "Financial report";
            // 
            // activitiesReportToolStripMenuItem
            // 
            this.activitiesReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("activitiesReportToolStripMenuItem.Image")));
            this.activitiesReportToolStripMenuItem.Name = "activitiesReportToolStripMenuItem";
            this.activitiesReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.activitiesReportToolStripMenuItem.Text = "Activities report";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(113, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.leftTableLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rightTableLayout, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 388);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // leftTableLayout
            // 
            this.leftTableLayout.ColumnCount = 1;
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftTableLayout.Controls.Add(this.groupBox1, 0, 0);
            this.leftTableLayout.Controls.Add(this.groupBox2, 0, 1);
            this.leftTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTableLayout.Location = new System.Drawing.Point(3, 3);
            this.leftTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.leftTableLayout.Name = "leftTableLayout";
            this.leftTableLayout.RowCount = 2;
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftTableLayout.Size = new System.Drawing.Size(268, 377);
            this.leftTableLayout.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.projectsListView);
            this.groupBox1.Controls.Add(this.projectsSearchTextbox);
            this.groupBox1.Controls.Add(this.projectsSearchButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projects";
            // 
            // projectsListView
            // 
            this.projectsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.projectsListView.AllColumns.Add(this.projectName);
            this.projectsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectsListView.AutoGenerateColumns = false;
            this.projectsListView.CellEditUseWholeCell = false;
            this.projectsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projectName});
            this.projectsListView.DataSource = null;
            this.projectsListView.FullRowSelect = true;
            this.projectsListView.GridLines = true;
            this.projectsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.projectsListView.HideSelection = false;
            this.projectsListView.Location = new System.Drawing.Point(7, 49);
            this.projectsListView.MultiSelect = false;
            this.projectsListView.Name = "projectsListView";
            this.projectsListView.Scrollable = false;
            this.projectsListView.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.projectsListView.SelectedForeColor = System.Drawing.Color.Black;
            this.projectsListView.ShowGroups = false;
            this.projectsListView.Size = new System.Drawing.Size(249, 128);
            this.projectsListView.SmallImageList = this.largeImageList;
            this.projectsListView.TabIndex = 6;
            this.projectsListView.UnfocusedSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.projectsListView.UseCompatibleStateImageBehavior = false;
            this.projectsListView.View = System.Windows.Forms.View.Details;
            this.projectsListView.SelectionChanged += new System.EventHandler(this.projectsListView_SelectionChanged);
            // 
            // projectName
            // 
            this.projectName.AspectName = "Name";
            this.projectName.AutoCompleteEditor = false;
            this.projectName.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.projectName.Groupable = false;
            this.projectName.Hideable = false;
            this.projectName.ImageAspectName = "project";
            this.projectName.IsEditable = false;
            this.projectName.Text = "Name";
            this.projectName.Width = 245;
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "project_30_30.png");
            this.largeImageList.Images.SetKeyName(1, "user_30_30.png");
            this.largeImageList.Images.SetKeyName(2, "unit_active_30x30.png");
            this.largeImageList.Images.SetKeyName(3, "unit_in_progress_30x30.png");
            this.largeImageList.Images.SetKeyName(4, "unit_paused_30x30.png");
            this.largeImageList.Images.SetKeyName(5, "unit_completed_30x30.png");
            this.largeImageList.Images.SetKeyName(6, "calendar_30x30.png");
            this.largeImageList.Images.SetKeyName(7, "status_active_30x30.png");
            this.largeImageList.Images.SetKeyName(8, "status_in_progress_30x30.png");
            this.largeImageList.Images.SetKeyName(9, "status_paused_30x30.png");
            this.largeImageList.Images.SetKeyName(10, "status_completed_30x30.png");
            this.largeImageList.Images.SetKeyName(11, "priority_none_30x30.png");
            this.largeImageList.Images.SetKeyName(12, "priority_very_low_30x30.png");
            this.largeImageList.Images.SetKeyName(13, "priority_low_30x30.png");
            this.largeImageList.Images.SetKeyName(14, "priority_medium_30x30.png");
            this.largeImageList.Images.SetKeyName(15, "priority_high_30x30.png");
            this.largeImageList.Images.SetKeyName(16, "priority_very_high_30x30.png");
            this.largeImageList.Images.SetKeyName(17, "clock_30x30.png");
            this.largeImageList.Images.SetKeyName(18, "dollar_30x30.png");
            // 
            // projectsSearchButton
            // 
            this.projectsSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("projectsSearchButton.Image")));
            this.projectsSearchButton.Location = new System.Drawing.Point(216, 20);
            this.projectsSearchButton.Name = "projectsSearchButton";
            this.projectsSearchButton.Size = new System.Drawing.Size(40, 23);
            this.projectsSearchButton.TabIndex = 2;
            this.projectsSearchButton.UseVisualStyleBackColor = true;
            this.projectsSearchButton.Click += new System.EventHandler(this.projectsSearchButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.workersListView);
            this.groupBox2.Controls.Add(this.workersSearchTextBox);
            this.groupBox2.Controls.Add(this.workersSearchButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(3, 188);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Workers";
            // 
            // workersListView
            // 
            this.workersListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.workersListView.AllColumns.Add(this.workerName);
            this.workersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workersListView.AutoGenerateColumns = false;
            this.workersListView.CellEditUseWholeCell = false;
            this.workersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.workerName});
            this.workersListView.DataSource = null;
            this.workersListView.FullRowSelect = true;
            this.workersListView.GridLines = true;
            this.workersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.workersListView.Location = new System.Drawing.Point(7, 48);
            this.workersListView.MultiSelect = false;
            this.workersListView.Name = "workersListView";
            this.workersListView.Scrollable = false;
            this.workersListView.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.workersListView.SelectedForeColor = System.Drawing.Color.Black;
            this.workersListView.ShowGroups = false;
            this.workersListView.Size = new System.Drawing.Size(249, 135);
            this.workersListView.SmallImageList = this.largeImageList;
            this.workersListView.TabIndex = 5;
            this.workersListView.UnfocusedSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.workersListView.UseCompatibleStateImageBehavior = false;
            this.workersListView.View = System.Windows.Forms.View.Details;
            // 
            // workersSearchButton
            // 
            this.workersSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("workersSearchButton.Image")));
            this.workersSearchButton.Location = new System.Drawing.Point(216, 19);
            this.workersSearchButton.Name = "workersSearchButton";
            this.workersSearchButton.Size = new System.Drawing.Size(40, 23);
            this.workersSearchButton.TabIndex = 5;
            this.workersSearchButton.UseVisualStyleBackColor = true;
            this.workersSearchButton.Click += new System.EventHandler(this.workersSearchButton_Click);
            // 
            // rightTableLayout
            // 
            this.rightTableLayout.ColumnCount = 2;
            this.rightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.rightTableLayout.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.rightTableLayout.Controls.Add(this.groupBox5, 1, 0);
            this.rightTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightTableLayout.Location = new System.Drawing.Point(271, 3);
            this.rightTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.rightTableLayout.Name = "rightTableLayout";
            this.rightTableLayout.RowCount = 1;
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightTableLayout.Size = new System.Drawing.Size(744, 377);
            this.rightTableLayout.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(429, 377);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.projectDescriptionLabel);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.projectStatusToolStrip);
            this.groupBox3.Controls.Add(this.expenseLabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.budgetLabel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.bossNameLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.endDateLabel);
            this.groupBox3.Controls.Add(this.startDateLabel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.projectRoleLabel);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.projectNameLabel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 177);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Project info";
            // 
            // projectDescriptionLabel
            // 
            this.projectDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectDescriptionLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.projectDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectDescriptionLabel.Location = new System.Drawing.Point(6, 62);
            this.projectDescriptionLabel.Name = "projectDescriptionLabel";
            this.projectDescriptionLabel.Size = new System.Drawing.Size(411, 55);
            this.projectDescriptionLabel.TabIndex = 28;
            this.projectDescriptionLabel.Text = "Here goes project description.";
            // 
            // label15
            // 
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(7, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 20);
            this.label15.TabIndex = 27;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(7, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 20);
            this.label14.TabIndex = 26;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // projectStatusToolStrip
            // 
            this.projectStatusToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.projectStatusToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.projectStatusToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.projectStatusToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectStatusMenuButton});
            this.projectStatusToolStrip.Location = new System.Drawing.Point(9, 17);
            this.projectStatusToolStrip.Name = "projectStatusToolStrip";
            this.projectStatusToolStrip.Size = new System.Drawing.Size(35, 25);
            this.projectStatusToolStrip.TabIndex = 17;
            this.projectStatusToolStrip.Text = "toolStrip2";
            // 
            // projectStatusMenuButton
            // 
            this.projectStatusMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.projectStatusMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.projectStatusMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("projectStatusMenuButton.Image")));
            this.projectStatusMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.projectStatusMenuButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.projectStatusMenuButton.Name = "projectStatusMenuButton";
            this.projectStatusMenuButton.Size = new System.Drawing.Size(29, 22);
            this.projectStatusMenuButton.Text = "Status";
            this.projectStatusMenuButton.ToolTipText = "Project status";
            // 
            // expenseLabel
            // 
            this.expenseLabel.AutoSize = true;
            this.expenseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.expenseLabel.Location = new System.Drawing.Point(231, 149);
            this.expenseLabel.Name = "expenseLabel";
            this.expenseLabel.Size = new System.Drawing.Size(67, 15);
            this.expenseLabel.TabIndex = 16;
            this.expenseLabel.Text = "10 000 KM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(175, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Expense:";
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.budgetLabel.Location = new System.Drawing.Point(230, 125);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(67, 15);
            this.budgetLabel.TabIndex = 13;
            this.budgetLabel.Text = "15 000 KM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label9.Location = new System.Drawing.Point(175, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Budget:";
            // 
            // bossNameLabel
            // 
            this.bossNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bossNameLabel.AutoSize = true;
            this.bossNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bossNameLabel.Location = new System.Drawing.Point(291, 43);
            this.bossNameLabel.Name = "bossNameLabel";
            this.bossNameLabel.Size = new System.Drawing.Size(109, 15);
            this.bossNameLabel.TabIndex = 10;
            this.bossNameLabel.Text = "Project boss name";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(257, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Boss:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.endDateLabel.Location = new System.Drawing.Point(87, 149);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(72, 15);
            this.endDateLabel.TabIndex = 8;
            this.endDateLabel.Text = "28.01.2017.";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.startDateLabel.Location = new System.Drawing.Point(87, 125);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(72, 15);
            this.startDateLabel.TabIndex = 7;
            this.startDateLabel.Text = "21.01.2017.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(27, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Deadline:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(27, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // projectRoleLabel
            // 
            this.projectRoleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectRoleLabel.AutoSize = true;
            this.projectRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.projectRoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.projectRoleLabel.Location = new System.Drawing.Point(326, 20);
            this.projectRoleLabel.Name = "projectRoleLabel";
            this.projectRoleLabel.Size = new System.Drawing.Size(43, 18);
            this.projectRoleLabel.TabIndex = 2;
            this.projectRoleLabel.Text = "Role";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(257, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your role:";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.projectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.projectNameLabel.Location = new System.Drawing.Point(55, 19);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(108, 18);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Project name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.unitTableLayoutPanel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Location = new System.Drawing.Point(3, 180);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 197);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Units";
            // 
            // unitTableLayoutPanel
            // 
            this.unitTableLayoutPanel.ColumnCount = 1;
            this.unitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.unitTableLayoutPanel.Controls.Add(this.unitsTreeView, 0, 2);
            this.unitTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.unitTableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.unitTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitTableLayoutPanel.Location = new System.Drawing.Point(3, 17);
            this.unitTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.unitTableLayoutPanel.Name = "unitTableLayoutPanel";
            this.unitTableLayoutPanel.RowCount = 3;
            this.unitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.unitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.unitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.unitTableLayoutPanel.Size = new System.Drawing.Size(417, 177);
            this.unitTableLayoutPanel.TabIndex = 0;
            // 
            // unitsTreeView
            // 
            this.unitsTreeView.AllColumns.Add(this.unitName);
            this.unitsTreeView.AllColumns.Add(this.unitStatus);
            this.unitsTreeView.AllColumns.Add(this.unitPriority);
            this.unitsTreeView.AllColumns.Add(this.unitDueDate);
            this.unitsTreeView.AllColumns.Add(this.unitEstimatedManhours);
            this.unitsTreeView.AllColumns.Add(this.unitSpentManhours);
            this.unitsTreeView.AllColumns.Add(this.unitExpense);
            this.unitsTreeView.CellEditUseWholeCell = false;
            this.unitsTreeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.unitName,
            this.unitStatus,
            this.unitPriority,
            this.unitDueDate,
            this.unitEstimatedManhours,
            this.unitSpentManhours,
            this.unitExpense});
            this.unitsTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.unitsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsTreeView.FullRowSelect = true;
            this.unitsTreeView.GridLines = true;
            this.unitsTreeView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.unitsTreeView.HideSelection = false;
            this.unitsTreeView.Location = new System.Drawing.Point(3, 63);
            this.unitsTreeView.MultiSelect = false;
            this.unitsTreeView.Name = "unitsTreeView";
            this.unitsTreeView.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.unitsTreeView.SelectedForeColor = System.Drawing.Color.Black;
            this.unitsTreeView.ShowGroups = false;
            this.unitsTreeView.Size = new System.Drawing.Size(411, 111);
            this.unitsTreeView.SmallImageList = this.largeImageList;
            this.unitsTreeView.TabIndex = 29;
            this.unitsTreeView.UnfocusedSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.unitsTreeView.UseCompatibleStateImageBehavior = false;
            this.unitsTreeView.View = System.Windows.Forms.View.Details;
            this.unitsTreeView.VirtualMode = true;
            this.unitsTreeView.SelectionChanged += new System.EventHandler(this.unitsTreeView_SelectionChanged);
            // 
            // unitName
            // 
            this.unitName.AspectName = "Name";
            this.unitName.FillsFreeSpace = true;
            this.unitName.Groupable = false;
            this.unitName.IsEditable = false;
            this.unitName.MinimumWidth = 200;
            this.unitName.Text = "Name";
            this.unitName.Width = 209;
            // 
            // unitStatus
            // 
            this.unitStatus.AspectName = "Status";
            this.unitStatus.Groupable = false;
            this.unitStatus.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitStatus.IsEditable = false;
            this.unitStatus.MaximumWidth = 100;
            this.unitStatus.MinimumWidth = 100;
            this.unitStatus.Text = "Status";
            this.unitStatus.Width = 100;
            // 
            // unitPriority
            // 
            this.unitPriority.AspectName = "Priority";
            this.unitPriority.Groupable = false;
            this.unitPriority.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitPriority.IsEditable = false;
            this.unitPriority.MaximumWidth = 100;
            this.unitPriority.MinimumWidth = 100;
            this.unitPriority.Text = "Priority";
            this.unitPriority.Width = 100;
            // 
            // unitDueDate
            // 
            this.unitDueDate.AspectName = "DueDate";
            this.unitDueDate.Groupable = false;
            this.unitDueDate.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitDueDate.IsEditable = false;
            this.unitDueDate.MaximumWidth = 110;
            this.unitDueDate.MinimumWidth = 110;
            this.unitDueDate.Text = "Due date";
            this.unitDueDate.Width = 110;
            // 
            // unitEstimatedManhours
            // 
            this.unitEstimatedManhours.AspectName = "EstManhours";
            this.unitEstimatedManhours.AspectToStringFormat = "{0} h";
            this.unitEstimatedManhours.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitEstimatedManhours.MaximumWidth = 100;
            this.unitEstimatedManhours.MinimumWidth = 100;
            this.unitEstimatedManhours.Text = "Est man-hours";
            this.unitEstimatedManhours.Width = 100;
            // 
            // unitSpentManhours
            // 
            this.unitSpentManhours.AspectName = "SpentManhours";
            this.unitSpentManhours.AspectToStringFormat = "{0} h";
            this.unitSpentManhours.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitSpentManhours.MaximumWidth = 110;
            this.unitSpentManhours.MinimumWidth = 110;
            this.unitSpentManhours.Text = "Spent man-hours";
            this.unitSpentManhours.Width = 110;
            // 
            // unitExpense
            // 
            this.unitExpense.AspectName = "Expense";
            this.unitExpense.AspectToStringFormat = "{0:0.00}";
            this.unitExpense.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitExpense.MaximumWidth = 200;
            this.unitExpense.MinimumWidth = 120;
            this.unitExpense.Text = "Expense (KM)";
            this.unitExpense.Width = 120;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.Controls.Add(this.promptTextBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.addNewUnitButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(417, 30);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // addNewUnitButton
            // 
            this.addNewUnitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNewUnitButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewUnitButton.Image")));
            this.addNewUnitButton.Location = new System.Drawing.Point(375, 3);
            this.addNewUnitButton.Name = "addNewUnitButton";
            this.addNewUnitButton.Size = new System.Drawing.Size(39, 24);
            this.addNewUnitButton.TabIndex = 9;
            this.addNewUnitButton.UseVisualStyleBackColor = true;
            this.addNewUnitButton.Click += new System.EventHandler(this.addNewUnitButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.Controls.Add(this.unitsSearchTextBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.unitsSearchButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(417, 30);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // unitsSearchButton
            // 
            this.unitsSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("unitsSearchButton.Image")));
            this.unitsSearchButton.Location = new System.Drawing.Point(375, 3);
            this.unitsSearchButton.Name = "unitsSearchButton";
            this.unitsSearchButton.Size = new System.Drawing.Size(39, 24);
            this.unitsSearchButton.TabIndex = 7;
            this.unitsSearchButton.UseVisualStyleBackColor = true;
            this.unitsSearchButton.Click += new System.EventHandler(this.unitsSearchButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel2);
            this.groupBox5.Controls.Add(this.unitNameLabel);
            this.groupBox5.Controls.Add(this.toolStrip1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox5.Location = new System.Drawing.Point(432, 3);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(309, 374);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Unit info";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.62816F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.37184F));
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.unitEstimatedManhoursLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label18, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.unitDueDateLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.unitSpentManhoursLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.assigneesListView, 2, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(297, 152);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 25);
            this.label17.TabIndex = 26;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitEstimatedManhoursLabel
            // 
            this.unitEstimatedManhoursLabel.AutoSize = true;
            this.unitEstimatedManhoursLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitEstimatedManhoursLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.unitEstimatedManhoursLabel.Location = new System.Drawing.Point(130, 0);
            this.unitEstimatedManhoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.unitEstimatedManhoursLabel.Name = "unitEstimatedManhoursLabel";
            this.unitEstimatedManhoursLabel.Size = new System.Drawing.Size(167, 25);
            this.unitEstimatedManhoursLabel.TabIndex = 27;
            this.unitEstimatedManhoursLabel.Text = "400h";
            this.unitEstimatedManhoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label18.Location = new System.Drawing.Point(25, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 25);
            this.label18.TabIndex = 25;
            this.label18.Text = "Est man-hours:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(0, 75);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 25);
            this.label12.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(25, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Assignees:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(0, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 25);
            this.label10.TabIndex = 22;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label11.Location = new System.Drawing.Point(25, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Due date:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitDueDateLabel
            // 
            this.unitDueDateLabel.AutoSize = true;
            this.unitDueDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitDueDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.unitDueDateLabel.Location = new System.Drawing.Point(130, 50);
            this.unitDueDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.unitDueDateLabel.Name = "unitDueDateLabel";
            this.unitDueDateLabel.Size = new System.Drawing.Size(167, 25);
            this.unitDueDateLabel.TabIndex = 28;
            this.unitDueDateLabel.Text = "25.02.2017.";
            this.unitDueDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(0, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 29;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(25, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Spent man-hours:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitSpentManhoursLabel
            // 
            this.unitSpentManhoursLabel.AutoSize = true;
            this.unitSpentManhoursLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitSpentManhoursLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.unitSpentManhoursLabel.Location = new System.Drawing.Point(130, 25);
            this.unitSpentManhoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.unitSpentManhoursLabel.Name = "unitSpentManhoursLabel";
            this.unitSpentManhoursLabel.Size = new System.Drawing.Size(167, 25);
            this.unitSpentManhoursLabel.TabIndex = 31;
            this.unitSpentManhoursLabel.Text = "0h";
            this.unitSpentManhoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // assigneesListView
            // 
            this.assigneesListView.AllColumns.Add(this.assigneeName);
            this.assigneesListView.AutoGenerateColumns = false;
            this.assigneesListView.BackColor = System.Drawing.SystemColors.Control;
            this.assigneesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assigneesListView.CellEditUseWholeCell = false;
            this.assigneesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.assigneeName});
            this.assigneesListView.DataSource = null;
            this.assigneesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assigneesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.assigneesListView.Location = new System.Drawing.Point(133, 78);
            this.assigneesListView.MultiSelect = false;
            this.assigneesListView.Name = "assigneesListView";
            this.assigneesListView.ShowGroups = false;
            this.assigneesListView.Size = new System.Drawing.Size(161, 71);
            this.assigneesListView.SmallImageList = this.smallImageList;
            this.assigneesListView.TabIndex = 32;
            this.assigneesListView.UseCompatibleStateImageBehavior = false;
            this.assigneesListView.View = System.Windows.Forms.View.Details;
            // 
            // assigneeName
            // 
            this.assigneeName.AspectName = "FullName";
            this.assigneeName.FillsFreeSpace = true;
            this.assigneeName.Text = "Assignees";
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "add_user.png");
            this.smallImageList.Images.SetKeyName(1, "project.png");
            // 
            // unitNameLabel
            // 
            this.unitNameLabel.AutoSize = true;
            this.unitNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unitNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.unitNameLabel.Location = new System.Drawing.Point(6, 46);
            this.unitNameLabel.Name = "unitNameLabel";
            this.unitNameLabel.Size = new System.Drawing.Size(84, 18);
            this.unitNameLabel.TabIndex = 12;
            this.unitNameLabel.Text = "Unit name";
            this.unitNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unitStatusMenuButton,
            this.unitPriorityMenuButton,
            this.toolStripButton1,
            this.toolStripSeparator6,
            this.toolStripSplitButton1,
            this.toolStripSplitButton3,
            this.toolStripSeparator7});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(303, 27);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // unitStatusMenuButton
            // 
            this.unitStatusMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unitStatusMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem,
            this.inProgressToolStripMenuItem,
            this.pausedToolStripMenuItem,
            this.completedToolStripMenuItem});
            this.unitStatusMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("unitStatusMenuButton.Image")));
            this.unitStatusMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.unitStatusMenuButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.unitStatusMenuButton.Name = "unitStatusMenuButton";
            this.unitStatusMenuButton.Size = new System.Drawing.Size(29, 24);
            this.unitStatusMenuButton.Text = "Status";
            // 
            // unitPriorityMenuButton
            // 
            this.unitPriorityMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unitPriorityMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veryHighToolStripMenuItem,
            this.highToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.lowToolStripMenuItem,
            this.veryLowToolStripMenuItem,
            this.noneToolStripMenuItem});
            this.unitPriorityMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("unitPriorityMenuButton.Image")));
            this.unitPriorityMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.unitPriorityMenuButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.unitPriorityMenuButton.Name = "unitPriorityMenuButton";
            this.unitPriorityMenuButton.Size = new System.Drawing.Size(29, 24);
            this.unitPriorityMenuButton.Text = "Priority";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Close";
            this.toolStripButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.viewAllToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(84, 24);
            this.toolStripSplitButton1.Text = "Activities";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem1.Text = "Add";
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewAllToolStripMenuItem.Image")));
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.viewAllToolStripMenuItem.Text = "View all";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(88, 24);
            this.toolStripSplitButton3.Text = "Assignees";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem7.Text = "Add";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem8.Text = "View all";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // sfasidofjiaosdj
            // 
            this.sfasidofjiaosdj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfasidofjiaosdj.AutoSize = false;
            this.sfasidofjiaosdj.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sfasidofjiaosdj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sfasidofjiaosdj.Dock = System.Windows.Forms.DockStyle.None;
            this.sfasidofjiaosdj.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sfasidofjiaosdj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userLabel});
            this.sfasidofjiaosdj.Location = new System.Drawing.Point(883, 0);
            this.sfasidofjiaosdj.Name = "sfasidofjiaosdj";
            this.sfasidofjiaosdj.Size = new System.Drawing.Size(134, 24);
            this.sfasidofjiaosdj.TabIndex = 2;
            this.sfasidofjiaosdj.Text = "toolStrip2";
            // 
            // userLabel
            // 
            this.userLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.userLabel.Image = ((System.Drawing.Image)(resources.GetObject("userLabel.Image")));
            this.userLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userLabel.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(92, 21);
            this.userLabel.Text = "User name";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // projectsSearchTextbox
            // 
            this.projectsSearchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectsSearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.projectsSearchTextbox.Location = new System.Drawing.Point(7, 21);
            this.projectsSearchTextbox.Multiline = true;
            this.projectsSearchTextbox.Name = "projectsSearchTextbox";
            this.projectsSearchTextbox.Size = new System.Drawing.Size(203, 21);
            this.projectsSearchTextbox.TabIndex = 3;
            this.projectsSearchTextbox.WaterMarkColor = System.Drawing.Color.Gray;
            this.projectsSearchTextbox.WaterMarkText = "Search projects";
            this.projectsSearchTextbox.TextChanged += new System.EventHandler(this.projectsSearchTextbox_TextChanged);
            // 
            // workersSearchTextBox
            // 
            this.workersSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workersSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.workersSearchTextBox.Location = new System.Drawing.Point(7, 20);
            this.workersSearchTextBox.Multiline = true;
            this.workersSearchTextBox.Name = "workersSearchTextBox";
            this.workersSearchTextBox.Size = new System.Drawing.Size(203, 21);
            this.workersSearchTextBox.TabIndex = 4;
            this.workersSearchTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.workersSearchTextBox.WaterMarkText = "Search workers";
            this.workersSearchTextBox.TextChanged += new System.EventHandler(this.workersSearchTextBox_TextChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem1.Tag = Khronos_PMS.Util.Status.ACTIVE;
            this.toolStripMenuItem1.Text = "Active";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem2.Tag = Khronos_PMS.Util.Status.IN_PROGRESS;
            this.toolStripMenuItem2.Text = "In progress";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem3.Tag = Khronos_PMS.Util.Status.PAUSED;
            this.toolStripMenuItem3.Text = "Paused";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem4.Tag = Khronos_PMS.Util.Status.COMPLETED;
            this.toolStripMenuItem4.Text = "Completed";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // promptTextBox3
            // 
            this.promptTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promptTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.promptTextBox3.Location = new System.Drawing.Point(3, 4);
            this.promptTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promptTextBox3.Multiline = true;
            this.promptTextBox3.Name = "promptTextBox3";
            this.promptTextBox3.Size = new System.Drawing.Size(366, 22);
            this.promptTextBox3.TabIndex = 8;
            this.promptTextBox3.WaterMarkColor = System.Drawing.Color.Gray;
            this.promptTextBox3.WaterMarkText = "Type here to add new unit...";
            // 
            // unitsSearchTextBox
            // 
            this.unitsSearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.unitsSearchTextBox.Location = new System.Drawing.Point(3, 4);
            this.unitsSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unitsSearchTextBox.Multiline = true;
            this.unitsSearchTextBox.Name = "unitsSearchTextBox";
            this.unitsSearchTextBox.Size = new System.Drawing.Size(366, 22);
            this.unitsSearchTextBox.TabIndex = 6;
            this.unitsSearchTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.unitsSearchTextBox.WaterMarkText = "Search units";
            this.unitsSearchTextBox.TextChanged += new System.EventHandler(this.searchUnitsTextBox_TextChanged);
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("activeToolStripMenuItem.Image")));
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.activeToolStripMenuItem.Tag = Khronos_PMS.Util.Status.ACTIVE;
            this.activeToolStripMenuItem.Text = "Active";
            this.activeToolStripMenuItem.Click += new System.EventHandler(this.unitStatusToolStripMenuItem_Click);
            // 
            // inProgressToolStripMenuItem
            // 
            this.inProgressToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inProgressToolStripMenuItem.Image")));
            this.inProgressToolStripMenuItem.Name = "inProgressToolStripMenuItem";
            this.inProgressToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.inProgressToolStripMenuItem.Tag = Khronos_PMS.Util.Status.IN_PROGRESS;
            this.inProgressToolStripMenuItem.Text = "In progress";
            this.inProgressToolStripMenuItem.Click += new System.EventHandler(this.unitStatusToolStripMenuItem_Click);
            // 
            // pausedToolStripMenuItem
            // 
            this.pausedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pausedToolStripMenuItem.Image")));
            this.pausedToolStripMenuItem.Name = "pausedToolStripMenuItem";
            this.pausedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.pausedToolStripMenuItem.Tag = Khronos_PMS.Util.Status.PAUSED;
            this.pausedToolStripMenuItem.Text = "Paused";
            this.pausedToolStripMenuItem.Click += new System.EventHandler(this.unitStatusToolStripMenuItem_Click);
            // 
            // completedToolStripMenuItem
            // 
            this.completedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("completedToolStripMenuItem.Image")));
            this.completedToolStripMenuItem.Name = "completedToolStripMenuItem";
            this.completedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.completedToolStripMenuItem.Tag = Khronos_PMS.Util.Status.COMPLETED;
            this.completedToolStripMenuItem.Text = "Completed";
            this.completedToolStripMenuItem.Click += new System.EventHandler(this.unitStatusToolStripMenuItem_Click);
            // 
            // veryHighToolStripMenuItem
            // 
            this.veryHighToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("veryHighToolStripMenuItem.Image")));
            this.veryHighToolStripMenuItem.Name = "veryHighToolStripMenuItem";
            this.veryHighToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.veryHighToolStripMenuItem.Tag = Khronos_PMS.Util.Priority.VERY_HIGH;
            this.veryHighToolStripMenuItem.Text = "Very high";
            this.veryHighToolStripMenuItem.Click += new System.EventHandler(this.unitPriorityToolStripMenuItem_Click);
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("highToolStripMenuItem.Image")));
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.highToolStripMenuItem.Tag = Khronos_PMS.Util.Priority.HIGH;
            this.highToolStripMenuItem.Text = "High";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.unitPriorityToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mediumToolStripMenuItem.Image")));
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mediumToolStripMenuItem.Tag = Khronos_PMS.Util.Priority.MEDIUM;
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.unitPriorityToolStripMenuItem_Click);
            // 
            // lowToolStripMenuItem
            // 
            this.lowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lowToolStripMenuItem.Image")));
            this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
            this.lowToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.lowToolStripMenuItem.Tag = Khronos_PMS.Util.Priority.LOW;
            this.lowToolStripMenuItem.Text = "Low";
            this.lowToolStripMenuItem.Click += new System.EventHandler(this.unitPriorityToolStripMenuItem_Click);
            // 
            // veryLowToolStripMenuItem
            // 
            this.veryLowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("veryLowToolStripMenuItem.Image")));
            this.veryLowToolStripMenuItem.Name = "veryLowToolStripMenuItem";
            this.veryLowToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.veryLowToolStripMenuItem.Tag = Khronos_PMS.Util.Priority.VERY_LOW;
            this.veryLowToolStripMenuItem.Text = "Very low";
            this.veryLowToolStripMenuItem.Click += new System.EventHandler(this.unitPriorityToolStripMenuItem_Click);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noneToolStripMenuItem.Image")));
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.noneToolStripMenuItem.Tag = Khronos_PMS.Util.Priority.NONE;
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.unitPriorityToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 412);
            this.Controls.Add(this.sfasidofjiaosdj);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 450);
            this.Name = "MainForm";
            this.Text = "Khronos Project Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.leftTableLayout.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsListView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersListView)).EndInit();
            this.rightTableLayout.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.projectStatusToolStrip.ResumeLayout(false);
            this.projectStatusToolStrip.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.unitTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitsTreeView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assigneesListView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.sfasidofjiaosdj.ResumeLayout(false);
            this.sfasidofjiaosdj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel leftTableLayout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel rightTableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label projectRoleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label bossNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button projectsSearchButton;
        private System.Windows.Forms.Button workersSearchButton;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip sfasidofjiaosdj;
        private View.CustomControls.PromptTextBox projectsSearchTextbox;
        private View.CustomControls.PromptTextBox workersSearchTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label unitNameLabel;
        private System.Windows.Forms.ToolStrip projectStatusToolStrip;
        private System.Windows.Forms.TableLayoutPanel unitTableLayoutPanel;
        private View.CustomControls.PromptTextBox unitsSearchTextBox;
        private System.Windows.Forms.Button unitsSearchButton;
        private View.CustomControls.PromptTextBox promptTextBox3;
        private System.Windows.Forms.Button addNewUnitButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label projectDescriptionLabel;
        private System.Windows.Forms.ToolStripDropDownButton projectStatusMenuButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripDropDownButton unitStatusMenuButton;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completedToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton unitPriorityMenuButton;
        private System.Windows.Forms.ToolStripMenuItem veryHighToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veryLowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem refrshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesReportToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label unitEstimatedManhoursLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label unitDueDateLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label unitSpentManhoursLabel;
        private System.Windows.Forms.ImageList smallImageList;
        private BrightIdeasSoftware.DataListView workersListView;
        private BrightIdeasSoftware.OLVColumn workerName;
        private BrightIdeasSoftware.DataListView projectsListView;
        private BrightIdeasSoftware.OLVColumn projectName;
        private System.Windows.Forms.ImageList largeImageList;
        private BrightIdeasSoftware.TreeListView unitsTreeView;
        private BrightIdeasSoftware.OLVColumn unitName;
        private BrightIdeasSoftware.OLVColumn unitStatus;
        private BrightIdeasSoftware.OLVColumn unitPriority;
        private BrightIdeasSoftware.OLVColumn unitDueDate;
        private System.Windows.Forms.ToolStripDropDownButton userLabel;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn unitEstimatedManhours;
        private BrightIdeasSoftware.OLVColumn unitSpentManhours;
        private BrightIdeasSoftware.OLVColumn unitExpense;
        private BrightIdeasSoftware.DataListView assigneesListView;
        private BrightIdeasSoftware.OLVColumn assigneeName;
    }
}