using System;

namespace Model {
    public class TicketEditEventArgs: EventArgs {
        public Ticket ticket;

        public TicketEditEventArgs(Ticket ticket) {
            this.ticket = ticket;
        }
    }
}
