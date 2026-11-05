namespace CarRental.Customer.Controls
{
    partial class ctrlCustomerCard
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
            ctrlPersonCard1 = new CarRental.People.Controls.ctrlPersonCard();
            groupBox1 = new GroupBox();
            lblDriverLicenseNumber = new Label();
            label4 = new Label();
            lblCustomerID = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.Teal;
            ctrlPersonCard1.Location = new Point(0, 12);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(589, 336);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Blue;
            groupBox1.Controls.Add(lblDriverLicenseNumber);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblCustomerID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(0, 354);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Info";
            // 
            // lblDriverLicenseNumber
            // 
            lblDriverLicenseNumber.AutoSize = true;
            lblDriverLicenseNumber.Location = new Point(419, 30);
            lblDriverLicenseNumber.Name = "lblDriverLicenseNumber";
            lblDriverLicenseNumber.Size = new Size(28, 17);
            lblDriverLicenseNumber.TabIndex = 4;
            lblDriverLicenseNumber.Text = ".. ?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 30);
            label4.Name = "label4";
            label4.Size = new Size(146, 17);
            label4.TabIndex = 3;
            label4.Text = "DriverLicenseNumber";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(139, 30);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(28, 17);
            lblCustomerID.TabIndex = 2;
            lblCustomerID.Text = ".. ?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 1;
            label1.Text = "CustomerID";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(476, 64);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 17);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Edite Customer";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ctrlCustomerCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            Controls.Add(groupBox1);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlCustomerCard";
            Size = new Size(658, 453);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private GroupBox groupBox1;
        private Label lblDriverLicenseNumber;
        private Label label4;
        private Label lblCustomerID;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
