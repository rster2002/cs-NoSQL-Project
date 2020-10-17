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
using Service;

namespace View.components {
    public partial class TicketDetailsComponent: UserControl {
        private Ticket ticket;
        private UserSession userSession = UserSession.GetInstance();

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
            CheckShowEditButton();
        }

        public event EventHandler CloseTicketDetailsEvent;

        private void FillControls() {
            // Subject
            ticketSubjectLabel.Text = "Subject: " + ticket.Subject;

            // Priority
            priorityBackground.BackColor = priorityColorMap[ticket.Priority];
            priorityLabel.Text = "Priority: " + ticket.Priority.ToString();

            // Deadline
            string deadlineString = deadlineStringMap[ticket.Deadline];
            deadlineBackground.BackColor = deadlineColorMap[ticket.Deadline];
            deadlineLabel.Text = "Deadline: " + deadlineString;

            // Reported by
            reportedByLabel.Text = "Reported by: " + ticket.ReportedByUser.ToString();

            // Date reported
            reportedAtBackground.BackColor = ticket.IsOverdue(DateTime.Now) ? Color.Red : Color.Green;
            reportedAtLabel.Text = "Date reported: " + ticket.DateReported.ToString("HH:mm dd/MM/yyyy");

            // Description
            descriptionBox.Text = ticket.Description;

            // Incident type
            incidentTypeBackground.BackColor = incidentTypeColorMap[ticket.TypeOfIncident];
            incidentTypeLabel.Text = ticket.TypeOfIncident.ToString();

            // Status
            statusBackground.BackColor = ticket.OpenStatus == OpenState.Closed ? Color.Red : Color.Green;
            statusLabel.Text = ticket.OpenStatus.ToString().ToUpper();
        }

        private void CheckShowEditButton() {
            editTicketButton.Visible = userSession.LoggedInUser.UserType == UserType.Editor;
        }

        private void EditButtonOnClick(object sender, EventArgs _) {
            ChangeTicketComponent changeTicketComponent = new ChangeTicketComponent(ticket);
            Popup popup = new Popup(changeTicketComponent);

            changeTicketComponent.OnDeleteEvent += (s, e) => {
                popup.Close();

                if (CloseTicketDetailsEvent != null) {
                    CloseTicketDetailsEvent.Invoke(this, new EventArgs());
                }
            };

            changeTicketComponent.OnTicketChangedEvent += (s, e) => {
                ticket = e.ticket;

                popup.Close();
                FillControls();
            };

            changeTicketComponent.OnCancelEvent += (s, e) => popup.Close();

            popup.ShowDialog();
        }
    }
}
