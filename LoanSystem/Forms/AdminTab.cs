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
    internal partial class AdminTab : Form
    {
        AdminMethods am;
        public AdminTab(AdminMethods data)
        {
            InitializeComponent();
            am = data;
            this.Load += ListBox_Load;
        }

        private void ListBox_Load(object sender, EventArgs e)
        {
            am.AccessUserDatabase();
            foreach (VerifiedUsers account in am.list)
            {
                listBox1.Items.Add(account.Name);
            }
        }

        private void AdminTab_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            labelName.Text = "";
            labelAge.Text = "";
            labelPassword.Text = "";
            labelUsername.Text = "";
            labelTotal.Text = "";
            labelDeposit.Text = "";
            labelLoan.Text = "";

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a user first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            VerifiedUsers account = am.DisplayUser((string)listBox1.SelectedItem);

            labelName.Text = account.Name;
            labelAge.Text = $"{account.Age}";
            labelPassword.Text = account.Password;
            labelUsername.Text = account.Username;
            labelTotal.Text = $"{account.total_balance}";
            labelDeposit.Text = $"{account.cashed_in_balance}";
            labelLoan.Text = $"{account.loan_balance}";
        }

        private void AdminTab_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            am.list = am.Delete((string)listBox1.SelectedItem);
            listBox1.Items.Clear();
            foreach (VerifiedUsers account in am.list)
            {
                listBox1.Items.Add(account.Name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
