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
        public ViewBallot(Ballot ballot, User user)
        {
            this.ballot = ballot;
            this.user = user;

            InitializeComponent();
            DatabaseInterface db = DatabaseInterface.getInstance();

            questionsListBox.DisplayMember = "QuestionText";
            questionsListBox.DataSource = ballot.Questions;
        }

        private void ViewBallot_Load()
        {

        }

        private void questionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                optionsPanel.Controls.Clear();

                for (int x = 0; x < ((Question)questionsListBox.SelectedItem).Options.Count; x++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = ((Question)questionsListBox.SelectedItem).Options[x].OptionText;
                    radioButton.Location = new Point(10, x * 20);
                    optionsPanel.Controls.Add(radioButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void optionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
