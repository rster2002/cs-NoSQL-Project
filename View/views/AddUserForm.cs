using Model;
using Service;
using System;
using System.Windows.Forms;

namespace View.views {
    public partial class AddUserForm: Form {

        private User user;
        private UserService userService;
        public AddUserForm() {
            InitializeComponent();

            user = new User();
            userService = new UserService();
        }

        private void btnAdd_Click(object sender, EventArgs e) {

            if(txtFirstName.Text != "" && txtLastName.Text != "" && cmbType.Text != "" && txtEmail.Text != "" && txtPhoneNumber.Text != "" && cmbLocation.Text != "" && txtPassword.Text != "") {

                user.Name = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.Email = txtEmail.Text;
                user.PhoneNumber = txtPhoneNumber.Text;    
                user.PasswordHash = txtPassword.Text;

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

                userService.AddUser(user);

                MessageBox.Show($"Created an account for {user.Name} {user.LastName}", "Created succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else {
                MessageBox.Show("Fill in all the fields to proceed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e) {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
