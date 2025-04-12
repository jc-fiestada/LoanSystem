using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanSystem.Forms
{
    public partial class AboutTab : Form
    {
        public AboutTab()
        {
            InitializeComponent();
        }

        private void AboutTab_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
