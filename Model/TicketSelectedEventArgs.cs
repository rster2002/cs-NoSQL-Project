using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class TicketSelectedEventArgs: EventArgs {
        public Ticket selectedTicket;

        public TicketSelectedEventArgs(Ticket selectedTicket) {
            this.selectedTicket = selectedTicket;
        }
    }
}
