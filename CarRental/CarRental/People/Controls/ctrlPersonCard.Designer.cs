namespace CarRental.People.Controls
{
    partial class ctrlPersonCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            llEditPersonInfo = new LinkLabel();
            pbPersonImage = new PictureBox();
            groupBox1 = new GroupBox();
            lblDateOfBirth = new Label();
            label2 = new Label();
            lblPhone = new Label();
            label8 = new Label();
            lblEmail = new Label();
            label10 = new Label();
            lblFullName = new Label();
            lblPersonID = new Label();
            label5 = new Label();
            label3 = new Label();
            lblGender = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(231, 235);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 0;
            label1.Text = "Date Of Birth";
            // 
            // llEditPersonInfo
            // 
            llEditPersonInfo.AutoSize = true;
            llEditPersonInfo.BackColor = Color.FromArgb(0, 0, 192);
            llEditPersonInfo.BorderStyle = BorderStyle.Fixed3D;
            llEditPersonInfo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llEditPersonInfo.ForeColor = Color.DarkBlue;
            llEditPersonInfo.LinkColor = Color.SeaShell;
            llEditPersonInfo.Location = new Point(448, 173);
            llEditPersonInfo.Name = "llEditPersonInfo";
            llEditPersonInfo.Size = new Size(112, 18);
            llEditPersonInfo.TabIndex = 1;
            llEditPersonInfo.TabStop = true;
            llEditPersonInfo.Text = "Edit Person Info";
            llEditPersonInfo.LinkClicked += llEditPersonInfo_LinkClicked;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackColor = Color.RoyalBlue;
            pbPersonImage.Image = Properties.Resources.Female_1__3_;
            pbPersonImage.Location = new Point(388, 17);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(204, 140);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 3;
            pbPersonImage.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Navy;
            groupBox1.Controls.Add(lblDateOfBirth);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lblFullName);
            groupBox1.Controls.Add(lblPersonID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblGender);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(llEditPersonInfo);
            groupBox1.Controls.Add(pbPersonImage);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 394);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Person Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblDateOfBirth.ForeColor = Color.Cornsilk;
            lblDateOfBirth.Location = new Point(344, 235);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(30, 19);
            lblDateOfBirth.TabIndex = 18;
            lblDateOfBirth.Text = ".. ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(13, 291);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 16;
            label2.Text = "Phone";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.Cornsilk;
            lblPhone.Location = new Point(107, 291);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(30, 19);
            lblPhone.TabIndex = 15;
            lblPhone.Text = ".. ?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Cornsilk;
            label8.Location = new Point(18, 159);
            label8.Name = "label8";
            label8.Size = new Size(53, 19);
            label8.TabIndex = 14;
            label8.Text = "Email";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Cornsilk;
            lblEmail.Location = new Point(107, 159);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(30, 19);
            lblEmail.TabIndex = 13;
            lblEmail.Text = ".. ?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Cornsilk;
            label10.Location = new Point(24, 95);
            label10.Name = "label10";
            label10.Size = new Size(54, 19);
            label10.TabIndex = 12;
            label10.Text = "Name";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblFullName.ForeColor = Color.Cornsilk;
            lblFullName.Location = new Point(107, 95);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(30, 19);
            lblFullName.TabIndex = 10;
            lblFullName.Text = ".. ?";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblPersonID.ForeColor = Color.Cornsilk;
            lblPersonID.Location = new Point(107, 35);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(30, 19);
            lblPersonID.TabIndex = 9;
            lblPersonID.Text = ".. ?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Cornsilk;
            label5.Location = new Point(18, 35);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 8;
            label5.Text = "PersonID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(11, 225);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 6;
            label3.Text = "Gender";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblGender.ForeColor = Color.Cornsilk;
            lblGender.Location = new Point(107, 225);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(30, 19);
            lblGender.TabIndex = 5;
            lblGender.Text = ".. ?";
            // 
            // ctrlPersonCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            Controls.Add(groupBox1);
            Name = "ctrlPersonCard";
            Size = new Size(595, 397);
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private LinkLabel llEditPersonInfo;
        private PictureBox pbPersonImage;
        private GroupBox groupBox1;
        private Label label8;
        private Label lblEmail;
        private Label label10;
        private Label lblFullName;
        private Label lblPersonID;
        private Label label5;
        private Label label3;
        private Label lblGender;
        private Label label2;
        private Label lblPhone;
        private Label lblDateOfBirth;
    }
}
