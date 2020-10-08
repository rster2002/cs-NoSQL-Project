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
using System.Security.Cryptography.X509Certificates;

namespace View.components {
    public partial class CreateTicketComponent: UserControl {
        private TicketService ticketService = new TicketService();

        public CreateTicketComponent() {
            InitializeComponent();
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes() {
            // Populate the Incident Type Combo Box
            typeOfIncidentComboBox.Items.Add(new ComboBoxOption(IncidentType.Hardware));
            typeOfIncidentComboBox.Items.Add(new ComboBoxOption(IncidentType.Software));
            typeOfIncidentComboBox.Items.Add(new ComboBoxOption(IncidentType.Service));

            // Populate the Priority Combo Box
            priorityComboBox.Items.Add(new ComboBoxOption(Priority.High));
            priorityComboBox.Items.Add(new ComboBoxOption(Priority.Normal));
            priorityComboBox.Items.Add(new ComboBoxOption(Priority.Low));

            // Populate the Deadline Combo Box
            deadlineComboBox.Items.Add(new ComboBoxOption("7 days", Deadline.SevenDays));
            deadlineComboBox.Items.Add(new ComboBoxOption("14 days", Deadline.FourteenDays));
            deadlineComboBox.Items.Add(new ComboBoxOption("28 days", Deadline.TwentyEightDays));
            deadlineComboBox.Items.Add(new ComboBoxOption("6 months", Deadline.SixMonths));
        }

        private void ConfirmButtonOnClick(object sender, EventArgs e) {
            DateTime reportedAt = dateTimeReportedPicker.Value;
            string subject = subjectTextBox.Text;
            ComboBoxOption typeOfIncidentOption = (ComboBoxOption) typeOfIncidentComboBox.SelectedItem;
            IncidentType incidentType = (IncidentType) typeOfIncidentOption.Value;

            // Get user
            ComboBoxOption priorityOption = (ComboBoxOption) priorityComboBox.SelectedItem;
            Priority priority = (Priority) priorityOption.Value;

            ComboBoxOption deadlineOption = (ComboBoxOption) deadlineComboBox.SelectedItem;
            Deadline deadline = (Deadline) deadlineOption.Value;
            string description = descriptionTextBox.Text;

            Ticket ticket = new Ticket() {
                DateReported = reportedAt,
                Deadline = deadline,
                Priority = priority,
                Description = description,
                Subject = subject,
                TypeOfIncident = incidentType,
            };

            Console.WriteLine(ticket);

            //ticketService.AddTicket(ticket);
        }
    }
}
