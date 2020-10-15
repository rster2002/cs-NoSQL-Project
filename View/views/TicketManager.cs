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

namespace View.views {
    public partial class TicketManager: UserControl {
        private TicketService TicketService = new TicketService();
        private TicketListView TicketListView;

        public TicketManager() {
            TicketListView = new TicketListView(TicketService.GetTickets().ToList());
            TicketListView.Dock = DockStyle.Fill;
            TicketListView.OnTicketSelectedEvent += (s, e) => {
                new Popup(new TicketDetailsComponent(e.selectedTicket))
                    .ShowDialog();
            };

            InitializeComponent();
            PopulateControls();
        }

        private void PopulateControls() {
            listViewTargetPanel.Controls.Add(TicketListView);
        }

        private void CreateTicketButtonOnClick(object sender, EventArgs _) {
            CreateTicketComponent createTicketComponent = new CreateTicketComponent();
            Popup popup = new Popup(createTicketComponent);

            createTicketComponent.OnCancelEvent += (s, e) => popup.Close();
            createTicketComponent.OnTicketCreatedEvent += (s, e) => {
                TicketListView.SetTickets(TicketService.GetTickets().ToList());
                popup.Close();
            };

            popup.ShowDialog();
        }
    }
}
