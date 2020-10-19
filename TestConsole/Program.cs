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
        }
    }
}
