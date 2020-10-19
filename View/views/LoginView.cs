using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.components;

namespace View.views {
    public partial class LoginView: UserControl {
        private MainWindow mainWindow;

        public LoginView(MainWindow mainWindow) {
            this.mainWindow = mainWindow;

            InitializeComponent();
            PopulateView();
        }
        private void PopulateView() {
            LoginComponent loginComponent = new LoginComponent();

            loginComponent.OnLogin += (s, e) => {
                mainWindow.ShowMenuControls(true);
                mainWindow.LoadView(new DashboardComponent());
            };

            centerPanel.Controls.Add(loginComponent);
        }
    }
}