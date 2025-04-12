using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Models
{
    class User
    {
        // username and password
        private string? username;
        private bool username_too_long = false;
        private bool username_too_short = false;

        private string? password;
        private bool password_too_long = false;
        private bool password_too_short = false;



        // user account info


        private string? name;
        private bool name_too_long;
        private bool name_too_short;
        private bool number_in_name_detected;

        private int? age;
        private bool underage;
        private bool overage;
        public bool IncorrectAgeValue { get; set; } = false;


        // user financial statement
        private int loan_balance { get; set; } = 0;
        private int total_balance { get; set; } = 0;
        private int cashed_in_balance { get; set; } = 0;


        // public getter and setter for the username and password
        public string Username
        {
            get { return username; }
            set
            {
                value.ToUpper();
                if (value.Count() > 16)
                {
                    username_too_long = true;
                    username = null;
                }
                else if(value.Count() < 3)
                {
                    username_too_short = true;
                    username = null;
                }
                else
                {
                    username = value;
                }
            }
        }

        public bool usernameTooLong
        {
            get { return username_too_long; }
        }

        public bool usernameTooShort
        {
            get { return username_too_short;  }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Count() > 16)
                {
                    password_too_long = true;
                    password = null;
                }
                else if (value.Count() < 3)
                {
                    password_too_short = true;
                    password = null;
                }
                else
                {
                    password_too_long = false;
                    password_too_short = false;
                    password = value;
                }
            }
        }


        public bool passwordTooLong
        {
            get { return password_too_long; }
        }

        public bool passwordTooShort
        {
            get { return password_too_short; }
        }

        // public getter and setter for user account info

        public string Name
        {
            get { return name; }
            set
            {


                if (value.Any(char.IsDigit))
                {
                    name = null;
                    number_in_name_detected = true;
                }
                else if (value.Trim().Count() > 25)
                {
                    name = null;
                    name_too_long = true;
                }
                else if (value.Trim().Count() < 6)
                {
                    name = null;
                    name_too_short = true;
                }
                else
                {
                    name = value.Trim().ToUpper();
                }
            }
        }

        public bool nameTooLong
        {
            get { return name_too_long; }
            set { name_too_long = value; }
        }

        public bool nameTooShort
        {
            get { return name_too_short; }
            set { name_too_short = value; }
        }

        public bool numberInNameDetected
        {
            get { return number_in_name_detected; }
            set {  number_in_name_detected = value; }
        }

        public int? Age
        {
            get { return age; }
            set
            {

                if (value < 18)
                {
                    age = null;
                    underage = true;
                }
                else if (value > 100)
                {
                    age = null;
                    overage = true;
                }
                else
                {
                    age = value;
                }
            }
        }

        public bool Underage
        {
            get { return underage; }
            set {  underage = value; }
        }

        public bool Overage
        {
            get { return overage; }
            set {  overage = value; }
        }

        
    }
}
