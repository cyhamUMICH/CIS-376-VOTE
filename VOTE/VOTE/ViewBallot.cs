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

        private void optionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewBallot_Load(object sender, EventArgs e)
        {
            int height = 0;
            int lastHeight = 0;

            for (int question = 0; question < this.ballot.Questions.Count; question++)
            {
                Question q = this.ballot.Questions[question];

                Panel panel = new Panel();
                panel.Location = new Point(0, height);
                panel.Width = 100;
                panel.Height = 100;
                optionsPanel.Controls.Add(panel);

                Label label = new Label();
                label.Text = q.QuestionText;
                label.Location = new Point(10, 0); // temp
                panel.Controls.Add(label);
                height += 20;

                for (int option = 0; option < q.Options.Count; option++)
                {
                    Option o = q.Options[option];

                    RadioButton radioButton = new RadioButton();
                    radioButton.Location = new Point(10, 20 + 20 * option);
                    radioButton.Text = o.OptionText;
                    panel.Controls.Add(radioButton);
                    height += 20;
                }

                height += 30;

                panel.Height = height - lastHeight;
                lastHeight = height;
                //optionsPanel.Controls.Add(panel);
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

                    if (o.OptionText == checkedButton.Text) votes.Add(new Vote(o.OptionId, q.QuestionId, true, user.State, age, user.Gender, user.Race));
                }
            }

            foreach (Vote vote in votes)
            {
                database.storeVote(vote);
            }

            database.storeUserBallot(user, ballot, DateTime.UtcNow);

            MessageBox.Show("Vote successfully submitted");

            this.Close();
        }
    }
}
