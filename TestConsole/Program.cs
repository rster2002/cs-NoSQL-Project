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
            //UserRepo userRepo = new UserRepo();
            //userRepo.Add(new User() {
            //    Name = "Jack",
            //    LastName = "Sparrow",
            //    Email = "blackpearl@pirate.car",
            //    Username = "CaptainJack",
            //    UserType = UserType.Normal,
            //    PasswordHash = "05ffb3697804f5520e368b7c1228de79c1df98d888bbb498f1e3a4834a45a214",
            //    Salt = 8228422,
            //});

            Form window = new Form();
            SelectUserComponent selectUserComponent = new SelectUserComponent();


            selectUserComponent.Dock = DockStyle.Fill;

            window.Controls.Add(selectUserComponent);
            window.ShowDialog();
        }
    }
}
