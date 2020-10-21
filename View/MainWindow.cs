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
            this.Text = "NoDesk";
        }

        public void LoadView(UserControl userControl) {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(userControl);
        }

        public void ShowMenuControls(bool show = false) {
            bool loggedInUserIsEditor = userSession.LoggedInUser.UserType == UserType.Editor;

            usersToolStripMenuItem.Visible = loggedInUserIsEditor;
            ArchiveToolStripMenuItem.Visible = loggedInUserIsEditor;
            mainMenuStrip.Visible = show;
            lbl_userName.Visible = show;

            if (show) {
                lbl_userName.Text = $"Welcome, {userSession.LoggedInUser.Name}";
                mainMenuStrip.Left = Width - mainMenuStrip.Width - 20;
            }
        }

        private void TicketsToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadView(new TicketManager());
        }

        private void UsersToolStipMenuItemOnClick(object sender, EventArgs e) {
            LoadView(new UserManagement());
        }

        private void ArchiveToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadView(new ArchiveView());
        }

        private void DashboardToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadView(new DashboardView());
        }
        
        private void LogoutToolStripMenuItemOnClick(object sender, EventArgs e) {
            userSession.Logout();

            mainMenuStrip.Visible = false;
            lbl_userName.Visible = false;
            LoadView(new LoginView(this));
        }

        private void MainWindow_Resize(object sender, EventArgs e) {
            mainMenuStrip.Left = Width - mainMenuStrip.Width - 20;
        }
    }
}
