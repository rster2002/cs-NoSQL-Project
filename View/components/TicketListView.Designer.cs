namespace View.components {
    partial class TicketListView {
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
            this.ticketsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ticketsListView
            // 
            this.ticketsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ticketsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketsListView.FullRowSelect = true;
            this.ticketsListView.HideSelection = false;
            this.ticketsListView.Location = new System.Drawing.Point(0, 0);
            this.ticketsListView.MultiSelect = false;
            this.ticketsListView.Name = "ticketsListView";
            this.ticketsListView.Size = new System.Drawing.Size(768, 451);
            this.ticketsListView.TabIndex = 0;
            this.ticketsListView.UseCompatibleStateImageBehavior = false;
            this.ticketsListView.View = System.Windows.Forms.View.Details;
            this.ticketsListView.DoubleClick += new System.EventHandler(this.TicketsListViewOnDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Subject";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Reported by";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date reported";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Priority";
            this.columnHeader5.Width = 82;
            // 
            // TicketListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ticketsListView);
            this.Name = "TicketListView";
            this.Size = new System.Drawing.Size(768, 451);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ticketsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
