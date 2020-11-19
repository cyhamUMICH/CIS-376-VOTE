namespace VOTE
{
    partial class CreateBallot
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
            this.questionsListBox = new System.Windows.Forms.ListBox();
            this.optionsListBox = new System.Windows.Forms.ListBox();
            this.ballotNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.removeQuestionButton = new System.Windows.Forms.Button();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.optionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addOptionButton = new System.Windows.Forms.Button();
            this.removeOptionButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.openDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionsListBox
            // 
            this.questionsListBox.FormattingEnabled = true;
            this.questionsListBox.Location = new System.Drawing.Point(216, 49);
            this.questionsListBox.Name = "questionsListBox";
            this.questionsListBox.Size = new System.Drawing.Size(148, 251);
            this.questionsListBox.TabIndex = 0;
            this.questionsListBox.SelectedIndexChanged += new System.EventHandler(this.questionsListBox_SelectedIndexChanged);
            // 
            // optionsListBox
            // 
            this.optionsListBox.FormattingEnabled = true;
            this.optionsListBox.Location = new System.Drawing.Point(495, 49);
            this.optionsListBox.Name = "optionsListBox";
            this.optionsListBox.Size = new System.Drawing.Size(163, 251);
            this.optionsListBox.TabIndex = 1;
            // 
            // ballotNameTextBox
            // 
            this.ballotNameTextBox.Location = new System.Drawing.Point(16, 50);
            this.ballotNameTextBox.Name = "ballotNameTextBox";
            this.ballotNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.ballotNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ballot Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Questions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Options:";
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(16, 161);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(52, 22);
            this.addQuestionButton.TabIndex = 6;
            this.addQuestionButton.Text = "Add";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // removeQuestionButton
            // 
            this.removeQuestionButton.Location = new System.Drawing.Point(370, 49);
            this.removeQuestionButton.Name = "removeQuestionButton";
            this.removeQuestionButton.Size = new System.Drawing.Size(57, 20);
            this.removeQuestionButton.TabIndex = 7;
            this.removeQuestionButton.Text = "Remove";
            this.removeQuestionButton.UseVisualStyleBackColor = true;
            this.removeQuestionButton.Click += new System.EventHandler(this.removeQuestionButton_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(16, 135);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(144, 20);
            this.questionTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Question:";
            // 
            // optionTextBox
            // 
            this.optionTextBox.Location = new System.Drawing.Point(16, 231);
            this.optionTextBox.Name = "optionTextBox";
            this.optionTextBox.Size = new System.Drawing.Size(141, 20);
            this.optionTextBox.TabIndex = 10;
            this.optionTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Option:";
            // 
            // addOptionButton
            // 
            this.addOptionButton.Location = new System.Drawing.Point(16, 257);
            this.addOptionButton.Name = "addOptionButton";
            this.addOptionButton.Size = new System.Drawing.Size(49, 23);
            this.addOptionButton.TabIndex = 12;
            this.addOptionButton.Text = "Add";
            this.addOptionButton.UseVisualStyleBackColor = true;
            this.addOptionButton.Click += new System.EventHandler(this.addOptionButton_Click);
            // 
            // removeOptionButton
            // 
            this.removeOptionButton.Location = new System.Drawing.Point(665, 49);
            this.removeOptionButton.Name = "removeOptionButton";
            this.removeOptionButton.Size = new System.Drawing.Size(57, 20);
            this.removeOptionButton.TabIndex = 13;
            this.removeOptionButton.Text = "Remove";
            this.removeOptionButton.UseVisualStyleBackColor = true;
            this.removeOptionButton.Click += new System.EventHandler(this.removeOptionButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(394, 369);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // openDatePicker
            // 
            this.openDatePicker.Location = new System.Drawing.Point(16, 337);
            this.openDatePicker.Name = "openDatePicker";
            this.openDatePicker.Size = new System.Drawing.Size(200, 20);
            this.openDatePicker.TabIndex = 15;
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Location = new System.Drawing.Point(16, 395);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(200, 20);
            this.dueDatePicker.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Open Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Due Date";
            // 
            // CreateBallot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 427);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dueDatePicker);
            this.Controls.Add(this.openDatePicker);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.removeOptionButton);
            this.Controls.Add(this.addOptionButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.optionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.removeQuestionButton);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ballotNameTextBox);
            this.Controls.Add(this.optionsListBox);
            this.Controls.Add(this.questionsListBox);
            this.Name = "CreateBallot";
            this.Text = "VOTE - Create Ballot";
            this.Load += new System.EventHandler(this.CreateBallot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox questionsListBox;
        private System.Windows.Forms.ListBox optionsListBox;
        private System.Windows.Forms.TextBox ballotNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.Button removeQuestionButton;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox optionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addOptionButton;
        private System.Windows.Forms.Button removeOptionButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker openDatePicker;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}