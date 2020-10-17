using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Service {
    public class UserSession {
        private static UserSession instance;

        public User LoggedInUser { private set; get; }

        private UserSession() { }

        public static UserSession GetInstance() {
            if (instance == null) instance = new UserSession();
            return instance;
        }

        public bool Login(User user, string password) {
            // TODO: Login and password checking should happen here
            throw new NotImplementedException();
        }
    }
}
