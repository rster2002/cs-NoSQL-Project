using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View.components {
    public partial class TicketListView: UserControl {
        private List<Ticket> tickets;

        private Dictionary<Priority, Color> priorityColorMap = new Dictionary<Priority, Color>() {
            { Priority.Low, Color.FromArgb(255, 105, 245, 175) },
            { Priority.Normal, Color.FromArgb(255, 63, 223, 235) },
            { Priority.High, Color.FromArgb(255, 255, 101, 84) },
        };

        public TicketListView(List<Ticket> tickets) {
            this.tickets = tickets;

            InitializeComponent();
            RefreshList();
        }

        public event EventHandler<TicketSelectedEventArgs> OnTicketSelectedEvent;

        public void SetTickets(List<Ticket> tickets) {
            this.tickets = tickets;
            RefreshList();
        }

        private void RefreshList() {
            List<ListViewItem> items = tickets.Select(MapTicketToListViewItem)
                .ToList();

            ticketsListView.Items.Clear();
            ticketsListView.Items.AddRange(items.ToArray());
        }

        private ListViewItem MapTicketToListViewItem(Ticket ticket) {
            ListViewItem listViewItem = new ListViewItem(ticket.Subject);
            listViewItem.UseItemStyleForSubItems = false;
            listViewItem.Tag = ticket;

            listViewItem.SubItems.Add(ticket.ReportedByUser.ToString());

            ListViewItem.ListViewSubItem reportedAtSubItem = listViewItem.SubItems.Add(ticket.DateReported.ToString());
            reportedAtSubItem.BackColor = ticket.IsOverdue(DateTime.Now) ? Color.Red : Color.Green;

            ListViewItem.ListViewSubItem statusSubItem = listViewItem.SubItems.Add(ticket.OpenStatus.ToString());
            statusSubItem.BackColor = ticket.OpenStatus == OpenState.Open ? Color.Green : Color.Red;


            ListViewItem.ListViewSubItem prioritySubItem = listViewItem.SubItems.Add(ticket.Priority.ToString());
            prioritySubItem.BackColor = priorityColorMap[ticket.Priority];

            return listViewItem;
        }

        private void TicketsListViewOnDoubleClick(object sender, EventArgs e) {
            if (ticketsListView.SelectedItems.Count == 1) {
                ListViewItem listViewItem = ticketsListView.SelectedItems[0];
                Ticket ticket = (Ticket) listViewItem.Tag;

                if (OnTicketSelectedEvent != null) {
                    OnTicketSelectedEvent.Invoke(this, new TicketSelectedEventArgs(ticket));
                }
            }
        }
    }
}
