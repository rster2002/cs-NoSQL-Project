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

        private Dictionary<IncidentType, Color> incidentTypeColorMap = new Dictionary<IncidentType, Color>() {
            { IncidentType.Hardware, Color.FromArgb(255, 230, 132, 67) },
            { IncidentType.Software, Color.FromArgb(255, 68, 157, 235) },
            { IncidentType.Service, Color.FromArgb(255, 68, 235, 124) },
        };

        public TicketDetailsComponent(Ticket ticket) {
            this.ticket = ticket;

            InitializeComponent();
            FillControls();
        }

        private void FillControls() {
            ticketSubjectLabel.Text = "Subject: " + ticket.Subject;

            priorityBackground.BackColor = priorityColorMap[ticket.Priority];
            priorityLabel.Text = "Priority: " + ticket.Priority.ToString();

            string deadlineString = deadlineStringMap[ticket.Deadline];
            deadlineBackground.BackColor = deadlineColorMap[ticket.Deadline];
            deadlineLabel.Text = "Deadline: " + deadlineString;

            reportedByLabel.Text = "Reported by: " + ticket.ReportedByUser.ToString();

            reportedAtBackground.BackColor = ticket.IsOverdue(DateTime.Now) ? Color.Red : Color.Green;
            reportedAtLabel.Text = "Date reported: " + ticket.DateReported.ToString("dd/MM/yyyy");

            descriptionBox.Text = ticket.Description;

            incidentTypeBackground.BackColor = incidentTypeColorMap[ticket.TypeOfIncident];
            incidentTypeLabel.Text = ticket.TypeOfIncident.ToString();

            statusBackground.BackColor = ticket.OpenStatus == OpenState.Closed ? Color.Red : Color.Green;
            statusLabel.Text = ticket.OpenStatus.ToString().ToUpper();
        }
    }
}
