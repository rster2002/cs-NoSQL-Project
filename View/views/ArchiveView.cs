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
    public partial class ArchiveView : UserControl {
        private ArchiveService archiveService = new ArchiveService();
        private TicketListView TicketListView = new TicketListView(new List<Ticket>());

        public ArchiveView() {
            InitializeComponent();

            TicketListView.OnTicketSelectedEvent += (s1, e1) => {
                TicketDetailsComponent ticketDetailsComponent = new TicketDetailsComponent(e1.selectedTicket);
                Popup popup = new Popup(ticketDetailsComponent);
                popup.ShowDialog();
            };

            TicketListView.Dock = DockStyle.Fill;
            ticketListViewTargetPanel.Controls.Add(TicketListView);
        }

        public ArchiveView(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }

        private void cb_beginDate_CheckedChanged(object sender, EventArgs e) {
            dtp_beginDate.Enabled = cb_beginDate.Checked;
        }

        private void cb_endDate_CheckedChanged(object sender, EventArgs e) {
            dtp_endDate.Enabled = cb_endDate.Checked;
        }

        private long ticketCount;

        private void btn_getTicketCount_Click(object sender, EventArgs e) {
            archiveService.BeginDate = dtp_beginDate.Value;
            archiveService.EndDate = dtp_endDate.Value;

            archiveService.UseBeginDate = cb_beginDate.Checked;
            archiveService.UseEndDate = cb_endDate.Checked;

            List<Ticket> ticketsToBeArchived = archiveService.GetTickets();
            ticketCount = ticketsToBeArchived.Count;
            lbl_ticketCount.Text = $"Ticket Count: {ticketCount}";

            TicketListView.SetTickets(ticketsToBeArchived);

            if (ticketCount > 0) {
                btn_archive.Enabled = true;
                btn_archiveAndDelete.Enabled = true;
            } 
            else {
                btn_archive.Enabled = false;
                btn_archiveAndDelete.Enabled = false;
            }
        }

        private void btn_archive_Click(object sender, EventArgs e) {
            saveFileDialog1.FileOk += OnFileOkArchive;
            saveFileDialog1.ShowDialog();
        }

        private void btn_archiveAndDelete_Click(object sender, EventArgs e) {
            //throw new Exception("Not implemented yet, for safety");
            if (MessageBox.Show($"Are you certain you want to archive and delete {ticketCount} tickets?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                saveFileDialog1.FileOk += OnFileOkArchiveDelete;
                saveFileDialog1.ShowDialog();
            }
        }

        private void OnFileOkArchive(object sender, EventArgs e) {
            archiveService.Archive(saveFileDialog1.FileName);
            saveFileDialog1.FileOk -= OnFileOkArchive;
            MessageBox.Show("Archive successful");
        }

        private void OnFileOkArchiveDelete(object sender, EventArgs e) {
            archiveService.ArchiveAndDelete(saveFileDialog1.FileName);
            saveFileDialog1.FileOk -= OnFileOkArchiveDelete;
            MessageBox.Show("Archive successful");
        }
    }
}
