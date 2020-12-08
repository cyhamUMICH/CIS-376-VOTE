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

            database = DatabaseInterface.getInstance(); // Get the instance of the database interface
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = loginUsernameTextBox.Text;
            String password = loginPasswordTextBox.Text;

            User user = database.authenticateUser(username, password);  // Have the database authenticate that the user exists

            if (user != null)
            {
                SelectBallot selectBallot = new SelectBallot(user); // Show the select ballot screen
                selectBallot.Show();
            } else
            {
                MessageBox.Show("Either user does not exist or password is incorrect"); // Is null, so something didn't go right with authentication
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            String username = registerUsernameTextBox.Text;
            String password = registerPasswordTextBox.Text;
            String state = registerStateComboBox.Text;
            String birthdate = registerBirthdateDatePicker.Value.ToString("yyyy-MM-dd");
            String gender = registerGenderComboBox.Text;
            String race = registerRaceComboBox.Text;

            if (username == "" || password == "" || state == "" || birthdate == "" || gender == "" || race == "")
            {
                MessageBox.Show("One or more of the fields were left empty");
                return;
            }

            if (database.doesUserExist(username))   // If user already exists, don't allow another to be created
            {
                MessageBox.Show("User with given username already exists");
                return;
            }

            User user = new User(username, password, state, birthdate, gender, race);   // Create new user object with given fields

            database.createNewUser(user);   // Insert object into database

            SelectBallot selectBallot = new SelectBallot(user); // Display the select ballot UI with the new user
            selectBallot.Show();
        }
    }
}
