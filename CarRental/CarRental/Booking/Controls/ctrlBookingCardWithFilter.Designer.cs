namespace CarRental.Booking.Controls
{
    partial class ctrlBookingCardWithFilter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlBookingCardWithFilter));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ctrlBookingCard1 = new ctrlBookingCard();
            tabPage2 = new TabPage();
            ctrlVehicleCard1 = new CarRental.Vehicle.Controls.ctrlVehicleCard();
            tabPage3 = new TabPage();
            ctrlCustomerCard1 = new CarRental.Customer.Controls.ctrlCustomerCard();
            textBox1 = new TextBox();
            label1 = new Label();
            btnFind = new Button();
            imageList1 = new ImageList(components);
            groupBox1 = new GroupBox();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 114);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(597, 507);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.Controls.Add(ctrlBookingCard1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(589, 479);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Booking Info";
            // 
            // ctrlBookingCard1
            // 
            ctrlBookingCard1.BackColor = Color.RoyalBlue;
            ctrlBookingCard1.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlBookingCard1.Location = new Point(0, 4);
            ctrlBookingCard1.Margin = new Padding(3, 4, 3, 4);
            ctrlBookingCard1.Name = "ctrlBookingCard1";
            ctrlBookingCard1.Size = new Size(583, 376);
            ctrlBookingCard1.TabIndex = 0;
            ctrlBookingCard1.Load += ctrlBookingCard1_Load;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(0, 0, 192);
            tabPage2.Controls.Add(ctrlVehicleCard1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(589, 479);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vehicle Info";
            // 
            // ctrlVehicleCard1
            // 
            ctrlVehicleCard1.BackColor = Color.DarkBlue;
            ctrlVehicleCard1.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlVehicleCard1.ForeColor = SystemColors.ButtonHighlight;
            ctrlVehicleCard1.Location = new Point(3, 4);
            ctrlVehicleCard1.Margin = new Padding(3, 4, 3, 4);
            ctrlVehicleCard1.Name = "ctrlVehicleCard1";
            ctrlVehicleCard1.Size = new Size(536, 318);
            ctrlVehicleCard1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Navy;
            tabPage3.Controls.Add(ctrlCustomerCard1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(589, 479);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Customer Info";
            // 
            // ctrlCustomerCard1
            // 
            ctrlCustomerCard1.BackColor = Color.Navy;
            ctrlCustomerCard1.Location = new Point(3, 3);
            ctrlCustomerCard1.Name = "ctrlCustomerCard1";
            ctrlCustomerCard1.Size = new Size(586, 470);
            ctrlCustomerCard1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 22);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Validating += textBox1_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Location = new Point(17, 55);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 2;
            label1.Text = "Booking ID";
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.HotTrack;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.ForeColor = SystemColors.ControlLightLight;
            btnFind.ImageAlign = ContentAlignment.MiddleRight;
            btnFind.ImageIndex = 1;
            btnFind.ImageList = imageList1;
            btnFind.Location = new Point(281, 54);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(155, 23);
            btnFind.TabIndex = 3;
            btnFind.Text = "Search";
            btnFind.TextAlign = ContentAlignment.MiddleLeft;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Add_1.png");
            imageList1.Images.SetKeyName(1, "find_1.png");
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnFind);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(0, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 94);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ImageIndex = 0;
            button2.ImageList = imageList1;
            button2.Location = new Point(442, 46);
            button2.Name = "button2";
            button2.Size = new Size(37, 34);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlBookingCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Name = "ctrlBookingCardWithFilter";
            Size = new Size(589, 590);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ctrlBookingCard ctrlBookingCard1;
        private Vehicle.Controls.ctrlVehicleCard ctrlVehicleCard1;
        private TabPage tabPage3;
        private Customer.Controls.ctrlCustomerCard ctrlCustomerCard1;
        private TextBox textBox1;
        private Label label1;
        private Button btnFind;
        private ImageList imageList1;
        private GroupBox groupBox1;
        private Button button2;
        private ErrorProvider errorProvider1;
    }
}
