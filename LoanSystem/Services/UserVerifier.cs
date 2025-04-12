using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using LoanSystem.Models;
using System.Text.Json.Serialization;

namespace LoanSystem.Services
{
    class UserVerifier
    {
        string filepath = "userdatabase.json";
        public List<VerifiedUsers> verifiedUserDatabase { get; set; }
        public VerifiedUsers UserAccount { get; set; }




        public VerifiedUsers CheckUserVerification(string username, string password)
        {
            if (!File.Exists(filepath))
            {
                List<VerifiedUsers> verifiedUsers = new List<VerifiedUsers>();
                string emptyData = JsonSerializer.Serialize(verifiedUsers);
                File.WriteAllText(filepath, emptyData);
            }

            string database = File.ReadAllText(filepath);
            verifiedUserDatabase = JsonSerializer.Deserialize<List<VerifiedUsers>>(database);

            UserAccount = verifiedUserDatabase.SingleOrDefault(user => user.Password == password.Trim() && user.Username == username);
            return UserAccount;
        }
        
        public void SaveAccountProgress()
        {
            string data = JsonSerializer.Serialize(verifiedUserDatabase);
            File.WriteAllText(filepath, data);
        }

    }
}
