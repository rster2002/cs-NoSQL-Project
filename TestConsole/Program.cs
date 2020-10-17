using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
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
            PopulateDatabase();
        }

        private void PopulateDatabase() {
            List<User> users = new List<User>();
            Random random = new Random();

            string[] rows = File.ReadAllLines("users.csv");

            foreach (string row in rows) {
                const string defaultPassword = "HelloWorld";

                string[] columns = row.Split(',');
                int salt = random.Next(1, 10000000);

                string username = columns[0] + columns[1];
                string passwordHash = HashString(defaultPassword + salt);

                users.Add(new User() {
                    Name = columns[0],
                    LastName = columns[1],
                    Email = columns[2],
                    UserType = columns[3] == "0" ? UserType.Normal : UserType.Editor,
                    Salt = salt,
                    PasswordHash = passwordHash,
                    Username = username,
                });
            }

            Console.WriteLine(users);
        }

        private string HashString(string input) {
            using (SHA256 sha256 = SHA256.Create()) {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in bytes) {
                    stringBuilder.Append(b.ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}
