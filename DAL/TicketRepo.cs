using Model;

namespace DAL {
    public class TicketRepo: BaseRepo<Ticket> {
        public TicketRepo() : base("Tickets") { }
    }
}
