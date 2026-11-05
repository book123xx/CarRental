namespace CarRental.Customer
{
    partial class frmShowCustomernfo
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
            ctrlCustomerCard1 = new CarRental.Customer.Controls.ctrlCustomerCard();
            label1 = new Label();
            SuspendLayout();
            // 
            // ctrlCustomerCard1
            // 
            ctrlCustomerCard1.BackColor = Color.Navy;
            ctrlCustomerCard1.Location = new Point(-1, 34);
            ctrlCustomerCard1.Name = "ctrlCustomerCard1";
            ctrlCustomerCard1.Size = new Size(619, 486);
            ctrlCustomerCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 22);
            label1.TabIndex = 1;
            label1.Text = "Customer Details";
            // 
            // frmShowCustomernfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(630, 519);
            Controls.Add(label1);
            Controls.Add(ctrlCustomerCard1);
            Name = "frmShowCustomernfo";
            Text = "frmShowCustomernfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlCustomerCard ctrlCustomerCard1;
        private Label label1;
    }
}