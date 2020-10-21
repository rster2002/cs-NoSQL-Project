using System;

namespace Model {
    public class TicketSelectedEventArgs: EventArgs {
        public Ticket selectedTicket;

        public TicketSelectedEventArgs(Ticket selectedTicket) {
            this.selectedTicket = selectedTicket;
        }
    }
}
