namespace CarRental.People
{
    partial class frmListPeople
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
            dgvPeople = new DataGridView();
            label1 = new Label();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            personDetailsToolStripMenuItem = new ToolStripMenuItem();
            addPersonToolStripMenuItem = new ToolStripMenuItem();
            updatePersonToolStripMenuItem = new ToolStripMenuItem();
            deletePersonToolStripMenuItem = new ToolStripMenuItem();
            lblRecordsCount = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.PowderBlue;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeople.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Location = new Point(31, 165);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.Blue;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Cornsilk;
            dgvPeople.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvPeople.Size = new Size(766, 275);
            dgvPeople.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 132);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 1;
            label1.Text = "Filter";
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(286, 132);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(143, 22);
            txtFilterValue.TabIndex = 2;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "PersonID", "Full Name", "Phone", "Email" });
            cbFilterBy.Location = new Point(106, 132);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(155, 25);
            cbFilterBy.TabIndex = 3;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { personDetailsToolStripMenuItem, addPersonToolStripMenuItem, updatePersonToolStripMenuItem, deletePersonToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(152, 92);
            // 
            // personDetailsToolStripMenuItem
            // 
            personDetailsToolStripMenuItem.Name = "personDetailsToolStripMenuItem";
            personDetailsToolStripMenuItem.Size = new Size(151, 22);
            personDetailsToolStripMenuItem.Text = "Person Details";
            personDetailsToolStripMenuItem.Click += personDetailsToolStripMenuItem_Click;
            // 
            // addPersonToolStripMenuItem
            // 
            addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            addPersonToolStripMenuItem.Size = new Size(151, 22);
            addPersonToolStripMenuItem.Text = "Add Person";
            addPersonToolStripMenuItem.Click += addPersonToolStripMenuItem_Click;
            // 
            // updatePersonToolStripMenuItem
            // 
            updatePersonToolStripMenuItem.Name = "updatePersonToolStripMenuItem";
            updatePersonToolStripMenuItem.Size = new Size(151, 22);
            updatePersonToolStripMenuItem.Text = "Update Person";
            updatePersonToolStripMenuItem.Click += updatePersonToolStripMenuItem_Click;
            // 
            // deletePersonToolStripMenuItem
            // 
            deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            deletePersonToolStripMenuItem.Size = new Size(151, 22);
            deletePersonToolStripMenuItem.Text = "Delete Person";
            deletePersonToolStripMenuItem.Click += deletePersonToolStripMenuItem_Click;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Location = new Point(204, 454);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(28, 17);
            lblRecordsCount.TabIndex = 5;
            lblRecordsCount.Text = ".. ?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HighlightText;
            label3.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(318, 23);
            label3.Name = "label3";
            label3.Size = new Size(111, 24);
            label3.TabIndex = 6;
            label3.Text = "List People";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 454);
            label2.Name = "label2";
            label2.Size = new Size(102, 17);
            label2.TabIndex = 7;
            label2.Text = "Records Count";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(681, 65);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 8;
            button1.Text = "Add Person";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmListPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(807, 510);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblRecordsCount);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label1);
            Controls.Add(dgvPeople);
            Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmListPeople";
            Text = "frmListPeople";
            Load += frmListPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPeople;
        private Label label1;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblRecordsCount;
        private Label label3;
        private Label label2;
        private Button button1;
        private ToolStripMenuItem personDetailsToolStripMenuItem;
        private ToolStripMenuItem addPersonToolStripMenuItem;
        private ToolStripMenuItem updatePersonToolStripMenuItem;
        private ToolStripMenuItem deletePersonToolStripMenuItem;
    }
}