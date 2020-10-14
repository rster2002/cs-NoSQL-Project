namespace View.components {
    partial class BaseTicketEditorComponent {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeReportedPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typeOfIncidentComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectUserButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deadlineComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.00248F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.99752F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeReportedPicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.subjectTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.typeOfIncidentComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.selectUserButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.priorityComboBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.deadlineComboBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.confirmButton, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date/time reported:\r\n";
            // 
            // dateTimeReportedPicker
            // 
            this.dateTimeReportedPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeReportedPicker.Location = new System.Drawing.Point(157, 5);
            this.dateTimeReportedPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeReportedPicker.Name = "dateTimeReportedPicker";
            this.dateTimeReportedPicker.Size = new System.Drawing.Size(303, 26);
            this.dateTimeReportedPicker.TabIndex = 1;
            this.dateTimeReportedPicker.ValueChanged += new System.EventHandler(this.UpdateButtonEnabled);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectTextBox.Location = new System.Drawing.Point(157, 45);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(303, 26);
            this.subjectTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type of incident";
            // 
            // typeOfIncidentComboBox
            // 
            this.typeOfIncidentComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeOfIncidentComboBox.FormattingEnabled = true;
            this.typeOfIncidentComboBox.Location = new System.Drawing.Point(157, 81);
            this.typeOfIncidentComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeOfIncidentComboBox.Name = "typeOfIncidentComboBox";
            this.typeOfIncidentComboBox.Size = new System.Drawing.Size(303, 28);
            this.typeOfIncidentComboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reported by user:";
            // 
            // selectUserButton
            // 
            this.selectUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectUserButton.Location = new System.Drawing.Point(157, 119);
            this.selectUserButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectUserButton.MinimumSize = new System.Drawing.Size(0, 32);
            this.selectUserButton.Name = "selectUserButton";
            this.selectUserButton.Size = new System.Drawing.Size(303, 52);
            this.selectUserButton.TabIndex = 7;
            this.selectUserButton.Text = "Select user";
            this.selectUserButton.UseVisualStyleBackColor = true;
            this.selectUserButton.Click += new System.EventHandler(this.SelectUserButtonOnClick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Priority:";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Location = new System.Drawing.Point(157, 181);
            this.priorityComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(303, 28);
            this.priorityComboBox.TabIndex = 8;
            this.priorityComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdateButtonEnabled);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(4, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Deadline/followup:";
            // 
            // deadlineComboBox
            // 
            this.deadlineComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadlineComboBox.FormattingEnabled = true;
            this.deadlineComboBox.Location = new System.Drawing.Point(157, 219);
            this.deadlineComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deadlineComboBox.Name = "deadlineComboBox";
            this.deadlineComboBox.Size = new System.Drawing.Size(303, 28);
            this.deadlineComboBox.TabIndex = 11;
            this.deadlineComboBox.SelectedValueChanged += new System.EventHandler(this.UpdateButtonEnabled);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(157, 257);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(303, 202);
            this.descriptionTextBox.TabIndex = 12;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.UpdateButtonEnabled);
            // 
            // confirmButton
            // 
            this.confirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(157, 469);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(303, 37);
            this.confirmButton.TabIndex = 14;
            this.confirmButton.Text = "Create ticket";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButtonOnClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(4, 469);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(145, 37);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonOnClick);
            // 
            // BaseTicketEditorComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(464, 511);
            this.Name = "BaseTicketEditorComponent";
            this.Size = new System.Drawing.Size(464, 511);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.ComboBox typeOfIncidentComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox deadlineComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeReportedPicker;
        private System.Windows.Forms.Button selectUserButton;
    }
}
