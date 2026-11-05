using CarRenta_Buisness;
using CarRental.People.Controls;
using CarRental_DataAccess;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Customer
{
    public partial class frmAddUpdateCustomer : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _CustomerID = -1;
        clsCustomerBll _Customer;

        public frmAddUpdateCustomer()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdateCustomer(int CustomerID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _CustomerID = CustomerID;
        }
        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Customer";
                this.Text = "Add New Customer";
                _Customer = new clsCustomerBll();

                tpCustomerInfo.Enabled = false;


            }
            else
            {
                lblTitle.Text = "Update Customer";
                this.Text = "Update Customer";

                tpCustomerInfo.Enabled = true;
                btnSave.Enabled = true;


            }
            textBox1.Text = "";



        }

        private void _LoadData()
        {

            _Customer = clsCustomerBll.Find(_CustomerID);
            ctrlPersonCardWithFilter21.FilterEnabled = false;

            if (_Customer == null)
            {
                MessageBox.Show("No Customer with ID = " + _Customer, "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }
            textBox1.Text = _Customer.DriverLicenseNumber.ToString();
            lblCustomerID.Text = _Customer.CustomerId.ToString();

            ctrlPersonCardWithFilter21.LoadPersonInfo(_Customer.PersonId);
        }
        private bool Validate()
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                return false;
            }
           
                return true;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!Validate())
            {
                
                MessageBox.Show("Some fileds are not valide!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _Customer.PersonId = ctrlPersonCardWithFilter21.PersonID;
            _Customer.DriverLicenseNumber = textBox1.Text.Trim();
            lblPersonID.Text = ctrlPersonCardWithFilter21.PersonID.ToString();

            if (_Customer.Save())
            {
               
                lblCustomerID.Text = _Customer.CustomerId.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Customer";
                this.Text = "Update Customer";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpCustomerInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tpCustomerInfo"];
                return;
            }

            //incase of add new mode.
            if (ctrlPersonCardWithFilter21.PersonID != -1)
            {

                if (clsCustomerBll.GetCustomerByPersonID(ctrlPersonCardWithFilter21.PersonID))
                {

                    MessageBox.Show("Selected Person already has a customer, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }

                else
                {
                    btnSave.Enabled = true;
                    tpCustomerInfo.Enabled = true;
                    tabControl1.SelectedTab = tabControl1.TabPages["tpCustomerInfo"];
                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
             

            }

        }
    }
}