﻿using System.Windows.Forms;

namespace View.components {
    public class Popup: Form {
        public Popup(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;

            Controls.Add(userControl);
            if (userControl.MinimumSize.Width > 0 && userControl.MinimumSize.Height > 0) {
                Size = new System.Drawing.Size(userControl.MinimumSize.Width + 50, userControl.MinimumSize.Height + 50);
            }
        }
    }
}
