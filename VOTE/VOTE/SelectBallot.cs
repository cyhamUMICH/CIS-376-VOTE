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
    public partial class SelectBallot : Form
    {
        User user;

        DatabaseInterface database;

        public SelectBallot(User user)
        {
            InitializeComponent();

            this.user = user;
            this.database = DatabaseInterface.getInstance();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            try
            {
                ViewBallot viewBallot = new ViewBallot((Ballot)ballotListBox.SelectedItem, user);
                
                if (((Ballot)ballotListBox.SelectedItem).DueDate < DateTime.UtcNow && !user.Administrator)
                {
                    MessageBox.Show("This ballot has closed.");
                }
                else
                {
                    viewBallot.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ballot selected.");
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateBallot createBallot = new CreateBallot();
            createBallot.Show();
        }

        private void SelectBallot_Load(object sender, EventArgs e)
        {

            if (this.user.Administrator == false)
            {
                disableButton.Enabled = false;
                createButton.Enabled = false;
            }

            updateItems();
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.UtcNow;
            Ballot ballot = (Ballot)ballotListBox.SelectedItem;

            this.database.changeBallotDueDate(ballot, now);

            updateItems();
        }

        private void updateItems()
        {
            List<Ballot> ballots;

            if (this.user.Administrator == true)
            {
                ballots = database.getAllBallots();
            }
            else
            {
                ballots = database.getActiveBallots(this.user);
            }

            ballotListBox.DisplayMember = "Name";
            ballotListBox.DataSource = ballots;
        }

        private void ballotListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            openDateLabel.Text = ((Ballot)ballotListBox.SelectedItem).OpenDate.ToLocalTime().ToString("g");
            dueDateLabel.Text = ((Ballot)ballotListBox.SelectedItem).DueDate.ToLocalTime().ToString("g");
        }
    }
}
