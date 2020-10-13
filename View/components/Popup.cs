using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.components {
    class Popup: Form {
        public Popup(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;
            Controls.Add(userControl);
        }
    }
}
