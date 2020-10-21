using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service {
    public class UserService {
        private UserRepo UserRepo = new UserRepo();

        public IEnumerable<User> GetUsers() => UserRepo.GetAll();

        public void AddUser(User user) => UserRepo.Add(user);
    }
}
