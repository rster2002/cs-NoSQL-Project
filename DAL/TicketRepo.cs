﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class TicketRepo: BaseRepo<Ticket> {
        public TicketRepo(): base("Tickets") { }
    }
}
