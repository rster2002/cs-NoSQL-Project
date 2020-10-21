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
                mainWindow.LoadView(new DashboardView());
            };

            centerPanel.Controls.Add(loginComponent);
        }
    }
}