using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model {
    public class Ticket : IEntity {
        private Dictionary<Deadline, TimeSpan> deadlineTimespanMap = new Dictionary<Deadline, TimeSpan>() {
            { Deadline.SevenDays, new TimeSpan(7, 0, 0, 0) },
            { Deadline.FourteenDays, new TimeSpan(14, 0, 0, 0) },
            { Deadline.TwentyEightDays, new TimeSpan(28, 0, 0, 0) },
            { Deadline.SixMonths, new TimeSpan(30 * 6, 0, 0, 0) },
        };

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
        public DateTime DueDate {
            get {
                TimeSpan timeSpan = deadlineTimespanMap[Deadline];
                DateTime dueDate = DateReported + timeSpan;

                return dueDate;
            }
            set { }
        }

        public bool ValidateIntegraty() {
            if (Id == null) return false;
            if (DateReported == null) return false;
            if (Subject == null) return false;
            if (ReportedByUser == null) return false;
            if (Description == null) return false;

            return true;
        }

        public bool IsOverdue(DateTime comparasonDatetime) {
            if (comparasonDatetime == null) comparasonDatetime = DateTime.Now;
            DateTime dueDate = DueDate;

            return comparasonDatetime > dueDate;
        }
    }
}
