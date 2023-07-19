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
    public partial class FormChemical : Form
    {
        private List<Chemical> _fullChemicalList;
        private int _currentChemicalIndex;
        private string filePath;


        public TaskCompletionSource<bool> TaskCompletionSource { get; private set; }

        public FormChemical(List<Chemical> chemicals, string filePath)
        {
            InitializeComponent();
            // Initalize Variables
            TaskCompletionSource = new TaskCompletionSource<bool>();
            _fullChemicalList = chemicals;
            _currentChemicalIndex = 0;
            this.filePath = filePath;

            // track each change to a text filed
            tbChemicalName.TextChanged += TextBox_TextChanged;
            tbSpecificGravity.TextChanged += TextBox_TextChanged;
            tpIrritant.TextChanged += TextBox_TextChanged;
            thLethal.TextChanged += TextBox_TextChanged;
            tbVaporPressure.TextChanged += TextBox_TextChanged;
            tbFlashPoint.TextChanged += TextBox_TextChanged;
            tbReaction.TextChanged += TextBox_TextChanged;
            tbToxicity.TextChanged += TextBox_TextChanged;

            // assign function to the closing of the form
            //            this.FormClosed += FormChemical_FormClosed;

            if (_fullChemicalList.Count > 0)
            {
                btnCancel.Enabled = true;
                btnNext.Enabled = true;
                LoadChemicalData();
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
        /*        private void FormChemical_FormClosed(object sender, FormClosedEventArgs e)
                {
                    TaskCompletionSource.SetResult(true);
                }*/

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentChemicalIndex > 0)
            {
                _currentChemicalIndex--;
                LoadChemicalData();
                btnNext.Enabled = true;
                btnCancel.Enabled = true;
            }

            if (_currentChemicalIndex == 0)
            {
                btnPrevious.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentChemicalIndex < _fullChemicalList.Count - 1)
            {
                _currentChemicalIndex++;
                LoadChemicalData();
                btnPrevious.Enabled = true;
                btnCancel.Enabled = true;
            }

            if (_currentChemicalIndex == _fullChemicalList.Count - 1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save the contents of this form to the list
            SaveChemicalData();
            //MessageBox.Show($"Saving: {_fullChemicalList[0].GetChemicalName()}", $"{_currentChemicalIndex}");
            DataHandler.SaveChemical(filePath, _fullChemicalList);
            btnCancel.Enabled = true;
        }

        private void LoadChemicalData()
        {
            Chemical chemical = _fullChemicalList[_currentChemicalIndex];
            tbChemicalName.Text = chemical.GetChemicalName();
            tbSpecificGravity.Text = chemical.GetSpecificGravity().ToString();
            tpIrritant.Text = chemical.GetIrritantPPM().ToString();
            thLethal.Text = chemical.GetLethalPPM().ToString();
            tbVaporPressure.Text = chemical.GetVaporPressure().ToString();
            tbFlashPoint.Text = chemical.GetFlashPoint().ToString();
            tbReaction.Text = chemical.GetReaction();
            tbToxicity.Text = chemical.GetToxicity();
        }

        private void PrepopulateForm()
        {
            // Prepopulate the form with generic information
            tbChemicalName.Text = "Enter Chemical Name";
            tbSpecificGravity.Text = "0.0";
            tpIrritant.Text = "0";
            thLethal.Text = "0";
            tbVaporPressure.Text = "0.0";
            tbFlashPoint.Text = "0";
            tbReaction.Text = "Enter Reaction Information";
            tbToxicity.Text = "Enter Toxicity Information";
        }

        private void SaveChemicalData()
        {
            Chemical updatedChemical = new Chemical();

            updatedChemical.SetChemicalName(tbChemicalName.Text);
            updatedChemical.SetSpecificGravity(Convert.ToDouble(tbSpecificGravity.Text));
            updatedChemical.SetIrritantPPM(Convert.ToInt32(tpIrritant.Text));
            updatedChemical.SetLethalPPM(Convert.ToInt32(thLethal.Text));
            updatedChemical.SetVaporPressure(Convert.ToDouble(tbVaporPressure.Text));
            updatedChemical.SetFlashPoint(Convert.ToInt32(tbFlashPoint.Text));
            updatedChemical.SetReaction(tbReaction.Text);
            updatedChemical.SetToxicity(tbToxicity.Text);

            int existingChemicalIndex = _fullChemicalList.FindIndex(c => c.GetChemicalName() == updatedChemical.GetChemicalName());

            if (existingChemicalIndex != -1)
            {
                // Update an existing chemical in the list
                _fullChemicalList[existingChemicalIndex] = updatedChemical;
                //MessageBox.Show($"Updated Chemical: {updatedChemical.GetChemicalName()}");
            }
            else
            {
                // Add a new chemical to the list
                _fullChemicalList.Add(updatedChemical);
                //MessageBox.Show($"Added Chemical: {updatedChemical.GetChemicalName()}");
            }
        }
    }
}
