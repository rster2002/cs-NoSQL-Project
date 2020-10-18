using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Windows.Forms;
using DAL;
using Model;
using Service;
using View.components;

namespace TestConsole {
    class Program {
        private Random random = new Random();
        private List<string> objects = new List<string>() {
            "mop",
            "trash bag",
            "sidewalk",
            "keychain",
            "drill press",
            "butter knife",
            "pasta strainer",
            "sheep",
            "lime",
            "box of baking soda",
            "soap",
            "plush dinosaur",
            "pair of tongs",
            "pinecone",
            "flowers",
            "pair of glasses",
            "spool of ribbon",
            "plush unicorn",
            "thimble",
            "baseball bat",
            "tire swing",
            "toy boat",
            "fake flowers",
            "can of chili",
            "notepad",
            "shampoo",
            "lighter",
            "food",
            "rat",
            "wine glass",
            "hand mirror",
            "hamster",
            "panda",
            "glasses",
            "fishing hook",
            "cookie tin",
            "hand bag",
            "bottle of glue",
            "button",
            "rabbit",
            "wireless control",
            "rubber duck",
            "sticker book",
            "CD",
            "box of chalk",
            "rubber stamp",
            "pepper shaker",
            "grocery list",
            "ring",
            "empty jar",
            "snail shell",
            "spoon",
            "statuette",
            "plush pony",
            "pair of rubber gloves",
            "leg warmers",
            "whale",
            "tube of lipstick",
            "perfume",
            "cement stone",
            "bag of cotton balls",
            "cars",
            "pop can",
            "tomato",
            "canvas",
            "clock",
            "flashlight",
            "plush cat",
            "can of beans",
            "music CD",
            "egg timer",
            "acorn",
            "paperclip",
            "cellphone",
            "dolphin",
            "fridge",
            "money",
            "crowbar",
            "wrench",
            "lamp",
            "picture frame",
            "chair",
            "keyboard",
            "key",
            "notebook",
            "baseball hat",
            "tube of lip balm",
            "plush bear",
            "turtle",
            "credit card",
            "candy cane",
            "garden spade",
            "flyswatter",
            "steak knife",
            "cup",
            "salt shaker",
            "ice pick",
            "sharpie",
            "monitor",
            "beef"
        };

        private List<string> promptStrings = new List<string>() {
            "Please fix my {object}",
            "My {object} is broken, {continue}",
            "My {object} is broken, {continue}",
            "Having trouble with my {object}, {continue}",
            "Yesterday my {object} worked just fine, but now it doesn't work anymore!",
            "My {object} broke down, {continue}",
            "I dropped my {object} out of the window.",
            "How do I replace someones {object} without them noticing?",
            "Got a new {object} but it isn't working properly",
        };

        private List<string> descriptionStrings = new List<string>() {
            "After spending a lot of time with my {object}, it finally broke down. {continue}",
            "I might have done something wrong because my {object} doesn't work as indented, {continue}",
            "Got my new {object} today but it's making wierd noices, {continue}",
            "It's the 7th time this month that my {object} acted up and I'm getting frustracted, {coninue}",
            "Haven't had any issues for the last 10 years, but now my {object} is acting up. {continue}"
        };

        private List<string> continueStrings = new List<string>() {
            "Can it be replaced?",
            "Can this be fixed?",
            "How can I fix it?",
            "Can someone come to fix it?",
            "Please help!",
            "Can I get a replacement?",
            "Any idea on how to fix it?",
        };

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
            List<User> users = GenerateUsers();
            List<Ticket> tickets = GenerateTickets(users);

            Console.WriteLine(tickets);
        }

        private List<User> GenerateUsers() {
            List<User> users = new List<User>();

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

            return users;
        }

        private List<Ticket> GenerateTickets(List<User> users) {
            List<Ticket> tickets = new List<Ticket>();

            for (int i = 0; i < 100; i++) {
                tickets.Add(GenerateTicket(users));
            }

            return tickets;
        }

        private Ticket GenerateTicket(List<User> users) {
            int month = random.Next(1, 10);
            int day = random.Next(1, 27);
            int hours = random.Next(0, 24);
            int minutes = random.Next(0, 60);
            int seconds = random.Next(0, 60);
            DateTime dateTimeReported = new DateTime(2020, month, day, hours, minutes, seconds);

            string obj = objects[random.Next(0, objects.Count)];
            IncidentType incidentType = (IncidentType) random.Next(0, 3);
            Priority priority = (Priority) random.Next(0, 3);
            OpenState openState = (OpenState) random.Next(0, 2);

            Deadline[] deadlines = { Deadline.SevenDays, Deadline.FourteenDays, Deadline.TwentyEightDays, Deadline.SixMonths };
            Deadline deadline = deadlines[random.Next(0, 4)];

            User user = users[random.Next(0, users.Count)];

            return new Ticket() {
                Subject = GenerateSubject(obj),
                Description = GenerateDescription(obj),
                DateReported = dateTimeReported,
                TypeOfIncident = incidentType,
                Priority = priority,
                OpenStatus = openState,
                Deadline = deadline,
                ReportedByUser = user,
            };
        }

        private string GenerateSubject(string obj) {
            string prompt = promptStrings[random.Next(0, promptStrings.Count)];
            string coninueString = continueStrings[random.Next(0, continueStrings.Count)];

            return prompt
                .Replace("{continue}", coninueString)
                .Replace("{object}", obj);
        }

        private string GenerateDescription(string obj) {
            string description = descriptionStrings[random.Next(0, descriptionStrings.Count)];
            string coninueString = continueStrings[random.Next(0, continueStrings.Count)];

            return description
                .Replace("{continue}", coninueString)
                .Replace("{object}", obj);
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
