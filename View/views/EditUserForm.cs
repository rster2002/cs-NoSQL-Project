using Model;
using Service;
using System;
using System.Windows.Forms;

namespace View.views {
    public partial class EditUserForm: Form {
        private User user;
        private UserService userService;

        public EditUserForm(User user) {
            this.user = user;

            userService = new UserService();

            InitializeComponent();

            EditUser();
        }

        public void EditUser() {
            txtUsername.Text = user.Username;
            txtFirstName.Text = user.Name;
            txtLastName.Text = user.LastName;
            txtEmail.Text = user.Email;
            txtPhoneNumber.Text = user.PhoneNumber;
            cmbLocation.SelectedItem = user.LocationBranch.ToString();
            cmbType.SelectedItem = user.UserType.ToString();

        }

        public void SaveUser() {
            user.Username = txtUsername.Text;
            user.Name = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.PhoneNumber = txtPhoneNumber.Text;

            switch (cmbType.SelectedItem) {
                case "Normal":
                    user.UserType = UserType.Normal;
                    break;
                case "Editor":
                    user.UserType = UserType.Editor;
                    break;
            }

            switch (cmbLocation.SelectedItem) {
                case "Haarlem":
                    user.LocationBranch = LocationBranch.Haarlem;
                    break;
                case "Amsterdam":
                    user.LocationBranch = LocationBranch.Amsterdam;
                    break;
                case "Knuppeldam":
                    user.LocationBranch = LocationBranch.Knuppeldam;
                    break;
                case "HQ":
                    user.LocationBranch = LocationBranch.HQ;
                    break;
            }

            userService.SaveUser(user);

            MessageBox.Show($"Changed account details for {user.Name} {user.LastName}", "Edit succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveUser();
        }
    }
}
