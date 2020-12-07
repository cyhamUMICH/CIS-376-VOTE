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
    public partial class CreateBallot : Form
    {
        private Ballot ballot;
        private DatabaseInterface database;

        private BindingSource questionSource = new BindingSource();
        private BindingSource optionSource = new BindingSource();

        public CreateBallot()
        {
            InitializeComponent();

            ballot = new Ballot();  // Create a new ballot option to store the questions and options as they're created
            database = DatabaseInterface.getInstance(); // Get the instance of the database interface

            questionSource.DataSource = ballot.Questions;   // Set the ballot's list of questions to the source for the question list box

            questionsListBox.DisplayMember = "QuestionText";    // Have the question list box display the question's text instead of an object id
            questionsListBox.DataSource = questionSource;

            optionsListBox.DisplayMember = "OptionText";    // Have the option list box display the option's text instead of an object id
            optionsListBox.DataSource = optionSource;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            ballot.Name = ballotNameTextBox.Text;   // Set the ballot's name to the contents of the text box
            ballot.OpenDate = openDatePicker.Value.ToUniversalTime();   // Set the opendate to the value given in the picker converted to utc
            ballot.DueDate = dueDatePicker.Value.ToUniversalTime();     // Set the duedate to the value given in the picker converted to utc

            database.storeBallot(ballot);   // Store the ballot object in the database

            MessageBox.Show("Ballot Successfully Created");
            this.Close();   // Close the window
        }

        private void CreateBallot_Load(object sender, EventArgs e)
        {

        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            ballot.Questions.Add(new Question(questionTextBox.Text));   // Add a question with correct text to the list
            questionSource.ResetBindings(false);    // Refresh the list in the listbox
            questionTextBox.Clear();    // Clear the text box
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionsListBox.Items.Count > 0)
            {
                ballot.Questions.Remove((Question)questionsListBox.SelectedItem);   // Remove item from the list

                questionSource.ResetBindings(false);    // Refresh the listbox
                
            }

        }

        private void questionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (questionsListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                optionSource.DataSource = ((Question)questionsListBox.SelectedItem).Options;    // Set the option listbox to a different list of options
                optionsListBox.DisplayMember = "OptionText";
            } catch (NullReferenceException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void addOptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                ((Question)questionsListBox.SelectedItem).Options.Add(new Option(optionTextBox.Text));  // Add a new option to a list of options
                optionSource.ResetBindings(false);  // Refresh the listbox
                optionTextBox.Clear();
            } catch (Exception ex)
            {
                MessageBox.Show("In order to add an option, you need to create a question first.");
            }
        }

        private void removeOptionButton_Click(object sender, EventArgs e)
        {
            if (optionsListBox.Items.Count > 0)
            {
                ((Question)questionsListBox.SelectedItem).Options.Remove((Option)optionsListBox.SelectedItem);  // Remove the object from the options list
                optionSource.ResetBindings(false);
            }
        }
    }
}
