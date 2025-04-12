using LoanSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace LoanSystem.Services
{
    internal class AdminMethods
    {
        private string AdminPassword = "admin123";
        private string AdminUsername = "admin";

        public List<VerifiedUsers> list { get; set; }

        public bool AdminAccess(string username, string password)
        {
            if (username == AdminUsername && password == AdminPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        string filepath = "userdatabase.json";

        public List<VerifiedUsers> AccessUserDatabase()
        {
            string stringData = File.ReadAllText(filepath);

            if (!File.Exists(filepath))
            {
                List<VerifiedUsers> newList = new List<VerifiedUsers>();
                string newDatabase = JsonSerializer.Serialize(newList);
                File.WriteAllText(filepath, newDatabase);
                return newList;
            }

            list = JsonSerializer.Deserialize<List<VerifiedUsers>>(stringData);
            return list;
        }

        public VerifiedUsers DisplayUser(string name)
        {
            VerifiedUsers account = list.SingleOrDefault(user => user.Name == name);
            return account;
        }

        public List<VerifiedUsers> Delete(string name)
        {
            VerifiedUsers account = list.SingleOrDefault(user => user.Name == name);
            list.Remove(account);
            SaveChanges();
            return list;
        }


        public void SaveChanges()
        {
            string data = JsonSerializer.Serialize(list);
            File.WriteAllText(filepath, data);
        }
    }
}
