namespace CarRental.User.Controls
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlPersonCard1 = new CarRental.People.Controls.ctrlPersonCard();
            groupBox1 = new GroupBox();
            lblIsActive = new Label();
            label6 = new Label();
            lblUserName = new Label();
            label4 = new Label();
            lblUserID = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.Teal;
            ctrlPersonCard1.Location = new Point(0, 0);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(564, 287);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 0, 192);
            groupBox1.Controls.Add(lblIsActive);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblUserName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblUserID);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(3, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 87);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Information";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(470, 30);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(24, 16);
            lblIsActive.TabIndex = 5;
            lblIsActive.Text = ".. ?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(384, 29);
            label6.Name = "label6";
            label6.Size = new Size(70, 16);
            label6.TabIndex = 4;
            label6.Text = "Is Active :";
            label6.Click += label6_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(253, 29);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(28, 16);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "... ?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 29);
            label4.Name = "label4";
            label4.Size = new Size(75, 16);
            label4.TabIndex = 2;
            label4.Text = "User Name";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(84, 29);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(28, 16);
            lblUserID.TabIndex = 1;
            lblUserID.Text = "... ?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(61, 16);
            label1.TabIndex = 0;
            label1.Text = "User ID :";
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlUserCard";
            Size = new Size(567, 375);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblIsActive;
        private Label label6;
        private Label lblUserName;
        private Label label4;
        private Label lblUserID;
    }
}
