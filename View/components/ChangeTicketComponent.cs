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

        public event EventHandler OnCancelEvent;
        public event EventHandler OnConfirmEvent;

        protected override void OnCancel() {
            OnCancelEvent.Invoke(this, new EventArgs());
        }

        protected override void OnConfirm(Ticket ticket) {
            OnConfirmEvent.Invoke(this, new EventArgs());
            ticketService.UpdateTicket(ticket);
        }
    }
}
