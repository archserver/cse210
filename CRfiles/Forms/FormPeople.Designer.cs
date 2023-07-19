namespace Chemical_Release_Pathing.Forms
{
    partial class FormPeople
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
            lblName = new Label();
            tbName = new TextBox();
            tbPhone1 = new TextBox();
            lblPhone1 = new Label();
            tbPhone2 = new TextBox();
            lblPhone2 = new Label();
            tbEmail = new TextBox();
            lblEmail = new Label();
            btnCancel = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(42, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(149, 30);
            tbName.Name = "tbName";
            tbName.Size = new Size(253, 27);
            tbName.TabIndex = 1;
            // 
            // tbPhone1
            // 
            tbPhone1.Location = new Point(149, 84);
            tbPhone1.Name = "tbPhone1";
            tbPhone1.Size = new Size(253, 27);
            tbPhone1.TabIndex = 3;
            // 
            // lblPhone1
            // 
            lblPhone1.AutoSize = true;
            lblPhone1.Location = new Point(42, 91);
            lblPhone1.Name = "lblPhone1";
            lblPhone1.Size = new Size(58, 20);
            lblPhone1.TabIndex = 2;
            lblPhone1.Text = "Phone1";
            // 
            // tbPhone2
            // 
            tbPhone2.Location = new Point(149, 145);
            tbPhone2.Name = "tbPhone2";
            tbPhone2.Size = new Size(253, 27);
            tbPhone2.TabIndex = 5;
            // 
            // lblPhone2
            // 
            lblPhone2.AutoSize = true;
            lblPhone2.Location = new Point(42, 152);
            lblPhone2.Name = "lblPhone2";
            lblPhone2.Size = new Size(58, 20);
            lblPhone2.TabIndex = 4;
            lblPhone2.Text = "Phone2";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(149, 203);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(253, 27);
            tbEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(42, 210);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(1291, 821);
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
            btnNext.Location = new Point(180, 817);
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
            btnPrevious.Location = new Point(29, 817);
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
            btnSave.Location = new Point(1444, 821);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 60);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1612, 889);
            Controls.Add(btnCancel);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnSave);
            Controls.Add(tbEmail);
            Controls.Add(lblEmail);
            Controls.Add(tbPhone2);
            Controls.Add(lblPhone2);
            Controls.Add(tbPhone1);
            Controls.Add(lblPhone1);
            Controls.Add(tbName);
            Controls.Add(lblName);
            Name = "FormPeople";
            Text = "FormPeople";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox tbName;
        private TextBox tbPhone1;
        private Label lblPhone1;
        private TextBox tbPhone2;
        private Label lblPhone2;
        private TextBox tbEmail;
        private Label lblEmail;
        private Button btnCancel;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnSave;
    }
}