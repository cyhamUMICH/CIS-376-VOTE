using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOTE
{
    public partial class ViewBallot : Form
    {
        Ballot ballot;
        User user;
        DatabaseInterface database;

        public ViewBallot(Ballot ballot, User user)
        {
            this.ballot = ballot;
            this.user = user;

            InitializeComponent();
            database = DatabaseInterface.getInstance();

            ballotNameLabel.Text = "Ballot: " + ballot.Name;
        }

        private void ViewBallot_Load(object sender, EventArgs e)
        {
            List<Vote> votes = database.getVotes(this.ballot);
            int totalVotes = votes.Count();
            if (ballot.DueDate < DateTime.UtcNow)
            {
                submitButton.Hide();
                totalVotesLabel.Text = "Total Votes: " + totalVotes.ToString();
            }
            else
            {
                totalVotesLabel.Hide();
            }

            int height = 0;
            int lastHeight = 0;

            for (int question = 0; question < this.ballot.Questions.Count; question++)
            {
                Question q = this.ballot.Questions[question];

                Panel panel = new Panel();
                panel.Location = new Point(0, height);
                panel.AutoSize = true;
                panel.AutoSizeMode = AutoSizeMode.GrowOnly;
                optionsPanel.Controls.Add(panel);

                Label questionLabel = new Label();
                questionLabel.Text = q.QuestionText;
                questionLabel.AutoSize = true;
                questionLabel.Location = new Point(10, 0);
                panel.Controls.Add(questionLabel);
                height += 20;

                for (int option = 0; option < q.Options.Count; option++)
                {
                    Option o = q.Options[option];

                    RadioButton radioButton = new RadioButton();
                    radioButton.Location = new Point(10, 20 + 20 * option);
                    radioButton.Text = o.OptionText;
                    radioButton.AutoSize = true;
                    radioButton.MinimumSize = new System.Drawing.Size(100, 24);
                    radioButton.TextAlign = ContentAlignment.MiddleLeft;
                    panel.Controls.Add(radioButton);

                    if (ballot.DueDate < DateTime.UtcNow)
                    {
                        int count = votes.Where(v => v.OptionID == o.OptionId).Count();
                        int votesForQuestion = votes.Where(v => v.QuestionID == q.QuestionId).Count();
                        double percentage = (votesForQuestion == 0) ? 0 : ((double)count / votesForQuestion) * 100;
                        Label resultLabel = new Label();
                        resultLabel.Text = count.ToString() + "    " + Math.Round(percentage, 2) + "%";
                        resultLabel.TextAlign = ContentAlignment.MiddleLeft;
                        resultLabel.Location = new Point(20 + radioButton.Size.Width, 20 + 20 * option);
                        panel.Controls.Add(resultLabel);
                    }
                    height += 20;
                }

                height += 30;

                panel.Height = height - lastHeight;
                lastHeight = height;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            List<Vote> votes = new List<Vote>();

            DateTime now = DateTime.UtcNow;
            int age = now.Year - Convert.ToDateTime(user.DateOfBirth).Year;
            if (Convert.ToDateTime(user.DateOfBirth) > now.AddYears(-age)) age--;

            for (int question = 0; question < this.ballot.Questions.Count; question++)
            {
                Question q = this.ballot.Questions[question];

                Panel p = (Panel)optionsPanel.Controls[question];

                RadioButton checkedButton = p.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (checkedButton == null) continue;

                for (int option = 0; option < q.Options.Count; option++)
                {
                    Option o = q.Options[option];

                    if (o.OptionText == checkedButton.Text) votes.Add(new Vote(o.OptionId, q.QuestionId, user.State, age, user.Gender, user.Race));
                }
            }

            foreach (Vote vote in votes)
            {
                database.storeVote(vote);
            }

            database.storeUserBallot(user, ballot, DateTime.UtcNow);

            MessageBox.Show("Vote successfully submitted");

            SelectBallot selectBallot = new SelectBallot(this.user);
            selectBallot.Show();

            this.Close();
        }
    }
}
