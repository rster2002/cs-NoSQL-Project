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
            Form window = new Form();

            Ticket ticket = new Ticket() {
                Subject = "Why even bother?",
                Priority = Priority.High,
                Deadline = Deadline.SevenDays,
                Description = "Something's not working as it should because why would it finally actually work this stupid piece of shit. How is windows forms actually something you'd want to work with? Are you insane?! Do you hate yourself that much? Aparently you do. Why not use a actual technology stack that doesn't want to make you want to down yourself in hot goat piss?"
            };

            TicketDetailsComponent ticketDetailsComponent = new TicketDetailsComponent(ticket);

            ticketDetailsComponent.Dock = DockStyle.Fill;
            window.Controls.Add(ticketDetailsComponent);

            window.ShowDialog();
        }
    }
}
