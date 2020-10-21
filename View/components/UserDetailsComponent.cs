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
    public partial class UserDetailsComponent: UserControl {
        private User user;

        public UserDetailsComponent(User user) {
            this.user = user;

            InitializeComponent();
            RefreshDetails();
        }

        public event EventHandler OnClose;

        public void RefreshDetails() {
            fullNameLabel.Text = user.ToString();
            userTypeLabel.Text = user.UserType.ToString();
            emailLabel.Text = user.Email;
            phoneNumberLabel.Text = user.PhoneNumber;
            locationLabel.Text = user.LocationBranch.ToString();
        }

        private void CloseButtonOnClick(object sender, EventArgs e) {
            if (OnClose != null) {
                OnClose.Invoke(this, new EventArgs());
            }
        }
    }
}
