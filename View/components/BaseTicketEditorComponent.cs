﻿using System;
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
            if (selectedUser == null) return false;

            return true;
        }

        private void SetTypeOfIncidentComboBoxValue(IncidentType incidentType) {
            foreach (ComboBoxOption option in typeOfIncidentComboBox.Items) { 
                if ((IncidentType) option.Value == incidentType) {
                    typeOfIncidentComboBox.SelectedItem = option;
                }
            }
        }

        private void SetPriorityComboBoxValue(Priority priority) {
            foreach (ComboBoxOption option in priorityComboBox.Items) {
                if ((Priority) option.Value == priority) {
                    priorityComboBox.SelectedItem = option;
                }
            }
        }

        private void SetDeadlineComboBoxValue(Deadline deadline) {
            foreach (ComboBoxOption option in deadlineComboBox.Items) {
                if ((Deadline) option.Value == deadline) {
                    deadlineComboBox.SelectedItem = option;
                }
            }
        }

        protected void LoadTicket(Ticket ticket) {
            if (ticket.Id != null) ticketId = ticket.Id;
            if (ticket.Subject != null) subjectTextBox.Text = ticket.Subject;
            if (ticket.Description != null) descriptionTextBox.Text = ticket.Description;

            SetTypeOfIncidentComboBoxValue(ticket.TypeOfIncident);
            SetPriorityComboBoxValue(ticket.Priority);
            SetDeadlineComboBoxValue(ticket.Deadline);

            dateTimeReportedPicker.Value = ticket.DateReported;

            if (ticket.ReportedByUser != null) {
                selectUserButton.Text = ticket.ReportedByUser.ToString();
                selectedUser = ticket.ReportedByUser;
            }
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
                Id = ticketId,
                DateReported = reportedAt,
                Deadline = deadline,
                Priority = priority,
                Subject = subject,
                TypeOfIncident = incidentType,
                Description = description,
                ReportedByUser = selectedUser,
            };

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

        protected abstract void OnCancel();
        protected abstract void OnConfirm(Ticket ticket);
    }
}
