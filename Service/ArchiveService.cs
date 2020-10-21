using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace Service {
    public class ArchiveService {
        private TicketRepo ticketRepo = new TicketRepo();

        public bool UseBeginDate { get; set; }
        public bool UseEndDate { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public ArchiveService() {
            BeginDate = DateTime.Now;
            EndDate = DateTime.Now;
            UseBeginDate = false;
            UseEndDate = false;
        }

        private void WriteCSV(string path, List<Ticket> tickets) {
            using (StreamWriter toWrite = new StreamWriter(path)) {
                toWrite.WriteLine(Ticket.CSVHeader());
                foreach (Ticket x in tickets) {
                    toWrite.WriteLine(x.CSVData());
                }
            }
        }
        /*
        private bool CompareDate(bool compare, DateTime baseTime, DateTime isLower) {
            if (!compare)
                return true;

            return baseTime > isLower;
        }
        */
        // x => CompareDate(UseBeginDate, x.DateReported, BeginDate) && CompareDate(UseEndDate, EndDate, x.DateReported)
        public long GetTicketCount() => ticketRepo.Count(x =>
            (!UseBeginDate || x.DateReported > BeginDate) &&
            (!UseEndDate || x.DateReported < EndDate)
        );

        public List<Ticket> GetTickets() {
            return (List<Ticket>) ticketRepo.Get(x =>
            (!UseBeginDate || x.DateReported > BeginDate) &&
            (!UseEndDate || x.DateReported < EndDate));
        }

        public void Archive(string path) {
            List<Ticket> tickets = GetTickets();
            if (tickets.Count <= 0)
                return;

            WriteCSV(path, tickets);
        }

        public void ArchiveAndDelete(string path) {
            Archive(path);

            ticketRepo.DeleteMultiple(x =>
            (!UseBeginDate || x.DateReported > BeginDate) &&
            (!UseEndDate || x.DateReported < EndDate));
        }
    }
}
