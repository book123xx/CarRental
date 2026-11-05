namespace CarRental.Booking
{
    partial class frmShowBookingInfo
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
            ctrlBookingCard1 = new CarRental.Booking.Controls.ctrlBookingCard();
            label1 = new Label();
            SuspendLayout();
            // 
            // ctrlBookingCard1
            // 
            ctrlBookingCard1.BackColor = Color.RoyalBlue;
            ctrlBookingCard1.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlBookingCard1.Location = new Point(0, 92);
            ctrlBookingCard1.Margin = new Padding(3, 4, 3, 4);
            ctrlBookingCard1.Name = "ctrlBookingCard1";
            ctrlBookingCard1.Size = new Size(538, 383);
            ctrlBookingCard1.TabIndex = 0;
            ctrlBookingCard1.Load += ctrlBookingCard1_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 0);
            label1.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 32);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 1;
            label1.Text = "Booking Details";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmShowBookingInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(538, 527);
            Controls.Add(label1);
            Controls.Add(ctrlBookingCard1);
            Name = "frmShowBookingInfo";
            Text = "frmShowBookingInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlBookingCard ctrlBookingCard1;
        private Label label1;
    }
}