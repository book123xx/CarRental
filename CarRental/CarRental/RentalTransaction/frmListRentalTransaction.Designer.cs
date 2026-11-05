namespace CarRental.RentalTransaction
{
    partial class frmListRentalTransaction
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
            dgvTransaction = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            transactionDetailsToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            label2 = new Label();
            lblRecordsCount = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTransaction
            // 
            dgvTransaction.AllowUserToAddRows = false;
            dgvTransaction.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransaction.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaction.ContextMenuStrip = contextMenuStrip1;
            dgvTransaction.Location = new Point(12, 140);
            dgvTransaction.Name = "dgvTransaction";
            dgvTransaction.ReadOnly = true;
            dgvTransaction.RowHeadersVisible = false;
            dgvTransaction.Size = new Size(787, 239);
            dgvTransaction.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { transactionDetailsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(173, 26);
            // 
            // transactionDetailsToolStripMenuItem
            // 
            transactionDetailsToolStripMenuItem.Name = "transactionDetailsToolStripMenuItem";
            transactionDetailsToolStripMenuItem.Size = new Size(172, 22);
            transactionDetailsToolStripMenuItem.Text = "Transaction Details";
            transactionDetailsToolStripMenuItem.Click += transactionDetailsToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, -2);
            label1.Name = "label1";
            label1.Size = new Size(124, 30);
            label1.TabIndex = 1;
            label1.Text = "Transactions";
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(363, 113);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(125, 23);
            txtFilterValue.TabIndex = 2;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "TransactionID", "PaidInitial Total Due Amount", "Actual Total Due Amount", "Total Remaining", "Total Refunded Amount" });
            cbFilterBy.Location = new Point(207, 113);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(135, 23);
            cbFilterBy.TabIndex = 3;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic Fixed", 11.25F, FontStyle.Bold);
            label2.Location = new Point(131, 113);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 5;
            label2.Text = "Filter";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Simplified Arabic Fixed", 11.25F, FontStyle.Bold);
            lblRecordsCount.Location = new Point(180, 396);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(50, 21);
            lblRecordsCount.TabIndex = 6;
            lblRecordsCount.Text = ".. ?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Simplified Arabic Fixed", 11.25F, FontStyle.Bold);
            label4.Location = new Point(12, 396);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 7;
            label4.Text = "Records Count";
            // 
            // frmListRentalTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label1);
            Controls.Add(dgvTransaction);
            Name = "frmListRentalTransaction";
            Text = "frmListRentalTransaction";
            Load += frmListRentalTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTransaction;
        private Label label1;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private Label lblRecordsCount;
        private Label label4;
        private ToolStripMenuItem transactionDetailsToolStripMenuItem;
    }
}