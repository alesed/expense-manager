namespace Expense_Manager
{
    partial class FormExpenses
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
            this.expenseLabel = new System.Windows.Forms.Label();
            this.addExpenseButton = new System.Windows.Forms.Button();
            FormExpenses.expensesTable = new System.Windows.Forms.DataGridView();
            FormExpenses.amountInput = new System.Windows.Forms.NumericUpDown();
            this.SuspendLayout();
            // 
            // expenseLabel
            // 
            this.expenseLabel.AutoSize = true;
            this.expenseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseLabel.Location = new System.Drawing.Point(35, 46);
            this.expenseLabel.Name = "expenseLabel";
            this.expenseLabel.Size = new System.Drawing.Size(134, 28);
            this.expenseLabel.TabIndex = 0;
            this.expenseLabel.Text = "Enter amount:";
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addExpenseButton.Location = new System.Drawing.Point(230, 90);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(92, 40);
            this.addExpenseButton.TabIndex = 2;
            this.addExpenseButton.Text = "Add";
            this.addExpenseButton.UseVisualStyleBackColor = true;
            this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click);
            // 
            // amountInput
            // 
            FormExpenses.amountInput.Location = new System.Drawing.Point(175, 51);
            FormExpenses.amountInput.Name = "amountInput";
            FormExpenses.amountInput.Size = new System.Drawing.Size(147, 23);
            FormExpenses.amountInput.TabIndex = 3;
            // 
            // expensesTable
            // 
            FormExpenses.expensesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FormExpenses.expensesTable.Location = new System.Drawing.Point(342, 12);
            FormExpenses.expensesTable.Name = "expensesTable";
            FormExpenses.expensesTable.RowTemplate.Height = 25;
            FormExpenses.expensesTable.Size = new System.Drawing.Size(446, 426);
            FormExpenses.expensesTable.TabIndex = 3;
            // 
            // FormExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(FormExpenses.expensesTable);
            this.Controls.Add(FormExpenses.amountInput);
            this.Controls.Add(this.addExpenseButton);
            this.Controls.Add(this.expenseLabel);
            this.Name = "FormExpenses";
            this.Text = "FormExpenses";
            this.Load += new System.EventHandler(this.FormExpenses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label expenseLabel;
        private Button addExpenseButton;
        private static DataGridView expensesTable;
        private static NumericUpDown amountInput;
    }
}