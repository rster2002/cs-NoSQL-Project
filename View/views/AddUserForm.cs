using System;
using Model;
using Service;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if(txtFirstName.Text != "" && txtLastName.Text != "" && cmbType.Text != "" && txtEmail.Text != "" && txtPassword.Text != "") {

                user.Name = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.Email = txtEmail.Text;
                user.PasswordHash = txtPassword.Text;

                switch (cmbType.SelectedItem) {
                    case "Normal":
                        user.UserType = UserType.Normal;
                        break;
                    case "Editor":
                        user.UserType = UserType.Editor;
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
