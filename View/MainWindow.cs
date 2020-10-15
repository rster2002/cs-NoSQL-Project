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
        }

        public void LoadView(UserControl userControl) {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(userControl);
        }

        private void TicketsToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadView(new TicketManager());
        }
    }
}
