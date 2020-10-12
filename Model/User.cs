using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class User : IEntity {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public UserType UserType { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public bool ValidateIntegraty() {
            if (Id == null) return false;
            if (Username == null) return false;
            if (PasswordHash == null) return false;
            if (Name == null) return false;
            if (LastName == null) return false;
            if (Email == null) return false;

            return true;
        }

        public override string ToString() {
            return $"{Name} {LastName}";
        }
    }
}
