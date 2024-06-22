namespace UI
{
    partial class AddTransactionPage
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            AmountTextBox = new TextBox();
            CategoryTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            IncomeOutcome = new ComboBox();
            DescriptionTextBox = new TextBox();
            AddButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 40F);
            label2.Location = new Point(98, 9);
            label2.Name = "label2";
            label2.Size = new Size(413, 72);
            label2.TabIndex = 1;
            label2.Text = "Add Transaction";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(108, 140);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 2;
            label1.Text = "Amount:";
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(98, 189);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 3;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(7, 239);
            label4.Name = "label4";
            label4.Size = new Size(206, 32);
            label4.TabIndex = 4;
            label4.Text = "Income/Outcome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(73, 286);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 5;
            label5.Text = "Description:";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Font = new Font("Segoe UI", 12F);
            AmountTextBox.Location = new Point(219, 146);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(182, 29);
            AmountTextBox.TabIndex = 6;
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Font = new Font("Segoe UI", 12F);
            CategoryTextBox.Location = new Point(219, 192);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(182, 29);
            CategoryTextBox.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // IncomeOutcome
            // 
            IncomeOutcome.Font = new Font("Segoe UI", 12F);
            IncomeOutcome.FormattingEnabled = true;
            IncomeOutcome.Items.AddRange(new object[] { "Income", "Outcome" });
            IncomeOutcome.Location = new Point(219, 242);
            IncomeOutcome.Name = "IncomeOutcome";
            IncomeOutcome.Size = new Size(182, 29);
            IncomeOutcome.TabIndex = 9;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Font = new Font("Segoe UI", 12F);
            DescriptionTextBox.ForeColor = SystemColors.WindowText;
            DescriptionTextBox.Location = new Point(73, 321);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(438, 110);
            DescriptionTextBox.TabIndex = 10;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 15F);
            AddButton.Location = new Point(402, 447);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(109, 42);
            AddButton.TabIndex = 11;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(73, 447);
            button1.Name = "button1";
            button1.Size = new Size(108, 42);
            button1.TabIndex = 12;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddTransactionPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 595);
            Controls.Add(button1);
            Controls.Add(AddButton);
            Controls.Add(DescriptionTextBox);
            Controls.Add(IncomeOutcome);
            Controls.Add(CategoryTextBox);
            Controls.Add(AmountTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "AddTransactionPage";
            Text = "AddTransactionPage";
            Load += AddTransactionPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox AmountTextBox;
        private TextBox CategoryTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox IncomeOutcome;
        private TextBox DescriptionTextBox;
        private Button AddButton;
        private Button button1;
    }
}