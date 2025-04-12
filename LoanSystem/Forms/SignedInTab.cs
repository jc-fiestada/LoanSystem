using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoanSystem.Models;
using LoanSystem.Services;

namespace LoanSystem.Forms
{
    internal partial class SignedInTab : Form
    {
        UserVerifier CurrentDatabaseAndMethod;
        string filepath = "userdatabase.json";







        public SignedInTab(UserVerifier currentDatabaseAndMethod)
        {
            InitializeComponent();
            CurrentDatabaseAndMethod = currentDatabaseAndMethod;
            this.Load += display_Load;
        }

        private void display_Load(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;


            labelName.Text = CurrentDatabaseAndMethod.UserAccount.Name;
            labelAge.Text = $"{CurrentDatabaseAndMethod.UserAccount.Age}";
            labelLoan.Text = $"{CurrentDatabaseAndMethod.UserAccount.loan_balance}";
            labelDeposits.Text = $"{CurrentDatabaseAndMethod.UserAccount.cashed_in_balance}";
            labelRemainingBalance.Text = $"{CurrentDatabaseAndMethod.UserAccount.total_balance}";
        }
        private void SignInTab_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void btnTakeLoan_Click(object sender, EventArgs e)
        {
            labelInputLoan.Text = "";
            BalanceManager bm = new BalanceManager();

            bool isValidInput;
            VerifiedUsers currentUser = bm.Loan(CurrentDatabaseAndMethod.UserAccount, txtboxLoan.Text, out isValidInput);

            if (isValidInput == false)
            {
                labelInputLoan.Text = "Invalid Input";
            }
            else
            {
                CurrentDatabaseAndMethod.UserAccount = currentUser;
                CurrentDatabaseAndMethod.SaveAccountProgress();
                labelLoan.Text = $"{CurrentDatabaseAndMethod.UserAccount.loan_balance}";
                labelDeposits.Text = $"{CurrentDatabaseAndMethod.UserAccount.cashed_in_balance}";
                labelRemainingBalance.Text = $"{CurrentDatabaseAndMethod.UserAccount.total_balance}";
            }
        }

        private void SignedInTab_Load(object sender, EventArgs e)
        {

        }

        private void btnPayLoan_Click(object sender, EventArgs e)
        {
            labelPayLoan.Text = "";
            labelPayLoanNotice.Text = "";

            BalanceManager bm = new BalanceManager();

            bool isValidInput;
            bool NoLoanToPay;

            VerifiedUsers User = bm.Pay_loan(CurrentDatabaseAndMethod.UserAccount, txtboxPayLoan.Text, out isValidInput, out NoLoanToPay);

            if (isValidInput == false)
            {
                labelPayLoan.Text = "Invalid Input";
            }
            else if (NoLoanToPay)
            {
                labelPayLoanNotice.Text = "There no loan to pay";
            }
            else
            {
                CurrentDatabaseAndMethod.UserAccount = User;
                CurrentDatabaseAndMethod.SaveAccountProgress();
                labelLoan.Text = $"{CurrentDatabaseAndMethod.UserAccount.loan_balance}";
                labelDeposits.Text = $"{CurrentDatabaseAndMethod.UserAccount.cashed_in_balance}";
                labelRemainingBalance.Text = $"{CurrentDatabaseAndMethod.UserAccount.total_balance}";
            }
        }

        private void btnCashIn_Click(object sender, EventArgs e)
        {
            labelCashInNotice.Text = "";

            BalanceManager bm = new BalanceManager();
            bool isValidInput;

            VerifiedUsers AccountUser = bm.CashIn(CurrentDatabaseAndMethod.UserAccount, txtboxCashIn.Text, out isValidInput);

            if (isValidInput == false)
            {
                labelCashInNotice.Text = "Invalid Input";
            }
            else
            {
                CurrentDatabaseAndMethod.UserAccount = AccountUser;
                CurrentDatabaseAndMethod.SaveAccountProgress();
                labelLoan.Text = $"{CurrentDatabaseAndMethod.UserAccount.loan_balance}";
                labelDeposits.Text = $"{CurrentDatabaseAndMethod.UserAccount.cashed_in_balance}";
                labelRemainingBalance.Text = $"{CurrentDatabaseAndMethod.UserAccount.total_balance}";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(171, 167);
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Location = new Point(171, 167);
            panel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(171, 167);
        }
    }
}
