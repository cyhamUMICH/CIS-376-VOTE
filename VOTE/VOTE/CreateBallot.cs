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

            ballot = new Ballot();
            database = DatabaseInterface.getInstance();

            questionSource.DataSource = ballot.Questions;

            questionsListBox.DisplayMember = "QuestionText";
            questionsListBox.DataSource = questionSource;

            optionsListBox.DisplayMember = "OptionText";
            optionsListBox.DataSource = optionSource;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            ballot.Name = ballotNameTextBox.Text;
            ballot.OpenDate = dueDatePicker.Value.ToUniversalTime();
            ballot.DueDate = dueDatePicker.Value.ToUniversalTime();

            database.storeBallot(ballot);
        }

        private void CreateBallot_Load(object sender, EventArgs e)
        {

        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            ballot.Questions.Add(new Question(questionTextBox.Text));
            questionSource.ResetBindings(false);
            questionTextBox.Clear();
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionsListBox.Items.Count > 0)
            {
                ballot.Questions.Remove((Question)questionsListBox.SelectedItem);

                questionSource.ResetBindings(false);
                
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
                optionSource.DataSource = ((Question)questionsListBox.SelectedItem).Options;
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
                ((Question)questionsListBox.SelectedItem).Options.Add(new Option(optionTextBox.Text));
                optionSource.ResetBindings(false);
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
                ((Question)questionsListBox.SelectedItem).Options.Remove((Option)optionsListBox.SelectedItem);
                optionSource.ResetBindings(false);
            }
        }
    }
}
