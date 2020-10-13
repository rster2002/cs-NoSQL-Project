using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class TicketEditEventArgs: EventArgs {
        public Ticket ticket;

        public TicketEditEventArgs(Ticket ticket) {
            this.ticket = ticket;
        }
    }
}
