namespace CarRental.Vehicle
{
    partial class frmListVehicle
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvVehcile = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            vehicleDetailsToolStripMenuItem = new ToolStripMenuItem();
            addVehicleToolStripMenuItem = new ToolStripMenuItem();
            updateVehcileToolStripMenuItem = new ToolStripMenuItem();
            deleteVehcileToolStripMenuItem = new ToolStripMenuItem();
            lblRecordsCount = new Label();
            button1 = new Button();
            txtFilterValue = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbFilterBy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvVehcile).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVehcile
            // 
            dgvVehcile.AllowUserToAddRows = false;
            dgvVehcile.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvVehcile.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVehcile.BackgroundColor = SystemColors.ButtonHighlight;
            dgvVehcile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehcile.ContextMenuStrip = contextMenuStrip1;
            dgvVehcile.Location = new Point(12, 156);
            dgvVehcile.Margin = new Padding(4);
            dgvVehcile.Name = "dgvVehcile";
            dgvVehcile.ReadOnly = true;
            dgvVehcile.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.Turquoise;
            dgvVehcile.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvVehcile.Size = new Size(705, 225);
            dgvVehcile.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { vehicleDetailsToolStripMenuItem, addVehicleToolStripMenuItem, updateVehcileToolStripMenuItem, deleteVehcileToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(153, 92);
            // 
            // vehicleDetailsToolStripMenuItem
            // 
            vehicleDetailsToolStripMenuItem.Name = "vehicleDetailsToolStripMenuItem";
            vehicleDetailsToolStripMenuItem.Size = new Size(152, 22);
            vehicleDetailsToolStripMenuItem.Text = "Vehicle  Details";
            vehicleDetailsToolStripMenuItem.Click += vehicleDetailsToolStripMenuItem_Click;
            // 
            // addVehicleToolStripMenuItem
            // 
            addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            addVehicleToolStripMenuItem.Size = new Size(152, 22);
            addVehicleToolStripMenuItem.Text = "Add Vehicle";
            addVehicleToolStripMenuItem.Click += addVehicleToolStripMenuItem_Click;
            // 
            // updateVehcileToolStripMenuItem
            // 
            updateVehcileToolStripMenuItem.Name = "updateVehcileToolStripMenuItem";
            updateVehcileToolStripMenuItem.Size = new Size(152, 22);
            updateVehcileToolStripMenuItem.Text = "Update Vehcile";
            updateVehcileToolStripMenuItem.Click += updateVehcileToolStripMenuItem_Click;
            // 
            // deleteVehcileToolStripMenuItem
            // 
            deleteVehcileToolStripMenuItem.Name = "deleteVehcileToolStripMenuItem";
            deleteVehcileToolStripMenuItem.Size = new Size(152, 22);
            deleteVehcileToolStripMenuItem.Text = "Delete Vehcile";
            deleteVehcileToolStripMenuItem.Click += deleteVehcileToolStripMenuItem_Click;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.BackColor = Color.LightSteelBlue;
            lblRecordsCount.Location = new Point(163, 395);
            lblRecordsCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(28, 17);
            lblRecordsCount.TabIndex = 1;
            lblRecordsCount.Text = ".. ?";
            // 
            // button1
            // 
            button1.Location = new Point(599, 120);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 26);
            button1.TabIndex = 2;
            button1.Text = "Add Vehicle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(264, 127);
            txtFilterValue.Margin = new Padding(4);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(194, 25);
            txtFilterValue.TabIndex = 5;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Location = new Point(12, 395);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 6;
            label2.Text = "Records Count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 31);
            label3.TabIndex = 7;
            label3.Text = "Vehicle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Location = new Point(36, 129);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 8;
            label4.Text = "Filter";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "VehicleID", "Make", "Fuel TypeID", "Plate Number", "Car CategoryID" });
            cbFilterBy.Location = new Point(94, 126);
            cbFilterBy.Margin = new Padding(4);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(150, 25);
            cbFilterBy.TabIndex = 9;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // frmListVehicle
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1029, 540);
            Controls.Add(cbFilterBy);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFilterValue);
            Controls.Add(button1);
            Controls.Add(lblRecordsCount);
            Controls.Add(dgvVehcile);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmListVehicle";
            Text = "frmListVehicle";
            Load += frmListVehicle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehcile).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVehcile;
        private Label lblRecordsCount;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtFilterValue;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbFilterBy;
        private ToolStripMenuItem vehicleDetailsToolStripMenuItem;
        private ToolStripMenuItem addVehicleToolStripMenuItem;
        private ToolStripMenuItem updateVehcileToolStripMenuItem;
        private ToolStripMenuItem deleteVehcileToolStripMenuItem;
    }
}