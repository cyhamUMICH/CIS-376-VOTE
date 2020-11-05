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
            this.SuspendLayout();
            // 
            // ballotListBox
            // 
            this.ballotListBox.FormattingEnabled = true;
            this.ballotListBox.Location = new System.Drawing.Point(15, 25);
            this.ballotListBox.Name = "ballotListBox";
            this.ballotListBox.Size = new System.Drawing.Size(315, 290);
            this.ballotListBox.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(15, 379);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(315, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create New Ballot";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // disableButton
            // 
            this.disableButton.Location = new System.Drawing.Point(15, 350);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(315, 23);
            this.disableButton.TabIndex = 2;
            this.disableButton.Text = "Disable Ballot";
            this.disableButton.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(15, 321);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(315, 23);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View Ballot";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of Ballots";
            // 
            // SelectBallot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.ballotListBox);
            this.Name = "SelectBallot";
            this.Text = "VOTE - Select Ballot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ballotListBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label label1;
    }
}