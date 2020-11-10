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
        DatabaseInterface database;

        public Login()
        {
            InitializeComponent();

            database = DatabaseInterface.getInstance();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SelectBallot selectBallot = new SelectBallot();
            selectBallot.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //SelectBallot selectBallot = new SelectBallot();
            //selectBallot.Show();

            String username = registerUsernameTextBox.Text;
            String password = registerPasswordTextBox.Text;
            String state = registerStateComboBox.Text;
            String birthdate = registerBirthdateDatePicker.Value.ToString("yyyy-MM-dd");
            String gender = registerGenderComboBox.Text;
            String race = registerRaceComboBox.Text;

            User user = new User(username, password, state, birthdate, gender, race);

            database.createNewUser(user);
        }
    }
}
