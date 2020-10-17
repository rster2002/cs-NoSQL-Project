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

namespace View.views {
    public partial class UserManagement: UserControl {
        private UserService userService;
        private List<User> users;

        public UserManagement() {
            InitializeComponent();

            userService = new UserService();
            users = (List<User>) userService.GetUsers();

            AddUsers();
        }

        private void AddUsers() 
        {
            foreach (User u in users) 
            {
                ListViewItem lvi = new ListViewItem(u.Id.ToString());
                lvi.SubItems.Add(u.Email.ToString());
                lvi.SubItems.Add(u.Name.ToString());
                lvi.SubItems.Add(u.LastName.ToString());
                lstUsers.Items.Add(lvi);
            }
        }
    }
}
