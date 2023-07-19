using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemical_Release_Pathing.Forms
{
    public partial class FormPeople : Form
    {
        private List<Person> _fullPeopleList;
        private int _currentPersonIndex;
        private string _filePath;

        public TaskCompletionSource<bool> TaskCompletionSource { get; private set; }

        public FormPeople(List<Person> people, string filePath)
        {
            InitializeComponent();

            // Initialize variables
            TaskCompletionSource = new TaskCompletionSource<bool>();
            _fullPeopleList = people;
            _currentPersonIndex = 0;
            this._filePath = filePath;

            // Assign event handlers
            tbName.TextChanged += TextBox_TextChanged;
            tbPhone1.TextChanged += TextBox_TextChanged;
            tbPhone2.TextChanged += TextBox_TextChanged;
            tbEmail.TextChanged += TextBox_TextChanged;

            // Load data
            if (_fullPeopleList.Count > 0)
            {
                btnCancel.Enabled = true;
                btnNext.Enabled = true;
                LoadPersonData();
            }
            else
            {
                PrepopulateForm();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPersonIndex > 0)
            {
                _currentPersonIndex--;
                LoadPersonData();
                btnNext.Enabled = true;
                btnCancel.Enabled = true;
            }

            if (_currentPersonIndex == 0)
            {
                btnPrevious.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPersonIndex < _fullPeopleList.Count - 1)
            {
                _currentPersonIndex++;
                LoadPersonData();
                btnPrevious.Enabled = true;
                btnCancel.Enabled = true;
            }

            if (_currentPersonIndex == _fullPeopleList.Count - 1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the contents of the form to the list
            SavePersonData();
            DataHandler.SavePerson(_filePath, _fullPeopleList);
            btnCancel.Enabled = true;
        }

        private void LoadPersonData()
        {
            Person person = _fullPeopleList[_currentPersonIndex];
            tbName.Text = person.GetName();
            tbPhone1.Text = person.GetContactNumber1();
            tbPhone2.Text = person.GetContactNumber2();
            tbEmail.Text = person.GetEmail();
        }

        private void PrepopulateForm()
        {
            // Prepopulate the form with generic information
            tbName.Text = "Enter Contact Name";
            tbPhone1.Text = "Enter Phone Number 1";
            tbPhone2.Text = "Enter Phone Number 2";
            tbEmail.Text = "Enter Email Address";
        }

        private void SavePersonData()
        {
            Person updatedPerson = new Person();
            updatedPerson.SetName(tbName.Text);
            updatedPerson.SetContactNumber1(tbPhone1.Text);
            updatedPerson.SetContactNumber2(tbPhone2.Text);
            updatedPerson.SetEmail(tbEmail.Text);

            int existingPersonIndex = _fullPeopleList.FindIndex(p => p.GetName() == updatedPerson.GetName());

            if (existingPersonIndex != -1)
            {
                // Update an existing person in the list
                _fullPeopleList[existingPersonIndex] = updatedPerson;
            }
            else
            {
                // Add a new person to the list
                _fullPeopleList.Add(updatedPerson);
            }
        }
    }
}
