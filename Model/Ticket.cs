using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Model {
    public class Ticket: IEntity {
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
            set { } // Waarom staat hier een set?
        }

        public bool ValidateIntegraty() {
            if (Id == null) return false;
            if (DateReported == null) return false;
            if (Subject == null) return false;
            if (ReportedByUser == null) return false;
            if (Description == null) return false;

            return true;
        }

        public bool IsOverdue() => IsOverdue(DateTime.Now);
        public bool IsOverdue(DateTime comparasonDatetime) {
            DateTime dueDate = DueDate;

            return comparasonDatetime > dueDate;
        }

        public static string CSVHeader() {
            return "DateReported;Subject;TypeOfIncident;ReportedByUser;Priority;Deadline;Description;OpenStatus";
        }

        public string CSVData() {
            return $"{DateReported};{Subject.Replace(';', ',')};{TypeOfIncident};{ReportedByUser.Username.Replace(';', ',')};{Priority};{Deadline};{Description.Replace(';', ',')};{OpenStatus}";
        }
    }
}
