namespace Chemical_Release_Pathing
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btnExit = new Button();
            btnSettings = new Button();
            btnWeather = new Button();
            btnPeople = new Button();
            btnChemicals = new Button();
            btnMaps = new Button();
            btnHistoricalRelease = new Button();
            btnChemicalRelease = new Button();
            panelLogo = new Panel();
            panelTitle = new Panel();
            lblMenuTitle = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(3, 24, 36);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnWeather);
            panelMenu.Controls.Add(btnPeople);
            panelMenu.Controls.Add(btnChemicals);
            panelMenu.Controls.Add(btnMaps);
            panelMenu.Controls.Add(btnHistoricalRelease);
            panelMenu.Controls.Add(btnChemicalRelease);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = SystemColors.ControlLight;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 1026);
            panelMenu.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(3, 24, 36);
            btnExit.Dock = DockStyle.Top;
            btnExit.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ControlDark;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 473);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(12, 0, 0, 0);
            btnExit.Size = new Size(250, 55);
            btnExit.TabIndex = 9;
            btnExit.Text = "  Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(3, 24, 36);
            btnSettings.Dock = DockStyle.Top;
            btnSettings.Enabled = false;
            btnSettings.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = SystemColors.ControlDark;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 418);
            btnSettings.Margin = new Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(12, 0, 0, 0);
            btnSettings.Size = new Size(250, 55);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "  Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnWeather
            // 
            btnWeather.BackColor = Color.FromArgb(3, 24, 36);
            btnWeather.Dock = DockStyle.Top;
            btnWeather.Enabled = false;
            btnWeather.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnWeather.ForeColor = SystemColors.ControlDark;
            btnWeather.Image = (Image)resources.GetObject("btnWeather.Image");
            btnWeather.ImageAlign = ContentAlignment.MiddleLeft;
            btnWeather.Location = new Point(0, 363);
            btnWeather.Margin = new Padding(3, 4, 3, 4);
            btnWeather.Name = "btnWeather";
            btnWeather.Padding = new Padding(12, 0, 0, 0);
            btnWeather.Size = new Size(250, 55);
            btnWeather.TabIndex = 7;
            btnWeather.Text = "  Weather";
            btnWeather.TextAlign = ContentAlignment.MiddleLeft;
            btnWeather.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWeather.UseVisualStyleBackColor = false;
            btnWeather.Click += btnWeather_Click;
            // 
            // btnPeople
            // 
            btnPeople.BackColor = Color.FromArgb(3, 24, 36);
            btnPeople.Dock = DockStyle.Top;
            btnPeople.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeople.ForeColor = SystemColors.ControlDark;
            btnPeople.Image = (Image)resources.GetObject("btnPeople.Image");
            btnPeople.ImageAlign = ContentAlignment.MiddleLeft;
            btnPeople.Location = new Point(0, 308);
            btnPeople.Margin = new Padding(3, 4, 3, 4);
            btnPeople.Name = "btnPeople";
            btnPeople.Padding = new Padding(12, 0, 0, 0);
            btnPeople.Size = new Size(250, 55);
            btnPeople.TabIndex = 6;
            btnPeople.Text = "  People";
            btnPeople.TextAlign = ContentAlignment.MiddleLeft;
            btnPeople.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPeople.UseVisualStyleBackColor = false;
            btnPeople.Click += btnPeople_Click;
            // 
            // btnChemicals
            // 
            btnChemicals.BackColor = Color.FromArgb(3, 24, 36);
            btnChemicals.Dock = DockStyle.Top;
            btnChemicals.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnChemicals.ForeColor = SystemColors.ControlDark;
            btnChemicals.Image = (Image)resources.GetObject("btnChemicals.Image");
            btnChemicals.ImageAlign = ContentAlignment.MiddleLeft;
            btnChemicals.Location = new Point(0, 253);
            btnChemicals.Margin = new Padding(3, 4, 3, 4);
            btnChemicals.Name = "btnChemicals";
            btnChemicals.Padding = new Padding(12, 0, 0, 0);
            btnChemicals.Size = new Size(250, 55);
            btnChemicals.TabIndex = 5;
            btnChemicals.Text = "  Chemicals";
            btnChemicals.TextAlign = ContentAlignment.MiddleLeft;
            btnChemicals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChemicals.UseVisualStyleBackColor = false;
            btnChemicals.Click += btnChemicals_Click;
            // 
            // btnMaps
            // 
            btnMaps.BackColor = Color.FromArgb(3, 24, 36);
            btnMaps.Dock = DockStyle.Top;
            btnMaps.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMaps.ForeColor = SystemColors.ControlDark;
            btnMaps.Image = (Image)resources.GetObject("btnMaps.Image");
            btnMaps.ImageAlign = ContentAlignment.MiddleLeft;
            btnMaps.Location = new Point(0, 198);
            btnMaps.Margin = new Padding(3, 4, 3, 4);
            btnMaps.Name = "btnMaps";
            btnMaps.Padding = new Padding(12, 0, 0, 0);
            btnMaps.Size = new Size(250, 55);
            btnMaps.TabIndex = 4;
            btnMaps.Text = "  Maps";
            btnMaps.TextAlign = ContentAlignment.MiddleLeft;
            btnMaps.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMaps.UseVisualStyleBackColor = false;
            btnMaps.Click += btnMaps_Click;
            // 
            // btnHistoricalRelease
            // 
            btnHistoricalRelease.BackColor = Color.FromArgb(3, 24, 36);
            btnHistoricalRelease.Dock = DockStyle.Top;
            btnHistoricalRelease.Enabled = false;
            btnHistoricalRelease.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistoricalRelease.ForeColor = SystemColors.ControlDark;
            btnHistoricalRelease.Image = (Image)resources.GetObject("btnHistoricalRelease.Image");
            btnHistoricalRelease.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistoricalRelease.Location = new Point(0, 143);
            btnHistoricalRelease.Margin = new Padding(3, 4, 3, 4);
            btnHistoricalRelease.Name = "btnHistoricalRelease";
            btnHistoricalRelease.Padding = new Padding(12, 0, 0, 0);
            btnHistoricalRelease.Size = new Size(250, 55);
            btnHistoricalRelease.TabIndex = 3;
            btnHistoricalRelease.Text = "  Historical Release";
            btnHistoricalRelease.TextAlign = ContentAlignment.MiddleLeft;
            btnHistoricalRelease.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistoricalRelease.UseVisualStyleBackColor = false;
            btnHistoricalRelease.Click += btnHistoricalRelease_Click;
            // 
            // btnChemicalRelease
            // 
            btnChemicalRelease.BackColor = Color.FromArgb(3, 24, 36);
            btnChemicalRelease.Dock = DockStyle.Top;
            btnChemicalRelease.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnChemicalRelease.ForeColor = SystemColors.ControlDark;
            btnChemicalRelease.Image = (Image)resources.GetObject("btnChemicalRelease.Image");
            btnChemicalRelease.ImageAlign = ContentAlignment.MiddleLeft;
            btnChemicalRelease.Location = new Point(0, 88);
            btnChemicalRelease.Margin = new Padding(3, 4, 3, 4);
            btnChemicalRelease.Name = "btnChemicalRelease";
            btnChemicalRelease.Padding = new Padding(12, 0, 0, 0);
            btnChemicalRelease.Size = new Size(250, 55);
            btnChemicalRelease.TabIndex = 2;
            btnChemicalRelease.Text = "  Chemical Release";
            btnChemicalRelease.TextAlign = ContentAlignment.MiddleLeft;
            btnChemicalRelease.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChemicalRelease.UseVisualStyleBackColor = false;
            btnChemicalRelease.Click += btnChemicalRelease_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(5, 15, 26);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 88);
            panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(5, 56, 78);
            panelTitle.Controls.Add(lblMenuTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.ForeColor = Color.White;
            panelTitle.Location = new Point(250, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1632, 88);
            panelTitle.TabIndex = 3;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.Anchor = AnchorStyles.None;
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenuTitle.ForeColor = Color.DarkGray;
            lblMenuTitle.Location = new Point(732, 27);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(99, 32);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 88);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1632, 938);
            panelDesktop.TabIndex = 4;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 1026);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormMainMenu";
            Text = "Chemical Release Pathing";
            panelMenu.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnChemicalRelease;
        private Button btnPeople;
        private Button btnChemicals;
        private Button btnMaps;
        private Button btnHistoricalRelease;
        private Button btnWeather;
        private Button btnSettings;
        private Button btnExit;
        private Panel panelTitle;
        private Label lblMenuTitle;
        private Panel panelDesktop;
    }
}