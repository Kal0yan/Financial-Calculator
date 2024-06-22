namespace UI
{
    partial class MainPage
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
            UsernameLabel = new Label();
            label1 = new Label();
            BalanceLabel = new Label();
            AddTransactionButton = new Button();
            listView1 = new ListView();
            Category = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            DeleteTransaction = new Button();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 20F);
            UsernameLabel.Location = new Point(12, 31);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(132, 37);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(723, 31);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 1;
            label1.Text = "Balance:";
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Segoe UI", 20F);
            BalanceLabel.ForeColor = Color.ForestGreen;
            BalanceLabel.Location = new Point(829, 31);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(272, 37);
            BalanceLabel.TabIndex = 2;
            BalanceLabel.Text = "00000000000000000";
            // 
            // AddTransactionButton
            // 
            AddTransactionButton.Font = new Font("Segoe UI", 15F);
            AddTransactionButton.Location = new Point(841, 87);
            AddTransactionButton.Name = "AddTransactionButton";
            AddTransactionButton.Size = new Size(170, 44);
            AddTransactionButton.TabIndex = 3;
            AddTransactionButton.Text = "Add Transaction";
            AddTransactionButton.UseVisualStyleBackColor = true;
            AddTransactionButton.Click += AddTransactionButton_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4, Category, columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(34, 169);
            listView1.Name = "listView1";
            listView1.Size = new Size(1050, 417);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Category
            // 
            Category.Text = "Category";
            Category.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Amount";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Income/Outcome";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 400;
            // 
            // DeleteTransaction
            // 
            DeleteTransaction.Font = new Font("Segoe UI", 15F);
            DeleteTransaction.Location = new Point(893, 602);
            DeleteTransaction.Name = "DeleteTransaction";
            DeleteTransaction.Size = new Size(191, 36);
            DeleteTransaction.TabIndex = 5;
            DeleteTransaction.Text = "Delete  Transaction";
            DeleteTransaction.UseVisualStyleBackColor = true;
            DeleteTransaction.Click += DeleteTransaction_Click;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Id";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 660);
            Controls.Add(DeleteTransaction);
            Controls.Add(listView1);
            Controls.Add(AddTransactionButton);
            Controls.Add(BalanceLabel);
            Controls.Add(label1);
            Controls.Add(UsernameLabel);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameLabel;
        private Label label1;
        private Label BalanceLabel;
        private Button AddTransactionButton;
        private ListView listView1;
        private ColumnHeader Category;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button DeleteTransaction;
        private ColumnHeader columnHeader4;
    }
}