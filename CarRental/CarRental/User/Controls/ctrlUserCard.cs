using CarRental.People.Controls;
using CarRental_DataAccess.File;
using System;
using CarRenta_Buisness;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Properties;


namespace CarRental.User.Controls
{
    public partial class ctrlUserCard : UserControl
    {

        private clsUserBll? _User;
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void LoadUserInfo(int UserID)
        {
            _User = clsUserBll.Find(UserID);
            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }
        private void _FillUserInfo()
        {
        
          
                ctrlPersonCard1.LoadPersonInfo(_User!.PersonId);
            lblUserID.Text = _User.UserId.ToString();
            lblUserName.Text = _User.UserName.ToString();
          
            if (_User.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";

        }
        private void _ResetPersonInfo()
        {

            ctrlPersonCard1.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";
            lblIsActive.Text = "[???]";
        }

    }

}
