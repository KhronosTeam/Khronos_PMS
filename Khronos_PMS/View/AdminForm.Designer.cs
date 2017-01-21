namespace Khronos_PMS {
    partial class AdminForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.accountTabPage = new System.Windows.Forms.TabPage();
            this.accountTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.accountToolStrip = new System.Windows.Forms.ToolStrip();
            this.newAdminToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newWorkerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newCustomerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.changePasswordToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newAdminPanel = new System.Windows.Forms.Panel();
            this.adminOKButton = new System.Windows.Forms.Button();
            this.adminLastnameTextBox = new System.Windows.Forms.TextBox();
            this.adminFirstnameTextBox = new System.Windows.Forms.TextBox();
            this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.adminUsernameTextBox = new System.Windows.Forms.TextBox();
            this.adminLastnameLabel = new System.Windows.Forms.Label();
            this.adminFirstnameLabel = new System.Windows.Forms.Label();
            this.adminPasswordLabel = new System.Windows.Forms.Label();
            this.adminUsernameLabel = new System.Windows.Forms.Label();
            this.newCustomerPanel = new System.Windows.Forms.Panel();
            this.customerOKButton = new System.Windows.Forms.Button();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.customerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerPasswordLabel = new System.Windows.Forms.Label();
            this.customerUsernameLabel = new System.Windows.Forms.Label();
            this.newWorkerPanel = new System.Windows.Forms.Panel();
            this.workerOKButton = new System.Windows.Forms.Button();
            this.workerLastnameTextBox = new System.Windows.Forms.TextBox();
            this.workerFirstnameTextBox = new System.Windows.Forms.TextBox();
            this.workerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.workerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.workerLastnameLabel = new System.Windows.Forms.Label();
            this.workerFirstnameLabel = new System.Windows.Forms.Label();
            this.workerPasswordLabel = new System.Windows.Forms.Label();
            this.workerUsernameLabel = new System.Windows.Forms.Label();
            this.changePasswordPanel = new System.Windows.Forms.Panel();
            this.changeOKButton = new System.Windows.Forms.Button();
            this.changeNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.changeUsernameComboBox = new System.Windows.Forms.ComboBox();
            this.changeNewPasswordLabel = new System.Windows.Forms.Label();
            this.changeUsernameLabel = new System.Windows.Forms.Label();
            this.projectTabPage = new System.Windows.Forms.TabPage();
            this.adminTabControl.SuspendLayout();
            this.accountTabPage.SuspendLayout();
            this.accountTableLayoutPanel.SuspendLayout();
            this.accountToolStrip.SuspendLayout();
            this.newAdminPanel.SuspendLayout();
            this.newCustomerPanel.SuspendLayout();
            this.newWorkerPanel.SuspendLayout();
            this.changePasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.accountTabPage);
            this.adminTabControl.Controls.Add(this.projectTabPage);
            this.adminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTabControl.Location = new System.Drawing.Point(0, 0);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(1032, 475);
            this.adminTabControl.TabIndex = 0;
            // 
            // accountTabPage
            // 
            this.accountTabPage.Controls.Add(this.accountTableLayoutPanel);
            this.accountTabPage.Location = new System.Drawing.Point(4, 22);
            this.accountTabPage.Name = "accountTabPage";
            this.accountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountTabPage.Size = new System.Drawing.Size(1024, 449);
            this.accountTabPage.TabIndex = 0;
            this.accountTabPage.Text = "Account Management";
            this.accountTabPage.UseVisualStyleBackColor = true;
            // 
            // accountTableLayoutPanel
            // 
            this.accountTableLayoutPanel.ColumnCount = 2;
            this.accountTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.65541F));
            this.accountTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.34459F));
            this.accountTableLayoutPanel.Controls.Add(this.accountToolStrip, 0, 0);
            this.accountTableLayoutPanel.Controls.Add(this.newAdminPanel, 1, 0);
            this.accountTableLayoutPanel.Controls.Add(this.newCustomerPanel, 1, 0);
            this.accountTableLayoutPanel.Controls.Add(this.newWorkerPanel, 1, 0);
            this.accountTableLayoutPanel.Controls.Add(this.changePasswordPanel, 1, 0);
            this.accountTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.accountTableLayoutPanel.Name = "accountTableLayoutPanel";
            this.accountTableLayoutPanel.RowCount = 1;
            this.accountTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.accountTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.accountTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.accountTableLayoutPanel.Size = new System.Drawing.Size(1018, 443);
            this.accountTableLayoutPanel.TabIndex = 0;
            // 
            // accountToolStrip
            // 
            this.accountToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdminToolStripButton,
            this.newWorkerToolStripButton,
            this.newCustomerToolStripButton,
            this.changePasswordToolStripButton});
            this.accountToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.accountToolStrip.Location = new System.Drawing.Point(0, 0);
            this.accountToolStrip.Name = "accountToolStrip";
            this.accountToolStrip.Size = new System.Drawing.Size(210, 211);
            this.accountToolStrip.TabIndex = 0;
            this.accountToolStrip.Text = "toolStrip1";
            // 
            // newAdminToolStripButton
            // 
            this.newAdminToolStripButton.BackColor = System.Drawing.Color.DarkGray;
            this.newAdminToolStripButton.Checked = true;
            this.newAdminToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newAdminToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newAdminToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newAdminToolStripButton.Image")));
            this.newAdminToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newAdminToolStripButton.Name = "newAdminToolStripButton";
            this.newAdminToolStripButton.Size = new System.Drawing.Size(208, 19);
            this.newAdminToolStripButton.Text = "New Admin";
            // 
            // newWorkerToolStripButton
            // 
            this.newWorkerToolStripButton.BackColor = System.Drawing.Color.DarkGray;
            this.newWorkerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newWorkerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newWorkerToolStripButton.Image")));
            this.newWorkerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newWorkerToolStripButton.Name = "newWorkerToolStripButton";
            this.newWorkerToolStripButton.Size = new System.Drawing.Size(208, 19);
            this.newWorkerToolStripButton.Text = "New Worker";
            // 
            // newCustomerToolStripButton
            // 
            this.newCustomerToolStripButton.BackColor = System.Drawing.Color.DarkGray;
            this.newCustomerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newCustomerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newCustomerToolStripButton.Image")));
            this.newCustomerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newCustomerToolStripButton.Name = "newCustomerToolStripButton";
            this.newCustomerToolStripButton.Size = new System.Drawing.Size(208, 19);
            this.newCustomerToolStripButton.Text = "New Customer";
            // 
            // changePasswordToolStripButton
            // 
            this.changePasswordToolStripButton.BackColor = System.Drawing.Color.DarkGray;
            this.changePasswordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changePasswordToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripButton.Image")));
            this.changePasswordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changePasswordToolStripButton.Name = "changePasswordToolStripButton";
            this.changePasswordToolStripButton.Size = new System.Drawing.Size(208, 19);
            this.changePasswordToolStripButton.Text = "Change Password";
            // 
            // newAdminPanel
            // 
            this.newAdminPanel.Controls.Add(this.adminOKButton);
            this.newAdminPanel.Controls.Add(this.adminLastnameTextBox);
            this.newAdminPanel.Controls.Add(this.adminFirstnameTextBox);
            this.newAdminPanel.Controls.Add(this.adminPasswordTextBox);
            this.newAdminPanel.Controls.Add(this.adminUsernameTextBox);
            this.newAdminPanel.Controls.Add(this.adminLastnameLabel);
            this.newAdminPanel.Controls.Add(this.adminFirstnameLabel);
            this.newAdminPanel.Controls.Add(this.adminPasswordLabel);
            this.newAdminPanel.Controls.Add(this.adminUsernameLabel);
            this.newAdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newAdminPanel.Location = new System.Drawing.Point(213, 214);
            this.newAdminPanel.Name = "newAdminPanel";
            this.newAdminPanel.Size = new System.Drawing.Size(802, 205);
            this.newAdminPanel.TabIndex = 1;
            // 
            // adminOKButton
            // 
            this.adminOKButton.Location = new System.Drawing.Point(99, 116);
            this.adminOKButton.Name = "adminOKButton";
            this.adminOKButton.Size = new System.Drawing.Size(75, 23);
            this.adminOKButton.TabIndex = 8;
            this.adminOKButton.Text = "OK";
            this.adminOKButton.UseVisualStyleBackColor = true;
            this.adminOKButton.Click += new System.EventHandler(this.adminOKButton_Click);
            // 
            // adminLastnameTextBox
            // 
            this.adminLastnameTextBox.Location = new System.Drawing.Point(74, 81);
            this.adminLastnameTextBox.Name = "adminLastnameTextBox";
            this.adminLastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminLastnameTextBox.TabIndex = 7;
            // 
            // adminFirstnameTextBox
            // 
            this.adminFirstnameTextBox.Location = new System.Drawing.Point(74, 55);
            this.adminFirstnameTextBox.Name = "adminFirstnameTextBox";
            this.adminFirstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminFirstnameTextBox.TabIndex = 6;
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.Location = new System.Drawing.Point(74, 29);
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminPasswordTextBox.TabIndex = 5;
            this.adminPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // adminUsernameTextBox
            // 
            this.adminUsernameTextBox.Location = new System.Drawing.Point(74, 3);
            this.adminUsernameTextBox.Name = "adminUsernameTextBox";
            this.adminUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminUsernameTextBox.TabIndex = 4;
            // 
            // adminLastnameLabel
            // 
            this.adminLastnameLabel.AutoSize = true;
            this.adminLastnameLabel.Location = new System.Drawing.Point(12, 84);
            this.adminLastnameLabel.Name = "adminLastnameLabel";
            this.adminLastnameLabel.Size = new System.Drawing.Size(56, 13);
            this.adminLastnameLabel.TabIndex = 3;
            this.adminLastnameLabel.Text = "Lastname:";
            // 
            // adminFirstnameLabel
            // 
            this.adminFirstnameLabel.AutoSize = true;
            this.adminFirstnameLabel.Location = new System.Drawing.Point(13, 58);
            this.adminFirstnameLabel.Name = "adminFirstnameLabel";
            this.adminFirstnameLabel.Size = new System.Drawing.Size(55, 13);
            this.adminFirstnameLabel.TabIndex = 2;
            this.adminFirstnameLabel.Text = "Firstname:";
            // 
            // adminPasswordLabel
            // 
            this.adminPasswordLabel.AutoSize = true;
            this.adminPasswordLabel.Location = new System.Drawing.Point(12, 32);
            this.adminPasswordLabel.Name = "adminPasswordLabel";
            this.adminPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.adminPasswordLabel.TabIndex = 1;
            this.adminPasswordLabel.Text = "Password:";
            // 
            // adminUsernameLabel
            // 
            this.adminUsernameLabel.AutoSize = true;
            this.adminUsernameLabel.Location = new System.Drawing.Point(10, 6);
            this.adminUsernameLabel.Name = "adminUsernameLabel";
            this.adminUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.adminUsernameLabel.TabIndex = 0;
            this.adminUsernameLabel.Text = "Username:";
            // 
            // newCustomerPanel
            // 
            this.newCustomerPanel.Controls.Add(this.customerOKButton);
            this.newCustomerPanel.Controls.Add(this.customerNameTextBox);
            this.newCustomerPanel.Controls.Add(this.customerPasswordTextBox);
            this.newCustomerPanel.Controls.Add(this.customerUsernameTextBox);
            this.newCustomerPanel.Controls.Add(this.customerNameLabel);
            this.newCustomerPanel.Controls.Add(this.customerPasswordLabel);
            this.newCustomerPanel.Controls.Add(this.customerUsernameLabel);
            this.newCustomerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newCustomerPanel.Location = new System.Drawing.Point(3, 425);
            this.newCustomerPanel.Name = "newCustomerPanel";
            this.newCustomerPanel.Size = new System.Drawing.Size(204, 15);
            this.newCustomerPanel.TabIndex = 10;
            this.newCustomerPanel.Visible = false;
            // 
            // customerOKButton
            // 
            this.customerOKButton.Location = new System.Drawing.Point(99, 88);
            this.customerOKButton.Name = "customerOKButton";
            this.customerOKButton.Size = new System.Drawing.Size(75, 23);
            this.customerOKButton.TabIndex = 26;
            this.customerOKButton.Text = "OK";
            this.customerOKButton.UseVisualStyleBackColor = true;
            this.customerOKButton.Click += new System.EventHandler(this.customerOKButton_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(74, 58);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextBox.TabIndex = 24;
            // 
            // customerPasswordTextBox
            // 
            this.customerPasswordTextBox.Location = new System.Drawing.Point(74, 32);
            this.customerPasswordTextBox.Name = "customerPasswordTextBox";
            this.customerPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerPasswordTextBox.TabIndex = 23;
            this.customerPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // customerUsernameTextBox
            // 
            this.customerUsernameTextBox.Location = new System.Drawing.Point(74, 6);
            this.customerUsernameTextBox.Name = "customerUsernameTextBox";
            this.customerUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerUsernameTextBox.TabIndex = 22;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(13, 61);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(38, 13);
            this.customerNameLabel.TabIndex = 20;
            this.customerNameLabel.Text = "Name:";
            // 
            // customerPasswordLabel
            // 
            this.customerPasswordLabel.AutoSize = true;
            this.customerPasswordLabel.Location = new System.Drawing.Point(12, 35);
            this.customerPasswordLabel.Name = "customerPasswordLabel";
            this.customerPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.customerPasswordLabel.TabIndex = 19;
            this.customerPasswordLabel.Text = "Password:";
            // 
            // customerUsernameLabel
            // 
            this.customerUsernameLabel.AutoSize = true;
            this.customerUsernameLabel.Location = new System.Drawing.Point(10, 9);
            this.customerUsernameLabel.Name = "customerUsernameLabel";
            this.customerUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.customerUsernameLabel.TabIndex = 18;
            this.customerUsernameLabel.Text = "Username:";
            // 
            // newWorkerPanel
            // 
            this.newWorkerPanel.Controls.Add(this.workerOKButton);
            this.newWorkerPanel.Controls.Add(this.workerLastnameTextBox);
            this.newWorkerPanel.Controls.Add(this.workerFirstnameTextBox);
            this.newWorkerPanel.Controls.Add(this.workerPasswordTextBox);
            this.newWorkerPanel.Controls.Add(this.workerUsernameTextBox);
            this.newWorkerPanel.Controls.Add(this.workerLastnameLabel);
            this.newWorkerPanel.Controls.Add(this.workerFirstnameLabel);
            this.newWorkerPanel.Controls.Add(this.workerPasswordLabel);
            this.newWorkerPanel.Controls.Add(this.workerUsernameLabel);
            this.newWorkerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newWorkerPanel.Location = new System.Drawing.Point(213, 3);
            this.newWorkerPanel.Name = "newWorkerPanel";
            this.newWorkerPanel.Size = new System.Drawing.Size(802, 205);
            this.newWorkerPanel.TabIndex = 9;
            this.newWorkerPanel.Visible = false;
            // 
            // workerOKButton
            // 
            this.workerOKButton.Location = new System.Drawing.Point(99, 120);
            this.workerOKButton.Name = "workerOKButton";
            this.workerOKButton.Size = new System.Drawing.Size(75, 23);
            this.workerOKButton.TabIndex = 17;
            this.workerOKButton.Text = "OK";
            this.workerOKButton.UseVisualStyleBackColor = true;
            this.workerOKButton.Click += new System.EventHandler(this.workerOKButton_Click);
            // 
            // workerLastnameTextBox
            // 
            this.workerLastnameTextBox.Location = new System.Drawing.Point(74, 85);
            this.workerLastnameTextBox.Name = "workerLastnameTextBox";
            this.workerLastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerLastnameTextBox.TabIndex = 16;
            // 
            // workerFirstnameTextBox
            // 
            this.workerFirstnameTextBox.Location = new System.Drawing.Point(74, 59);
            this.workerFirstnameTextBox.Name = "workerFirstnameTextBox";
            this.workerFirstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerFirstnameTextBox.TabIndex = 15;
            // 
            // workerPasswordTextBox
            // 
            this.workerPasswordTextBox.Location = new System.Drawing.Point(74, 33);
            this.workerPasswordTextBox.Name = "workerPasswordTextBox";
            this.workerPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerPasswordTextBox.TabIndex = 14;
            this.workerPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // workerUsernameTextBox
            // 
            this.workerUsernameTextBox.Location = new System.Drawing.Point(74, 7);
            this.workerUsernameTextBox.Name = "workerUsernameTextBox";
            this.workerUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerUsernameTextBox.TabIndex = 13;
            // 
            // workerLastnameLabel
            // 
            this.workerLastnameLabel.AutoSize = true;
            this.workerLastnameLabel.Location = new System.Drawing.Point(12, 88);
            this.workerLastnameLabel.Name = "workerLastnameLabel";
            this.workerLastnameLabel.Size = new System.Drawing.Size(56, 13);
            this.workerLastnameLabel.TabIndex = 12;
            this.workerLastnameLabel.Text = "Lastname:";
            // 
            // workerFirstnameLabel
            // 
            this.workerFirstnameLabel.AutoSize = true;
            this.workerFirstnameLabel.Location = new System.Drawing.Point(13, 62);
            this.workerFirstnameLabel.Name = "workerFirstnameLabel";
            this.workerFirstnameLabel.Size = new System.Drawing.Size(55, 13);
            this.workerFirstnameLabel.TabIndex = 11;
            this.workerFirstnameLabel.Text = "Firstname:";
            // 
            // workerPasswordLabel
            // 
            this.workerPasswordLabel.AutoSize = true;
            this.workerPasswordLabel.Location = new System.Drawing.Point(12, 36);
            this.workerPasswordLabel.Name = "workerPasswordLabel";
            this.workerPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.workerPasswordLabel.TabIndex = 10;
            this.workerPasswordLabel.Text = "Password:";
            // 
            // workerUsernameLabel
            // 
            this.workerUsernameLabel.AutoSize = true;
            this.workerUsernameLabel.Location = new System.Drawing.Point(10, 10);
            this.workerUsernameLabel.Name = "workerUsernameLabel";
            this.workerUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.workerUsernameLabel.TabIndex = 9;
            this.workerUsernameLabel.Text = "Username:";
            // 
            // changePasswordPanel
            // 
            this.changePasswordPanel.Controls.Add(this.changeOKButton);
            this.changePasswordPanel.Controls.Add(this.changeNewPasswordTextBox);
            this.changePasswordPanel.Controls.Add(this.changeUsernameComboBox);
            this.changePasswordPanel.Controls.Add(this.changeNewPasswordLabel);
            this.changePasswordPanel.Controls.Add(this.changeUsernameLabel);
            this.changePasswordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePasswordPanel.Location = new System.Drawing.Point(3, 214);
            this.changePasswordPanel.Name = "changePasswordPanel";
            this.changePasswordPanel.Size = new System.Drawing.Size(204, 205);
            this.changePasswordPanel.TabIndex = 27;
            this.changePasswordPanel.Visible = false;
            this.changePasswordPanel.VisibleChanged += new System.EventHandler(this.changePasswordPanel_VisibleChanged);
            // 
            // changeOKButton
            // 
            this.changeOKButton.Location = new System.Drawing.Point(145, 59);
            this.changeOKButton.Name = "changeOKButton";
            this.changeOKButton.Size = new System.Drawing.Size(75, 23);
            this.changeOKButton.TabIndex = 4;
            this.changeOKButton.Text = "OK";
            this.changeOKButton.UseVisualStyleBackColor = true;
            this.changeOKButton.Click += new System.EventHandler(this.changeOKButton_Click);
            // 
            // changeNewPasswordTextBox
            // 
            this.changeNewPasswordTextBox.Location = new System.Drawing.Point(99, 33);
            this.changeNewPasswordTextBox.Name = "changeNewPasswordTextBox";
            this.changeNewPasswordTextBox.Size = new System.Drawing.Size(121, 20);
            this.changeNewPasswordTextBox.TabIndex = 3;
            this.changeNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // changeUsernameComboBox
            // 
            this.changeUsernameComboBox.FormattingEnabled = true;
            this.changeUsernameComboBox.Location = new System.Drawing.Point(99, 6);
            this.changeUsernameComboBox.Name = "changeUsernameComboBox";
            this.changeUsernameComboBox.Size = new System.Drawing.Size(121, 21);
            this.changeUsernameComboBox.TabIndex = 2;
            // 
            // changeNewPasswordLabel
            // 
            this.changeNewPasswordLabel.AutoSize = true;
            this.changeNewPasswordLabel.Location = new System.Drawing.Point(13, 36);
            this.changeNewPasswordLabel.Name = "changeNewPasswordLabel";
            this.changeNewPasswordLabel.Size = new System.Drawing.Size(80, 13);
            this.changeNewPasswordLabel.TabIndex = 1;
            this.changeNewPasswordLabel.Text = "New password:";
            // 
            // changeUsernameLabel
            // 
            this.changeUsernameLabel.AutoSize = true;
            this.changeUsernameLabel.Location = new System.Drawing.Point(35, 10);
            this.changeUsernameLabel.Name = "changeUsernameLabel";
            this.changeUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.changeUsernameLabel.TabIndex = 0;
            this.changeUsernameLabel.Text = "Username:";
            // 
            // projectTabPage
            // 
            this.projectTabPage.Location = new System.Drawing.Point(4, 22);
            this.projectTabPage.Name = "projectTabPage";
            this.projectTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectTabPage.Size = new System.Drawing.Size(1024, 449);
            this.projectTabPage.TabIndex = 1;
            this.projectTabPage.Text = "Project Management";
            this.projectTabPage.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 475);
            this.Controls.Add(this.adminTabControl);
            this.Name = "AdminForm";
            this.Text = "Khronos Project Management System Administration";
            this.adminTabControl.ResumeLayout(false);
            this.accountTabPage.ResumeLayout(false);
            this.accountTableLayoutPanel.ResumeLayout(false);
            this.accountTableLayoutPanel.PerformLayout();
            this.accountToolStrip.ResumeLayout(false);
            this.accountToolStrip.PerformLayout();
            this.newAdminPanel.ResumeLayout(false);
            this.newAdminPanel.PerformLayout();
            this.newCustomerPanel.ResumeLayout(false);
            this.newCustomerPanel.PerformLayout();
            this.newWorkerPanel.ResumeLayout(false);
            this.newWorkerPanel.PerformLayout();
            this.changePasswordPanel.ResumeLayout(false);
            this.changePasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage accountTabPage;
        private System.Windows.Forms.TabPage projectTabPage;
        private System.Windows.Forms.TableLayoutPanel accountTableLayoutPanel;
        private System.Windows.Forms.ToolStrip accountToolStrip;
        private System.Windows.Forms.ToolStripButton newAdminToolStripButton;
        private System.Windows.Forms.ToolStripButton newWorkerToolStripButton;
        private System.Windows.Forms.ToolStripButton newCustomerToolStripButton;
        private System.Windows.Forms.ToolStripButton changePasswordToolStripButton;
        private System.Windows.Forms.Panel newAdminPanel;
        private System.Windows.Forms.Label adminLastnameLabel;
        private System.Windows.Forms.Label adminFirstnameLabel;
        private System.Windows.Forms.Label adminPasswordLabel;
        private System.Windows.Forms.Label adminUsernameLabel;
        private System.Windows.Forms.Button adminOKButton;
        private System.Windows.Forms.TextBox adminLastnameTextBox;
        private System.Windows.Forms.TextBox adminFirstnameTextBox;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
        private System.Windows.Forms.TextBox adminUsernameTextBox;
        private System.Windows.Forms.Panel newWorkerPanel;
        private System.Windows.Forms.Button workerOKButton;
        private System.Windows.Forms.TextBox workerLastnameTextBox;
        private System.Windows.Forms.TextBox workerFirstnameTextBox;
        private System.Windows.Forms.TextBox workerPasswordTextBox;
        private System.Windows.Forms.TextBox workerUsernameTextBox;
        private System.Windows.Forms.Label workerLastnameLabel;
        private System.Windows.Forms.Label workerFirstnameLabel;
        private System.Windows.Forms.Label workerPasswordLabel;
        private System.Windows.Forms.Label workerUsernameLabel;
        private System.Windows.Forms.Panel newCustomerPanel;
        private System.Windows.Forms.Button customerOKButton;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerPasswordTextBox;
        private System.Windows.Forms.TextBox customerUsernameTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerPasswordLabel;
        private System.Windows.Forms.Label customerUsernameLabel;
        private System.Windows.Forms.Panel changePasswordPanel;
        private System.Windows.Forms.Button changeOKButton;
        private System.Windows.Forms.TextBox changeNewPasswordTextBox;
        private System.Windows.Forms.ComboBox changeUsernameComboBox;
        private System.Windows.Forms.Label changeNewPasswordLabel;
        private System.Windows.Forms.Label changeUsernameLabel;
    }
}