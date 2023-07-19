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
using System.Xml.Linq;

namespace Chemical_Release_Pathing.Forms
{
    public partial class FormMap : Form
    {
        private List<Map> _fullMapList;
        private int _currentMapIndex;
        private string _filePath;
        private List<Chemical> _fullChemicalList;
        private List<Person> _fullPersonList;

        public TaskCompletionSource<bool> TaskCompletionSource { get; private set; }

        public FormMap(List<Map> maps, List<Chemical> chemicals, List<Person> people, string filePath)
        {
            InitializeComponent();

            // Initialize variables
            TaskCompletionSource = new TaskCompletionSource<bool>();
            _fullPersonList = people;
            _fullChemicalList = chemicals;
            _fullMapList = maps;
            _currentMapIndex = 0;
            this._filePath = filePath;

            // Assign Event Handlers
            tbMapName.TextChanged += TextBox_TextChanged;
            tbMapDescription.TextChanged += TextBox_TextChanged;
            tbMapScale.TextChanged += TextBox_TextChanged;
            tbMapImageLocation.TextChanged += TextBox_TextChanged;
            lbHSEManager.SelectedIndexChanged += LbHSEManager_SelectedIndexChanged;

            // Load data
            btnCancel.Enabled = true;
            btnNext.Enabled = true;
            LoadMapData();
            
        }

        private void LbHSEManager_SelectedIndexChanged(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            btnSave.Enabled = true;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentMapIndex > 0)
            {
                _currentMapIndex--;
                LoadMapData();
                btnNext.Enabled = true;
                btnCancel.Enabled = true;
            }

            if (_currentMapIndex == 0)
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
            if (_currentMapIndex < _fullMapList.Count - 1)
            {
                _currentMapIndex++;
                LoadMapData();
                btnPrevious.Enabled = true;
                btnCancel.Enabled = true;
            }

            if (_currentMapIndex == _fullMapList.Count - 1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the contents of the form to the list
            SaveMapData();
            DataHandler.SaveMaps(_filePath, _fullMapList);
            btnCancel.Enabled = true;
        }

        /*private void LoadMapData()
        {
            Map map = _fullMapList[_currentMapIndex];
            tbMapName.Text = map.GetMapName();
            tbMapDescription.Text = map.GetMapDescription();
            lbChemicals.DataSource = map.GetMapChemicalNames();
            tbMapScale.Text = map.GetMapScale().ToString();
            tbMapImageLocation.Text = map.GetMapImageLocation();
            lbHSEManager.DataSource = map.GetHSEManagerName();
        }*/
        private void LoadMapData()
        {
            if (_fullMapList.Count > 0 && _currentMapIndex >= 0 && _currentMapIndex < _fullMapList.Count)
            {
                Map selectedMap = _fullMapList[_currentMapIndex];

                // Populate the form with the selected map's data
                tbMapName.Text = selectedMap.GetMapName();
                tbMapDescription.Text = selectedMap.GetMapDescription();

                // Load all chemicals into the ListBox
                lbChemicals.Items.Clear();

                foreach (Chemical chemical in _fullChemicalList)
                {
                    lbChemicals.Items.Add(chemical.GetChemicalName());
                }

                // Select the chemicals that are already assigned to the map
                foreach (string chemicalName in selectedMap.GetMapChemicalNames())
                {
                    int index = lbChemicals.Items.IndexOf(chemicalName);
                    if (index != -1)
                    {
                        lbChemicals.SetSelected(index, true);
                    }
                }

                tbMapScale.Text = selectedMap.GetMapScale().ToString();
                tbMapImageLocation.Text = selectedMap.GetMapImageLocation();

                // Load the HSE managers into the ListBox
                lbHSEManager.Items.Clear();
                foreach (Person person in _fullPersonList)
                {
                    lbHSEManager.Items.Add(person.GetName());
                }
                int index2 = lbHSEManager.Items.IndexOf(selectedMap.GetHSEManagerName());
                if (index2 != -1)
                {
                    lbHSEManager.SetSelected(index2, true);
                }
            }
            else
            {
                // Prepopulate the form with default information
                tbMapName.Text = "Enter Map Name";
                tbMapDescription.Text = "Enter Map Description";
                lbChemicals.Items.Clear(); // Load the list of chemicals to select from
                foreach (Chemical chemical in _fullChemicalList)
                {
                    lbChemicals.Items.Add(chemical.GetChemicalName());
                }
                tbMapScale.Text = "Enter Map Scale";
                tbMapImageLocation.Text = "Enter Map Image Location";
                lbHSEManager.Items.Clear(); // load the list of people avaliable to select from 
                foreach (Person person in _fullPersonList)
                {
                    lbHSEManager.Items.Add(person.GetName());
                }
            }
        }

        private void SaveMapData()
        {
            Map updatedMap = new Map();
            updatedMap.SetMapName(tbMapName.Text);
            updatedMap.SetMapDescription(tbMapDescription.Text);
            
            // Get the names of the chemicals which are selected
            List<string> selectedChemicalNames = lbChemicals.SelectedItems.Cast<string>().ToList();
            updatedMap.SetMapChemicalNames(selectedChemicalNames);

            updatedMap.SetMapScale(Convert.ToDouble(tbMapScale.Text));
            updatedMap.SetMapImageLocation(tbMapImageLocation.Text);

            // get the managers name from the list box 
            string selectedPersonsName = lbHSEManager.SelectedItem?.ToString(); ;

            if (!string.IsNullOrEmpty(selectedPersonsName))
            {
                updatedMap.SetHSEManagerName(selectedPersonsName);
            }
            
            int existingMapIndex = _fullMapList.FindIndex(m => m.GetMapName() == updatedMap.GetMapName());

            if (existingMapIndex != -1)
            {
                // Update an existing map in the list
                _fullMapList[existingMapIndex] = updatedMap;
            }
            else
            {
                // Add a new map to the list
                _fullMapList.Add(updatedMap);
            }


        }
    }
}
