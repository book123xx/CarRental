namespace CarRental
{
    partial class FrmLogin
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
            txtPassword = new TextBox();
            b = new Label();
            chkRememberMe = new CheckBox();
            btnLogin = new Button();
            button2 = new Button();
            txtUserName = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            txtPassword.Location = new Point(234, 318);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 23);
            txtPassword.TabIndex = 0;
            // 
            // b
            // 
            b.AutoSize = true;
            b.BackColor = SystemColors.InactiveCaptionText;
            b.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            b.ForeColor = SystemColors.ButtonHighlight;
            b.Location = new Point(131, 229);
            b.Name = "b";
            b.Size = new Size(97, 22);
            b.TabIndex = 1;
            b.Text = "User name";
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.BackColor = Color.CornflowerBlue;
            chkRememberMe.FlatStyle = FlatStyle.Flat;
            chkRememberMe.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkRememberMe.ForeColor = SystemColors.ActiveCaptionText;
            chkRememberMe.Location = new Point(224, 364);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(120, 20);
            chkRememberMe.TabIndex = 2;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Blue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(479, 332);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 31);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(479, 388);
            button2.Name = "button2";
            button2.Size = new Size(105, 31);
            button2.TabIndex = 4;
            button2.Text = "Open";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            txtUserName.Location = new Point(234, 231);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(155, 23);
            txtUserName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaptionText;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(131, 316);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.car1;
            pictureBox1.Location = new Point(104, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(633, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(button2);
            Controls.Add(btnLogin);
            Controls.Add(chkRememberMe);
            Controls.Add(b);
            Controls.Add(txtPassword);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label b;
        private CheckBox chkRememberMe;
        private Button btnLogin;
        private Button button2;
        private TextBox txtUserName;
        private Label label2;
        private PictureBox pictureBox1;
    }
}