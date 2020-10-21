using Model;

namespace DAL {
    public class UserRepo: BaseRepo<User> {
        public UserRepo() : base("Users") { }
    }
}
