namespace LoanSystem.Forms
{
    partial class SignUpTab
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
            btnSubmitUserAndPassword = new Button();
            panel1 = new Panel();
            labelPassword = new Label();
            labelUsername = new Label();
            panel2 = new Panel();
            btnSubmitNameAndAge = new Button();
            labelAge = new Label();
            labelName = new Label();
            txtboxAge = new TextBox();
            label4 = new Label();
            txtboxName = new TextBox();
            label3 = new Label();
            btnBack = new Button();
            labelNotice = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Location = new Point(144, 22);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(180, 27);
            txtboxUsername.TabIndex = 1;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Location = new Point(144, 75);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(180, 27);
            txtboxPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 72);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // btnSubmitUserAndPassword
            // 
            btnSubmitUserAndPassword.Location = new Point(144, 124);
            btnSubmitUserAndPassword.Name = "btnSubmitUserAndPassword";
            btnSubmitUserAndPassword.Size = new Size(115, 30);
            btnSubmitUserAndPassword.TabIndex = 4;
            btnSubmitUserAndPassword.Text = "Submit";
            btnSubmitUserAndPassword.UseVisualStyleBackColor = true;
            btnSubmitUserAndPassword.Click += btnSubmit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(btnSubmitUserAndPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtboxPassword);
            panel1.Controls.Add(txtboxUsername);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(133, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 200);
            panel1.TabIndex = 5;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.Maroon;
            labelPassword.Location = new Point(329, 78);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(0, 23);
            labelPassword.TabIndex = 6;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.Maroon;
            labelUsername.Location = new Point(329, 24);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(0, 23);
            labelUsername.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSubmitNameAndAge);
            panel2.Controls.Add(labelAge);
            panel2.Controls.Add(labelName);
            panel2.Controls.Add(txtboxAge);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtboxName);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(668, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 200);
            panel2.TabIndex = 7;
            // 
            // btnSubmitNameAndAge
            // 
            btnSubmitNameAndAge.Location = new Point(144, 124);
            btnSubmitNameAndAge.Name = "btnSubmitNameAndAge";
            btnSubmitNameAndAge.Size = new Size(115, 30);
            btnSubmitNameAndAge.TabIndex = 6;
            btnSubmitNameAndAge.Text = "Submit";
            btnSubmitNameAndAge.UseVisualStyleBackColor = true;
            btnSubmitNameAndAge.Click += btnSubmitNameAndAge_Click;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.ForeColor = Color.Maroon;
            labelAge.Location = new Point(329, 78);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(0, 20);
            labelAge.TabIndex = 5;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.ForeColor = Color.Maroon;
            labelName.Location = new Point(329, 24);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 20);
            labelName.TabIndex = 4;
            // 
            // txtboxAge
            // 
            txtboxAge.Location = new Point(144, 75);
            txtboxAge.Name = "txtboxAge";
            txtboxAge.Size = new Size(180, 27);
            txtboxAge.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 72);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 2;
            label4.Text = "Age:";
            // 
            // txtboxName
            // 
            txtboxName.Location = new Point(144, 22);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(180, 27);
            txtboxName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 21);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 0;
            label3.Text = "Name:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Location = new Point(12, 412);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // labelNotice
            // 
            labelNotice.AutoSize = true;
            labelNotice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNotice.ForeColor = Color.Maroon;
            labelNotice.Location = new Point(718, 399);
            labelNotice.Name = "labelNotice";
            labelNotice.Size = new Size(0, 41);
            labelNotice.TabIndex = 8;
            // 
            // SignUpTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(782, 453);
            Controls.Add(labelNotice);
            Controls.Add(panel2);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SignUpTab";
            Text = "SignUpTab";
            FormClosing += SignUpTab_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtboxUsername;
        private TextBox txtboxPassword;
        private Label label2;
        private Button btnSubmitUserAndPassword;
        private Panel panel1;
        private Label labelPassword;
        private Label labelUsername;
        private Button btnBack;
        private Panel panel2;
        private Button btnSubmitNameAndAge;
        private Label labelAge;
        private Label labelName;
        private TextBox txtboxAge;
        private Label label4;
        private TextBox txtboxName;
        private Label label3;
        private Label labelNotice;
    }
}