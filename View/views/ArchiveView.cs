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
    public partial class ArchiveView: UserControl {
        public ArchiveView() {
            InitializeComponent();
            PopulateView();
        }

        private void PopulateView() {
            ArchiveComponent archiveComponent = new ArchiveComponent();

            panel1.Controls.Add(archiveComponent);
        }
    }
}
