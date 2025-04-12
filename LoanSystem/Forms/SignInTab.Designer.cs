namespace LoanSystem.Forms
{
    partial class SignInTab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtboxUsername = new TextBox();
            txtboxPassword = new TextBox();
            label2 = new Label();
            btnSubmit = new Button();
            labelUsername = new Label();
            labelPassword = new Label();
            labelNotice = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(172, 143);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Location = new Point(294, 147);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(235, 27);
            txtboxUsername.TabIndex = 1;
            txtboxUsername.TextChanged += txtboxUsername_TextChanged;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Location = new Point(294, 194);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(235, 27);
            txtboxPassword.TabIndex = 3;
            txtboxPassword.TextChanged += txtboxPassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(179, 190);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(294, 242);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(111, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.ForeColor = Color.Red;
            labelUsername.Location = new Point(489, 154);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(0, 20);
            labelUsername.TabIndex = 5;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.ForeColor = Color.Red;
            labelPassword.Location = new Point(478, 208);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(0, 20);
            labelPassword.TabIndex = 6;
            // 
            // labelNotice
            // 
            labelNotice.AutoSize = true;
            labelNotice.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNotice.ForeColor = Color.Maroon;
            labelNotice.Location = new Point(211, 66);
            labelNotice.Name = "labelNotice";
            labelNotice.Size = new Size(0, 41);
            labelNotice.TabIndex = 7;
            // 
            // SignInTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(782, 453);
            Controls.Add(labelNotice);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(btnSubmit);
            Controls.Add(txtboxPassword);
            Controls.Add(label2);
            Controls.Add(txtboxUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SignInTab";
            Text = "SignInTab";
            FormClosing += SignInTab_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtboxUsername;
        private TextBox txtboxPassword;
        private Label label2;
        private Button btnSubmit;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelNotice;
    }
}