using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View.components {
    public partial class TicketDetailsComponent: UserControl {
        private Ticket ticket;
        private Dictionary<Priority, Color> priorityColorMap = new Dictionary<Priority, Color>() {
            { Priority.Low, Color.FromArgb(255, 105, 245, 175) },
            { Priority.Normal, Color.FromArgb(255, 63, 223, 235) },
            { Priority.High, Color.FromArgb(255, 255, 101, 84) },
        };

        private Dictionary<Deadline, string> deadlineStringMap = new Dictionary<Deadline, string>() {
            { Deadline.SevenDays, "7 days" },
            { Deadline.FourteenDays, "14 days" },
            { Deadline.TwentyEightDays, "28 days" },
            { Deadline.SixMonths, "6 months" },
        };

        private Dictionary<Deadline, Color> deadlineColorMap = new Dictionary<Deadline, Color>() {
            { Deadline.SevenDays, Color.FromArgb(255, 255, 101, 84) },
            { Deadline.FourteenDays, Color.FromArgb(255, 247, 178, 49) },
            { Deadline.TwentyEightDays, Color.FromArgb(255, 63, 223, 235) },
            { Deadline.SixMonths, Color.FromArgb(255, 105, 245, 175) },
        };

        public TicketDetailsComponent(Ticket ticket) {
            this.ticket = ticket;

            InitializeComponent();
            FillControls();
        }

        private void FillControls() {
            ticketSubjectLabel.Text = ticket.Subject;

            priorityBackground.BackColor = priorityColorMap[ticket.Priority];
            priorityLabel.Text = "Priority: " + ticket.Priority.ToString();

            string deadlineString = deadlineStringMap[ticket.Deadline];
            deadlineBackground.BackColor = deadlineColorMap[ticket.Deadline];
            deadlineLabel.Text = "Deadline: " + deadlineString;

            descriptionBox.Text = ticket.Description;
        }
    }
}
