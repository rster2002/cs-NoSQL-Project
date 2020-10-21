using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.components;

namespace View.views {
    public partial class UserManagement: UserControl {
        private UserService userService;
        private TicketService ticketService;
        private IEnumerable<Ticket> tickets;

        public UserManagement() {
            InitializeComponent();

            txtSearch.Text = "Enter a letter or email and press enter...";
            txtSearch.ForeColor = Color.Gray;

            userService = new UserService();
            ticketService = new TicketService();

            LoopThroughUsers();
        }

        private void LoopThroughUsers() {
            IEnumerable<User> users = userService.GetUsers();

            tickets = ticketService.GetTickets();

            lstUsers.Items.Clear();
            foreach (User user in users) {
                lstUsers.Items.Add(AddUsers(user));
            }
        }

        private ListViewItem AddUsers(User u) {

            ListViewItem lvi = new ListViewItem(u.Id.ToString());
            lvi.SubItems.Add(u.Email.ToString());
            lvi.SubItems.Add(u.Name.ToString());
            lvi.SubItems.Add(u.LastName.ToString());
            lvi.SubItems.Add(tickets.Count(x => x.ReportedByUser.Id == u.Id).ToString());

            lvi.Tag = u;

            return lvi;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter) {

                // Get the query string and get the list of users
                string query = ((TextBox) sender).Text.ToLower();
                List<User> users = userService.GetUsers().ToList();

                // Filter and map the users
                List<ListViewItem> listViewItems = users.Where(user => {
                    // If one of the fields contains the query, return true
                    string emailAddress = user.Email.ToLower();

                    return emailAddress.Contains(query);
                })
                    .Select(AddUsers)
                    .ToList();

                // Add the items to the list
                lstUsers.Items.Clear();
                lstUsers.Items.AddRange(listViewItems.ToArray());
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e) {
            AddUserForm adForm = new AddUserForm();
            adForm.ShowDialog();
        }

        private void lstUsers_DoubleClick(object sender, EventArgs e) {
            if (lstUsers.SelectedItems.Count == 0) return;
            ListViewItem selectedListViewItem = lstUsers.SelectedItems[0];
            User selectedUser = (User) selectedListViewItem.Tag;

            UserDetailsComponent userDetailsComponent = new UserDetailsComponent(selectedUser);
            Popup popup = new Popup(userDetailsComponent);

            userDetailsComponent.OnClose += (s1, e1) => popup.Close();

            popup.ShowDialog();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e) {
            if (txtSearch.Text == "Enter a letter or email and press enter...") {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e) {
            if (txtSearch.Text == "") {
                txtSearch.Text = "Enter a letter or email and press enter...";
                txtSearch.ForeColor = Color.Gray;
            }
        }
    }
}
