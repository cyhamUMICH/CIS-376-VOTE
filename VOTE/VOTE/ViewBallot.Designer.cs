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
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.AutoScroll = true;
            this.optionsPanel.Location = new System.Drawing.Point(12, 43);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(776, 357);
            this.optionsPanel.TabIndex = 1;
            this.optionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.optionsPanel_Paint);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(326, 483);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(79, 24);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ballotNameLabel
            // 
            this.ballotNameLabel.AutoSize = true;
            this.ballotNameLabel.Location = new System.Drawing.Point(9, 9);
            this.ballotNameLabel.Name = "ballotNameLabel";
            this.ballotNameLabel.Size = new System.Drawing.Size(39, 13);
            this.ballotNameLabel.TabIndex = 3;
            this.ballotNameLabel.Text = "Ballot: ";
            // 
            // ViewBallot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.ballotNameLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.optionsPanel);
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
    }
}