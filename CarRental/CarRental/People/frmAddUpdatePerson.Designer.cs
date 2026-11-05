namespace CarRental.People
{
    partial class frmAddUpdatePerson
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnSave = new Button();
            rbMale = new RadioButton();
            dtpDateOfBirth = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            lblTitle = new Label();
            label13 = new Label();
            txtFirstName = new TextBox();
            lblPersonID = new Label();
            llSetImage = new LinkLabel();
            rbFemale = new RadioButton();
            pbPersonImage = new PictureBox();
            txtSecondName = new TextBox();
            txtLastName = new TextBox();
            label9 = new Label();
            llRemoveImage = new LinkLabel();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 91);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "LastName";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 0, 192);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(399, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 33);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(119, 269);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 3;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(418, 269);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 23);
            dtpDateOfBirth.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 264);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "DateOfBirth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 189);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 346);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 8;
            label5.Text = "Phone";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 267);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 9;
            label6.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 91);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 11;
            label8.Text = "FirstName";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(283, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 26);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Add Person";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 9);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 16;
            label13.Text = "PersonID";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(17, 123);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(141, 23);
            txtFirstName.TabIndex = 21;
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Location = new Point(102, 9);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(21, 15);
            lblPersonID.TabIndex = 22;
            lblPersonID.Text = ".. ?";
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Location = new Point(691, 264);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(56, 15);
            llSetImage.TabIndex = 23;
            llSetImage.TabStop = true;
            llSetImage.Text = "SetImage";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(209, 269);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 24;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // pbPersonImage
            // 
            pbPersonImage.Image = Properties.Resources.Male;
            pbPersonImage.Location = new Point(631, 113);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(157, 131);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 25;
            pbPersonImage.TabStop = false;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(209, 123);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(141, 23);
            txtSecondName.TabIndex = 26;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(418, 123);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(141, 23);
            txtLastName.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(236, 91);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 28;
            label9.Text = "SecondName";
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.Location = new Point(691, 302);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(83, 15);
            llRemoveImage.TabIndex = 29;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "RemoveImage";
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(84, 338);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(141, 23);
            txtPhone.TabIndex = 30;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(102, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(141, 23);
            txtEmail.TabIndex = 31;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // frmAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(llRemoveImage);
            Controls.Add(label9);
            Controls.Add(txtLastName);
            Controls.Add(txtSecondName);
            Controls.Add(pbPersonImage);
            Controls.Add(rbFemale);
            Controls.Add(llSetImage);
            Controls.Add(lblPersonID);
            Controls.Add(txtFirstName);
            Controls.Add(label13);
            Controls.Add(lblTitle);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(rbMale);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "frmAddUpdatePerson";
            Text = "frmAddUpdatePerson";
            Load += frmAddUpdatePerson_Load;
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPersonID;
        private Label label1;
        private Button btnSave;
        private RadioButton rbMale;
        private DateTimePicker dtpDateOfBirth;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label lblTitle;
        private Label label12;
        private Label label13;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txtFirstName;
        private Label lblPersonID;
        private LinkLabel llSetImage;
        private RadioButton rbFemale;
        private PictureBox pbPersonImage;
        private TextBox txtSecondName;
        private TextBox txtLastName;
        private Label label9;
        private LinkLabel llRemoveImage;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
        private TextBox txtEmail;
        private TextBox txtPhone;
    }
}