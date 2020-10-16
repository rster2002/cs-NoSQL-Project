using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
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

        // TODO: Login and password checking should happen here
        public bool Login(User user, string password) {
            
            if (Verify(user.PasswordHash, password)) {
                LoggedInUser = user;
                return true;
            }
            return false;
            
        }
        public bool Verify(string clearText, string data) {
            var dataBytes = Convert.FromBase64String(data);
            return Verify(clearText, dataBytes);
        }

        /// The default number of Iterations
        private const int DefaultIterations = 10000;


        /// Holds all possible Hash Versions
        private readonly Dictionary<short, HashVersion> _versions = new Dictionary<short, HashVersion>
        {
            {
                1, new HashVersion
                {
                    Version = 1,
                    KeyDerivation = KeyDerivationPrf.HMACSHA256,
                    HashSize = 256 / 8,
                    SaltSize = 128 / 8
                }
            }
        };

        /// The default Hash Version, which should be used, if a new Hash is Created
        private HashVersion DefaultVersion => _versions[1];

        /// Checks if a given hash uses the latest version
        public bool IsLatestHashVersion(byte[] data) {
            var version = BitConverter.ToInt16(data, 0);
            return version == DefaultVersion.Version;
        }

        /// Checks if a given hash uses the latest version
        public bool IsLatestHashVersion(string data) {
            var dataBytes = Convert.FromBase64String(data);
            return IsLatestHashVersion(dataBytes);
        }

        /// Gets a random byte array
        public byte[] GetRandomBytes(int length) {
            var data = new byte[length];
            using (var randomNumberGenerator = RandomNumberGenerator.Create()) {
                randomNumberGenerator.GetBytes(data);
            }
            return data;
        }

        /// Creates a Hash of a clear text
        public byte[] Hash(string clearText, int iterations = DefaultIterations) {
            //get current version
            var currentVersion = DefaultVersion;

            //get the byte arrays of the hash and meta information
            var saltBytes = GetRandomBytes(currentVersion.SaltSize);
            var versionBytes = BitConverter.GetBytes(currentVersion.Version);
            var iterationBytes = BitConverter.GetBytes(iterations);
            var hashBytes = KeyDerivation.Pbkdf2(clearText, saltBytes, currentVersion.KeyDerivation, iterations, currentVersion.HashSize);

            //calculate the indexes for the combined hash
            var indexVersion = 0;
            var indexIteration = indexVersion + 2;
            var indexSalt = indexIteration + 4;
            var indexHash = indexSalt + currentVersion.SaltSize;

            //combine all data to one result hash
            var resultBytes = new byte[2 + 4 + currentVersion.SaltSize + currentVersion.HashSize];
            Array.Copy(versionBytes, 0, resultBytes, indexVersion, 2);
            Array.Copy(iterationBytes, 0, resultBytes, indexIteration, 4);
            Array.Copy(saltBytes, 0, resultBytes, indexSalt, currentVersion.SaltSize);
            Array.Copy(hashBytes, 0, resultBytes, indexHash, currentVersion.HashSize);
            return resultBytes;
        }

        /// Creates a Hash of a clear text and convert it to a Base64 String representation
        public string HashToString(string clearText, int iterations = DefaultIterations) {
            var data = Hash(clearText, iterations);
            return Convert.ToBase64String(data);
        }

        /// Verifies a given clear Text against a hash
        public bool Verify(string clearText, byte[] data) {
            //Get the current version and number of iterations
            var currentVersion = _versions[BitConverter.ToInt16(data, 0)];
            var iteration = BitConverter.ToInt32(data, 2);

            //Create the byte arrays for the salt and hash
            var saltBytes = new byte[currentVersion.SaltSize];
            var hashBytes = new byte[currentVersion.HashSize];

            //Calculate the indexes of the salt and the hash
            var indexSalt = 2 + 4; // Int16 (Version) and Int32 (Iteration)
            var indexHash = indexSalt + currentVersion.SaltSize;

            //Fill the byte arrays with salt and hash
            Array.Copy(data, indexSalt, saltBytes, 0, currentVersion.SaltSize);
            Array.Copy(data, indexHash, hashBytes, 0, currentVersion.HashSize);

            //Hash the current clearText with the parameters given via the data
            var verificationHashBytes = KeyDerivation.Pbkdf2(clearText, saltBytes, currentVersion.KeyDerivation, iteration, currentVersion.HashSize);

            //Check if generated hashes are equal
            return hashBytes.SequenceEqual(verificationHashBytes);
        }
    }
}
