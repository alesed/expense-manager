namespace Expense_Manager
{
    partial class FormIncomes
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
            this.incomeLabel = new System.Windows.Forms.Label();
            this.addIncomeButton = new System.Windows.Forms.Button();
            FormIncomes.incomesTable = new System.Windows.Forms.DataGridView();
            FormIncomes.amountInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeLabel.Location = new System.Drawing.Point(35, 46);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(134, 28);
            this.incomeLabel.TabIndex = 0;
            this.incomeLabel.Text = "Enter amount:";
            // 
            // addExpenseButton
            // 
            this.addIncomeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addIncomeButton.Location = new System.Drawing.Point(230, 90);
            this.addIncomeButton.Name = "addExpenseButton";
            this.addIncomeButton.Size = new System.Drawing.Size(92, 40);
            this.addIncomeButton.TabIndex = 2;
            this.addIncomeButton.Text = "Add";
            this.addIncomeButton.UseVisualStyleBackColor = true;
            this.addIncomeButton.Click += new System.EventHandler(this.addIncomeButton_Click);
            // 
            // amountInput
            // 
            FormIncomes.amountInput.Location = new System.Drawing.Point(175, 51);
            FormIncomes.amountInput.Name = "amountInput";
            FormIncomes.amountInput.Size = new System.Drawing.Size(147, 23);
            FormIncomes.amountInput.TabIndex = 3;
            // 
            // incomesTable
            // 
            FormIncomes.incomesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FormIncomes.incomesTable.Location = new System.Drawing.Point(342, 12);
            FormIncomes.incomesTable.Name = "incomesTable";
            FormIncomes.incomesTable.RowTemplate.Height = 25;
            FormIncomes.incomesTable.Size = new System.Drawing.Size(446, 426);
            FormIncomes.incomesTable.TabIndex = 3;
            // 
            // FormIncomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(FormIncomes.incomesTable);
            this.Controls.Add(FormIncomes.amountInput);
            this.Controls.Add(this.addIncomeButton);
            this.Controls.Add(this.incomeLabel);
            this.Name = "FormIncomes";
            this.Text = "FormIncomes";
            this.Load += new System.EventHandler(this.FormIncomes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label incomeLabel;
        private Button addIncomeButton;
        private static DataGridView incomesTable;
        private static TextBox amountInput;
    }
}