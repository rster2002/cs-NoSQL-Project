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

        public IEnumerable<Ticket> GetTickets() {
            return TicketRepo.GetAll();
        }

        public void AddTicket(Ticket ticket) => TicketRepo.Add(ticket);
        public void CloseTicket(Ticket ticket) {
            ticket.OpenStatus = OpenState.Closed;
            TicketRepo.Update(ticket);
        }

        public void OpenTicket(Ticket ticket) {
            ticket.OpenStatus = OpenState.Open;
            TicketRepo.Update(ticket);
        }

        public void UpdateTicket(Ticket ticket) => TicketRepo.Update(ticket);
        public IEnumerable<Ticket> GetTicketsByUser(User user) {
            return TicketRepo.GetAll()
                .Where(ticket => ticket.ReportedByUser.Id == user.Id);
        }

        public void DeleteTicket(Ticket ticket) {
            TicketRepo.Delete(ticket);
        }

        public void DeleteTicketById(string id) {
            TicketRepo.Delete(id);
        }
    }
}
