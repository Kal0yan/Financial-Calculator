namespace UI
{
    partial class SignUpPage
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
            label3 = new Label();
            label4 = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SignUpButton = new Button();
            LoginButton = new Button();
            label5 = new Label();
            BalanceTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F);
            label1.Location = new Point(263, 47);
            label1.Name = "label1";
            label1.Size = new Size(550, 81);
            label1.TabIndex = 0;
            label1.Text = "Financial Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(458, 128);
            label2.Name = "label2";
            label2.Size = new Size(137, 46);
            label2.TabIndex = 1;
            label2.Text = "Sign Up";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(356, 198);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(365, 239);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Font = new Font("Segoe UI", 12F);
            UsernameTextBox.ForeColor = SystemColors.WindowText;
            UsernameTextBox.Location = new Point(487, 201);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(166, 29);
            UsernameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 12F);
            PasswordTextBox.ForeColor = SystemColors.WindowText;
            PasswordTextBox.Location = new Point(487, 242);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(166, 29);
            PasswordTextBox.TabIndex = 5;
            // 
            // SignUpButton
            // 
            SignUpButton.Font = new Font("Segoe UI", 12F);
            SignUpButton.Location = new Point(560, 333);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(93, 35);
            SignUpButton.TabIndex = 6;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 12F);
            LoginButton.Location = new Point(356, 333);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(89, 35);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(380, 283);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 9;
            label5.Text = "Balance:";
            // 
            // BalanceTextBox
            // 
            BalanceTextBox.Font = new Font("Segoe UI", 12F);
            BalanceTextBox.ForeColor = SystemColors.WindowText;
            BalanceTextBox.Location = new Point(487, 286);
            BalanceTextBox.Name = "BalanceTextBox";
            BalanceTextBox.Size = new Size(166, 29);
            BalanceTextBox.TabIndex = 10;
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 684);
            Controls.Add(BalanceTextBox);
            Controls.Add(label5);
            Controls.Add(LoginButton);
            Controls.Add(SignUpButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Name = "SignUpPage";
            Text = "SignUpPagecs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button SignUpButton;
        private Button LoginButton;
        private Label label5;
        private TextBox BalanceTextBox;
    }
}