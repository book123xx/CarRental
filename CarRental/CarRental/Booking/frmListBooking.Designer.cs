namespace CarRental.Booking
{
    partial class frmListBooking
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
            dgvBooking = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            bookingDetailsToolStripMenuItem = new ToolStripMenuItem();
            addNewBookingToolStripMenuItem = new ToolStripMenuItem();
            updateBookingToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            x = new Label();
            lblRecordsCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooking
            // 
            dgvBooking.AllowUserToAddRows = false;
            dgvBooking.AllowUserToDeleteRows = false;
            dgvBooking.BackgroundColor = SystemColors.ControlLightLight;
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.ContextMenuStrip = contextMenuStrip1;
            dgvBooking.Location = new Point(17, 142);
            dgvBooking.Margin = new Padding(4);
            dgvBooking.Name = "dgvBooking";
            dgvBooking.ReadOnly = true;
            dgvBooking.RowHeadersVisible = false;
            dgvBooking.Size = new Size(749, 299);
            dgvBooking.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { bookingDetailsToolStripMenuItem, addNewBookingToolStripMenuItem, updateBookingToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(171, 92);
            // 
            // bookingDetailsToolStripMenuItem
            // 
            bookingDetailsToolStripMenuItem.Name = "bookingDetailsToolStripMenuItem";
            bookingDetailsToolStripMenuItem.Size = new Size(170, 22);
            bookingDetailsToolStripMenuItem.Text = "Booking Details";
            bookingDetailsToolStripMenuItem.Click += bookingDetailsToolStripMenuItem_Click;
            // 
            // addNewBookingToolStripMenuItem
            // 
            addNewBookingToolStripMenuItem.Name = "addNewBookingToolStripMenuItem";
            addNewBookingToolStripMenuItem.Size = new Size(170, 22);
            addNewBookingToolStripMenuItem.Text = "Add New Booking";
            addNewBookingToolStripMenuItem.Click += addNewBookingToolStripMenuItem_Click;
            // 
            // updateBookingToolStripMenuItem
            // 
            updateBookingToolStripMenuItem.Name = "updateBookingToolStripMenuItem";
            updateBookingToolStripMenuItem.Size = new Size(170, 22);
            updateBookingToolStripMenuItem.Text = "Update Booking";
            updateBookingToolStripMenuItem.Click += updateBookingToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(170, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "BookingID", "CustomerID", "VehicleID", "Pickup Location", "Dropoff Location", "InitialRental Days" });
            cbFilterBy.Location = new Point(93, 108);
            cbFilterBy.Margin = new Padding(4);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(191, 26);
            cbFilterBy.TabIndex = 1;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            cbFilterBy.TextChanged += txtFilterValue_TextChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(292, 109);
            txtFilterValue.Margin = new Padding(4);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(204, 25);
            txtFilterValue.TabIndex = 2;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged_1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(241, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 41);
            label1.TabIndex = 3;
            label1.Text = "Booking List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(589, 103);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(154, 28);
            button1.TabIndex = 4;
            button1.Text = "Add Booking";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(17, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 5;
            label2.Text = "Filter";
            // 
            // x
            // 
            x.AutoSize = true;
            x.BackColor = SystemColors.GradientActiveCaption;
            x.Location = new Point(221, 445);
            x.Margin = new Padding(4, 0, 4, 0);
            x.Name = "x";
            x.Size = new Size(30, 18);
            x.TabIndex = 6;
            x.Text = ".. ?";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.BackColor = SystemColors.GradientActiveCaption;
            lblRecordsCount.Location = new Point(66, 445);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(125, 18);
            lblRecordsCount.TabIndex = 7;
            lblRecordsCount.Text = ".Records Count";
            // 
            // frmListBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1143, 540);
            Controls.Add(lblRecordsCount);
            Controls.Add(x);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(dgvBooking);
            Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmListBooking";
            Text = "frmListBooking";
            Load += frmListBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooking;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label x;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem bookingDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewBookingToolStripMenuItem;
        private ToolStripMenuItem updateBookingToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label lblRecordsCount;
    }
}