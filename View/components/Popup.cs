using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.components {
    public class Popup: Form {
        public Popup(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;

            Controls.Add(userControl);
            if (userControl.MinimumSize.Width > 0 && userControl.MinimumSize.Height > 0) {
                Size = userControl.MinimumSize;
            }
        }
    }
}
