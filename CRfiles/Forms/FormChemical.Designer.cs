namespace Chemical_Release_Pathing.Forms
{
    partial class FormChemical
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
            lblChemicalName = new Label();
            tbChemicalName = new TextBox();
            tbSpecificGravity = new TextBox();
            lblSpecificGravity = new Label();
            tpIrritant = new TextBox();
            lblIrritantPPM = new Label();
            thLethal = new TextBox();
            lblLethalPPM = new Label();
            tbVaporPressure = new TextBox();
            lblVaporPressure = new Label();
            tbFlashPoint = new TextBox();
            lblFlashPoint = new Label();
            tbReaction = new TextBox();
            lblReaction = new Label();
            tbToxicity = new TextBox();
            lblToxicity = new Label();
            btnSave = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblChemicalName
            // 
            lblChemicalName.AutoSize = true;
            lblChemicalName.Location = new Point(54, 45);
            lblChemicalName.Name = "lblChemicalName";
            lblChemicalName.Size = new Size(114, 20);
            lblChemicalName.TabIndex = 0;
            lblChemicalName.Text = "Chemical Name";
            // 
            // tbChemicalName
            // 
            tbChemicalName.Location = new Point(203, 42);
            tbChemicalName.Name = "tbChemicalName";
            tbChemicalName.Size = new Size(237, 27);
            tbChemicalName.TabIndex = 1;
            // 
            // tbSpecificGravity
            // 
            tbSpecificGravity.Location = new Point(203, 98);
            tbSpecificGravity.Name = "tbSpecificGravity";
            tbSpecificGravity.Size = new Size(120, 27);
            tbSpecificGravity.TabIndex = 3;
            // 
            // lblSpecificGravity
            // 
            lblSpecificGravity.AutoSize = true;
            lblSpecificGravity.Location = new Point(54, 98);
            lblSpecificGravity.Name = "lblSpecificGravity";
            lblSpecificGravity.Size = new Size(111, 20);
            lblSpecificGravity.TabIndex = 2;
            lblSpecificGravity.Text = "Specific Gravity";
            // 
            // tpIrritant
            // 
            tpIrritant.Location = new Point(203, 141);
            tpIrritant.Name = "tpIrritant";
            tpIrritant.Size = new Size(120, 27);
            tpIrritant.TabIndex = 5;
            // 
            // lblIrritantPPM
            // 
            lblIrritantPPM.AutoSize = true;
            lblIrritantPPM.Location = new Point(54, 141);
            lblIrritantPPM.Name = "lblIrritantPPM";
            lblIrritantPPM.Size = new Size(86, 20);
            lblIrritantPPM.TabIndex = 4;
            lblIrritantPPM.Text = "Irritant PPM";
            // 
            // thLethal
            // 
            thLethal.Location = new Point(203, 195);
            thLethal.Name = "thLethal";
            thLethal.Size = new Size(120, 27);
            thLethal.TabIndex = 7;
            // 
            // lblLethalPPM
            // 
            lblLethalPPM.AutoSize = true;
            lblLethalPPM.Location = new Point(54, 195);
            lblLethalPPM.Name = "lblLethalPPM";
            lblLethalPPM.Size = new Size(82, 20);
            lblLethalPPM.TabIndex = 6;
            lblLethalPPM.Text = "Lethal PPM";
            // 
            // tbVaporPressure
            // 
            tbVaporPressure.Location = new Point(203, 254);
            tbVaporPressure.Name = "tbVaporPressure";
            tbVaporPressure.Size = new Size(120, 27);
            tbVaporPressure.TabIndex = 9;
            // 
            // lblVaporPressure
            // 
            lblVaporPressure.AutoSize = true;
            lblVaporPressure.Location = new Point(54, 257);
            lblVaporPressure.Name = "lblVaporPressure";
            lblVaporPressure.Size = new Size(106, 20);
            lblVaporPressure.TabIndex = 8;
            lblVaporPressure.Text = "Vapor Pressure";
            // 
            // tbFlashPoint
            // 
            tbFlashPoint.Location = new Point(203, 313);
            tbFlashPoint.Name = "tbFlashPoint";
            tbFlashPoint.Size = new Size(120, 27);
            tbFlashPoint.TabIndex = 11;
            // 
            // lblFlashPoint
            // 
            lblFlashPoint.AutoSize = true;
            lblFlashPoint.Location = new Point(54, 320);
            lblFlashPoint.Name = "lblFlashPoint";
            lblFlashPoint.Size = new Size(79, 20);
            lblFlashPoint.TabIndex = 10;
            lblFlashPoint.Text = "Flash Point";
            // 
            // tbReaction
            // 
            tbReaction.Location = new Point(203, 366);
            tbReaction.MaxLength = 2048;
            tbReaction.Multiline = true;
            tbReaction.Name = "tbReaction";
            tbReaction.Size = new Size(1354, 225);
            tbReaction.TabIndex = 13;
            // 
            // lblReaction
            // 
            lblReaction.AutoSize = true;
            lblReaction.Location = new Point(54, 373);
            lblReaction.Name = "lblReaction";
            lblReaction.Size = new Size(149, 20);
            lblReaction.TabIndex = 12;
            lblReaction.Text = "Reaction Information";
            // 
            // tbToxicity
            // 
            tbToxicity.Location = new Point(203, 597);
            tbToxicity.MaxLength = 2048;
            tbToxicity.Multiline = true;
            tbToxicity.Name = "tbToxicity";
            tbToxicity.Size = new Size(1354, 209);
            tbToxicity.TabIndex = 15;
            // 
            // lblToxicity
            // 
            lblToxicity.AutoSize = true;
            lblToxicity.Location = new Point(54, 597);
            lblToxicity.Name = "lblToxicity";
            lblToxicity.Size = new Size(141, 20);
            lblToxicity.TabIndex = 14;
            lblToxicity.Text = "Toxicity Information";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(1445, 821);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 60);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Enabled = false;
            btnPrevious.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.Location = new Point(30, 817);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(135, 60);
            btnPrevious.TabIndex = 17;
            btnPrevious.Text = "<Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Enabled = false;
            btnNext.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(181, 817);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(135, 60);
            btnNext.TabIndex = 18;
            btnNext.Text = "Next>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(1292, 821);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 60);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormChemical
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1612, 889);
            Controls.Add(btnCancel);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnSave);
            Controls.Add(tbToxicity);
            Controls.Add(lblToxicity);
            Controls.Add(tbReaction);
            Controls.Add(lblReaction);
            Controls.Add(tbFlashPoint);
            Controls.Add(lblFlashPoint);
            Controls.Add(tbVaporPressure);
            Controls.Add(lblVaporPressure);
            Controls.Add(thLethal);
            Controls.Add(lblLethalPPM);
            Controls.Add(tpIrritant);
            Controls.Add(lblIrritantPPM);
            Controls.Add(tbSpecificGravity);
            Controls.Add(lblSpecificGravity);
            Controls.Add(tbChemicalName);
            Controls.Add(lblChemicalName);
            Name = "FormChemical";
            Text = "FormChemical";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChemicalName;
        private TextBox tbChemicalName;
        private TextBox tbSpecificGravity;
        private Label lblSpecificGravity;
        private TextBox tpIrritant;
        private Label lblIrritantPPM;
        private TextBox thLethal;
        private Label lblLethalPPM;
        private TextBox tbVaporPressure;
        private Label lblVaporPressure;
        private TextBox tbFlashPoint;
        private Label lblFlashPoint;
        private TextBox tbReaction;
        private Label lblReaction;
        private TextBox tbToxicity;
        private Label lblToxicity;
        private Button btnSave;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnCancel;
    }
}