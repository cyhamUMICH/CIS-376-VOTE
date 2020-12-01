namespace VOTE
{
    partial class SelectBallot
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
            this.ballotListBox = new System.Windows.Forms.ListBox();
            this.createButton = new System.Windows.Forms.Button();
            this.disableButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openDateLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ballotListBox
            // 
            this.ballotListBox.FormattingEnabled = true;
            this.ballotListBox.ItemHeight = 16;
            this.ballotListBox.Location = new System.Drawing.Point(33, 54);
            this.ballotListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ballotListBox.Name = "ballotListBox";
            this.ballotListBox.Size = new System.Drawing.Size(420, 388);
            this.ballotListBox.TabIndex = 0;
            this.ballotListBox.SelectedIndexChanged += new System.EventHandler(this.ballotListBox_SelectedIndexChanged);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(33, 522);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(420, 28);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create New Ballot";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // disableButton
            // 
            this.disableButton.Location = new System.Drawing.Point(33, 486);
            this.disableButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(420, 28);
            this.disableButton.TabIndex = 2;
            this.disableButton.Text = "Disable Ballot";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(33, 450);
            this.viewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(420, 28);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View Ballot";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of Ballots";
            // 
            // openDateLabel
            // 
            this.openDateLabel.AutoSize = true;
            this.openDateLabel.Location = new System.Drawing.Point(147, 33);
            this.openDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.openDateLabel.Name = "openDateLabel";
            this.openDateLabel.Size = new System.Drawing.Size(124, 17);
            this.openDateLabel.TabIndex = 5;
            this.openDateLabel.Text = "No Ballot Selected";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(308, 33);
            this.dueDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(124, 17);
            this.dueDateLabel.TabIndex = 6;
            this.dueDateLabel.Text = "No Ballot Selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Open Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Due Date";
            // 
            // SelectBallot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 576);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.openDateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.ballotListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectBallot";
            this.Text = "VOTE - Select Ballot";
            this.Load += new System.EventHandler(this.SelectBallot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ballotListBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label openDateLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}