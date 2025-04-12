using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoanSystem.Services;

namespace LoanSystem.Forms
{
    public partial class AdminSignIn : Form
    {
        public AdminSignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMethods am = new AdminMethods();
            bool isAccessApproved = am.AdminAccess(txtboxUsername.Text, txtboxPassword.Text);

            if (isAccessApproved)
            {
                this.Hide();
                AdminTab admin = new AdminTab(am);
                admin.Show();
            }
            else
            {
                labelNotice.Text = "Invalid Username and Password";
            }




        }

        private void AdminSignIn_FormClosing(object sender, FormClosingEventArgs e)
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
