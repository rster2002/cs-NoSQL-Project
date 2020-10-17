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
using Model;

namespace View.components {
    public partial class SelectUserComponent: UserControl {
        private UserService UserService = new UserService();

        public SelectUserComponent() {
            InitializeComponent();
            PopulateControls();
        }

        public event EventHandler<UserSelectedEventArgs> OnUserSelectedEvent;
        public event EventHandler OnCancelEvent;

        private void PopulateControls() {
            IEnumerable<User> users = UserService.GetUsers();

            userListView.Items.Clear();
            foreach (User user in users) {
                userListView.Items.Add(MapUserToListViewItem(user));
            }
        }

        private ListViewItem MapUserToListViewItem(User user) {
            ListViewItem listViewItem = new ListViewItem(user.Name);
            listViewItem.SubItems.Add(user.LastName);
            listViewItem.SubItems.Add(user.Email);

            listViewItem.Tag = user;

            return listViewItem;
        }

        private void ConfirmButtonOnClick(object sender, EventArgs e) {
            ListViewItem item = userListView.SelectedItems[0];
            User user = (User) item.Tag;

            if (OnUserSelectedEvent != null) {
                OnUserSelectedEvent.Invoke(this, new UserSelectedEventArgs(user));
            }
        }

        private void CancelButtonOnClick(object sender, EventArgs e) {
            if (OnCancelEvent != null) {
                OnCancelEvent.Invoke(this, new EventArgs());
            }
        }

        private void UserListViewOnSelectedIndexChanged(object sender, EventArgs e) {
            if (userListView.SelectedItems.Count == 0) return;

            confirmButton.Enabled = true;
        }

        private void UserSearchTextBoxOnChange(object sender, EventArgs e) {
            // Get the query string and get the list of users
            string query = ((TextBox) sender).Text.ToLower();
            List<User> users = UserService.GetUsers().ToList();

            // Filter and map the users
            List<ListViewItem> listViewItems = users.Where(user => {
                    // If one of the fields contains the query, return true
                    string firstName = user.Name.ToLower();
                    string lastName = user.LastName.ToLower();
                    string emailAddress = user.Email.ToLower();

                    return firstName.Contains(query) ||
                        lastName.Contains(query) ||
                        emailAddress.Contains(query);
                })
                .Select(MapUserToListViewItem)
                .ToList();

            // Add the items to the list
            userListView.Items.Clear();
            userListView.Items.AddRange(listViewItems.ToArray());
        }
    }
}
