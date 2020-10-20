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
using View.views;


namespace View {
    public partial class MainWindow: Form {
        private UserSession userSession = UserSession.GetInstance();
        public MainWindow() {
            InitializeComponent();
            LoadView(new LoginView(this));

            mainMenuStrip.Visible = false;
        }

        public void LoadView(UserControl userControl) {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(userControl);
        }

        public void ShowMenuControls(bool show = false) {
            if (userSession.LoggedInUser.UserType == UserType.Normal) {
                usersToolStripMenuItem.Visible = false;
            }
            mainMenuStrip.Visible = show;
        }

        private void TicketsToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadView(new TicketManager());
        }

        private void UsersToolStipMenuItemOnClick(object sender, EventArgs e) {
            LoadView(new UserManagement());
        }

        private void DashboardToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadView(new DashboardComponent());
        }
        
        private void LogoutToolStripMenuItemOnClick(object sender, EventArgs e) {
            userSession.Logout();

            mainMenuStrip.Visible = false;
            LoadView(new LoginView(this));
        }
    }
}
