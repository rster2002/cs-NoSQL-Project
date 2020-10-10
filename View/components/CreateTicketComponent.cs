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
            Dock = DockStyle.Fill;

            InitializeComponent();
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes() {
            // Populate the Incident Type Combo Box
            typeOfIncidentComboBox.Items.Add(new ComboBoxOption("Hardware", IncidentType.Hardware));
            typeOfIncidentComboBox.Items.Add(new ComboBoxOption("Software", IncidentType.Software));
            typeOfIncidentComboBox.Items.Add(new ComboBoxOption("Service", IncidentType.Service));

            // Populate the Priority Combo Box
            priorityComboBox.Items.Add(new ComboBoxOption("High", Priority.High));
            priorityComboBox.Items.Add(new ComboBoxOption("Normal", Priority.Normal));
            priorityComboBox.Items.Add(new ComboBoxOption("Low", Priority.Low));

            // Populate the Deadline Combo Box
            deadlineComboBox.Items.Add(new ComboBoxOption("7 days", Deadline.SevenDays));
            deadlineComboBox.Items.Add(new ComboBoxOption("14 days", Deadline.FourteenDays));
            deadlineComboBox.Items.Add(new ComboBoxOption("28 days", Deadline.TwentyEightDays));
            deadlineComboBox.Items.Add(new ComboBoxOption("6 months", Deadline.SixMonths));
        }

        private void UpdateButtonEnabled(object sender, EventArgs e) {
            confirmButton.Enabled = ValidateFormInputs();
        }

        private bool ValidateFormInputs() {
            string subject = subjectTextBox.Text;
            string description = descriptionTextBox.Text;

            ComboBoxOption typeOfIncidentOption = (ComboBoxOption) typeOfIncidentComboBox.SelectedItem;
            ComboBoxOption priorityOption = (ComboBoxOption) priorityComboBox.SelectedItem;
            ComboBoxOption deadlineOption = (ComboBoxOption) deadlineComboBox.SelectedItem;

            if (subject.Length == 0) return false;
            if (description.Length == 0) return false;
            if (typeOfIncidentOption == null) return false;
            if (priorityOption == null) return false;
            if (deadlineOption == null) return false;

            return true;
        }

        private void ConfirmButtonOnClick(object sender, EventArgs e) {
            DateTime reportedAt = dateTimeReportedPicker.Value;
            string subject = subjectTextBox.Text;

            ComboBoxOption typeOfIncidentOption = (ComboBoxOption) typeOfIncidentComboBox.SelectedItem;
            ComboBoxOption priorityOption = (ComboBoxOption) priorityComboBox.SelectedItem;
            ComboBoxOption deadlineOption = (ComboBoxOption) deadlineComboBox.SelectedItem;

            IncidentType incidentType = (IncidentType) typeOfIncidentOption.Value;
            Priority priority = (Priority) priorityOption.Value;
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
