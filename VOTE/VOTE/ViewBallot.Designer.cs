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
            this.questionsListBox = new System.Windows.Forms.ListBox();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionsListBox
            // 
            this.questionsListBox.FormattingEnabled = true;
            this.questionsListBox.Location = new System.Drawing.Point(12, 12);
            this.questionsListBox.Name = "questionsListBox";
            this.questionsListBox.Size = new System.Drawing.Size(776, 56);
            this.questionsListBox.TabIndex = 0;
            this.questionsListBox.SelectedIndexChanged += new System.EventHandler(this.questionsListBox_SelectedIndexChanged);
            // 
            // optionsPanel
            // 
            this.optionsPanel.AutoScroll = true;
            this.optionsPanel.Location = new System.Drawing.Point(12, 74);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(776, 375);
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
            // 
            // ViewBallot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.questionsListBox);
            this.Name = "ViewBallot";
            this.Text = "ViewBallot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox questionsListBox;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Button submitButton;
    }
}