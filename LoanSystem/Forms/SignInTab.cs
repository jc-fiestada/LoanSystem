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
    public partial class SignInTab : Form
    {
        public SignInTab()
        {
            InitializeComponent();
        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            labelPassword.Text = "";
            labelUsername.Text = "";
            labelNotice.Text = "";

            UserVerifier verifier = new UserVerifier();

            verifier.CheckUserVerification(txtboxUsername.Text, txtboxPassword.Text);

            if (verifier.UserAccount == null)
            {
                labelNotice.Text = "User Do Not Exist's";
            }
            else
            {
                this.Hide();
                SignedInTab signedinTab = new SignedInTab(verifier);
                signedinTab.Show();
            }

        }

        private void SignInTab_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
