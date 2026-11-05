namespace CarRental.Vehicle
{
    partial class frmAddUpdateVehicle
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
            errorProvider1 = new ErrorProvider(components);
            txtPlateNumber = new TextBox();
            lblVehicleID = new Label();
            txtRentalPricePerDay = new TextBox();
            txtMileage = new TextBox();
            txtVehicleYear = new TextBox();
            txtModel = new TextBox();
            txtMake = new TextBox();
            label2 = new Label();
            lblTitle = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            cbFuelType = new ComboBox();
            label12 = new Label();
            cbCarCategory = new ComboBox();
            checkBox1 = new CheckBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(512, 120);
            txtPlateNumber.Margin = new Padding(3, 4, 3, 4);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(114, 23);
            txtPlateNumber.TabIndex = 0;
            // 
            // lblVehicleID
            // 
            lblVehicleID.AutoSize = true;
            lblVehicleID.Location = new Point(182, 84);
            lblVehicleID.Name = "lblVehicleID";
            lblVehicleID.Size = new Size(23, 18);
            lblVehicleID.TabIndex = 1;
            lblVehicleID.Text = ".. ?";
            // 
            // txtRentalPricePerDay
            // 
            txtRentalPricePerDay.Location = new Point(556, 360);
            txtRentalPricePerDay.Margin = new Padding(3, 4, 3, 4);
            txtRentalPricePerDay.Name = "txtRentalPricePerDay";
            txtRentalPricePerDay.Size = new Size(114, 23);
            txtRentalPricePerDay.TabIndex = 5;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(101, 348);
            txtMileage.Margin = new Padding(3, 4, 3, 4);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(114, 23);
            txtMileage.TabIndex = 6;
            // 
            // txtVehicleYear
            // 
            txtVehicleYear.Location = new Point(101, 283);
            txtVehicleYear.Margin = new Padding(3, 4, 3, 4);
            txtVehicleYear.Name = "txtVehicleYear";
            txtVehicleYear.Size = new Size(114, 23);
            txtVehicleYear.TabIndex = 7;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(132, 203);
            txtModel.Margin = new Padding(3, 4, 3, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(114, 23);
            txtModel.TabIndex = 8;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(132, 141);
            txtMake.Margin = new Padding(3, 4, 3, 4);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(114, 23);
            txtMake.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 204);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 10;
            label2.Text = "FuelTypeID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(298, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(77, 23);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Vehicle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 120);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 12;
            label4.Text = "PlateNumber";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(402, 364);
            label6.Name = "label6";
            label6.Size = new Size(122, 18);
            label6.TabIndex = 14;
            label6.Text = "RentalPricePerDay";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 351);
            label7.Name = "label7";
            label7.Size = new Size(57, 18);
            label7.TabIndex = 15;
            label7.Text = "Mileage";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 283);
            label8.Name = "label8";
            label8.Size = new Size(82, 18);
            label8.TabIndex = 16;
            label8.Text = "VehicleYear";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 208);
            label9.Name = "label9";
            label9.Size = new Size(47, 18);
            label9.TabIndex = 17;
            label9.Text = "Model";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(86, 84);
            label10.Name = "label10";
            label10.Size = new Size(70, 18);
            label10.TabIndex = 18;
            label10.Text = "VehicleID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(64, 141);
            label11.Name = "label11";
            label11.Size = new Size(43, 18);
            label11.TabIndex = 19;
            label11.Text = "Make";
            // 
            // cbFuelType
            // 
            cbFuelType.FormattingEnabled = true;
            cbFuelType.Location = new Point(488, 200);
            cbFuelType.Margin = new Padding(3, 4, 3, 4);
            cbFuelType.Name = "cbFuelType";
            cbFuelType.Size = new Size(138, 26);
            cbFuelType.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(397, 283);
            label12.Name = "label12";
            label12.Size = new Size(98, 18);
            label12.TabIndex = 21;
            label12.Text = "CarCategoryID";
            // 
            // cbCarCategory
            // 
            cbCarCategory.FormattingEnabled = true;
            cbCarCategory.Location = new Point(512, 280);
            cbCarCategory.Margin = new Padding(3, 4, 3, 4);
            cbCarCategory.Name = "cbCarCategory";
            cbCarCategory.Size = new Size(138, 26);
            cbCarCategory.TabIndex = 22;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(64, 397);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(152, 22);
            checkBox1.TabIndex = 23;
            checkBox1.Text = "Is Available For Rent";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 0, 192);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(555, 426);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 34);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddUpdateVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(695, 487);
            Controls.Add(btnSave);
            Controls.Add(checkBox1);
            Controls.Add(cbCarCategory);
            Controls.Add(label12);
            Controls.Add(cbFuelType);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(lblTitle);
            Controls.Add(label2);
            Controls.Add(txtMake);
            Controls.Add(txtModel);
            Controls.Add(txtVehicleYear);
            Controls.Add(txtMileage);
            Controls.Add(txtRentalPricePerDay);
            Controls.Add(lblVehicleID);
            Controls.Add(txtPlateNumber);
            Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAddUpdateVehicle";
            Text = "frmAddUpdateVehicle";
            Load += frmAddUpdateVehicle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private ComboBox cbCarCategory;
        private Label label12;
        private ComboBox cbFuelType;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label lblTitle;
        private Label label2;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtVehicleYear;
        private TextBox txtMileage;
        private TextBox txtRentalPricePerDay;
        private Label lblVehicleID;
        private TextBox txtPlateNumber;
        private CheckBox checkBox1;
        private Button btnSave;
    }
}