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
using Service;
using View.components;
using View.views;

namespace View.components {
    public partial class UserDetailsComponent: UserControl {
        private UserSession userSession = UserSession.GetInstance();
        private User user;
        private TicketService ticketService = new TicketService();

        public UserDetailsComponent(User user) {
            this.user = user;

            InitializeComponent();

            TicketListView ticketListView = new TicketListView(ticketService.GetTicketsByUser(user).ToList());
            ticketListView.Dock = DockStyle.Fill;

            ticketListView.OnTicketSelectedEvent += (s, e) => {
                TicketDetailsComponent ticketDetailsComponent = new TicketDetailsComponent(e.selectedTicket);
                Popup popup = new Popup(ticketDetailsComponent);

                popup.ShowDialog();
            };

            ticketsListViewTargetPanel.Controls.Add(ticketListView);

            RefreshDetails();
        }

        public event EventHandler OnClose;

        public void RefreshDetails() {
            fullNameLabel.Text = user.ToString();
            userTypeLabel.Text = user.UserType.ToString();
            emailLabel.Text = user.Email;
            phoneNumberLabel.Text = user.PhoneNumber;
            locationLabel.Text = user.LocationBranch.ToString();

            editButton.Visible = userSession.LoggedInUser.UserType == UserType.Editor;
        }

        private void CloseButtonOnClick(object sender, EventArgs e) {
            if (OnClose != null) {
                OnClose.Invoke(this, new EventArgs());
            }
        }

        private void editButton_Click(object sender, EventArgs e) {
            EditUserForm euForm = new EditUserForm(user);
            euForm.ShowDialog();
        }
    }
}
