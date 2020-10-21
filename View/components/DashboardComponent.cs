using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace View.components {
    public partial class DashboardComponent : UserControl {
        private TicketService ticketService = new TicketService();
        public DashboardComponent() {
            InitializeComponent();
            FillDashboard();
        }

        public DashboardComponent(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }

        private void FillDashboard() {
            long totalTickets, unsolvedTickets, overdueTickets;

            IEnumerable<Ticket> tickets = ticketService.GetTicketsForLoggedInUser();
            totalTickets = tickets.Count();
            unsolvedTickets = tickets.Count(x => x.OpenStatus != OpenState.Closed);
            overdueTickets = tickets.Count(x => x.OpenStatus != OpenState.Closed && x.DueDate < DateTime.Now);

            //chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            //chart1.Series[0].Points.AddXY(unsolvedTickets, unsolvedTickets);
            //chart1.Series[1].Points.AddXY(overdueTickets, overdueTickets);
            //chart1.ChartAreas[0].AxisY.Maximum = totalTickets;

            chart1.Series[0].Points[0].YValues = new double[] { totalTickets - unsolvedTickets };
            chart1.Series[0].Points[1].YValues = new double[] { unsolvedTickets - overdueTickets };
            chart1.Series[0].Points[2].YValues = new double[] { overdueTickets };

            lbl_info.Text = $"Total tickets: {totalTickets}\nTotal Unsolved tickets: {unsolvedTickets}\nTotal overdue tickets: {overdueTickets}";
        }

        private void DashboardComponent_Load(object sender, EventArgs e) {

        }
    }
}
