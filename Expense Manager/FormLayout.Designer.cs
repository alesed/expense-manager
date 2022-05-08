namespace Expense_Manager
{
    partial class FormLayout
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIncomes = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            FormLayout.sidebarUserLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnIncomes);
            this.panel1.Controls.Add(this.btnExpenses);
            this.panel1.Controls.Add(this.btnOverview);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 637);
            this.panel1.TabIndex = 0;
            // 
            // btnIncomes
            // 
            this.btnIncomes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncomes.FlatAppearance.BorderSize = 0;
            this.btnIncomes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncomes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncomes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnIncomes.Location = new System.Drawing.Point(0, 274);
            this.btnIncomes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIncomes.Name = "btnIncomes";
            this.btnIncomes.Size = new System.Drawing.Size(217, 48);
            this.btnIncomes.TabIndex = 6;
            this.btnIncomes.Text = "Incomes";
            this.btnIncomes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIncomes.UseVisualStyleBackColor = true;
            this.btnIncomes.Click += new System.EventHandler(this.btnIncomes_Click);
            this.btnIncomes.Leave += new System.EventHandler(this.btnIncomes_Leave);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExpenses.Location = new System.Drawing.Point(0, 226);
            this.btnExpenses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(217, 48);
            this.btnExpenses.TabIndex = 5;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            this.btnExpenses.Leave += new System.EventHandler(this.btnExpenses_Leave);
            // 
            // btnOverview
            // 
            this.btnOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOverview.Location = new System.Drawing.Point(0, 178);
            this.btnOverview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(217, 48);
            this.btnOverview.TabIndex = 4;
            this.btnOverview.Text = "Overview";
            this.btnOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            this.btnOverview.Leave += new System.EventHandler(this.btnOverview_Leave);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 223);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 115);
            this.pnlNav.TabIndex = 2;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUsers.Location = new System.Drawing.Point(0, 589);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(217, 48);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.Leave += new System.EventHandler(this.btnUsers_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(FormLayout.sidebarUserLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 178);
            this.panel2.TabIndex = 0;
            // 
            // sidebarUserLabel
            // 
            FormLayout.sidebarUserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            FormLayout.sidebarUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormLayout.sidebarUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            FormLayout.sidebarUserLabel.Location = new System.Drawing.Point(0, 0);
            FormLayout.sidebarUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            FormLayout.sidebarUserLabel.Name = "sidebarUserLabel";
            FormLayout.sidebarUserLabel.Size = new System.Drawing.Size(217, 178);
            FormLayout.sidebarUserLabel.TabIndex = 1;
            FormLayout.sidebarUserLabel.Text = "User Name";
            FormLayout.sidebarUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1018, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbltitle.Location = new System.Drawing.Point(230, 27);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(162, 32);
            this.lbltitle.TabIndex = 10;
            this.lbltitle.Text = "Dashboard";
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(217, 87);
            this.pnlFormLoader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(855, 550);
            this.pnlFormLoader.TabIndex = 14;
            // 
            // FormLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1072, 637);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public static System.Windows.Forms.Label sidebarUserLabel;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel pnlFormLoader;
        private Button btnIncomes;
        private Button btnExpenses;
        private Button btnOverview;
    }
}

