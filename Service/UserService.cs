using DAL;
using Model;
using System.Collections.Generic;

namespace Service {
    public class UserService {
        private UserRepo UserRepo = new UserRepo();

        public IEnumerable<User> GetUsers() => UserRepo.GetAll();

        public void AddUser(User user) => UserRepo.Add(user);

        public void SaveUser(User user) => UserRepo.Update(user);
    }
}
