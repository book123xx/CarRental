namespace CarRental.User
{
    partial class frmAddUpdateUser
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
            txtUserName = new TextBox();
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label4 = new Label();
            lblPersonID = new Label();
            label6 = new Label();
            btnSave = new Button();
            lblTitle = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            lblUserID = new Label();
            label9 = new Label();
            chkIsActive = new CheckBox();
            tcUserInfo = new TabControl();
            TabPage1 = new TabPage();
            ctrlPersonCardWithFilter21 = new CarRental.People.Controls.ctrlPersonCardWithFilter2();
            btnNext = new Button();
            tpLoginInfo = new TabPage();
            errorProvider1 = new ErrorProvider(components);
            tcUserInfo.SuspendLayout();
            TabPage1.SuspendLayout();
            tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(208, 163);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(158, 23);
            txtUserName.TabIndex = 0;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 213);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 1;
            label1.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(198, 267);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(178, 23);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating_1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(208, 213);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(158, 23);
            txtPassword.TabIndex = 4;
            txtPassword.Validating += txtPassword_Validating_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 270);
            label2.Name = "label2";
            label2.Size = new Size(137, 24);
            label2.TabIndex = 5;
            label2.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 162);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 7;
            label4.Text = "UserName";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Location = new Point(187, 116);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(31, 24);
            lblPersonID.TabIndex = 8;
            lblPersonID.Text = ".. ?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 116);
            label6.Name = "label6";
            label6.Size = new Size(74, 24);
            label6.TabIndex = 9;
            label6.Text = "PersonID";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(521, 258);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 32);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ActiveCaption;
            lblTitle.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(334, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(25, 23);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "...";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(187, 81);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(31, 24);
            lblUserID.TabIndex = 13;
            lblUserID.Text = ".. ?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(102, 81);
            label9.Name = "label9";
            label9.Size = new Size(60, 24);
            label9.TabIndex = 14;
            label9.Text = "UserID";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(179, 346);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(90, 28);
            chkIsActive.TabIndex = 15;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // tcUserInfo
            // 
            tcUserInfo.Controls.Add(TabPage1);
            tcUserInfo.Controls.Add(tpLoginInfo);
            tcUserInfo.Location = new Point(-5, 37);
            tcUserInfo.Name = "tcUserInfo";
            tcUserInfo.SelectedIndex = 0;
            tcUserInfo.Size = new Size(759, 482);
            tcUserInfo.TabIndex = 16;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(ctrlPersonCardWithFilter21);
            TabPage1.Controls.Add(btnNext);
            TabPage1.Location = new Point(4, 24);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(751, 454);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Person Info";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter21
            // 
            ctrlPersonCardWithFilter21.FilterEnabled = true;
            ctrlPersonCardWithFilter21.Location = new Point(0, 6);
            ctrlPersonCardWithFilter21.Name = "ctrlPersonCardWithFilter21";
            ctrlPersonCardWithFilter21.Size = new Size(596, 467);
            ctrlPersonCardWithFilter21.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Black;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(602, 6);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(153, 46);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // tpLoginInfo
            // 
            tpLoginInfo.BackColor = Color.LightGray;
            tpLoginInfo.Controls.Add(label9);
            tpLoginInfo.Controls.Add(txtPassword);
            tpLoginInfo.Controls.Add(btnSave);
            tpLoginInfo.Controls.Add(txtConfirmPassword);
            tpLoginInfo.Controls.Add(label2);
            tpLoginInfo.Controls.Add(label4);
            tpLoginInfo.Controls.Add(lblUserID);
            tpLoginInfo.Controls.Add(chkIsActive);
            tpLoginInfo.Controls.Add(label6);
            tpLoginInfo.Controls.Add(lblPersonID);
            tpLoginInfo.Controls.Add(label1);
            tpLoginInfo.Controls.Add(txtUserName);
            tpLoginInfo.Font = new Font("Andalus", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpLoginInfo.ForeColor = Color.Blue;
            tpLoginInfo.Location = new Point(4, 24);
            tpLoginInfo.Name = "tpLoginInfo";
            tpLoginInfo.Padding = new Padding(3);
            tpLoginInfo.Size = new Size(751, 454);
            tpLoginInfo.TabIndex = 1;
            tpLoginInfo.Text = "LoginInfo";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 531);
            Controls.Add(lblTitle);
            Controls.Add(tcUserInfo);
            Name = "frmAddUpdateUser";
            Text = "frmAddUpdateUser";
            Load += frmAddUpdateUser_Load;
            tcUserInfo.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            tpLoginInfo.ResumeLayout(false);
            tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label label1;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private Label label2;
        private Label label4;
        private Label lblPersonID;
        private Label label6;
        private Button btnSave;
        private Label lblTitle;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label lblUserID;
        private Label label9;
        private CheckBox chkIsActive;
        private TabControl tcUserInfo;
        private TabPage TabPage1;
        private TabPage tpLoginInfo;
        private Button btnNext;
        private ErrorProvider errorProvider1;
        private People.Controls.ctrlPersonCardWithFilter2 ctrlPersonCardWithFilter21;
    }
}