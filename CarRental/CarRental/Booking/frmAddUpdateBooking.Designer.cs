namespace CarRental.Booking
{
    partial class frmAddUpdateBooking
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
            dtpRentalStartDate = new DateTimePicker();
            btnSave = new Button();
            lblBookingID = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            lblInitialRentalDays = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            label11 = new Label();
            lblInitialTotalDueAmount = new Label();
            label20 = new Label();
            label22 = new Label();
            label24 = new Label();
            lblRentalPricePerDay = new Label();
            txtDropoffLocation = new TextBox();
            txtPickupLocation = new TextBox();
            dtpRentalEndDate = new DateTimePicker();
            lbltitle = new Label();
            txtPaymentDetails = new TextBox();
            txtPaidInitialTotalDueAmount = new TextBox();
            txtInitialCheckNotes = new TextBox();
            tcBookingInfo = new TabControl();
            tpCustomerInfo = new TabPage();
            ctrlCustomerCardWithFilter1 = new CarRental.Customer.Controls.ctrlCustomerCardWithFilter();
            btnNext1 = new Button();
            tpVehicleInfo = new TabPage();
            btnNext2 = new Button();
            ctrlVehicleCardWithFilter1 = new CarRental.Vehicle.Controls.ctrlVehicleCardWithFilter();
            tpBookinginfo = new TabPage();
            errorProvider1 = new ErrorProvider(components);
            tcBookingInfo.SuspendLayout();
            tpCustomerInfo.SuspendLayout();
            tpVehicleInfo.SuspendLayout();
            tpBookinginfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dtpRentalStartDate
            // 
            dtpRentalStartDate.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            dtpRentalStartDate.Location = new Point(153, 76);
            dtpRentalStartDate.Name = "dtpRentalStartDate";
            dtpRentalStartDate.Size = new Size(151, 22);
            dtpRentalStartDate.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(573, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 32);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblBookingID
            // 
            lblBookingID.AutoSize = true;
            lblBookingID.BackColor = Color.White;
            lblBookingID.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblBookingID.Location = new Point(166, 3);
            lblBookingID.Name = "lblBookingID";
            lblBookingID.Size = new Size(23, 15);
            lblBookingID.TabIndex = 11;
            lblBookingID.Text = ".. ?";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label14.Location = new Point(55, 3);
            label14.Name = "label14";
            label14.Size = new Size(67, 15);
            label14.TabIndex = 16;
            label14.Text = "BookingID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(255, 224, 192);
            label15.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label15.Location = new Point(41, 82);
            label15.Name = "label15";
            label15.Size = new Size(102, 15);
            label15.TabIndex = 18;
            label15.Text = "Rental Start Date";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(255, 224, 192);
            label17.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label17.Location = new Point(55, 135);
            label17.Name = "label17";
            label17.Size = new Size(94, 15);
            label17.TabIndex = 20;
            label17.Text = "Rental End Date";
            // 
            // lblInitialRentalDays
            // 
            lblInitialRentalDays.AutoSize = true;
            lblInitialRentalDays.BackColor = Color.White;
            lblInitialRentalDays.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblInitialRentalDays.Location = new Point(204, 320);
            lblInitialRentalDays.Name = "lblInitialRentalDays";
            lblInitialRentalDays.Size = new Size(23, 15);
            lblInitialRentalDays.TabIndex = 19;
            lblInitialRentalDays.Text = ".. ?";
            lblInitialRentalDays.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label2.Location = new Point(61, 320);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 26;
            label2.Text = "Initial Rental Days";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 224, 192);
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label4.Location = new Point(49, 241);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 24;
            label4.Text = "Dropoff Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 224, 192);
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label6.Location = new Point(61, 188);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 22;
            label6.Text = "Pickup Location";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 224, 192);
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label8.Location = new Point(317, 187);
            label8.Name = "label8";
            label8.Size = new Size(167, 15);
            label8.TabIndex = 38;
            label8.Text = "Paid Initial Total Due Amount";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(255, 224, 192);
            label11.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label11.Location = new Point(340, 252);
            label11.Name = "label11";
            label11.Size = new Size(113, 15);
            label11.TabIndex = 36;
            label11.Text = "Initial Check Notes";
            // 
            // lblInitialTotalDueAmount
            // 
            lblInitialTotalDueAmount.AutoSize = true;
            lblInitialTotalDueAmount.BackColor = Color.White;
            lblInitialTotalDueAmount.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblInitialTotalDueAmount.Location = new Point(492, 72);
            lblInitialTotalDueAmount.Name = "lblInitialTotalDueAmount";
            lblInitialTotalDueAmount.Size = new Size(23, 15);
            lblInitialTotalDueAmount.TabIndex = 33;
            lblInitialTotalDueAmount.Text = ".. ?";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(255, 224, 192);
            label20.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label20.Location = new Point(362, 131);
            label20.Name = "label20";
            label20.Size = new Size(96, 15);
            label20.TabIndex = 32;
            label20.Text = "Payment Details";
            label20.TextAlign = ContentAlignment.TopRight;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(255, 224, 192);
            label22.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label22.Location = new Point(340, 72);
            label22.Name = "label22";
            label22.Size = new Size(140, 15);
            label22.TabIndex = 30;
            label22.Text = "Initial Total Due Amount";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.FromArgb(255, 224, 192);
            label24.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label24.Location = new Point(69, 371);
            label24.Name = "label24";
            label24.Size = new Size(123, 15);
            label24.TabIndex = 28;
            label24.Text = "Rental Price Per Day";
            // 
            // lblRentalPricePerDay
            // 
            lblRentalPricePerDay.AutoSize = true;
            lblRentalPricePerDay.BackColor = Color.White;
            lblRentalPricePerDay.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblRentalPricePerDay.Location = new Point(204, 371);
            lblRentalPricePerDay.Name = "lblRentalPricePerDay";
            lblRentalPricePerDay.Size = new Size(23, 15);
            lblRentalPricePerDay.TabIndex = 27;
            lblRentalPricePerDay.Text = ".. ?";
            lblRentalPricePerDay.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDropoffLocation
            // 
            txtDropoffLocation.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            txtDropoffLocation.Location = new Point(153, 238);
            txtDropoffLocation.Name = "txtDropoffLocation";
            txtDropoffLocation.Size = new Size(137, 22);
            txtDropoffLocation.TabIndex = 39;
            // 
            // txtPickupLocation
            // 
            txtPickupLocation.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            txtPickupLocation.Location = new Point(166, 188);
            txtPickupLocation.Name = "txtPickupLocation";
            txtPickupLocation.Size = new Size(124, 22);
            txtPickupLocation.TabIndex = 40;
            // 
            // dtpRentalEndDate
            // 
            dtpRentalEndDate.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            dtpRentalEndDate.Location = new Point(153, 135);
            dtpRentalEndDate.Name = "dtpRentalEndDate";
            dtpRentalEndDate.Size = new Size(151, 22);
            dtpRentalEndDate.TabIndex = 44;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(363, 9);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(33, 19);
            lbltitle.TabIndex = 45;
            lbltitle.Text = ".. ?";
            // 
            // txtPaymentDetails
            // 
            txtPaymentDetails.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            txtPaymentDetails.Location = new Point(472, 128);
            txtPaymentDetails.Name = "txtPaymentDetails";
            txtPaymentDetails.Size = new Size(124, 22);
            txtPaymentDetails.TabIndex = 49;
            txtPaymentDetails.TextChanged += textBox7_TextChanged;
            // 
            // txtPaidInitialTotalDueAmount
            // 
            txtPaidInitialTotalDueAmount.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            txtPaidInitialTotalDueAmount.Location = new Point(492, 181);
            txtPaidInitialTotalDueAmount.Name = "txtPaidInitialTotalDueAmount";
            txtPaidInitialTotalDueAmount.Size = new Size(137, 22);
            txtPaidInitialTotalDueAmount.TabIndex = 48;
            // 
            // txtInitialCheckNotes
            // 
            txtInitialCheckNotes.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            txtInitialCheckNotes.Location = new Point(472, 244);
            txtInitialCheckNotes.Name = "txtInitialCheckNotes";
            txtInitialCheckNotes.Size = new Size(137, 22);
            txtInitialCheckNotes.TabIndex = 50;
            // 
            // tcBookingInfo
            // 
            tcBookingInfo.Controls.Add(tpCustomerInfo);
            tcBookingInfo.Controls.Add(tpVehicleInfo);
            tcBookingInfo.Controls.Add(tpBookinginfo);
            tcBookingInfo.Location = new Point(-3, 27);
            tcBookingInfo.Name = "tcBookingInfo";
            tcBookingInfo.SelectedIndex = 0;
            tcBookingInfo.Size = new Size(791, 602);
            tcBookingInfo.TabIndex = 51;
            // 
            // tpCustomerInfo
            // 
            tpCustomerInfo.BackColor = SystemColors.Desktop;
            tpCustomerInfo.Controls.Add(ctrlCustomerCardWithFilter1);
            tpCustomerInfo.Controls.Add(btnNext1);
            tpCustomerInfo.Location = new Point(4, 24);
            tpCustomerInfo.Name = "tpCustomerInfo";
            tpCustomerInfo.Padding = new Padding(3);
            tpCustomerInfo.Size = new Size(783, 574);
            tpCustomerInfo.TabIndex = 0;
            tpCustomerInfo.Text = "Customer Info";
            // 
            // ctrlCustomerCardWithFilter1
            // 
            ctrlCustomerCardWithFilter1.BackColor = Color.Navy;
            ctrlCustomerCardWithFilter1.FilterEnabled = true;
            ctrlCustomerCardWithFilter1.Location = new Point(-4, -6);
            ctrlCustomerCardWithFilter1.Name = "ctrlCustomerCardWithFilter1";
            ctrlCustomerCardWithFilter1.Size = new Size(614, 574);
            ctrlCustomerCardWithFilter1.TabIndex = 0;
            // 
            // btnNext1
            // 
            btnNext1.BackColor = SystemColors.ActiveCaptionText;
            btnNext1.FlatStyle = FlatStyle.Popup;
            btnNext1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext1.ForeColor = SystemColors.ButtonFace;
            btnNext1.Location = new Point(589, 6);
            btnNext1.Name = "btnNext1";
            btnNext1.Size = new Size(188, 36);
            btnNext1.TabIndex = 1;
            btnNext1.Text = "Next";
            btnNext1.UseVisualStyleBackColor = false;
            btnNext1.Click += btnNext1_Click;
            // 
            // tpVehicleInfo
            // 
            tpVehicleInfo.BackColor = Color.Blue;
            tpVehicleInfo.Controls.Add(btnNext2);
            tpVehicleInfo.Controls.Add(ctrlVehicleCardWithFilter1);
            tpVehicleInfo.ForeColor = Color.MidnightBlue;
            tpVehicleInfo.Location = new Point(4, 24);
            tpVehicleInfo.Name = "tpVehicleInfo";
            tpVehicleInfo.Padding = new Padding(3);
            tpVehicleInfo.Size = new Size(783, 574);
            tpVehicleInfo.TabIndex = 1;
            tpVehicleInfo.Text = "Vehicle";
            // 
            // btnNext2
            // 
            btnNext2.BackColor = Color.Lavender;
            btnNext2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext2.Location = new Point(571, 0);
            btnNext2.Name = "btnNext2";
            btnNext2.Size = new Size(206, 36);
            btnNext2.TabIndex = 52;
            btnNext2.Text = "Next";
            btnNext2.UseVisualStyleBackColor = false;
            btnNext2.Click += btnNext2_Click;
            // 
            // ctrlVehicleCardWithFilter1
            // 
            ctrlVehicleCardWithFilter1.FilterEnabled = true;
            ctrlVehicleCardWithFilter1.Location = new Point(-4, 6);
            ctrlVehicleCardWithFilter1.Name = "ctrlVehicleCardWithFilter1";
            ctrlVehicleCardWithFilter1.Size = new Size(540, 402);
            ctrlVehicleCardWithFilter1.TabIndex = 0;
            // 
            // tpBookinginfo
            // 
            tpBookinginfo.BackColor = Color.LightGray;
            tpBookinginfo.Controls.Add(dtpRentalEndDate);
            tpBookinginfo.Controls.Add(txtInitialCheckNotes);
            tpBookinginfo.Controls.Add(txtPickupLocation);
            tpBookinginfo.Controls.Add(btnSave);
            tpBookinginfo.Controls.Add(txtDropoffLocation);
            tpBookinginfo.Controls.Add(txtPaymentDetails);
            tpBookinginfo.Controls.Add(label24);
            tpBookinginfo.Controls.Add(label22);
            tpBookinginfo.Controls.Add(lblRentalPricePerDay);
            tpBookinginfo.Controls.Add(txtPaidInitialTotalDueAmount);
            tpBookinginfo.Controls.Add(label2);
            tpBookinginfo.Controls.Add(label20);
            tpBookinginfo.Controls.Add(label4);
            tpBookinginfo.Controls.Add(lblInitialTotalDueAmount);
            tpBookinginfo.Controls.Add(label6);
            tpBookinginfo.Controls.Add(label11);
            tpBookinginfo.Controls.Add(label17);
            tpBookinginfo.Controls.Add(label8);
            tpBookinginfo.Controls.Add(lblInitialRentalDays);
            tpBookinginfo.Controls.Add(label14);
            tpBookinginfo.Controls.Add(label15);
            tpBookinginfo.Controls.Add(dtpRentalStartDate);
            tpBookinginfo.Controls.Add(lblBookingID);
            tpBookinginfo.Location = new Point(4, 24);
            tpBookinginfo.Name = "tpBookinginfo";
            tpBookinginfo.Padding = new Padding(3);
            tpBookinginfo.Size = new Size(783, 574);
            tpBookinginfo.TabIndex = 2;
            tpBookinginfo.Text = "Booking Info";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(lbltitle);
            Controls.Add(tcBookingInfo);
            Name = "frmAddUpdateBooking";
            Text = "frmAddUpdateBooking";
            Load += frmAddUpdateBooking_Load;
            tcBookingInfo.ResumeLayout(false);
            tpCustomerInfo.ResumeLayout(false);
            tpVehicleInfo.ResumeLayout(false);
            tpBookinginfo.ResumeLayout(false);
            tpBookinginfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dtpRentalStartDate;
        private Button btnSave;
        private Label lblBookingID;
        private Label label14;
        private Label label15;
        private Label lbl;
        private Label label17;
        private Label lblInitialRentalDays;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label11;
        private Label label13;
        private Label lblInitialTotalDueAmount;
        private Label label20;
        private Label label22;
        private Label label24;
        private Label lblRentalPricePerDay;
        private TextBox txtDropoffLocation;
        private TextBox txtPickupLocation;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DateTimePicker dtpRentalEndDate;
        private Label lbltitle;
        private TextBox txtPaymentDetails;
        private TextBox txtPaidInitialTotalDueAmount;
        private TextBox txtInitialCheckNotes;
        private TabControl tcBookingInfo;
        private TabPage tpCustomerInfo;
        private TabPage tpVehicleInfo;
        private TabPage tpBookinginfo;
        private Vehicle.Controls.ctrlVehicleCardWithFilter ctrlVehicleCardWithFilter1;
        private Button btnNext1;
        private Button btnNext2;
        private ErrorProvider errorProvider1;
        private Customer.Controls.ctrlCustomerCardWithFilter ctrlCustomerCardWithFilter1;
    }
}