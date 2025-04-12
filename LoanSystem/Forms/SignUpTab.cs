using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoanSystem.Services;
using LoanSystem.Models;


namespace LoanSystem.Forms
{
    public partial class SignUpTab : Form
    {
        User CurrentUser;
        public SignUpTab()
        {
            InitializeComponent();
            this.Load += default_Load;
        }

        private void default_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SignUpMethods sum = new SignUpMethods();
            User user = new User();

            labelUsername.Text = "";
            labelPassword.Text = "";

            user = sum.PasswordAndUsernameChecker(txtboxPassword.Text, txtboxUsername.Text);

            if (user.Username == null)
            {
                if (user.usernameTooShort)
                {
                    labelUsername.Text = "Username is too short";
                }
                else if (user.usernameTooLong)
                {
                    labelUsername.Text = "Username is too long";
                }
            }

            if (user.Password == null)
            {
                if (user.passwordTooLong)
                {
                    labelPassword.Text = "Password is too long";
                }
                else if (user.passwordTooShort)
                {
                    labelPassword.Text = "Password is too short";
                }
            }

            if (user.Username != null && user.Password != null)
            {
                CurrentUser = user;
                panel2.Location = panel1.Location;
                panel1.Visible = false;
                panel2.Visible = true;
            }

        }

        private void btnSubmitNameAndAge_Click(object sender, EventArgs e)
        {
            SignUpMethods sm = new SignUpMethods();
            User user = new User();

            labelName.Text = "";
            labelAge.Text = "";

            user.nameTooShort = false;
            user.nameTooLong = false;
            user.IncorrectAgeValue = false;
            user.Overage = false;
            user.Underage = false;



            user = sm.NameAndAgeChecker(txtboxName.Text, txtboxAge.Text);

            if (user.Name == null)
            {
                if (user.nameTooShort)
                {
                    labelName.Text = "Name is too short";
                }
                else if (user.nameTooLong)
                {
                    labelName.Text = "Name is too long";
                }
            }

            if (user.Age == null)
            {
                if (user.IncorrectAgeValue)
                {
                    labelAge.Text = "Invalid age value";
                }
                else if (user.Overage)
                {
                    labelAge.Text = "User age is considered as overage";
                }
                else if (user.Underage)
                {
                    labelAge.Text = "User age is considered as underage";
                }
            }

            if (user.Age != null && user.Name != null)
            {
                VerifiedUsers verifiedUsers = new VerifiedUsers();
                verifiedUsers.Age = (int)user.Age;
                verifiedUsers.Name = user.Name;
                verifiedUsers.Username = CurrentUser.Username;
                verifiedUsers.Password = CurrentUser.Password;


                sm.AddToDataBase(verifiedUsers);
                labelNotice.Location = new Point(196, 184);
                labelNotice.Text = "Data successfully saved";
                panel2.Visible = false;
            }
        }

        private void SignUpTab_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 main = (Form1)Application.OpenForms["Form1"];

            if (main != null)
            {
                main.Show();
            }
            else
            {
                main = new Form1();
                main.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 main = (Form1)Application.OpenForms["Form1"];

            if (main  != null)
            {
                main.Show();
            }
            else
            {
                main = new Form1();
                main.Show();
            }
        }
    }
}
