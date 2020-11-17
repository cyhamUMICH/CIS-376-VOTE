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
            List<Ballot> ballots;
            
            if (this.user.Administrator == true)
            {
                ballots = database.getAllBallots();
                disableButton.Enabled = false;
                createButton.Enabled = false;
            } else
            {
                ballots = database.getActiveBallots();
            }

            foreach (Ballot ballot in ballots)
            {
                ballotListBox.Items.Add(ballot);
            }
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.UtcNow;
            Ballot ballot;

            //this.database.changeBallotDate(ballot, now);
            // Modify date of ballot to current date
        }
    }
}
