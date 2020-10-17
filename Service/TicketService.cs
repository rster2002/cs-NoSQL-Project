using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service {
    public class TicketService {
        private TicketRepo TicketRepo = new TicketRepo();

        public void AddTicket(Ticket ticket) => TicketRepo.Add(ticket);
        public void CloseTicket(Ticket ticket) {
            ticket.OpenStatus = OpenState.Closed;
            TicketRepo.Update(ticket);
        }

        public void OpenTicket(Ticket ticket) {
            ticket.OpenStatus = OpenState.Reopened;
            TicketRepo.Update(ticket);
        }

        public void UpdateTicket(Ticket ticket) => TicketRepo.Update(ticket);
        public IEnumerable<Ticket> GetTicketsByUser(User user) {
            return TicketRepo.GetAll().ToList();
        }

        public long GetTicketCount() => TicketRepo.Count(x => true);
        public long GetUnsolvedTicketCount() => TicketRepo.Count(x => x.OpenStatus != OpenState.Closed);
        public long GetPastDeadlineTicketCount() => TicketRepo.Count(x => (x.OpenStatus != OpenState.Closed && x.DueDate > DateTime.Now));
    }
}
