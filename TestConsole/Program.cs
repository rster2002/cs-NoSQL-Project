using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace TestConsole {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.Start();

            Console.WriteLine("End of Test Console...");
            Console.ReadKey();
        }

        public void Start() {
            TicketRepo ticketRepo = new TicketRepo();
            foreach (Ticket ticket in ticketRepo.GetAll()) {
                Console.WriteLine(ticket);
            }
        }

        public void StartA() {
            User user = new User() {
                Name = "A",
                LastName = "B",
                Email = "r@r.au",
            };

            Ticket ticket = new Ticket() {
                Subject = "Test Ticket",
                DateReported = DateTime.Now,
                Deadline = Deadline.FourteenDays,
                Priority = Priority.High,
                ReportedByUser = user,
                TypeOfIncident = IncidentType.Software,
                Description = @"Testing whether or not the database will work",
            };

            TicketRepo ticketRepo = new TicketRepo();
            ticketRepo.Add(ticket);
        }
    }
}
