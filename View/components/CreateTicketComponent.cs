using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.components {
    public class CreateTicketComponent: BaseTicketEditorComponent {
        TicketService ticketService = new TicketService();

        public CreateTicketComponent() {
            SetConfirmButtonText("Create ticket");
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
