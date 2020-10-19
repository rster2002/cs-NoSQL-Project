using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace View.components {
    public partial class ArchiveComponent : UserControl {
        private ArchiveService archiveService = new ArchiveService();
        public ArchiveComponent() {
            InitializeComponent();
            FillArchiveScreen();
        }

        public ArchiveComponent(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }

        private void FillArchiveScreen() {
            saveFileDialog1.FileOk += OnFileOk;
        }

        private void cb_beginDate_CheckedChanged(object sender, EventArgs e) {
            dtp_beginDate.Enabled = cb_beginDate.Checked;
        }

        private void cb_endDate_CheckedChanged(object sender, EventArgs e) {
            dtp_endDate.Enabled = cb_endDate.Checked;
        }

        private void btn_setPath_Click(object sender, EventArgs e) {
            btn_archive.Enabled = false;
            btn_archiveAndDelete.Enabled = false;
            saveFileDialog1.ShowDialog();
        }

        private void OnFileOk(object sender, EventArgs e) {
            btn_archive.Enabled = true;
            btn_archiveAndDelete.Enabled = true;
        }

        private void btn_getTicketCount_Click(object sender, EventArgs e) {
            long res = archiveService.GetTicketCount();
            lbl_ticketCount.Text = $"Ticket Count: {res}";
            if (res > 0) {
                pnl_afterTicketCount.Show();

                archiveService.BeginDate = dtp_beginDate.Value;
                archiveService.EndDate = dtp_endDate.Value;

                archiveService.UseBeginDate = cb_beginDate.Checked;
                archiveService.UseEndDate = cb_endDate.Checked;
            } 
            else
                pnl_afterTicketCount.Hide();
        }

        private void btn_archive_Click(object sender, EventArgs e) {
            archiveService.Archive(saveFileDialog1.FileName);
            lbl_status.Text = "Archive successful";
        }

        private void btn_archiveAndDelete_Click(object sender, EventArgs e) {
            throw new Exception("Not implemented yet, for safety");
        }
    }
}
