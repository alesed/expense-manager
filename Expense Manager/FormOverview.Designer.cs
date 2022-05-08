namespace Expense_Manager
{
    partial class FormOverview
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
            this.overviewPanel = new System.Windows.Forms.Panel();
            FormOverview.balance = new System.Windows.Forms.Label();
            FormOverview.outcomingsCounter = new System.Windows.Forms.Label();
            FormOverview.incomingsCounter = new System.Windows.Forms.Label();
            this.outcomingsLabel = new System.Windows.Forms.Label();
            this.incomingsLabel = new System.Windows.Forms.Label();
            FormOverview.lastExpense = new System.Windows.Forms.Label();
            FormOverview.lastIncome = new System.Windows.Forms.Label();
            this.outcomingLabel = new System.Windows.Forms.Label();
            this.incomingLabel = new System.Windows.Forms.Label();
            this.paymentsCounterLabel = new System.Windows.Forms.Label();
            this.lastPaymentLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.overviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // overviewPanel
            // 
            this.overviewPanel.Controls.Add(FormOverview.outcomingsCounter);
            this.overviewPanel.Controls.Add(FormOverview.incomingsCounter);
            this.overviewPanel.Controls.Add(this.outcomingsLabel);
            this.overviewPanel.Controls.Add(this.incomingsLabel);
            this.overviewPanel.Controls.Add(FormOverview.lastExpense);
            this.overviewPanel.Controls.Add(FormOverview.lastIncome);
            this.overviewPanel.Controls.Add(this.outcomingLabel);
            this.overviewPanel.Controls.Add(this.incomingLabel);
            this.overviewPanel.Controls.Add(this.paymentsCounterLabel);
            this.overviewPanel.Controls.Add(this.lastPaymentLabel);
            this.overviewPanel.Controls.Add(this.balanceLabel);
            this.overviewPanel.Controls.Add(FormOverview.balance);
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Location = new System.Drawing.Point(0, 0);
            this.overviewPanel.Name = "overviewPanel";
            this.overviewPanel.Size = new System.Drawing.Size(800, 450);
            this.overviewPanel.TabIndex = 0;
            // 
            // outcomingsCounter
            // 
            FormOverview.outcomingsCounter.AutoSize = true;
            FormOverview.outcomingsCounter.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormOverview.outcomingsCounter.ForeColor = System.Drawing.SystemColors.ControlText;
            FormOverview.outcomingsCounter.Location = new System.Drawing.Point(496, 367);
            FormOverview.outcomingsCounter.Name = "outcomingsCounter";
            FormOverview.outcomingsCounter.Size = new System.Drawing.Size(84, 25);
            FormOverview.outcomingsCounter.TabIndex = 12;
            FormOverview.outcomingsCounter.Text = "loading...";
            // 
            // incomingsCounter
            // 
            FormOverview.incomingsCounter.AutoSize = true;
            FormOverview.incomingsCounter.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormOverview.incomingsCounter.ForeColor = System.Drawing.SystemColors.ControlText;
            FormOverview.incomingsCounter.Location = new System.Drawing.Point(152, 367);
            FormOverview.incomingsCounter.Name = "incomingsCounter";
            FormOverview.incomingsCounter.Size = new System.Drawing.Size(84, 25);
            FormOverview.incomingsCounter.TabIndex = 11;
            FormOverview.incomingsCounter.Text = "loading...";
            // 
            // outcomingsLabel
            // 
            this.outcomingsLabel.AutoSize = true;
            this.outcomingsLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outcomingsLabel.Location = new System.Drawing.Point(402, 367);
            this.outcomingsLabel.Name = "outcomingsLabel";
            this.outcomingsLabel.Size = new System.Drawing.Size(88, 25);
            this.outcomingsLabel.TabIndex = 10;
            this.outcomingsLabel.Text = "Expenses:";
            // 
            // incomingsLabel
            // 
            this.incomingsLabel.AutoSize = true;
            this.incomingsLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomingsLabel.Location = new System.Drawing.Point(63, 367);
            this.incomingsLabel.Name = "incomingsLabel";
            this.incomingsLabel.Size = new System.Drawing.Size(83, 25);
            this.incomingsLabel.TabIndex = 9;
            this.incomingsLabel.Text = "Incomes:";
            // 
            // lastExpense
            // 
            FormOverview.lastExpense.AutoSize = true;
            FormOverview.lastExpense.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormOverview.lastExpense.ForeColor = System.Drawing.Color.Red;
            FormOverview.lastExpense.Location = new System.Drawing.Point(402, 268);
            FormOverview.lastExpense.Name = "lastExpense";
            FormOverview.lastExpense.Size = new System.Drawing.Size(84, 25);
            FormOverview.lastExpense.TabIndex = 8;
            FormOverview.lastExpense.Text = "loading...";
            // 
            // lastIncome
            // 
            FormOverview.lastIncome.AutoSize = true;
            FormOverview.lastIncome.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormOverview.lastIncome.ForeColor = System.Drawing.Color.Green;
            FormOverview.lastIncome.Location = new System.Drawing.Point(63, 268);
            FormOverview.lastIncome.Name = "lastIncome";
            FormOverview.lastIncome.Size = new System.Drawing.Size(84, 25);
            FormOverview.lastIncome.TabIndex = 7;
            FormOverview.lastIncome.Text = "loading...";
            // 
            // outcomingLabel
            // 
            this.outcomingLabel.AutoSize = true;
            this.outcomingLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outcomingLabel.Location = new System.Drawing.Point(402, 234);
            this.outcomingLabel.Name = "outcomingLabel";
            this.outcomingLabel.Size = new System.Drawing.Size(76, 25);
            this.outcomingLabel.TabIndex = 5;
            this.outcomingLabel.Text = "Last expense";
            // 
            // incomingLabel
            // 
            this.incomingLabel.AutoSize = true;
            this.incomingLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomingLabel.Location = new System.Drawing.Point(63, 234);
            this.incomingLabel.Name = "incomingLabel";
            this.incomingLabel.Size = new System.Drawing.Size(71, 25);
            this.incomingLabel.TabIndex = 4;
            this.incomingLabel.Text = "Last income";
            // 
            // paymentsCounterLabel
            // 
            this.paymentsCounterLabel.AutoSize = true;
            this.paymentsCounterLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentsCounterLabel.Location = new System.Drawing.Point(63, 330);
            this.paymentsCounterLabel.Name = "paymentsCounterLabel";
            this.paymentsCounterLabel.Size = new System.Drawing.Size(171, 28);
            this.paymentsCounterLabel.TabIndex = 3;
            this.paymentsCounterLabel.Text = "Payments counter:";
            // 
            // lastPaymentLabel
            // 
            this.lastPaymentLabel.AutoSize = true;
            this.lastPaymentLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastPaymentLabel.Location = new System.Drawing.Point(63, 194);
            this.lastPaymentLabel.Name = "lastPaymentLabel";
            this.lastPaymentLabel.Size = new System.Drawing.Size(132, 28);
            this.lastPaymentLabel.TabIndex = 2;
            this.lastPaymentLabel.Text = "Last payment:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceLabel.Location = new System.Drawing.Point(63, 57);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(153, 28);
            this.balanceLabel.TabIndex = 0;
            this.balanceLabel.Text = "Current balance:";
            // 
            // balance
            // 
            FormOverview.balance.AutoSize = true;
            FormOverview.balance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormOverview.balance.Location = new System.Drawing.Point(63, 111);
            FormOverview.balance.Name = "balance";
            FormOverview.balance.Size = new System.Drawing.Size(153, 28);
            FormOverview.balance.TabIndex = 0;
            FormOverview.balance.Text = "loading...";
            // 
            // FormOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.overviewPanel);
            this.Name = "FormOverview";
            this.Text = "FormOverview";
            this.overviewPanel.ResumeLayout(false);
            this.overviewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel overviewPanel;
        private Label balanceLabel;
        private Label lastPaymentLabel;
        private Label paymentsCounterLabel;
        private static Label balance;
        private Label outcomingLabel;
        private Label incomingLabel;
        private Label outcomingsLabel;
        private Label incomingsLabel;
        private static Label lastExpense;
        private static Label lastIncome;
        private static Label outcomingsCounter;
        private static Label incomingsCounter;
    }
}