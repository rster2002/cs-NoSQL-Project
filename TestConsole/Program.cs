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

            Form window = new Form();
            TicketListView ticketListView = new TicketListView(ticketRepo.GetAll().ToList());
            ticketListView.Dock = DockStyle.Fill;

            ticketListView.OnTicketSelectedEvent += (s, e) => {
                new Popup(new TicketDetailsComponent(e.selectedTicket))
                    .ShowDialog();
            };

            window.Controls.Add(ticketListView);
            window.ShowDialog();
        }
    }
}
