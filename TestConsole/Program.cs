using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;
using View.components;

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
            Ticket ticket = ticketRepo.GetAll().First();

            Form window = new Form();
            ChangeTicketComponent changeTicketComponent = new ChangeTicketComponent(ticket);

            changeTicketComponent.OnCancelEvent += (s, e) => window.Close();
            changeTicketComponent.OnTicketChangedEvent += (s, e) => window.Close();

            window.Controls.Add(changeTicketComponent);
            window.ShowDialog();
        }
    }
}
