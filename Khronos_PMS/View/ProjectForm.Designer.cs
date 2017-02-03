namespace Khronos_PMS.View
{
    partial class ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.bossUsernameLabel = new System.Windows.Forms.Label();
            this.supervisorUsernameLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.deadLineLabel = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.supervisorUsernameComboBox = new System.Windows.Forms.ComboBox();
            this.bossUsernameComboBox = new System.Windows.Forms.ComboBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.customersLabel = new System.Windows.Forms.Label();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.removeCustomerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(12, 17);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(74, 13);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Project Name:";
            // 
            // bossUsernameLabel
            // 
            this.bossUsernameLabel.AutoSize = true;
            this.bossUsernameLabel.Location = new System.Drawing.Point(12, 63);
            this.bossUsernameLabel.Name = "bossUsernameLabel";
            this.bossUsernameLabel.Size = new System.Drawing.Size(84, 13);
            this.bossUsernameLabel.TabIndex = 1;
            this.bossUsernameLabel.Text = "Boss Username:";
            // 
            // supervisorUsernameLabel
            // 
            this.supervisorUsernameLabel.AutoSize = true;
            this.supervisorUsernameLabel.Location = new System.Drawing.Point(12, 91);
            this.supervisorUsernameLabel.Name = "supervisorUsernameLabel";
            this.supervisorUsernameLabel.Size = new System.Drawing.Size(111, 13);
            this.supervisorUsernameLabel.TabIndex = 2;
            this.supervisorUsernameLabel.Text = "Supervisor Username:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(384, 36);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Start Date:";
            // 
            // deadLineLabel
            // 
            this.deadLineLabel.AutoSize = true;
            this.deadLineLabel.Location = new System.Drawing.Point(384, 63);
            this.deadLineLabel.Name = "deadLineLabel";
            this.deadLineLabel.Size = new System.Drawing.Size(52, 13);
            this.deadLineLabel.TabIndex = 4;
            this.deadLineLabel.Text = "Deadline:";
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Location = new System.Drawing.Point(384, 91);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(44, 13);
            this.budgetLabel.TabIndex = 5;
            this.budgetLabel.Text = "Budget:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(386, 121);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Description:";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(15, 33);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(316, 20);
            this.projectNameTextBox.TabIndex = 7;
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(473, 88);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(100, 20);
            this.budgetTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(389, 137);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(284, 126);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // supervisorUsernameComboBox
            // 
            this.supervisorUsernameComboBox.FormattingEnabled = true;
            this.supervisorUsernameComboBox.Location = new System.Drawing.Point(129, 88);
            this.supervisorUsernameComboBox.Name = "supervisorUsernameComboBox";
            this.supervisorUsernameComboBox.Size = new System.Drawing.Size(202, 21);
            this.supervisorUsernameComboBox.TabIndex = 10;
            // 
            // bossUsernameComboBox
            // 
            this.bossUsernameComboBox.FormattingEnabled = true;
            this.bossUsernameComboBox.Location = new System.Drawing.Point(129, 60);
            this.bossUsernameComboBox.Name = "bossUsernameComboBox";
            this.bossUsernameComboBox.Size = new System.Drawing.Size(202, 21);
            this.bossUsernameComboBox.TabIndex = 11;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Location = new System.Drawing.Point(473, 33);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateDateTimePicker.TabIndex = 12;
            // 
            // deadlineDateTimePicker
            // 
            this.deadlineDateTimePicker.Location = new System.Drawing.Point(473, 60);
            this.deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            this.deadlineDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.deadlineDateTimePicker.TabIndex = 13;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(598, 278);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(517, 278);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "Confirm";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Location = new System.Drawing.Point(12, 121);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(56, 13);
            this.customersLabel.TabIndex = 16;
            this.customersLabel.Text = "Customers";
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(12, 137);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(319, 97);
            this.customerDataGridView.TabIndex = 17;
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(12, 242);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(137, 21);
            this.customerComboBox.TabIndex = 18;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(155, 242);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(85, 23);
            this.addCustomerButton.TabIndex = 19;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // removeCustomerButton
            // 
            this.removeCustomerButton.Location = new System.Drawing.Point(246, 242);
            this.removeCustomerButton.Name = "removeCustomerButton";
            this.removeCustomerButton.Size = new System.Drawing.Size(85, 23);
            this.removeCustomerButton.TabIndex = 20;
            this.removeCustomerButton.Text = "Remove";
            this.removeCustomerButton.UseVisualStyleBackColor = true;
            this.removeCustomerButton.Click += new System.EventHandler(this.removeCustomerButton_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 313);
            this.Controls.Add(this.removeCustomerButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.customersLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deadlineDateTimePicker);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(this.bossUsernameComboBox);
            this.Controls.Add(this.supervisorUsernameComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.deadLineLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.supervisorUsernameLabel);
            this.Controls.Add(this.bossUsernameLabel);
            this.Controls.Add(this.projectNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectForm";
            this.Text = "Project Creation";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label bossUsernameLabel;
        private System.Windows.Forms.Label supervisorUsernameLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label deadLineLabel;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox supervisorUsernameComboBox;
        private System.Windows.Forms.ComboBox bossUsernameComboBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker deadlineDateTimePicker;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button removeCustomerButton;
    }
}