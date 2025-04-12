namespace LoanSystem.Forms
{
    partial class AdminSignIn
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
            label2 = new Label();
            txtboxUsername = new TextBox();
            txtboxPassword = new TextBox();
            label3 = new Label();
            btnSubmit = new Button();
            labelNotice = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 46);
            label1.Name = "label1";
            label1.Size = new Size(219, 41);
            label1.TabIndex = 0;
            label1.Text = "Admin Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(164, 206);
            label2.Name = "label2";
            label2.Size = new Size(179, 28);
            label2.TabIndex = 1;
            label2.Text = "Admin Username:";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Location = new Point(349, 206);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(196, 27);
            txtboxUsername.TabIndex = 2;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Location = new Point(349, 256);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(196, 27);
            txtboxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(169, 256);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 3;
            label3.Text = "Admin Password:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(349, 307);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // labelNotice
            // 
            labelNotice.AutoSize = true;
            labelNotice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNotice.ForeColor = Color.Maroon;
            labelNotice.Location = new Point(349, 168);
            labelNotice.Name = "labelNotice";
            labelNotice.Size = new Size(0, 28);
            labelNotice.TabIndex = 6;
            // 
            // AdminSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(782, 453);
            Controls.Add(labelNotice);
            Controls.Add(btnSubmit);
            Controls.Add(txtboxPassword);
            Controls.Add(label3);
            Controls.Add(txtboxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminSignIn";
            Text = "AdminSignIn";
            FormClosing += AdminSignIn_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtboxUsername;
        private TextBox txtboxPassword;
        private Label label3;
        private Button btnSubmit;
        private Label labelNotice;
    }
}