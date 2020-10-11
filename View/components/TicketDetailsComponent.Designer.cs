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
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.deadlineBackground = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.priorityBackground.SuspendLayout();
            this.deadlineBackground.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.19023F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.3856F));
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
            this.ticketSubjectLabel.Size = new System.Drawing.Size(78, 22);
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 86);
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
            this.priorityBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.priorityBackground.Size = new System.Drawing.Size(175, 37);
            this.priorityBackground.TabIndex = 0;
            // 
            // priorityLabel
            // 
            this.priorityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(70, 12);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(35, 13);
            this.priorityLabel.TabIndex = 0;
            this.priorityLabel.Text = "label1";
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Location = new System.Drawing.Point(70, 12);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(35, 13);
            this.deadlineLabel.TabIndex = 1;
            this.deadlineLabel.Text = "label1";
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
            this.deadlineBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.deadlineBackground.Size = new System.Drawing.Size(175, 37);
            this.deadlineBackground.TabIndex = 2;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionBox.Location = new System.Drawing.Point(3, 137);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(362, 132);
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
    }
}
