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
using System.Runtime.Remoting.Channels;

namespace View.components {
    public abstract partial class BaseTicketEditorComponent: UserControl {
        private TicketService ticketService = new TicketService();
        private User selectedUser;
        private string ticketId;

        public BaseTicketEditorComponent() {
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

            // Populate the status Combo Box
            statusComboBox.Items.Add(new ComboBoxOption("Open", OpenState.Open));
            statusComboBox.Items.Add(new ComboBoxOption("Closed", OpenState.Closed));
            statusComboBox.SelectedIndex = 0;
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
            ComboBoxOption openStatusOption = (ComboBoxOption) statusComboBox.SelectedItem;

            if (subject.Length == 0) return false;
            if (description.Length == 0) return false;
            if (typeOfIncidentOption == null) return false;
            if (priorityOption == null) return false;
            if (deadlineOption == null) return false;
            if (openStatusOption == null) return false;
            if (selectedUser == null) return false;

            return true;
        }

        private void SetComboBoxByValue<T>(ComboBox comboBox, T value) {
            foreach (ComboBoxOption option in comboBox.Items) {
                if (((T) option.Value).Equals(value)) {
                    comboBox.SelectedItem = option;
                }
            }
        }

        protected void LoadTicket(Ticket ticket) {
            // Check wheher or not the field is filled and sets the form fields
            if (ticket.Id != null) ticketId = ticket.Id;
            if (ticket.Subject != null) subjectTextBox.Text = ticket.Subject;
            if (ticket.Description != null) descriptionTextBox.Text = ticket.Description;
            
            SetComboBoxByValue(typeOfIncidentComboBox, ticket.TypeOfIncident);
            SetComboBoxByValue(priorityComboBox, ticket.Priority);
            SetComboBoxByValue(deadlineComboBox, ticket.Deadline);
            SetComboBoxByValue(statusComboBox, ticket.OpenStatus);

            dateTimeReportedPicker.Value = ticket.DateReported;

            if (ticket.ReportedByUser != null) {
                selectUserButton.Text = ticket.ReportedByUser.ToString();
                selectedUser = ticket.ReportedByUser;
            }
        }

        private void ConfirmButtonOnClick(object sender, EventArgs e) {
            DateTime reportedAt = dateTimeReportedPicker.Value;
            string subject = subjectTextBox.Text;

            // Get the combo box options
            ComboBoxOption typeOfIncidentOption = (ComboBoxOption) typeOfIncidentComboBox.SelectedItem;
            ComboBoxOption priorityOption = (ComboBoxOption) priorityComboBox.SelectedItem;
            ComboBoxOption deadlineOption = (ComboBoxOption) deadlineComboBox.SelectedItem;
            ComboBoxOption openStatusOption = (ComboBoxOption) statusComboBox.SelectedItem;

            // Get the values from the combo box options
            IncidentType incidentType = (IncidentType) typeOfIncidentOption.Value;
            Priority priority = (Priority) priorityOption.Value;
            Deadline deadline = (Deadline) deadlineOption.Value;
            OpenState openState = (OpenState) openStatusOption.Value;

            string description = descriptionTextBox.Text;

            // Construct the ticket. If ticketId is null, MongoDB will create a new id
            Ticket ticket = new Ticket() {
                Id = ticketId,
                DateReported = reportedAt,
                Deadline = deadline,
                Priority = priority,
                Subject = subject,
                TypeOfIncident = incidentType,
                Description = description,
                ReportedByUser = selectedUser,
                OpenStatus = openState,
            };
            
            // Trigger callback
            OnConfirm(ticket);
        }

        private void CancelButtonOnClick(object sender, EventArgs e) {
            OnCancel();
        }

        private void SelectUserButtonOnClick(object sender, EventArgs _) {
            SelectUserComponent selectUserComponent = new SelectUserComponent();
            Popup popup = new Popup(selectUserComponent);

            // Add event handlers
            selectUserComponent.OnCancelEvent += (s, e) => popup.Close();
            selectUserComponent.OnUserSelectedEvent += (s, e) => {
                selectedUser = e.selectedUser;
                UpdateButtonEnabled(s, e);

                selectUserButton.Text = e.selectedUser.ToString();
                popup.Close();
            };

            popup.ShowDialog();
        }

        private void DeleteButtonOnClick(object sender, EventArgs e) {
            OnDeleteTicket();
        }

        protected void SetConfirmButtonText(string text) {
            confirmButton.Text = text;
        }

        protected void AllowChangingOfStatus(bool allowChange) {
            statusComboBox.Enabled = allowChange;
        }

        protected void AllowDeletionOfTicket(bool allowDeletion) {
            deleteButton.Visible = allowDeletion;
        }

        protected abstract void OnCancel();
        protected abstract void OnConfirm(Ticket ticket);
        protected abstract void OnDeleteTicket();
    }
}
