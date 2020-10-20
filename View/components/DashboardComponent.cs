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
            totalTickets = ticketService.GetTicketCount();
            unsolvedTickets = ticketService.GetUnsolvedTicketCount();
            overdueTickets = ticketService.GetPastDeadlineTicketCount();

            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            chart1.Series[0].Points.AddXY("0", unsolvedTickets);
            chart1.Series[1].Points.AddXY("0", overdueTickets);
            chart1.ChartAreas[0].AxisY.Maximum = totalTickets;

            lbl_info.Text = $"Total tickets: {totalTickets}\nTotal Unsolved tickets: {unsolvedTickets}\nTotal overdue tickets: {overdueTickets}";
        }

        private void DashboardComponent_Load(object sender, EventArgs e) {

        }
    }
}
