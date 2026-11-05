namespace CarRental.VehicleReturn
{
    partial class frmShowVehicleInfo
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
            ctrlVehicleCard1 = new CarRental.Vehicle.Controls.ctrlVehicleCard();
            SuspendLayout();
            // 
            // ctrlVehicleCard1
            // 
            ctrlVehicleCard1.BackColor = Color.DarkBlue;
            ctrlVehicleCard1.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlVehicleCard1.ForeColor = SystemColors.ButtonHighlight;
            ctrlVehicleCard1.Location = new Point(2, -5);
            ctrlVehicleCard1.Margin = new Padding(3, 4, 3, 4);
            ctrlVehicleCard1.Name = "ctrlVehicleCard1";
            ctrlVehicleCard1.Size = new Size(536, 318);
            ctrlVehicleCard1.TabIndex = 0;
            // 
            // frmShowVehicleInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 308);
            Controls.Add(ctrlVehicleCard1);
            Name = "frmShowVehicleInfo";
            Text = "frmShowVehicleInfo";
            ResumeLayout(false);
        }

        #endregion

        private Vehicle.Controls.ctrlVehicleCard ctrlVehicleCard1;
    }
}