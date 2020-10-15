namespace View.components {
    partial class TicketDetailsComponent {
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
            this.ticketSubjectLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.priorityBackground = new System.Windows.Forms.TableLayoutPanel();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.deadlineBackground = new System.Windows.Forms.TableLayoutPanel();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.reportedByBackground = new System.Windows.Forms.TableLayoutPanel();
            this.reportedByLabel = new System.Windows.Forms.Label();
            this.reportedAtBackground = new System.Windows.Forms.TableLayoutPanel();
            this.reportedAtLabel = new System.Windows.Forms.Label();
            this.incidentTypeBackground = new System.Windows.Forms.TableLayoutPanel();
            this.incidentTypeLabel = new System.Windows.Forms.Label();
            this.statusBackground = new System.Windows.Forms.TableLayoutPanel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.priorityBackground.SuspendLayout();
            this.deadlineBackground.SuspendLayout();
            this.reportedByBackground.SuspendLayout();
            this.reportedAtBackground.SuspendLayout();
            this.incidentTypeBackground.SuspendLayout();
            this.statusBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ticketSubjectLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.descriptionBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.68123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.38235F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ticketSubjectLabel
            // 
            this.ticketSubjectLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ticketSubjectLabel.AutoSize = true;
            this.ticketSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketSubjectLabel.Location = new System.Drawing.Point(16, 16);
            this.ticketSubjectLabel.Margin = new System.Windows.Forms.Padding(16);
            this.ticketSubjectLabel.MinimumSize = new System.Drawing.Size(0, 22);
            this.ticketSubjectLabel.Name = "ticketSubjectLabel";
            this.ticketSubjectLabel.Size = new System.Drawing.Size(118, 22);
            this.ticketSubjectLabel.TabIndex = 0;
            this.ticketSubjectLabel.Text = "<subject>";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.priorityBackground, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.deadlineBackground, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.reportedByBackground, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.reportedAtBackground, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.incidentTypeBackground, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.statusBackground, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 105);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // priorityBackground
            // 
            this.priorityBackground.ColumnCount = 1;
            this.priorityBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.priorityBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.priorityBackground.Controls.Add(this.priorityLabel, 0, 0);
            this.priorityBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityBackground.Location = new System.Drawing.Point(3, 3);
            this.priorityBackground.Name = "priorityBackground";
            this.priorityBackground.RowCount = 1;
            this.priorityBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.priorityBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.priorityBackground.Size = new System.Drawing.Size(175, 29);
            this.priorityBackground.TabIndex = 0;
            // 
            // priorityLabel
            // 
            this.priorityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(70, 8);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(35, 13);
            this.priorityLabel.TabIndex = 0;
            this.priorityLabel.Text = "label1";
            // 
            // deadlineBackground
            // 
            this.deadlineBackground.ColumnCount = 1;
            this.deadlineBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.deadlineBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.deadlineBackground.Controls.Add(this.deadlineLabel, 0, 0);
            this.deadlineBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadlineBackground.Location = new System.Drawing.Point(184, 3);
            this.deadlineBackground.Name = "deadlineBackground";
            this.deadlineBackground.RowCount = 1;
            this.deadlineBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.deadlineBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.deadlineBackground.Size = new System.Drawing.Size(175, 29);
            this.deadlineBackground.TabIndex = 2;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Location = new System.Drawing.Point(70, 8);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(35, 13);
            this.deadlineLabel.TabIndex = 1;
            this.deadlineLabel.Text = "label1";
            // 
            // reportedByBackground
            // 
            this.reportedByBackground.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reportedByBackground.ColumnCount = 1;
            this.reportedByBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reportedByBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.reportedByBackground.Controls.Add(this.reportedByLabel, 0, 0);
            this.reportedByBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportedByBackground.Location = new System.Drawing.Point(3, 38);
            this.reportedByBackground.Name = "reportedByBackground";
            this.reportedByBackground.RowCount = 1;
            this.reportedByBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reportedByBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.reportedByBackground.Size = new System.Drawing.Size(175, 29);
            this.reportedByBackground.TabIndex = 3;
            // 
            // reportedByLabel
            // 
            this.reportedByLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportedByLabel.AutoSize = true;
            this.reportedByLabel.Location = new System.Drawing.Point(70, 8);
            this.reportedByLabel.Name = "reportedByLabel";
            this.reportedByLabel.Size = new System.Drawing.Size(35, 13);
            this.reportedByLabel.TabIndex = 0;
            this.reportedByLabel.Text = "label1";
            // 
            // reportedAtBackground
            // 
            this.reportedAtBackground.ColumnCount = 1;
            this.reportedAtBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reportedAtBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.reportedAtBackground.Controls.Add(this.reportedAtLabel, 0, 0);
            this.reportedAtBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportedAtBackground.Location = new System.Drawing.Point(184, 38);
            this.reportedAtBackground.Name = "reportedAtBackground";
            this.reportedAtBackground.RowCount = 1;
            this.reportedAtBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reportedAtBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.reportedAtBackground.Size = new System.Drawing.Size(175, 29);
            this.reportedAtBackground.TabIndex = 4;
            // 
            // reportedAtLabel
            // 
            this.reportedAtLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportedAtLabel.AutoSize = true;
            this.reportedAtLabel.Location = new System.Drawing.Point(70, 8);
            this.reportedAtLabel.Name = "reportedAtLabel";
            this.reportedAtLabel.Size = new System.Drawing.Size(35, 13);
            this.reportedAtLabel.TabIndex = 0;
            this.reportedAtLabel.Text = "label1";
            // 
            // incidentTypeBackground
            // 
            this.incidentTypeBackground.ColumnCount = 1;
            this.incidentTypeBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.incidentTypeBackground.Controls.Add(this.incidentTypeLabel, 0, 0);
            this.incidentTypeBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incidentTypeBackground.Location = new System.Drawing.Point(3, 73);
            this.incidentTypeBackground.Name = "incidentTypeBackground";
            this.incidentTypeBackground.RowCount = 1;
            this.incidentTypeBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.incidentTypeBackground.Size = new System.Drawing.Size(175, 29);
            this.incidentTypeBackground.TabIndex = 5;
            // 
            // incidentTypeLabel
            // 
            this.incidentTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incidentTypeLabel.AutoSize = true;
            this.incidentTypeLabel.Location = new System.Drawing.Point(70, 8);
            this.incidentTypeLabel.Name = "incidentTypeLabel";
            this.incidentTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.incidentTypeLabel.TabIndex = 0;
            this.incidentTypeLabel.Text = "label1";
            // 
            // statusBackground
            // 
            this.statusBackground.ColumnCount = 1;
            this.statusBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.statusBackground.Controls.Add(this.statusLabel, 0, 0);
            this.statusBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusBackground.Location = new System.Drawing.Point(184, 73);
            this.statusBackground.Name = "statusBackground";
            this.statusBackground.RowCount = 1;
            this.statusBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.statusBackground.Size = new System.Drawing.Size(175, 29);
            this.statusBackground.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(70, 8);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "label1";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionBox.Location = new System.Drawing.Point(3, 156);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(362, 113);
            this.descriptionBox.TabIndex = 2;
            // 
            // TicketDetailsComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TicketDetailsComponent";
            this.Size = new System.Drawing.Size(368, 272);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.priorityBackground.ResumeLayout(false);
            this.priorityBackground.PerformLayout();
            this.deadlineBackground.ResumeLayout(false);
            this.deadlineBackground.PerformLayout();
            this.reportedByBackground.ResumeLayout(false);
            this.reportedByBackground.PerformLayout();
            this.reportedAtBackground.ResumeLayout(false);
            this.reportedAtBackground.PerformLayout();
            this.incidentTypeBackground.ResumeLayout(false);
            this.incidentTypeBackground.PerformLayout();
            this.statusBackground.ResumeLayout(false);
            this.statusBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ticketSubjectLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel priorityBackground;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label deadlineLabel;
        private System.Windows.Forms.TableLayoutPanel deadlineBackground;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TableLayoutPanel reportedByBackground;
        private System.Windows.Forms.Label reportedByLabel;
        private System.Windows.Forms.TableLayoutPanel reportedAtBackground;
        private System.Windows.Forms.Label reportedAtLabel;
        private System.Windows.Forms.TableLayoutPanel incidentTypeBackground;
        private System.Windows.Forms.Label incidentTypeLabel;
        private System.Windows.Forms.TableLayoutPanel statusBackground;
        private System.Windows.Forms.Label statusLabel;
    }
}
