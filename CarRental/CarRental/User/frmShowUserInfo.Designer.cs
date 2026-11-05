namespace CarRental.User
{
    partial class frmShowUserInfo
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
            ctrlUserCard1 = new CarRental.User.Controls.ctrlUserCard();
            label1 = new Label();
            SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new Point(-1, 66);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(562, 360);
            ctrlUserCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 21);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 1;
            label1.Text = "User Details";
            // 
            // frmShowUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(562, 424);
            Controls.Add(label1);
            Controls.Add(ctrlUserCard1);
            Name = "frmShowUserInfo";
            Text = "frmShowUserInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlUserCard ctrlUserCard1;
        private Label label1;
    }
}