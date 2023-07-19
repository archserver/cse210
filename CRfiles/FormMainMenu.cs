using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chemical_Release_Pathing
{
    public partial class FormMainMenu : Form
    {
        private static string filePath = "CRfiles\\";
        private static List<Map> maps;
        private static List<Chemical> fullChemicalList;
        private static List<Person> fullPersonList;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            maps = new List<Map>();
            fullChemicalList = new List<Chemical>();
            fullPersonList = new List<Person>();
     
            Load += FormMainMenu_Load;
        }

        private async void FormMainMenu_Load(object sender, EventArgs e)
        {
            await LoadChemical();
            await LoadPerson();
            await LoadMaps();

            if (fullChemicalList.Count == 0)
            {
                DisableButtons();
                Forms.FormChemical formChemical = new Forms.FormChemical(fullChemicalList, filePath);
                OpenChildForm(formChemical, null);
                await formChemical.TaskCompletionSource.Task;
                //                SaveChemical();
                EnableButtons();
            }

            if (fullPersonList.Count == 0)
            {
                DisableButtons();
                Forms.FormPeople formPeople = new Forms.FormPeople(fullPersonList, filePath );
                OpenChildForm(formPeople, null);
                await formPeople.TaskCompletionSource.Task;
                //MessageBox.Show("Needs a Person");
                //                SavePerson();
                EnableButtons();
            }

            if (maps.Count == 0)
            {
                DisableButtons();
                Forms.FormMap formMap = new Forms.FormMap(maps, fullChemicalList, fullPersonList, filePath);
                OpenChildForm(formMap, null);
                await formMap.TaskCompletionSource.Task;
                //MessageBox.Show("Needs a Map");
                //                SaveMaps();
                EnableButtons();
            }
            EnableButtons();
        }

        private void DisableButtons()
        {
            btnChemicalRelease.Enabled = false;
            btnChemicals.Enabled = false;
            btnPeople.Enabled = false;
            btnMaps.Enabled = false;
        }

        private void EnableButtons()
        {
            btnChemicalRelease.Enabled = fullChemicalList.Count > 0 && fullPersonList.Count > 0 && maps.Count > 0;
            btnMaps = btnChemicalRelease;

            btnChemicals.Enabled = fullChemicalList.Count > 0;

            btnPeople.Enabled = fullPersonList.Count > 0;
            
        }

        private async Task LoadChemical()
        {
            try
            {
                fullChemicalList = await DataHandler.LoadChemical(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading chemicals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadPerson()
        {
            try
            {
                fullPersonList = await DataHandler.LoadPerson(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading people: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadMaps()
        {
            try
            {
                maps = await DataHandler.LoadMaps(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading maps: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveChemical()
        {
            try
            {
                DataHandler.SaveChemical(filePath, fullChemicalList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving chemicals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePerson()
        {
            try
            {
                DataHandler.SavePerson(filePath, fullPersonList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving people: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveMaps()
        {
            try
            {
                DataHandler.SaveMaps(filePath, maps);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving maps: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Color SelectTheamColor()
        {
            int index = random.Next(TheamColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(TheamColor.ColorList.Count);
            }
            tempIndex = index;
            string color = TheamColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectTheamColor();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = TheamColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(3, 24, 36);
                    previousBtn.ForeColor = Color.DarkGray;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.FormClosed -= ActiveForm_FormClosed;
                activeForm.Close();
                activeForm = null; // when closing the chile set to null
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.FormClosed += ChildForm_FormClosed;
            childForm.Show();
            lblMenuTitle.Text = childForm.Text;
        }

        private void ChildForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            activeForm = null;
            lblMenuTitle.Text = "Home";
            EnableButtons();
            //throw new NotImplementedException();
        }

        private void ActiveForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            activeForm = null;
            lblMenuTitle.Text = "Home";
            EnableButtons();
        }

        private void btnChemicalRelease_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Button clickedButton = (Button)sender;
            lblMenuTitle.Text = clickedButton.Text;
        }

        private void btnHistoricalRelease_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Button clickedButton = (Button)sender;
            lblMenuTitle.Text = clickedButton.Text;
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMap(maps, fullChemicalList, fullPersonList ,filePath), sender);
        }

        private void btnChemicals_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormChemical(fullChemicalList, filePath), sender);
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPeople(fullPersonList, filePath), sender);
        }

        private void btnWeather_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Button clickedButton = (Button)sender;
            lblMenuTitle.Text = clickedButton.Text;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Button clickedButton = (Button)sender;
            lblMenuTitle.Text = clickedButton.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Button clickedButton = (Button)sender;
            lblMenuTitle.Text = clickedButton.Text;
            DialogResult dr = MessageBox.Show("You want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.Close();
        }
    }
}
