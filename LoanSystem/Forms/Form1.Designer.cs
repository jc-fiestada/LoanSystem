namespace LoanSystem.Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSignIn = new Button();
            btnSignUp = new Button();
            btnAdmin = new Button();
            btnExit = new Button();
            btnAbout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 52);
            label1.Name = "label1";
            label1.Size = new Size(512, 46);
            label1.TabIndex = 0;
            label1.Text = "Loan Management System";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.White;
            btnSignIn.Location = new Point(260, 173);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(235, 40);
            btnSignIn.TabIndex = 1;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.White;
            btnSignUp.Location = new Point(260, 219);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(235, 40);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.White;
            btnAdmin.Location = new Point(260, 265);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(235, 40);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Location = new Point(260, 357);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(235, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.White;
            btnAbout.Location = new Point(259, 311);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(235, 40);
            btnAbout.TabIndex = 5;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(782, 453);
            Controls.Add(btnAbout);
            Controls.Add(btnExit);
            Controls.Add(btnAdmin);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSignIn;
        private Button btnSignUp;
        private Button btnAdmin;
        private Button btnExit;
        private Button btnAbout;
    }
}
