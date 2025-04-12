using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LoanSystem.Models;
using System.IO;

namespace LoanSystem.Services
{
    class SignUpMethods
    {
        string filepath = "userdatabase.json";

        public User PasswordAndUsernameChecker(string password, string username)
        {
            User user = new User();

            user.Username = username;
            user.Password = password;

            return user;
        }

        public User NameAndAgeChecker(string name, string age)
        {
            User user = new User();
            user.Name = name;

            int convertedAge;

            if (!int.TryParse(age, out convertedAge))
            {
                user.IncorrectAgeValue = true;
                return user;
            }
            user.Age = convertedAge;

            return user;
        }

        public void AddToDataBase(VerifiedUsers user)
        {
            if (!File.Exists(filepath))
            {
                List<VerifiedUsers> users = new List<VerifiedUsers>();
                string data = JsonSerializer.Serialize(users);


                File.WriteAllText(filepath, data);
            }
            string content = File.ReadAllText(filepath);


            List<VerifiedUsers> userlist;

            userlist = JsonSerializer.Deserialize<List<VerifiedUsers>>(content);

            if (userlist == null)
            {
                userlist = new List<VerifiedUsers>();
            }

            userlist.Add(user);
            string savedData = JsonSerializer.Serialize(userlist);
            File.WriteAllText(filepath, savedData);
        }
    }
}
