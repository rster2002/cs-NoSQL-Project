using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        public void Start() {
            Console.WriteLine(ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString);
        }
    }
}
