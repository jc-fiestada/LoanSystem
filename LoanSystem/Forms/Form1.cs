namespace LoanSystem.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInTab signIn = new SignInTab();
            signIn.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to quit?", "Exit Program",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to quit?", "Exit Program",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpTab signUp = new SignUpTab();
            signUp.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutTab about = new AboutTab();
            about.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSignIn admin = new AdminSignIn();
            admin.Show();
        }
    }

}
