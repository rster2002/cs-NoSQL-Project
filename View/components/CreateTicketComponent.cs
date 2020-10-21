using Model;
using Service;
using System;

namespace View.components {
    public class CreateTicketComponent: BaseTicketEditorComponent {
        TicketService ticketService = new TicketService();

        public CreateTicketComponent() {
            SetConfirmButtonText("Create ticket");

            EnableFormControlsByLoggedInUser();
            AllowChangingOfStatus(false);
            AllowDeletionOfTicket(false);
        }

        public event EventHandler<TicketEditEventArgs> OnTicketCreatedEvent;
        public event EventHandler OnCancelEvent;

        protected override void OnCancel() {
            if (OnCancelEvent != null) {
                OnCancelEvent.Invoke(this, new EventArgs());
            }
        }

        protected override void OnConfirm(Ticket ticket) {
            ticketService.AddTicket(ticket);

            if (OnTicketCreatedEvent != null) {
                OnTicketCreatedEvent.Invoke(this, new TicketEditEventArgs(ticket));
            }
        }

        protected override void OnDeleteTicket() {
            OnCancel();
        }
    }
}
