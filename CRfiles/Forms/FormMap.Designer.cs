namespace Chemical_Release_Pathing.Forms
{
    partial class FormMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMapName = new Label();
            tbMapName = new TextBox();
            tbMapDescription = new TextBox();
            lblMapDescription = new Label();
            lbChemicals = new ListBox();
            lblMapChemicals = new Label();
            lblMapScale = new Label();
            tbMapScale = new TextBox();
            tbMapImageLocation = new TextBox();
            lblMapFile = new Label();
            lblHSEManager = new Label();
            lbHSEManager = new ListBox();
            btnCancel = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblMapName
            // 
            lblMapName.AutoSize = true;
            lblMapName.Location = new Point(28, 28);
            lblMapName.Name = "lblMapName";
            lblMapName.Size = new Size(83, 20);
            lblMapName.TabIndex = 0;
            lblMapName.Text = "Map Name";
            // 
            // tbMapName
            // 
            tbMapName.Location = new Point(155, 27);
            tbMapName.MaxLength = 256;
            tbMapName.Name = "tbMapName";
            tbMapName.Size = new Size(192, 27);
            tbMapName.TabIndex = 1;
            // 
            // tbMapDescription
            // 
            tbMapDescription.Location = new Point(153, 78);
            tbMapDescription.MaxLength = 1024;
            tbMapDescription.Multiline = true;
            tbMapDescription.Name = "tbMapDescription";
            tbMapDescription.Size = new Size(635, 88);
            tbMapDescription.TabIndex = 3;
            // 
            // lblMapDescription
            // 
            lblMapDescription.AutoSize = true;
            lblMapDescription.Location = new Point(28, 81);
            lblMapDescription.Name = "lblMapDescription";
            lblMapDescription.Size = new Size(119, 20);
            lblMapDescription.TabIndex = 2;
            lblMapDescription.Text = "Map Description";
            // 
            // lbChemicals
            // 
            lbChemicals.FormattingEnabled = true;
            lbChemicals.ItemHeight = 20;
            lbChemicals.Location = new Point(153, 201);
            lbChemicals.Name = "lbChemicals";
            lbChemicals.SelectionMode = SelectionMode.MultiSimple;
            lbChemicals.Size = new Size(635, 84);
            lbChemicals.TabIndex = 4;
            // 
            // lblMapChemicals
            // 
            lblMapChemicals.AutoSize = true;
            lblMapChemicals.Location = new Point(28, 201);
            lblMapChemicals.Name = "lblMapChemicals";
            lblMapChemicals.Size = new Size(120, 20);
            lblMapChemicals.TabIndex = 5;
            lblMapChemicals.Text = "List of Chemicals";
            // 
            // lblMapScale
            // 
            lblMapScale.AutoSize = true;
            lblMapScale.Location = new Point(28, 316);
            lblMapScale.Name = "lblMapScale";
            lblMapScale.Size = new Size(78, 20);
            lblMapScale.TabIndex = 6;
            lblMapScale.Text = "Map Scale";
            // 
            // tbMapScale
            // 
            tbMapScale.Location = new Point(155, 313);
            tbMapScale.MaxLength = 256;
            tbMapScale.Name = "tbMapScale";
            tbMapScale.Size = new Size(192, 27);
            tbMapScale.TabIndex = 7;
            // 
            // tbMapImageLocation
            // 
            tbMapImageLocation.Location = new Point(155, 368);
            tbMapImageLocation.MaxLength = 256;
            tbMapImageLocation.Name = "tbMapImageLocation";
            tbMapImageLocation.Size = new Size(633, 27);
            tbMapImageLocation.TabIndex = 9;
            // 
            // lblMapFile
            // 
            lblMapFile.AutoSize = true;
            lblMapFile.Location = new Point(28, 371);
            lblMapFile.Name = "lblMapFile";
            lblMapFile.Size = new Size(127, 20);
            lblMapFile.TabIndex = 8;
            lblMapFile.Text = "Map File Location";
            // 
            // lblHSEManager
            // 
            lblHSEManager.AutoSize = true;
            lblHSEManager.Location = new Point(28, 438);
            lblHSEManager.Name = "lblHSEManager";
            lblHSEManager.Size = new Size(99, 20);
            lblHSEManager.TabIndex = 10;
            lblHSEManager.Text = "HSE Manager";
            // 
            // lbHSEManager
            // 
            lbHSEManager.FormattingEnabled = true;
            lbHSEManager.ItemHeight = 20;
            lbHSEManager.Location = new Point(153, 438);
            lbHSEManager.Name = "lbHSEManager";
            lbHSEManager.Size = new Size(635, 64);
            lbHSEManager.TabIndex = 11;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(1301, 807);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 60);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnNext
            // 
            btnNext.Enabled = false;
            btnNext.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(190, 803);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(135, 60);
            btnNext.TabIndex = 22;
            btnNext.Text = "Next>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Enabled = false;
            btnPrevious.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.Location = new Point(39, 803);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(135, 60);
            btnPrevious.TabIndex = 21;
            btnPrevious.Text = "<Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(1454, 807);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 60);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormMap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1612, 889);
            Controls.Add(btnCancel);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnSave);
            Controls.Add(lbHSEManager);
            Controls.Add(lblHSEManager);
            Controls.Add(tbMapImageLocation);
            Controls.Add(lblMapFile);
            Controls.Add(tbMapScale);
            Controls.Add(lblMapScale);
            Controls.Add(lblMapChemicals);
            Controls.Add(lbChemicals);
            Controls.Add(tbMapDescription);
            Controls.Add(lblMapDescription);
            Controls.Add(tbMapName);
            Controls.Add(lblMapName);
            Name = "FormMap";
            Text = "FormMap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMapName;
        private TextBox tbMapName;
        private TextBox tbMapDescription;
        private Label lblMapDescription;
        private ListBox lbChemicals;
        private Label lblMapChemicals;
        private Label lblMapScale;
        private TextBox tbMapScale;
        private TextBox tbMapImageLocation;
        private Label lblMapFile;
        private Label lblHSEManager;
        private ListBox lbHSEManager;
        private Button btnCancel;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnSave;
    }
}