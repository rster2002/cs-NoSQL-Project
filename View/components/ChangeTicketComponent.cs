using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.components {
    public class ChangeTicketComponent: BaseTicketEditorComponent {
        private TicketService ticketService = new TicketService();
        private Ticket ticket;

        public ChangeTicketComponent(Ticket ticket) {
            this.ticket = ticket;

            SetConfirmButtonText("Save changes");
            LoadTicket(ticket);
        }

        public event EventHandler<TicketEditEventArgs> OnTicketChangedEvent;
        public event EventHandler OnCancelEvent;
        public event EventHandler OnDeleteEvent;

        protected override void OnCancel() {
            if (OnCancelEvent != null) {
                OnCancelEvent.Invoke(this, new EventArgs());
            }
        }

        protected override void OnConfirm(Ticket ticket) {
            ticketService.UpdateTicket(ticket);

            if (OnTicketChangedEvent != null) {
                OnTicketChangedEvent.Invoke(this, new TicketEditEventArgs(ticket));
            }
        }

        protected override void OnDeleteTicket() {
            ticketService.DeleteTicket(ticket);

            if (OnDeleteEvent != null) {
                OnDeleteEvent.Invoke(this, new EventArgs());
            }
        }
    }
}
