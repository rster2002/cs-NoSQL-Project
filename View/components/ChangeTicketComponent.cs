using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.components {
    public class ChangeTicketComponent: BaseTicketEditorComponent {
        TicketService ticketService = new TicketService();

        public event EventHandler<TicketEditEventArgs> OnTicketChangedEvent;
        public event EventHandler OnCancelEvent;

        protected override void OnCancel() {
            OnCancelEvent.Invoke(this, new EventArgs());
        }

        protected override void OnConfirm(Ticket ticket) {
            ticketService.UpdateTicket(ticket);
            OnTicketChangedEvent.Invoke(this, new TicketEditEventArgs(ticket));
        }
    }
}
