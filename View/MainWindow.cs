using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.views;

namespace View {
    public partial class MainWindow: Form {
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
            mainMenuStrip.Visible = show;
        }

        private void TicketsToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadView(new TicketManager());
        }
    }
}
