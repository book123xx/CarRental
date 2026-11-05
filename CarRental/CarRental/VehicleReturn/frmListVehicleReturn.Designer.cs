namespace CarRental.VehicleReturn
{
    partial class frmListVehicleReturn
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
            txtFilterValue = new TextBox();
            lblRecordsCount = new Label();
            dgvVehicleReturn = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addVehicleReturnToolStripMenuItem = new ToolStripMenuItem();
            updateVehicleReturnToolStripMenuItem = new ToolStripMenuItem();
            deleteVehicleReturnToolStripMenuItem = new ToolStripMenuItem();
            cbFilterBy = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleReturn).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(324, 106);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(160, 23);
            txtFilterValue.TabIndex = 0;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.BackColor = Color.FromArgb(255, 192, 128);
            lblRecordsCount.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            lblRecordsCount.Location = new Point(191, 383);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(40, 19);
            lblRecordsCount.TabIndex = 1;
            lblRecordsCount.Text = "... ?";
            // 
            // dgvVehicleReturn
            // 
            dgvVehicleReturn.AllowUserToAddRows = false;
            dgvVehicleReturn.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            dgvVehicleReturn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVehicleReturn.BackgroundColor = SystemColors.ButtonHighlight;
            dgvVehicleReturn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleReturn.ContextMenuStrip = contextMenuStrip1;
            dgvVehicleReturn.Location = new Point(12, 135);
            dgvVehicleReturn.Name = "dgvVehicleReturn";
            dgvVehicleReturn.ReadOnly = true;
            dgvVehicleReturn.RowHeadersVisible = false;
            dgvVehicleReturn.Size = new Size(776, 220);
            dgvVehicleReturn.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addVehicleReturnToolStripMenuItem, updateVehicleReturnToolStripMenuItem, deleteVehicleReturnToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(190, 70);
            // 
            // addVehicleReturnToolStripMenuItem
            // 
            addVehicleReturnToolStripMenuItem.Name = "addVehicleReturnToolStripMenuItem";
            addVehicleReturnToolStripMenuItem.Size = new Size(189, 22);
            addVehicleReturnToolStripMenuItem.Text = "Add Vehicle Return";
            addVehicleReturnToolStripMenuItem.Click += addVehicleReturnToolStripMenuItem_Click;
            // 
            // updateVehicleReturnToolStripMenuItem
            // 
            updateVehicleReturnToolStripMenuItem.Name = "updateVehicleReturnToolStripMenuItem";
            updateVehicleReturnToolStripMenuItem.Size = new Size(189, 22);
            updateVehicleReturnToolStripMenuItem.Text = "update Vehicle Return";
            updateVehicleReturnToolStripMenuItem.Click += updateVehicleReturnToolStripMenuItem_Click;
            // 
            // deleteVehicleReturnToolStripMenuItem
            // 
            deleteVehicleReturnToolStripMenuItem.Name = "deleteVehicleReturnToolStripMenuItem";
            deleteVehicleReturnToolStripMenuItem.Size = new Size(189, 22);
            deleteVehicleReturnToolStripMenuItem.Text = "Delete Vehicle Return";
            deleteVehicleReturnToolStripMenuItem.Click += deleteVehicleReturnToolStripMenuItem_Click;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "ReturenID", "Mileage", "Consumed Mileage", "Final Check Notes", "Additional Charges", "Actual Total Due Amount" });
            cbFilterBy.Location = new Point(191, 106);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(121, 23);
            cbFilterBy.TabIndex = 3;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(602, 105);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 5;
            button1.Text = "Add Vehicle Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 128);
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label2.Location = new Point(54, 383);
            label2.Name = "label2";
            label2.Size = new Size(131, 19);
            label2.TabIndex = 6;
            label2.Text = "Records Count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(308, 9);
            label3.Name = "label3";
            label3.Size = new Size(188, 24);
            label3.TabIndex = 7;
            label3.Text = "List Vehicle Returns";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 128);
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label4.Location = new Point(133, 105);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 8;
            label4.Text = "Filter";
            // 
            // frmListVehicleReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(cbFilterBy);
            Controls.Add(dgvVehicleReturn);
            Controls.Add(lblRecordsCount);
            Controls.Add(txtFilterValue);
            Name = "frmListVehicleReturn";
            Text = "frmListVehicleReturn";
            Load += frmListVehicleReturn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehicleReturn).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilterValue;
        private Label lblRecordsCount;
        private DataGridView dgvVehicleReturn;
        private ComboBox cbFilterBy;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStripMenuItem addVehicleReturnToolStripMenuItem;
        private ToolStripMenuItem updateVehicleReturnToolStripMenuItem;
        private ToolStripMenuItem deleteVehicleReturnToolStripMenuItem;
    }
}