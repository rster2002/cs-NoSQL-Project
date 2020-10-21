using Model;
using System.Security.Cryptography;
using System.Text;

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
            string hash = Encrypt(password, user.Salt);
            if (hash == user.PasswordHash) {
                LoggedInUser = user;
                return true;
            }
            return false;
        }

        public void Logout() {
            LoggedInUser = null;
        }

        public string Encrypt(string strData, int salt) {
            return EncryptHash(strData + salt.ToString());
        }

        private string EncryptHash(string strData) {
            using (SHA256 sha256Hash = SHA256.Create()) {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(strData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
