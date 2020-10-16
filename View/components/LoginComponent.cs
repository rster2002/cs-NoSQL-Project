﻿using System;
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
using System.Security.Cryptography;

namespace View.components {
    public partial class LoginComponent: UserControl {
        
        private User user = new User();
        private UserService userService = new UserService();
        public LoginComponent() {
            InitializeComponent();
            lblwarning.Hide();   
        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            UserSession userSession = UserSession.GetInstance();
            var userName = TBUserName.Text;
            string password = TBpassword.Text;
            User user = SearchUser(userName);
            if (user == null) {
                lblwarning.Text = @"User name is inco.";
                lblwarning.Show();
            } else if (userSession.Login(user, TBpassword.Text)) {
                lblwarning.Text = @"correctpassword.";
                lblwarning.Show();
            } else {
                //lblwarning.Text = @"Incorrect password.";
                lblwarning.Text = userSession.ReturnString(user, TBpassword.Text);
                lblwarning.Show();
            }
        }

        private User SearchUser(string userName) {
            List<User> users = userService.GetUsers().ToList();
            foreach (User item in users) {
                if (item.Username.Equals(userName)) {
                    user = item;
                    return user;
                }
            }
            return null;
        }
    }
}
