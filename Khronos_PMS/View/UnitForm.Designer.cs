namespace Khronos_PMS.View {
    partial class UnitForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.unitsGroupBox = new System.Windows.Forms.GroupBox();
            this.unitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.unitsTreeView = new BrightIdeasSoftware.TreeListView();
            this.unitName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.unitStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.unitsSearchTextBox = new Khronos_PMS.View.CustomControls.PromptTextBox();
            this.unitsSearchButton = new System.Windows.Forms.Button();
            this.unitInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.estimatedManhoursTextBox = new System.Windows.Forms.TextBox();
            this.unitNameTextBox = new System.Windows.Forms.TextBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.estimatedManhoursLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.unitNameLabel = new System.Windows.Forms.Label();
            this.workersGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.workersListView = new BrightIdeasSoftware.DataListView();
            this.workerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.workersSearchTextBox = new Khronos_PMS.View.CustomControls.PromptTextBox();
            this.workersSearchButton = new System.Windows.Forms.Button();
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.unitsGroupBox.SuspendLayout();
            this.unitTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsTreeView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.unitInformationGroupBox.SuspendLayout();
            this.workersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersListView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.unitsGroupBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.unitInformationGroupBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.87671F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.12329F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(393, 511);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // unitsGroupBox
            // 
            this.unitsGroupBox.Controls.Add(this.unitTableLayoutPanel);
            this.unitsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unitsGroupBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.unitsGroupBox.Location = new System.Drawing.Point(3, 168);
            this.unitsGroupBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.unitsGroupBox.Name = "unitsGroupBox";
            this.unitsGroupBox.Size = new System.Drawing.Size(387, 343);
            this.unitsGroupBox.TabIndex = 3;
            this.unitsGroupBox.TabStop = false;
            this.unitsGroupBox.Text = "Units";
            // 
            // unitTableLayoutPanel
            // 
            this.unitTableLayoutPanel.ColumnCount = 1;
            this.unitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.unitTableLayoutPanel.Controls.Add(this.unitsTreeView, 0, 1);
            this.unitTableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.unitTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitTableLayoutPanel.Location = new System.Drawing.Point(3, 17);
            this.unitTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.unitTableLayoutPanel.Name = "unitTableLayoutPanel";
            this.unitTableLayoutPanel.RowCount = 2;
            this.unitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.unitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.unitTableLayoutPanel.Size = new System.Drawing.Size(381, 323);
            this.unitTableLayoutPanel.TabIndex = 0;
            // 
            // unitsTreeView
            // 
            this.unitsTreeView.AllColumns.Add(this.unitName);
            this.unitsTreeView.AllColumns.Add(this.unitStatus);
            this.unitsTreeView.CellEditUseWholeCell = false;
            this.unitsTreeView.CheckBoxes = true;
            this.unitsTreeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.unitName,
            this.unitStatus});
            this.unitsTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.unitsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsTreeView.FullRowSelect = true;
            this.unitsTreeView.GridLines = true;
            this.unitsTreeView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.unitsTreeView.HideSelection = false;
            this.unitsTreeView.Location = new System.Drawing.Point(3, 33);
            this.unitsTreeView.MultiSelect = false;
            this.unitsTreeView.Name = "unitsTreeView";
            this.unitsTreeView.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.unitsTreeView.SelectedForeColor = System.Drawing.Color.Black;
            this.unitsTreeView.ShowGroups = false;
            this.unitsTreeView.ShowImagesOnSubItems = true;
            this.unitsTreeView.Size = new System.Drawing.Size(375, 287);
            this.unitsTreeView.SmallImageList = this.largeImageList;
            this.unitsTreeView.TabIndex = 29;
            this.unitsTreeView.UnfocusedSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.unitsTreeView.UseCompatibleStateImageBehavior = false;
            this.unitsTreeView.View = System.Windows.Forms.View.Details;
            this.unitsTreeView.VirtualMode = true;
            this.unitsTreeView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.unitsTreeView_ItemCheck);
            // 
            // unitName
            // 
            this.unitName.AspectName = "Name";
            this.unitName.Groupable = false;
            this.unitName.IsEditable = false;
            this.unitName.MinimumWidth = 200;
            this.unitName.Text = "Name";
            this.unitName.ToolTipText = "Select ancestor unit.";
            this.unitName.Width = 270;
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
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.Controls.Add(this.unitsSearchTextBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.unitsSearchButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(381, 30);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // unitsSearchTextBox
            // 
            this.unitsSearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.unitsSearchTextBox.Location = new System.Drawing.Point(3, 4);
            this.unitsSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unitsSearchTextBox.Multiline = true;
            this.unitsSearchTextBox.Name = "unitsSearchTextBox";
            this.unitsSearchTextBox.Size = new System.Drawing.Size(330, 22);
            this.unitsSearchTextBox.TabIndex = 6;
            this.unitsSearchTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.unitsSearchTextBox.WaterMarkText = "Search units";
            this.unitsSearchTextBox.TextChanged += new System.EventHandler(this.unitsSearchTextBox_TextChanged);
            // 
            // unitsSearchButton
            // 
            this.unitsSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("unitsSearchButton.Image")));
            this.unitsSearchButton.Location = new System.Drawing.Point(339, 3);
            this.unitsSearchButton.Name = "unitsSearchButton";
            this.unitsSearchButton.Size = new System.Drawing.Size(39, 24);
            this.unitsSearchButton.TabIndex = 7;
            this.unitsSearchButton.UseVisualStyleBackColor = true;
            this.unitsSearchButton.Click += new System.EventHandler(this.unitsSearchButton_Click);
            // 
            // unitInformationGroupBox
            // 
            this.unitInformationGroupBox.Controls.Add(this.priorityComboBox);
            this.unitInformationGroupBox.Controls.Add(this.dueDateDateTimePicker);
            this.unitInformationGroupBox.Controls.Add(this.estimatedManhoursTextBox);
            this.unitInformationGroupBox.Controls.Add(this.unitNameTextBox);
            this.unitInformationGroupBox.Controls.Add(this.priorityLabel);
            this.unitInformationGroupBox.Controls.Add(this.estimatedManhoursLabel);
            this.unitInformationGroupBox.Controls.Add(this.dueDateLabel);
            this.unitInformationGroupBox.Controls.Add(this.unitNameLabel);
            this.unitInformationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitInformationGroupBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.unitInformationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.unitInformationGroupBox.Name = "unitInformationGroupBox";
            this.unitInformationGroupBox.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.unitInformationGroupBox.Size = new System.Drawing.Size(387, 162);
            this.unitInformationGroupBox.TabIndex = 0;
            this.unitInformationGroupBox.TabStop = false;
            this.unitInformationGroupBox.Text = "Unit Information";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Location = new System.Drawing.Point(124, 123);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(223, 21);
            this.priorityComboBox.TabIndex = 7;
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(124, 71);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(223, 20);
            this.dueDateDateTimePicker.TabIndex = 6;
            // 
            // estimatedManhoursTextBox
            // 
            this.estimatedManhoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.estimatedManhoursTextBox.Location = new System.Drawing.Point(124, 97);
            this.estimatedManhoursTextBox.Name = "estimatedManhoursTextBox";
            this.estimatedManhoursTextBox.Size = new System.Drawing.Size(223, 20);
            this.estimatedManhoursTextBox.TabIndex = 5;
            // 
            // unitNameTextBox
            // 
            this.unitNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unitNameTextBox.Location = new System.Drawing.Point(5, 39);
            this.unitNameTextBox.Name = "unitNameTextBox";
            this.unitNameTextBox.Size = new System.Drawing.Size(376, 24);
            this.unitNameTextBox.TabIndex = 4;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.priorityLabel.Location = new System.Drawing.Point(15, 126);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(41, 13);
            this.priorityLabel.TabIndex = 3;
            this.priorityLabel.Text = "Priority:";
            // 
            // estimatedManhoursLabel
            // 
            this.estimatedManhoursLabel.AutoSize = true;
            this.estimatedManhoursLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.estimatedManhoursLabel.Location = new System.Drawing.Point(15, 100);
            this.estimatedManhoursLabel.Name = "estimatedManhoursLabel";
            this.estimatedManhoursLabel.Size = new System.Drawing.Size(106, 13);
            this.estimatedManhoursLabel.TabIndex = 2;
            this.estimatedManhoursLabel.Text = "Estimated Manhours:";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dueDateLabel.Location = new System.Drawing.Point(15, 77);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(56, 13);
            this.dueDateLabel.TabIndex = 1;
            this.dueDateLabel.Text = "Due Date:";
            // 
            // unitNameLabel
            // 
            this.unitNameLabel.AutoSize = true;
            this.unitNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.unitNameLabel.Location = new System.Drawing.Point(15, 24);
            this.unitNameLabel.Name = "unitNameLabel";
            this.unitNameLabel.Size = new System.Drawing.Size(60, 13);
            this.unitNameLabel.TabIndex = 0;
            this.unitNameLabel.Text = "Unit Name:";
            // 
            // workersGroupBox
            // 
            this.workersGroupBox.Controls.Add(this.button1);
            this.workersGroupBox.Controls.Add(this.workersListView);
            this.workersGroupBox.Controls.Add(this.workersSearchTextBox);
            this.workersGroupBox.Controls.Add(this.workersSearchButton);
            this.workersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workersGroupBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.workersGroupBox.Location = new System.Drawing.Point(399, 5);
            this.workersGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.workersGroupBox.Name = "workersGroupBox";
            this.workersGroupBox.Size = new System.Drawing.Size(268, 509);
            this.workersGroupBox.TabIndex = 2;
            this.workersGroupBox.TabStop = false;
            this.workersGroupBox.Text = "Workers";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(440, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.workersListView.CheckBoxes = true;
            this.workersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.workerName});
            this.workersListView.DataSource = null;
            this.workersListView.FullRowSelect = true;
            this.workersListView.GridLines = true;
            this.workersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.workersListView.HideSelection = false;
            this.workersListView.Location = new System.Drawing.Point(7, 48);
            this.workersListView.MultiSelect = false;
            this.workersListView.Name = "workersListView";
            this.workersListView.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.workersListView.SelectedForeColor = System.Drawing.Color.Black;
            this.workersListView.ShowGroups = false;
            this.workersListView.Size = new System.Drawing.Size(255, 455);
            this.workersListView.SmallImageList = this.largeImageList;
            this.workersListView.TabIndex = 5;
            this.workersListView.UnfocusedSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.workersListView.UseCompatibleStateImageBehavior = false;
            this.workersListView.View = System.Windows.Forms.View.Details;
            // 
            // workerName
            // 
            this.workerName.AspectName = "FullName";
            this.workerName.AutoCompleteEditor = false;
            this.workerName.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.workerName.FillsFreeSpace = true;
            this.workerName.Groupable = false;
            this.workerName.Hideable = false;
            this.workerName.ImageAspectName = "add_user";
            this.workerName.IsEditable = false;
            this.workerName.Text = "Full name";
            this.workerName.Width = 250;
            // 
            // workersSearchTextBox
            // 
            this.workersSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workersSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.workersSearchTextBox.Location = new System.Drawing.Point(7, 20);
            this.workersSearchTextBox.Multiline = true;
            this.workersSearchTextBox.Name = "workersSearchTextBox";
            this.workersSearchTextBox.Size = new System.Drawing.Size(209, 21);
            this.workersSearchTextBox.TabIndex = 4;
            this.workersSearchTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.workersSearchTextBox.WaterMarkText = "Search workers";
            this.workersSearchTextBox.TextChanged += new System.EventHandler(this.workersSearchTextBox_TextChanged);
            // 
            // workersSearchButton
            // 
            this.workersSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("workersSearchButton.Image")));
            this.workersSearchButton.Location = new System.Drawing.Point(223, 19);
            this.workersSearchButton.Name = "workersSearchButton";
            this.workersSearchButton.Size = new System.Drawing.Size(40, 23);
            this.workersSearchButton.TabIndex = 5;
            this.workersSearchButton.UseVisualStyleBackColor = true;
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "add_user.png");
            this.smallImageList.Images.SetKeyName(1, "project.png");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.95865F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.04135F));
            this.tableLayoutPanel1.Controls.Add(this.workersGroupBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(399, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 29);
            this.panel1.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(107, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(188, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UnitForm";
            this.Text = "Unit creation";
            this.Load += new System.EventHandler(this.UnitForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.unitsGroupBox.ResumeLayout(false);
            this.unitTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitsTreeView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.unitInformationGroupBox.ResumeLayout(false);
            this.unitInformationGroupBox.PerformLayout();
            this.workersGroupBox.ResumeLayout(false);
            this.workersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersListView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox unitsGroupBox;
        private System.Windows.Forms.TableLayoutPanel unitTableLayoutPanel;
        private BrightIdeasSoftware.TreeListView unitsTreeView;
        private BrightIdeasSoftware.OLVColumn unitName;
        private BrightIdeasSoftware.OLVColumn unitStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private CustomControls.PromptTextBox unitsSearchTextBox;
        private System.Windows.Forms.Button unitsSearchButton;
        private System.Windows.Forms.GroupBox unitInformationGroupBox;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private System.Windows.Forms.TextBox estimatedManhoursTextBox;
        private System.Windows.Forms.TextBox unitNameTextBox;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label estimatedManhoursLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label unitNameLabel;
        private System.Windows.Forms.GroupBox workersGroupBox;
        private System.Windows.Forms.Button button1;
        private BrightIdeasSoftware.DataListView workersListView;
        private BrightIdeasSoftware.OLVColumn workerName;
        private CustomControls.PromptTextBox workersSearchTextBox;
        private System.Windows.Forms.Button workersSearchButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ImageList largeImageList;
    }
}