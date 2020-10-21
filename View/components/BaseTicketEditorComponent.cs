using Model;
using Service;
using System;
using System.Windows.Forms;

namespace View.components {
    public abstract partial class BaseTicketEditorComponent: UserControl {
        private User selectedUser;
        private UserSession UserSession = UserSession.GetInstance();
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
            statusComboBox.Items.Add(new ComboBoxOption("Escalated", OpenState.Escalated));
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
                SetSelectedUser(e.selectedUser);
                UpdateButtonEnabled(s, e);

                popup.Close();
            };

            popup.ShowDialog();
        }

        private void SetSelectedUser(User user) {
            selectedUser = user;
            selectUserButton.Text = user.ToString();
        }

        private void DeleteButtonOnClick(object sender, EventArgs e) {
            OnDeleteTicket();
        }

        protected void EnableFormControlsByLoggedInUser() {
            EnableFormControlsByUser(UserSession.LoggedInUser);
        }

        protected void EnableFormControlsByUser(User user) {
            UserType userType = user.UserType;

            if (userType == UserType.Normal) {
                SetSelectedUser(user);

                SetComboBoxByValue(statusComboBox, OpenState.Open);
                AllowChangingOfStatus(false);
                AllowDeletionOfTicket(false);
                AllowChangingDateTimeReported(false);
                AllowChangingReportedBy(false);
            } else {
                AllowChangingOfStatus(true);
                AllowDeletionOfTicket(true);
                AllowChangingDateTimeReported(true);
                AllowChangingReportedBy(true);
            }
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

        protected void AllowChangingDateTimeReported(bool allowChange) {
            dateTimeReportedPicker.Enabled = allowChange;
        }

        protected void AllowChangingReportedBy(bool allowChange) {
            selectUserButton.Enabled = allowChange;
        }

        protected abstract void OnCancel();
        protected abstract void OnConfirm(Ticket ticket);
        protected abstract void OnDeleteTicket();
    }
}
