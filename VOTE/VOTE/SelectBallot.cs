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
        public SelectBallot()
        {
            InitializeComponent();
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
    }
}
