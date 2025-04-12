namespace LoanSystem.Forms
{
    partial class AdminTab
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
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            labelPassword = new Label();
            labelUsername = new Label();
            labelTotal = new Label();
            labelLoan = new Label();
            labelDeposit = new Label();
            labelAge = new Label();
            labelName = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 412);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "View Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(276, 324);
            listBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(184, 412);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Delete User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(676, 412);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(labelTotal);
            panel1.Controls.Add(labelLoan);
            panel1.Controls.Add(labelDeposit);
            panel1.Controls.Add(labelAge);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(318, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 324);
            panel1.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(20, 225);
            label11.Name = "label11";
            label11.Size = new Size(141, 28);
            label11.TabIndex = 16;
            label11.Text = "User Account";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(20, 102);
            label10.Name = "label10";
            label10.Size = new Size(226, 28);
            label10.TabIndex = 15;
            label10.Text = "Financial Statement's";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 14);
            label9.Name = "label9";
            label9.Size = new Size(145, 28);
            label9.TabIndex = 14;
            label9.Text = "Personal Info";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.Location = new Point(139, 281);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(0, 28);
            labelPassword.TabIndex = 13;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F);
            labelUsername.Location = new Point(139, 253);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(0, 28);
            labelUsername.TabIndex = 12;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 12F);
            labelTotal.Location = new Point(196, 186);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(0, 28);
            labelTotal.TabIndex = 11;
            // 
            // labelLoan
            // 
            labelLoan.AutoSize = true;
            labelLoan.Font = new Font("Segoe UI", 12F);
            labelLoan.Location = new Point(196, 158);
            labelLoan.Name = "labelLoan";
            labelLoan.Size = new Size(0, 28);
            labelLoan.TabIndex = 10;
            // 
            // labelDeposit
            // 
            labelDeposit.AutoSize = true;
            labelDeposit.Font = new Font("Segoe UI", 12F);
            labelDeposit.Location = new Point(196, 130);
            labelDeposit.Name = "labelDeposit";
            labelDeposit.Size = new Size(0, 28);
            labelDeposit.TabIndex = 9;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 12F);
            labelAge.Location = new Point(99, 70);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(0, 28);
            labelAge.TabIndex = 8;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(99, 42);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 28);
            labelName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(20, 281);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 6;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(20, 253);
            label7.Name = "label7";
            label7.Size = new Size(111, 28);
            label7.TabIndex = 5;
            label7.Text = "Username:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(20, 186);
            label8.Name = "label8";
            label8.Size = new Size(144, 28);
            label8.TabIndex = 4;
            label8.Text = "Total Balance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(20, 158);
            label3.Name = "label3";
            label3.Size = new Size(142, 28);
            label3.TabIndex = 3;
            label3.Text = "Loan Balance:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(20, 130);
            label4.Name = "label4";
            label4.Size = new Size(170, 28);
            label4.TabIndex = 2;
            label4.Text = "Deposit Balance:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 1;
            label2.Text = "Age:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 26);
            label5.Name = "label5";
            label5.Size = new Size(266, 28);
            label5.TabIndex = 6;
            label5.Text = "Database / User Account's:";
            // 
            // AdminTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(782, 453);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminTab";
            Text = "AdminTab";
            FormClosing += AdminTab_FormClosing;
            Load += AdminTab_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label labelPassword;
        private Label labelUsername;
        private Label labelTotal;
        private Label labelLoan;
        private Label labelDeposit;
        private Label labelAge;
        private Label labelName;
        private Label label9;
        private Label label5;
        private Label label11;
        private Label label10;
    }
}