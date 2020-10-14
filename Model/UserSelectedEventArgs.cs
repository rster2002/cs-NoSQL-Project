﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class UserSelectedEventArgs: EventArgs {
        public User selectedUser;

        public UserSelectedEventArgs(User selectedUser) {
            this.selectedUser = selectedUser;
        }
    }
}