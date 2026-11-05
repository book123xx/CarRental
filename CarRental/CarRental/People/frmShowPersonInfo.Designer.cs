namespace CarRental.People
{
    partial class frmShowPeopleInfo
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
            ctrlPersonCard1 = new CarRental.People.Controls.ctrlPersonCard();
            label1 = new Label();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.Teal;
            ctrlPersonCard1.Location = new Point(-5, 63);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(599, 396);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 22);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 1;
            label1.Text = "Person Details";
            // 
            // frmShowPeopleInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 450);
            Controls.Add(label1);
            Controls.Add(ctrlPersonCard1);
            Name = "frmShowPeopleInfo";
            Text = "frmShowPeopleInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlPersonCard ctrlPersonCard1;
        private Label label1;
    }
}