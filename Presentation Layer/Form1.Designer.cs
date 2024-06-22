namespace Presentation_Layer
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
            UsernameTextBox = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "UsernameLabel";
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(46, 61);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(46, 113);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.AccessibleName = "UsernameTextBox";
            UsernameTextBox.Location = new Point(168, 68);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(160, 23);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "PasswordTextBox";
            textBox2.Location = new Point(168, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 592);
            Controls.Add(textBox2);
            Controls.Add(UsernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UsernameTextBox;
        private TextBox textBox2;
    }
}
