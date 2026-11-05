using CarRenta_Buisness;
using CarRental.People.Controls;
using CarRental_DataAccess;
using CarRental_DataAccess.File;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Properties;
namespace CarRental.Customer.Controls
{
    public partial class ctrlCustomerCard : UserControl
    {
        private clsCustomerBll? _Customer;
        private int _CustomerID = -1;

        public int CustomerID
        {
            get { return _CustomerID; }
        }
        public clsCustomerBll? SelecteCustomerInfo
        {
            get { return _Customer; }
        }
        public ctrlCustomerCard()
        {
            InitializeComponent();
        }

        public void LoadCustomerInfo(int CustomerID)
        {
            _Customer = clsCustomerBll.Find(CustomerID);
            if (_Customer == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Cusomer with ID = " + CustomerID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }
        private void _FillUserInfo()
        {
            _CustomerID = _Customer!.CustomerId;
            ctrlPersonCard1.LoadPersonInfo(_Customer!.PersonId);
            lblCustomerID.Text = _Customer.CustomerId.ToString();
            lblDriverLicenseNumber.Text = _Customer.DriverLicenseNumber.ToString();



        }
        private void _ResetPersonInfo()
        {
            _CustomerID = -1;
            ctrlPersonCard1.ResetPersonInfo();
            lblCustomerID.Text = "[???]";
            lblDriverLicenseNumber.Text = "[???]";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer(_CustomerID);
            frm.ShowDialog();
            LoadCustomerInfo(_CustomerID);  
        }
    }
}


