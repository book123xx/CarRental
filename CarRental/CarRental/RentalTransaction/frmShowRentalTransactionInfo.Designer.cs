namespace CarRental.RentalTransaction
{
    partial class frmShowRentalTransactionInfo
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
            ctrlRentalTransactionCard1 = new CarRental.RentalTransaction.Controls.ctrlRentalTransactionCard();
            SuspendLayout();
            // 
            // ctrlRentalTransactionCard1
            // 
            ctrlRentalTransactionCard1.BackColor = SystemColors.ScrollBar;
            ctrlRentalTransactionCard1.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlRentalTransactionCard1.Location = new Point(0, -3);
            ctrlRentalTransactionCard1.Margin = new Padding(3, 4, 3, 4);
            ctrlRentalTransactionCard1.Name = "ctrlRentalTransactionCard1";
            ctrlRentalTransactionCard1.Size = new Size(599, 348);
            ctrlRentalTransactionCard1.TabIndex = 0;
            // 
            // frmShowRentalTransactionInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 346);
            Controls.Add(ctrlRentalTransactionCard1);
            Name = "frmShowRentalTransactionInfo";
            Text = "frmShowRentalTransactionInfo";
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlRentalTransactionCard ctrlRentalTransactionCard1;
    }
}