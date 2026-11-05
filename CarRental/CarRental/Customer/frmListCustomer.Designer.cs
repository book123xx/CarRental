namespace CarRental.Customer
{
    partial class frmListCustomer
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            contextMenuStrip1 = new ContextMenuStrip(components);
            customerDetailsToolStripMenuItem = new ToolStripMenuItem();
            addCustomerToolStripMenuItem = new ToolStripMenuItem();
            updateCustomerToolStripMenuItem = new ToolStripMenuItem();
            deleteCustomerToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            button1 = new Button();
            label3 = new Label();
            x = new Label();
            lblRecordsCount = new Label();
            dgvCustomers = new DataGridView();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { customerDetailsToolStripMenuItem, addCustomerToolStripMenuItem, updateCustomerToolStripMenuItem, deleteCustomerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(168, 92);
            // 
            // customerDetailsToolStripMenuItem
            // 
            customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            customerDetailsToolStripMenuItem.Size = new Size(167, 22);
            customerDetailsToolStripMenuItem.Text = "Customer Details";
            customerDetailsToolStripMenuItem.Click += customerDetailsToolStripMenuItem_Click;
            // 
            // addCustomerToolStripMenuItem
            // 
            addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            addCustomerToolStripMenuItem.Size = new Size(167, 22);
            addCustomerToolStripMenuItem.Text = "Add Customer";
            addCustomerToolStripMenuItem.Click += addCustomerToolStripMenuItem_Click;
            // 
            // updateCustomerToolStripMenuItem
            // 
            updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            updateCustomerToolStripMenuItem.Size = new Size(167, 22);
            updateCustomerToolStripMenuItem.Text = "Update Customer";
            updateCustomerToolStripMenuItem.Click += updateCustomerToolStripMenuItem_Click;
            // 
            // deleteCustomerToolStripMenuItem
            // 
            deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            deleteCustomerToolStripMenuItem.Size = new Size(167, 22);
            deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            deleteCustomerToolStripMenuItem.Click += deleteCustomerToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(70, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 1;
            label1.Text = "Filter";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "CustomerID", "PersonID", "Full Name", "Phone", "Driver License Number" });
            cbFilterBy.Location = new Point(149, 96);
            cbFilterBy.Margin = new Padding(4);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(155, 26);
            cbFilterBy.TabIndex = 2;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(326, 96);
            txtFilterValue.Margin = new Padding(4);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(159, 25);
            txtFilterValue.TabIndex = 3;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(610, 100);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(95, 28);
            button1.TabIndex = 4;
            button1.Text = "Add Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(391, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 18);
            label3.TabIndex = 6;
            label3.Text = "List Customer";
            // 
            // x
            // 
            x.AutoSize = true;
            x.BackColor = SystemColors.GradientActiveCaption;
            x.Location = new Point(184, 438);
            x.Name = "x";
            x.Size = new Size(30, 18);
            x.TabIndex = 7;
            x.Text = ",, ?";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.BackColor = SystemColors.GradientActiveCaption;
            lblRecordsCount.Location = new Point(46, 435);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(120, 18);
            lblRecordsCount.TabIndex = 8;
            lblRecordsCount.Text = "Records Count";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.ContextMenuStrip = contextMenuStrip1;
            dgvCustomers.Location = new Point(46, 131);
            dgvCustomers.Margin = new Padding(4);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 128);
            dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomers.Size = new Size(728, 300);
            dgvCustomers.TabIndex = 0;
            // 
            // frmListCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1001, 465);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(lblRecordsCount);
            Controls.Add(x);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label1);
            Controls.Add(dgvCustomers);
            Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmListCustomer";
            Text = "frmListCustomer";
            Load += frmListCustomer_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private Button button1;
        private Label label3;
        private Label x;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem customerDetailsToolStripMenuItem;
        private ToolStripMenuItem addCustomerToolStripMenuItem;
        private ToolStripMenuItem updateCustomerToolStripMenuItem;
        private ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private Label lblRecordsCount;
        private DataGridView dgvCustomers;
    }
}