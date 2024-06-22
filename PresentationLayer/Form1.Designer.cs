namespace PresentationLayer
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
            lbUsername = new Label();
            lbPassword = new Label();
            btnSign = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(317, 223);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(103, 28);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(317, 285);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(97, 28);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password:";
            // 
            // btnSign
            // 
            btnSign.Location = new Point(517, 529);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(144, 72);
            btnSign.TabIndex = 3;
            btnSign.Text = "Sign In";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(462, 223);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(272, 34);
            tbUsername.TabIndex = 4;
            tbUsername.Text = "Enter username here";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(462, 285);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(272, 34);
            tbPassword.TabIndex = 5;
            tbPassword.Text = "Enter password here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 775);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(btnSign);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Start";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbUsername;
        private Label lbPassword;
        private Button btnSign;
        private TextBox tbUsername;
        private TextBox tbPassword;
    }
}
