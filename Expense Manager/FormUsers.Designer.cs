namespace Expense_Manager
{
    partial class FormUsers
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
            this.components = new System.ComponentModel.Container();
            this.createUserLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.userSurnameInput = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.selectUserLabel = new System.Windows.Forms.Label();
            this.usersDropdown = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // createUserLabel
            // 
            this.createUserLabel.AutoSize = true;
            this.createUserLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createUserLabel.Location = new System.Drawing.Point(48, 48);
            this.createUserLabel.Name = "createUserLabel";
            this.createUserLabel.Size = new System.Drawing.Size(149, 28);
            this.createUserLabel.TabIndex = 0;
            this.createUserLabel.Text = "Create new user";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(48, 103);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(136, 105);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(201, 23);
            this.userNameInput.TabIndex = 2;
            // 
            // userSurnameInput
            // 
            this.userSurnameInput.Location = new System.Drawing.Point(136, 141);
            this.userSurnameInput.Name = "userSurnameInput";
            this.userSurnameInput.Size = new System.Drawing.Size(201, 23);
            this.userSurnameInput.TabIndex = 4;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.Location = new System.Drawing.Point(48, 141);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(82, 25);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Surname";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(240, 186);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(97, 37);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // selectUserLabel
            // 
            this.selectUserLabel.AutoSize = true;
            this.selectUserLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectUserLabel.Location = new System.Drawing.Point(481, 48);
            this.selectUserLabel.Name = "selectUserLabel";
            this.selectUserLabel.Size = new System.Drawing.Size(178, 28);
            this.selectUserLabel.TabIndex = 6;
            this.selectUserLabel.Text = "Select another user";
            // 
            // usersDropdown
            // 
            this.usersDropdown.DataSource = this.userBindingSource;
            this.usersDropdown.DisplayMember = "Name";
            this.usersDropdown.Location = new System.Drawing.Point(481, 105);
            this.usersDropdown.Name = "usersDropdown";
            this.usersDropdown.Size = new System.Drawing.Size(231, 23);
            this.usersDropdown.TabIndex = 7;
            this.usersDropdown.ValueMember = "Id";
            this.usersDropdown.SelectedIndexChanged += new System.EventHandler(this.usersDropdown_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DAL.Models.User);
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(DAL.Models.User);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usersDropdown);
            this.Controls.Add(this.selectUserLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.userSurnameInput);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createUserLabel);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label createUserLabel;
        private Label nameLabel;
        private TextBox userNameInput;
        private TextBox userSurnameInput;
        private Label surnameLabel;
        private Button createButton;
        private Label selectUserLabel;
        private ComboBox usersDropdown;
        private BindingSource userBindingSource;
        private BindingSource userBindingSource1;
    }
}