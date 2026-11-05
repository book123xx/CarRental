using CarRental.People.Controls;
using CarRental_DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Classes;
using CarRenta_Buisness;
//using System.Runtime.Remoting.Messaging;


namespace CarRental.User
{
    
 
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        clsUserBll? _User;

        public frmAddUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _UserID = UserID;
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUserBll();

                tpLoginInfo.Enabled = false;


            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;


            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;


        }

        private void _LoadData()
        {

            _User = clsUserBll.Find(_UserID);
            ctrlPersonCardWithFilter21.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            //the following code will not be executed if the person was not found
            lblUserID.Text = _User.UserId.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = _User.IsActive;
            ctrlPersonCardWithFilter21.LoadPersonInfo(_User.PersonId);
            lblPersonID.Text = ctrlPersonCardWithFilter21.PersonID.ToString();

        }


        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (_User != null)
            {
                _User.PersonId = ctrlPersonCardWithFilter21.PersonID;
                _User.UserName = txtUserName.Text.Trim();
                _User.PlainPassword = txtPassword.Text.Trim();
                _User.IsActive = chkIsActive.Checked;
                lblPersonID.Text = ctrlPersonCardWithFilter21.PersonID.ToString();


                if (_User.Save())
                {
                    lblUserID.Text = _User.UserId.ToString();
                    //change form mode to update.
                    _Mode = enMode.Update;
                    lblTitle.Text = "Update User";
                    this.Text = "Update User";

                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                return;
            }

            //incase of add new mode.
            if (ctrlPersonCardWithFilter21.PersonID != -1)
            {

                if (clsUserBll.isUserExist(ctrlPersonCardWithFilter21.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
               lblPersonID.Text= ctrlPersonCardWithFilter21.PersonID.ToString();
                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }



        private void txtPassword_Validating_1(object sender, CancelEventArgs e)
        {

            if (_Mode == enMode.Update)
            {
                return;
            }

                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
            ;

        }



        private void txtConfirmPassword_Validating_1(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                return;
            }


            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
                ;

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                return;
            }


            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
           ;


            if (_Mode == enMode.AddNew)
            {

                if (clsUserBll.isUserNameExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                }
                ;
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User!.UserName != txtUserName.Text.Trim())
                {
                    if (clsUserBll.isUserNameExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    }
                    ;
                }
            }
        }
    }
}
    
