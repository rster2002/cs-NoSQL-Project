using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model {
    public class Ticket : IEntity {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime DateReported { get; set; }
        public string Subject { get; set; }
        public IncidentType TypeOfIncident { get; set; }
        public User ReportedByUser { get; set; }
        public Priority Priority { get; set; }
        public Deadline Deadline { get; set; }
        public string Description { get; set; }
        public OpenState OpenStatus { get; set; }

        public bool ValidateIntegraty() {
            if (Id == null) return false;
            if (DateReported == null) return false;
            if (Subject == null) return false;
            if (ReportedByUser == null) return false;
            if (Description == null) return false;

            return true;
        }
    }
}
