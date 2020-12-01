namespace VOTE
{
    partial class ViewBallot
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
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.submitButton = new System.Windows.Forms.Button();
            this.ballotNameLabel = new System.Windows.Forms.Label();
            this.totalVotesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.AutoScroll = true;
            this.optionsPanel.Location = new System.Drawing.Point(16, 53);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(1387, 439);
            this.optionsPanel.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(435, 594);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(105, 30);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ballotNameLabel
            // 
            this.ballotNameLabel.AutoSize = true;
            this.ballotNameLabel.Location = new System.Drawing.Point(12, 11);
            this.ballotNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ballotNameLabel.Name = "ballotNameLabel";
            this.ballotNameLabel.Size = new System.Drawing.Size(51, 17);
            this.ballotNameLabel.TabIndex = 3;
            this.ballotNameLabel.Text = "Ballot: ";
            // 
            // totalVotesLabel
            // 
            this.totalVotesLabel.AutoSize = true;
            this.totalVotesLabel.Location = new System.Drawing.Point(1319, 11);
            this.totalVotesLabel.Name = "totalVotesLabel";
            this.totalVotesLabel.Size = new System.Drawing.Size(84, 17);
            this.totalVotesLabel.TabIndex = 4;
            this.totalVotesLabel.Text = "Total Votes:";
            this.totalVotesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ViewBallot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 695);
            this.Controls.Add(this.totalVotesLabel);
            this.Controls.Add(this.ballotNameLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.optionsPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewBallot";
            this.Text = "ViewBallot";
            this.Load += new System.EventHandler(this.ViewBallot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label ballotNameLabel;
        private System.Windows.Forms.Label totalVotesLabel;
    }
}