namespace VOTE
{
    partial class Login
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
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.registerGroupBox = new System.Windows.Forms.GroupBox();
            this.registerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerStateComboBox = new System.Windows.Forms.ComboBox();
            this.registerGenderComboBox = new System.Windows.Forms.ComboBox();
            this.registerRaceComboBox = new System.Windows.Forms.ComboBox();
            this.registerUsernameLabel = new System.Windows.Forms.Label();
            this.registerPasswordLabel = new System.Windows.Forms.Label();
            this.registerStateLabel = new System.Windows.Forms.Label();
            this.registerBirthdateLabel = new System.Windows.Forms.Label();
            this.registerGenderLabel = new System.Windows.Forms.Label();
            this.registerRaceLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginGroupBox.SuspendLayout();
            this.registerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(9, 95);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(177, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(9, 256);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(177, 23);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.Location = new System.Drawing.Point(9, 32);
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(177, 20);
            this.loginUsernameTextBox.TabIndex = 2;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(9, 69);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.Size = new System.Drawing.Size(177, 20);
            this.loginPasswordTextBox.TabIndex = 3;
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Location = new System.Drawing.Point(6, 16);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.loginUsernameLabel.TabIndex = 4;
            this.loginUsernameLabel.Text = "Username";
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Location = new System.Drawing.Point(6, 55);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.loginPasswordLabel.TabIndex = 5;
            this.loginPasswordLabel.Text = "Password";
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.loginUsernameLabel);
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Controls.Add(this.loginUsernameTextBox);
            this.loginGroupBox.Controls.Add(this.loginPasswordTextBox);
            this.loginGroupBox.Controls.Add(this.loginPasswordLabel);
            this.loginGroupBox.Location = new System.Drawing.Point(6, 156);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(200, 131);
            this.loginGroupBox.TabIndex = 6;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Login";
            // 
            // registerGroupBox
            // 
            this.registerGroupBox.Controls.Add(this.dateTimePicker1);
            this.registerGroupBox.Controls.Add(this.registerUsernameLabel);
            this.registerGroupBox.Controls.Add(this.registerRaceLabel);
            this.registerGroupBox.Controls.Add(this.registerButton);
            this.registerGroupBox.Controls.Add(this.registerGenderLabel);
            this.registerGroupBox.Controls.Add(this.registerUsernameTextBox);
            this.registerGroupBox.Controls.Add(this.registerBirthdateLabel);
            this.registerGroupBox.Controls.Add(this.registerPasswordTextBox);
            this.registerGroupBox.Controls.Add(this.registerStateLabel);
            this.registerGroupBox.Controls.Add(this.registerStateComboBox);
            this.registerGroupBox.Controls.Add(this.registerPasswordLabel);
            this.registerGroupBox.Controls.Add(this.registerGenderComboBox);
            this.registerGroupBox.Controls.Add(this.registerRaceComboBox);
            this.registerGroupBox.Location = new System.Drawing.Point(212, 85);
            this.registerGroupBox.Name = "registerGroupBox";
            this.registerGroupBox.Size = new System.Drawing.Size(197, 291);
            this.registerGroupBox.TabIndex = 7;
            this.registerGroupBox.TabStop = false;
            this.registerGroupBox.Text = "Register";
            // 
            // registerUsernameTextBox
            // 
            this.registerUsernameTextBox.Location = new System.Drawing.Point(9, 32);
            this.registerUsernameTextBox.Name = "registerUsernameTextBox";
            this.registerUsernameTextBox.Size = new System.Drawing.Size(177, 20);
            this.registerUsernameTextBox.TabIndex = 8;
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(9, 71);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(177, 20);
            this.registerPasswordTextBox.TabIndex = 9;
            // 
            // registerStateComboBox
            // 
            this.registerStateComboBox.FormattingEnabled = true;
            this.registerStateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA"});
            this.registerStateComboBox.Location = new System.Drawing.Point(9, 110);
            this.registerStateComboBox.Name = "registerStateComboBox";
            this.registerStateComboBox.Size = new System.Drawing.Size(177, 21);
            this.registerStateComboBox.TabIndex = 14;
            // 
            // registerGenderComboBox
            // 
            this.registerGenderComboBox.FormattingEnabled = true;
            this.registerGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other/Unspecified"});
            this.registerGenderComboBox.Location = new System.Drawing.Point(9, 189);
            this.registerGenderComboBox.Name = "registerGenderComboBox";
            this.registerGenderComboBox.Size = new System.Drawing.Size(177, 21);
            this.registerGenderComboBox.TabIndex = 15;
            // 
            // registerRaceComboBox
            // 
            this.registerRaceComboBox.FormattingEnabled = true;
            this.registerRaceComboBox.Items.AddRange(new object[] {
            "American Indian or Alaska Native",
            "Asian",
            "Black or African American",
            "Native Hawaiian or Other Pacific Islander",
            "White",
            "Hispanic or Latino"});
            this.registerRaceComboBox.Location = new System.Drawing.Point(9, 229);
            this.registerRaceComboBox.Name = "registerRaceComboBox";
            this.registerRaceComboBox.Size = new System.Drawing.Size(177, 21);
            this.registerRaceComboBox.TabIndex = 16;
            // 
            // registerUsernameLabel
            // 
            this.registerUsernameLabel.AutoSize = true;
            this.registerUsernameLabel.Location = new System.Drawing.Point(6, 16);
            this.registerUsernameLabel.Name = "registerUsernameLabel";
            this.registerUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.registerUsernameLabel.TabIndex = 17;
            this.registerUsernameLabel.Text = "Username";
            // 
            // registerPasswordLabel
            // 
            this.registerPasswordLabel.AutoSize = true;
            this.registerPasswordLabel.Location = new System.Drawing.Point(8, 55);
            this.registerPasswordLabel.Name = "registerPasswordLabel";
            this.registerPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.registerPasswordLabel.TabIndex = 18;
            this.registerPasswordLabel.Text = "Password";
            // 
            // registerStateLabel
            // 
            this.registerStateLabel.AutoSize = true;
            this.registerStateLabel.Location = new System.Drawing.Point(8, 94);
            this.registerStateLabel.Name = "registerStateLabel";
            this.registerStateLabel.Size = new System.Drawing.Size(32, 13);
            this.registerStateLabel.TabIndex = 19;
            this.registerStateLabel.Text = "State";
            // 
            // registerBirthdateLabel
            // 
            this.registerBirthdateLabel.AutoSize = true;
            this.registerBirthdateLabel.Location = new System.Drawing.Point(6, 134);
            this.registerBirthdateLabel.Name = "registerBirthdateLabel";
            this.registerBirthdateLabel.Size = new System.Drawing.Size(49, 13);
            this.registerBirthdateLabel.TabIndex = 20;
            this.registerBirthdateLabel.Text = "Birthdate";
            // 
            // registerGenderLabel
            // 
            this.registerGenderLabel.AutoSize = true;
            this.registerGenderLabel.Location = new System.Drawing.Point(6, 173);
            this.registerGenderLabel.Name = "registerGenderLabel";
            this.registerGenderLabel.Size = new System.Drawing.Size(42, 13);
            this.registerGenderLabel.TabIndex = 21;
            this.registerGenderLabel.Text = "Gender";
            // 
            // registerRaceLabel
            // 
            this.registerRaceLabel.AutoSize = true;
            this.registerRaceLabel.Location = new System.Drawing.Point(6, 213);
            this.registerRaceLabel.Name = "registerRaceLabel";
            this.registerRaceLabel.Size = new System.Drawing.Size(33, 13);
            this.registerRaceLabel.TabIndex = 22;
            this.registerRaceLabel.Text = "Race";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(403, 67);
            this.textBox1.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 386);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.registerGroupBox);
            this.Controls.Add(this.loginGroupBox);
            this.Name = "Login";
            this.Text = "VOTE - Login";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.registerGroupBox.ResumeLayout(false);
            this.registerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.GroupBox registerGroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label registerUsernameLabel;
        private System.Windows.Forms.Label registerRaceLabel;
        private System.Windows.Forms.Label registerGenderLabel;
        private System.Windows.Forms.TextBox registerUsernameTextBox;
        private System.Windows.Forms.Label registerBirthdateLabel;
        private System.Windows.Forms.TextBox registerPasswordTextBox;
        private System.Windows.Forms.Label registerStateLabel;
        private System.Windows.Forms.ComboBox registerStateComboBox;
        private System.Windows.Forms.Label registerPasswordLabel;
        private System.Windows.Forms.ComboBox registerGenderComboBox;
        private System.Windows.Forms.ComboBox registerRaceComboBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

