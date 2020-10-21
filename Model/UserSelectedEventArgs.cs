using System;

namespace Model {
    public class UserSelectedEventArgs: EventArgs {
        public User selectedUser;

        public UserSelectedEventArgs(User selectedUser) {
            this.selectedUser = selectedUser;
        }
    }
}
