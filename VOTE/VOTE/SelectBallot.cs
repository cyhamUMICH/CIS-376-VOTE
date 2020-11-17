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

        //List<Ballot> ballots;
        DatabaseInterface database;

        public SelectBallot(User user)
        {
            InitializeComponent();

            this.user = user;
            this.database = DatabaseInterface.getInstance();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewBallot viewBallot = new ViewBallot();
            viewBallot.Show();
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
            /*
            foreach (Ballot ballot in ballots)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "";
                item.Tag = ballot;

                ballotListBox.Items.Add(ballot);
            }*/
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.UtcNow;
            Ballot ballot;

            ballot = (Ballot)ballotListBox.SelectedItem;

            this.database.changeBallotDueDate(ballot, now);

            updateItems();

            // Modify date of ballot to current date
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
                ballots = database.getActiveBallots();
            }

            ballotListBox.DisplayMember = "Name";
            ballotListBox.DataSource = ballots;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ballotListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            openDateLabel.Text = ((Ballot)ballotListBox.SelectedItem).OpenDate.ToLocalTime().ToString("g");
            dueDateLabel.Text = ((Ballot)ballotListBox.SelectedItem).DueDate.ToLocalTime().ToString("g");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
