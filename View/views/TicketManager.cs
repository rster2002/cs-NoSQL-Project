using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using View.components;
using Model;
using System.Data.SqlTypes;

namespace View.views {
    public partial class TicketManager: UserControl {
        private TicketService TicketService = new TicketService();
        private TicketListView TicketListView;
        private string query = "";

        public TicketManager() {
            TicketListView = new TicketListView(TicketService.GetTickets().ToList());

            // Configure the TicketListView
            TicketListView.Dock = DockStyle.Fill;
            TicketListView.OnTicketSelectedEvent += (s, e) => {
                // Create a component and add it to a popup
                TicketDetailsComponent ticketDetailsComponent = new TicketDetailsComponent(e.selectedTicket);
                Popup popup = new Popup(ticketDetailsComponent);

                // Add EventHandlers
                popup.FormClosed += (s2, e2) => RefreshTickets();
                ticketDetailsComponent.CloseTicketDetailsEvent += (s2, e2) => {
                    popup.Close();
                    RefreshTickets();
                };

                popup.ShowDialog();
            };

            InitializeComponent();
            PopulateControls();
        }

        private void RefreshTickets() {
            List<Ticket> tickets = FilterTickets(TicketService.GetTickets().ToList());
            TicketListView.SetTickets(tickets);
        }

        private List<Ticket> FilterTickets(List<Ticket> filterTickets) {
            return filterTickets.Where(ticket => {
                    // Check whether or not some fields contians the query.
                    if (ticket.Subject.ToLower().Contains(query)) return true;
                    if (ticket.Description.ToLower().Contains(query)) return true;
                    if (ticket.ReportedByUser.ToString().ToLower().Contains(query)) return true;

                    return false;
                })
                .ToList();
        }

        private void PopulateControls() {
            listViewTargetPanel.Controls.Add(TicketListView);
        }

        private void CreateTicketButtonOnClick(object sender, EventArgs _) {
            CreateTicketComponent createTicketComponent = new CreateTicketComponent();
            Popup popup = new Popup(createTicketComponent);

            // Add EventHandlers
            createTicketComponent.OnCancelEvent += (s, e) => popup.Close();
            createTicketComponent.OnTicketCreatedEvent += (s, e) => {
                RefreshTickets();
                popup.Close();
            };

            popup.ShowDialog();
        }

        private void SearchTextBoxOnChange(object sender, EventArgs e) {
            query = searchTextBox.Text.ToLower();
            RefreshTickets();
        }
    }
}
