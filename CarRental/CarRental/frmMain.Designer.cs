namespace CarRental
{
    partial class frmMain
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
            splitContainer1 = new SplitContainer();
            btnLoginOut = new Button();
            btnCurrentUser = new Button();
            btnReturn = new Button();
            btnCustomer = new Button();
            btnPeople = new Button();
            btnTransaction = new Button();
            btnUser = new Button();
            button2 = new Button();
            btnBooking = new Button();
            lblLoggedInUser = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(1, 32);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Highlight;
            splitContainer1.Panel1.Controls.Add(btnLoginOut);
            splitContainer1.Panel1.Controls.Add(btnCurrentUser);
            splitContainer1.Panel1.Controls.Add(btnReturn);
            splitContainer1.Panel1.Controls.Add(btnCustomer);
            splitContainer1.Panel1.Controls.Add(btnPeople);
            splitContainer1.Panel1.Controls.Add(btnTransaction);
            splitContainer1.Panel1.Controls.Add(btnUser);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(btnBooking);
            splitContainer1.Size = new Size(1372, 598);
            splitContainer1.SplitterDistance = 416;
            splitContainer1.TabIndex = 0;
            // 
            // btnLoginOut
            // 
            btnLoginOut.BackColor = Color.FromArgb(0, 0, 192);
            btnLoginOut.FlatStyle = FlatStyle.Flat;
            btnLoginOut.Font = new Font("Candara", 9.75F, FontStyle.Bold);
            btnLoginOut.ForeColor = SystemColors.ControlLightLight;
            btnLoginOut.Location = new Point(38, 339);
            btnLoginOut.Name = "btnLoginOut";
            btnLoginOut.Size = new Size(166, 29);
            btnLoginOut.TabIndex = 8;
            btnLoginOut.Text = "Login Out";
            btnLoginOut.UseVisualStyleBackColor = false;
            btnLoginOut.Click += btnLoginOut_Click;
            // 
            // btnCurrentUser
            // 
            btnCurrentUser.BackColor = Color.FromArgb(0, 0, 192);
            btnCurrentUser.FlatStyle = FlatStyle.Flat;
            btnCurrentUser.Font = new Font("Candara", 9.75F, FontStyle.Bold);
            btnCurrentUser.ForeColor = SystemColors.ControlLightLight;
            btnCurrentUser.Location = new Point(38, 291);
            btnCurrentUser.Name = "btnCurrentUser";
            btnCurrentUser.Size = new Size(166, 29);
            btnCurrentUser.TabIndex = 7;
            btnCurrentUser.Text = "Current User";
            btnCurrentUser.UseVisualStyleBackColor = false;
            btnCurrentUser.Click += btnCurrentUser_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(0, 0, 192);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Candara", 9.75F, FontStyle.Bold);
            btnReturn.ForeColor = SystemColors.ControlLightLight;
            btnReturn.Location = new Point(38, 240);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(166, 29);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "VehicleReturn";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(0, 0, 192);
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Candara", 9.75F, FontStyle.Bold);
            btnCustomer.ForeColor = SystemColors.ControlLightLight;
            btnCustomer.Location = new Point(38, 65);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(166, 29);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "Customers";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnPeople
            // 
            btnPeople.BackColor = Color.FromArgb(0, 0, 192);
            btnPeople.FlatStyle = FlatStyle.Flat;
            btnPeople.Font = new Font("Candara", 9.75F, FontStyle.Bold);
            btnPeople.ForeColor = SystemColors.ControlLightLight;
            btnPeople.Location = new Point(38, 100);
            btnPeople.Name = "btnPeople";
            btnPeople.Size = new Size(166, 29);
            btnPeople.TabIndex = 4;
            btnPeople.Text = "People";
            btnPeople.UseVisualStyleBackColor = false;
            btnPeople.Click += btnPeople_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = Color.FromArgb(0, 0, 192);
            btnTransaction.FlatStyle = FlatStyle.Flat;
            btnTransaction.Font = new Font("Candara", 9.75F, FontStyle.Bold);
            btnTransaction.ForeColor = SystemColors.ControlLightLight;
            btnTransaction.Location = new Point(38, 135);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(166, 29);
            btnTransaction.TabIndex = 3;
            btnTransaction.Text = "Rental Transaction";
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(0, 0, 192);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Candara", 9.75F, FontStyle.Bold);
            btnUser.ForeColor = SystemColors.ControlLightLight;
            btnUser.Location = new Point(38, 170);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(166, 29);
            btnUser.TabIndex = 2;
            btnUser.Text = "Users";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // button2
            // 
            button2.AccessibleDescription = "btnVehicle";
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Candara", 9.75F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(38, 205);
            button2.Name = "button2";
            button2.Size = new Size(166, 29);
            button2.TabIndex = 1;
            button2.Text = "Vehicle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.FromArgb(0, 0, 192);
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Candara", 9.75F, FontStyle.Bold);
            btnBooking.ForeColor = SystemColors.ControlLightLight;
            btnBooking.Location = new Point(38, 30);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(166, 29);
            btnBooking.TabIndex = 0;
            btnBooking.Text = "Booking";
            btnBooking.UseVisualStyleBackColor = false;
            btnBooking.Click += btnBooking_Click;
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.BackColor = Color.FromArgb(0, 0, 192);
            lblLoggedInUser.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoggedInUser.ForeColor = SystemColors.ControlLightLight;
            lblLoggedInUser.Location = new Point(264, 2);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(304, 27);
            lblLoggedInUser.TabIndex = 0;
            lblLoggedInUser.Text = ".. ?";
            lblLoggedInUser.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 578);
            Controls.Add(lblLoggedInUser);
            Controls.Add(splitContainer1);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnReturn;
        private Button btnCustomer;
        private Button btnPeople;
        private Button btnTransaction;
        private Button btnUser;
        private Button button2;
        private Button btnBooking;
        private Button btnLoginOut;
        private Button btnCurrentUser;
        private Label lblLoggedInUser;
    }
}