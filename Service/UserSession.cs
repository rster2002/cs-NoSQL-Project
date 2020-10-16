using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        //code for password encrypter / decrypter
        // set permutations
        private const String strPermutation = "ouiveyxaqtd";

        public bool Login(User user, string password) {
            string hash = Encrypt(password, user.Salt);
            if (user.PasswordHash == hash) {
                LoggedInUser = user;
                return true;
            }
            return false;
        }
        public string Encrypt(string strData, int salt) {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(strData), salt));
        }

        private byte[] Encrypt(byte[] strData, int inSalt) {
            byte[] salt = BitConverter.GetBytes(inSalt);
            HashAlgorithm algorithm = new SHA256Managed();
            byte[] password = new byte[strData.Length + salt.Length];
            for (int i = 0; i < strData.Length; i++) {
                password[i] = strData[i];
            }
            for (int i = 0; i < salt.Length; i++) {
                password[strData.Length + i] = salt[i];
            }
            return algorithm.ComputeHash(password);
        }
    }
}
