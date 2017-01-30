namespace Khronos_PMS.View
{
    partial class ActivityForm
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
            this.manHourSpentLabel = new System.Windows.Forms.Label();
            this.manHourSpentTextBox = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manHourSpentLabel
            // 
            this.manHourSpentLabel.AutoSize = true;
            this.manHourSpentLabel.Location = new System.Drawing.Point(13, 13);
            this.manHourSpentLabel.Name = "manHourSpentLabel";
            this.manHourSpentLabel.Size = new System.Drawing.Size(93, 13);
            this.manHourSpentLabel.TabIndex = 0;
            this.manHourSpentLabel.Text = "Man - hour spent: ";
            // 
            // manHourSpentTextBox
            // 
            this.manHourSpentTextBox.Location = new System.Drawing.Point(113, 9);
            this.manHourSpentTextBox.Name = "manHourSpentTextBox";
            this.manHourSpentTextBox.Size = new System.Drawing.Size(209, 20);
            this.manHourSpentTextBox.TabIndex = 1;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(12, 41);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(33, 13);
            this.noteLabel.TabIndex = 2;
            this.noteLabel.Text = "Note:";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(12, 57);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(310, 216);
            this.noteTextBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(247, 279);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(166, 279);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 313);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.manHourSpentTextBox);
            this.Controls.Add(this.manHourSpentLabel);
            this.Name = "ActivityForm";
            this.Text = "ActivityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manHourSpentLabel;
        private System.Windows.Forms.TextBox manHourSpentTextBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}