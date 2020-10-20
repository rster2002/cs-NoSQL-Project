namespace View.components {
    partial class ArchiveComponent {
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
            this.dtp_beginDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.cb_beginDate = new System.Windows.Forms.CheckBox();
            this.cb_endDate = new System.Windows.Forms.CheckBox();
            this.btn_getTicketCount = new System.Windows.Forms.Button();
            this.pnl_afterTicketCount = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_archiveAndDelete = new System.Windows.Forms.Button();
            this.btn_archive = new System.Windows.Forms.Button();
            this.btn_setPath = new System.Windows.Forms.Button();
            this.lbl_ticketCount = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnl_afterTicketCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_beginDate
            // 
            this.dtp_beginDate.Enabled = false;
            this.dtp_beginDate.Location = new System.Drawing.Point(117, 3);
            this.dtp_beginDate.Name = "dtp_beginDate";
            this.dtp_beginDate.Size = new System.Drawing.Size(283, 20);
            this.dtp_beginDate.TabIndex = 0;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Enabled = false;
            this.dtp_endDate.Location = new System.Drawing.Point(117, 33);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(283, 20);
            this.dtp_endDate.TabIndex = 3;
            // 
            // cb_beginDate
            // 
            this.cb_beginDate.AutoSize = true;
            this.cb_beginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_beginDate.Location = new System.Drawing.Point(3, 3);
            this.cb_beginDate.Name = "cb_beginDate";
            this.cb_beginDate.Size = new System.Drawing.Size(108, 24);
            this.cb_beginDate.TabIndex = 4;
            this.cb_beginDate.Text = "BeginDate:";
            this.cb_beginDate.UseVisualStyleBackColor = true;
            this.cb_beginDate.CheckedChanged += new System.EventHandler(this.cb_beginDate_CheckedChanged);
            // 
            // cb_endDate
            // 
            this.cb_endDate.AutoSize = true;
            this.cb_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_endDate.Location = new System.Drawing.Point(3, 33);
            this.cb_endDate.Name = "cb_endDate";
            this.cb_endDate.Size = new System.Drawing.Size(96, 24);
            this.cb_endDate.TabIndex = 5;
            this.cb_endDate.Text = "EndDate:";
            this.cb_endDate.UseVisualStyleBackColor = true;
            this.cb_endDate.CheckedChanged += new System.EventHandler(this.cb_endDate_CheckedChanged);
            // 
            // btn_getTicketCount
            // 
            this.btn_getTicketCount.Location = new System.Drawing.Point(3, 59);
            this.btn_getTicketCount.Name = "btn_getTicketCount";
            this.btn_getTicketCount.Size = new System.Drawing.Size(397, 23);
            this.btn_getTicketCount.TabIndex = 7;
            this.btn_getTicketCount.Text = "Get Ticket Count";
            this.btn_getTicketCount.UseVisualStyleBackColor = true;
            this.btn_getTicketCount.Click += new System.EventHandler(this.btn_getTicketCount_Click);
            // 
            // pnl_afterTicketCount
            // 
            this.pnl_afterTicketCount.Controls.Add(this.lbl_status);
            this.pnl_afterTicketCount.Controls.Add(this.btn_setPath);
            this.pnl_afterTicketCount.Location = new System.Drawing.Point(3, 237);
            this.pnl_afterTicketCount.Name = "pnl_afterTicketCount";
            this.pnl_afterTicketCount.Size = new System.Drawing.Size(397, 101);
            this.pnl_afterTicketCount.TabIndex = 8;
            this.pnl_afterTicketCount.Visible = false;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(4, 57);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 16);
            this.lbl_status.TabIndex = 4;
            // 
            // btn_archiveAndDelete
            // 
            this.btn_archiveAndDelete.Enabled = false;
            this.btn_archiveAndDelete.ForeColor = System.Drawing.Color.Red;
            this.btn_archiveAndDelete.Location = new System.Drawing.Point(207, 132);
            this.btn_archiveAndDelete.Name = "btn_archiveAndDelete";
            this.btn_archiveAndDelete.Size = new System.Drawing.Size(193, 23);
            this.btn_archiveAndDelete.TabIndex = 3;
            this.btn_archiveAndDelete.Text = "Archive and Delete";
            this.btn_archiveAndDelete.UseVisualStyleBackColor = true;
            this.btn_archiveAndDelete.Click += new System.EventHandler(this.btn_archiveAndDelete_Click);
            // 
            // btn_archive
            // 
            this.btn_archive.Enabled = false;
            this.btn_archive.Location = new System.Drawing.Point(3, 132);
            this.btn_archive.Name = "btn_archive";
            this.btn_archive.Size = new System.Drawing.Size(198, 23);
            this.btn_archive.TabIndex = 2;
            this.btn_archive.Text = "Archive";
            this.btn_archive.UseVisualStyleBackColor = true;
            this.btn_archive.Click += new System.EventHandler(this.btn_archive_Click);
            // 
            // btn_setPath
            // 
            this.btn_setPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setPath.Location = new System.Drawing.Point(7, 3);
            this.btn_setPath.Name = "btn_setPath";
            this.btn_setPath.Size = new System.Drawing.Size(387, 22);
            this.btn_setPath.TabIndex = 1;
            this.btn_setPath.Text = "Set Path";
            this.btn_setPath.UseVisualStyleBackColor = true;
            // 
            // lbl_ticketCount
            // 
            this.lbl_ticketCount.AutoSize = true;
            this.lbl_ticketCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ticketCount.Location = new System.Drawing.Point(6, 94);
            this.lbl_ticketCount.Name = "lbl_ticketCount";
            this.lbl_ticketCount.Size = new System.Drawing.Size(102, 20);
            this.lbl_ticketCount.TabIndex = 0;
            this.lbl_ticketCount.Text = "Ticket Count:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "CSV Document|*.csv";
            // 
            // ArchiveComponent
            // 
            this.Controls.Add(this.pnl_afterTicketCount);
            this.Controls.Add(this.btn_archive);
            this.Controls.Add(this.btn_archiveAndDelete);
            this.Controls.Add(this.lbl_ticketCount);
            this.Controls.Add(this.btn_getTicketCount);
            this.Controls.Add(this.cb_endDate);
            this.Controls.Add(this.cb_beginDate);
            this.Controls.Add(this.dtp_endDate);
            this.Controls.Add(this.dtp_beginDate);
            this.Name = "ArchiveComponent";
            this.Size = new System.Drawing.Size(403, 341);
            this.pnl_afterTicketCount.ResumeLayout(false);
            this.pnl_afterTicketCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_beginDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.CheckBox cb_beginDate;
        private System.Windows.Forms.CheckBox cb_endDate;
        private System.Windows.Forms.Button btn_getTicketCount;
        private System.Windows.Forms.Panel pnl_afterTicketCount;
        private System.Windows.Forms.Button btn_setPath;
        private System.Windows.Forms.Label lbl_ticketCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_archiveAndDelete;
        private System.Windows.Forms.Button btn_archive;
        private System.Windows.Forms.Label lbl_status;
    }
}
