namespace CarRental.Customer
{
    partial class frmAddUpdateCustomer
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
            tabControl1 = new TabControl();
            tpPersonInfo = new TabPage();
            tpCustomerInfo = new TabPage();
            btnSave = new Button();
            lblPersonID = new Label();
            label7 = new Label();
            lblDriverLicenseNumber = new Label();
            textBox1 = new TextBox();
            lblCustomerID = new Label();
            label2 = new Label();
            button1 = new Button();
            lblTitle = new Label();
            ctrlPersonCardWithFilter21 = new CarRental.People.Controls.ctrlPersonCardWithFilter2();
            tabControl1.SuspendLayout();
            tpPersonInfo.SuspendLayout();
            tpCustomerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpPersonInfo);
            tabControl1.Controls.Add(tpCustomerInfo);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(598, 472);
            tabControl1.TabIndex = 1;
            // 
            // tpPersonInfo
            // 
            tpPersonInfo.Controls.Add(ctrlPersonCardWithFilter21);
            tpPersonInfo.Location = new Point(4, 24);
            tpPersonInfo.Name = "tpPersonInfo";
            tpPersonInfo.Padding = new Padding(3);
            tpPersonInfo.Size = new Size(590, 444);
            tpPersonInfo.TabIndex = 0;
            tpPersonInfo.Text = "Person Info";
            tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // tpCustomerInfo
            // 
            tpCustomerInfo.BackColor = Color.DarkBlue;
            tpCustomerInfo.Controls.Add(btnSave);
            tpCustomerInfo.Controls.Add(lblPersonID);
            tpCustomerInfo.Controls.Add(label7);
            tpCustomerInfo.Controls.Add(lblDriverLicenseNumber);
            tpCustomerInfo.Controls.Add(textBox1);
            tpCustomerInfo.Controls.Add(lblCustomerID);
            tpCustomerInfo.Controls.Add(label2);
            tpCustomerInfo.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpCustomerInfo.ForeColor = SystemColors.ButtonHighlight;
            tpCustomerInfo.Location = new Point(4, 24);
            tpCustomerInfo.Name = "tpCustomerInfo";
            tpCustomerInfo.Padding = new Padding(3);
            tpCustomerInfo.Size = new Size(590, 444);
            tpCustomerInfo.TabIndex = 1;
            tpCustomerInfo.Text = "Customer Info";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSkyBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(466, 236);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Location = new Point(136, 133);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(25, 16);
            lblPersonID.TabIndex = 7;
            lblPersonID.Text = ".. ?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 133);
            label7.Name = "label7";
            label7.Size = new Size(75, 16);
            label7.TabIndex = 6;
            label7.Text = "PersonID";
            // 
            // lblDriverLicenseNumber
            // 
            lblDriverLicenseNumber.AutoSize = true;
            lblDriverLicenseNumber.Location = new Point(44, 171);
            lblDriverLicenseNumber.Name = "lblDriverLicenseNumber";
            lblDriverLicenseNumber.Size = new Size(176, 16);
            lblDriverLicenseNumber.TabIndex = 5;
            lblDriverLicenseNumber.Text = "Driver License Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 22);
            textBox1.TabIndex = 3;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(167, 45);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(25, 16);
            lblCustomerID.TabIndex = 2;
            lblCustomerID.Text = ".. ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 45);
            label2.Name = "label2";
            label2.Size = new Size(97, 16);
            label2.TabIndex = 0;
            label2.Text = "CustomerID";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(448, 501);
            button1.Name = "button1";
            button1.Size = new Size(162, 37);
            button1.TabIndex = 4;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Bookman Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(319, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(45, 24);
            lblTitle.TabIndex = 3;
            lblTitle.Text = ".. ?";
            // 
            // ctrlPersonCardWithFilter21
            // 
            ctrlPersonCardWithFilter21.FilterEnabled = true;
            ctrlPersonCardWithFilter21.Location = new Point(-6, 0);
            ctrlPersonCardWithFilter21.Name = "ctrlPersonCardWithFilter21";
            ctrlPersonCardWithFilter21.Size = new Size(596, 467);
            ctrlPersonCardWithFilter21.TabIndex = 0;
            // 
            // frmAddUpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(703, 597);
            Controls.Add(lblTitle);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "frmAddUpdateCustomer";
            Text = "frmAddUpdateCustomer";
            Load += frmAddUpdateCustomer_Load;
            tabControl1.ResumeLayout(false);
            tpPersonInfo.ResumeLayout(false);
            tpCustomerInfo.ResumeLayout(false);
            tpCustomerInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tpPersonInfo;
        private TabPage tpCustomerInfo;
        private Label lblPersonID;
        private Label label7;
        private Label lblDriverLicenseNumber;
        private TextBox textBox1;
        private Label lblCustomerID;
        private Label label2;
        private Label lblTitle;
        private Button btnSave;
        private Button button1;
        private People.Controls.ctrlPersonCardWithFilter2 ctrlPersonCardWithFilter21;
    }
}