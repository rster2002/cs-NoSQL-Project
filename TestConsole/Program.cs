using DAL;
using System;

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
