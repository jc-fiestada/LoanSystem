using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Models
{
    class VerifiedUsers
    {

        // user account info

        private string username;
        private string password;
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age 
        { 
            get { return age; }
            set { age = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        // user financial statement
        public int loan_balance { get; set; } = 0;
        public int total_balance
        {
            get
            {
                int value = cashed_in_balance - loan_balance;
                return value;
            }
        }
        public int cashed_in_balance { get; set; } = 0;
    }
}
