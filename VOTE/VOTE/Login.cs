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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SelectBallot selectBallot = new SelectBallot();
            selectBallot.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SelectBallot selectBallot = new SelectBallot();
            selectBallot.Show();
        }
    }
}
