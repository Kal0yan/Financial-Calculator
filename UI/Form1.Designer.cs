namespace UI
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
            label2 = new Label();
            label3 = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            SignUpButton = new Button();
            ResponsePanel = new Panel();
            ResponseLabel = new Label();
            ResponsePanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F);
            label1.Location = new Point(291, 32);
            label1.Name = "label1";
            label1.Size = new Size(550, 81);
            label1.TabIndex = 0;
            label1.Text = "Financial Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(391, 229);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(401, 276);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Font = new Font("Segoe UI", 12F);
            UsernameTextBox.ForeColor = SystemColors.WindowText;
            UsernameTextBox.Location = new Point(523, 232);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(152, 29);
            UsernameTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 12F);
            PasswordTextBox.ForeColor = SystemColors.WindowText;
            PasswordTextBox.Location = new Point(523, 276);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(152, 29);
            PasswordTextBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 12F);
            LoginButton.Location = new Point(578, 322);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(97, 35);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.Font = new Font("Segoe UI", 12F);
            SignUpButton.Location = new Point(401, 322);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(95, 35);
            SignUpButton.TabIndex = 6;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // ResponsePanel
            // 
            ResponsePanel.Controls.Add(ResponseLabel);
            ResponsePanel.Location = new Point(315, 134);
            ResponsePanel.Name = "ResponsePanel";
            ResponsePanel.Size = new Size(566, 81);
            ResponsePanel.TabIndex = 7;
            // 
            // ResponseLabel
            // 
            ResponseLabel.AutoSize = true;
            ResponseLabel.Font = new Font("Segoe UI", 12F);
            ResponseLabel.ForeColor = Color.Red;
            ResponseLabel.Location = new Point(76, 60);
            ResponseLabel.Name = "ResponseLabel";
            ResponseLabel.Size = new Size(148, 21);
            ResponseLabel.TabIndex = 0;
            ResponseLabel.Text = "..............................................";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 616);
            Controls.Add(ResponsePanel);
            Controls.Add(SignUpButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResponsePanel.ResumeLayout(false);
            ResponsePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button SignUpButton;
        private Panel ResponsePanel;
        private Label ResponseLabel;
    }
}
