using CarRenta_Buisness;
using CarRental.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Customer.Controls
{
    public partial class ctrlCustomerCardWithFilter : UserControl
    {
        public ctrlCustomerCardWithFilter()
        {
            InitializeComponent();
        }
        public event Action<int> OnCustomerSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void CustomerSelected(int PersonID)
        {
            Action<int> handler = OnCustomerSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }


        //private bool _ShowAddPerson = true;
        //public bool ShowAddPerson
        //{
        //    get
        //    {
        //        return _ShowAddPerson;
        //    }
        //    set
        //    {
        //        _ShowAddPerson = value;
        //        btnAddNewPerson.Visible = _ShowAddPerson;
        //    }
        //}

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        private int _CustomerID = -1;

        public int CustomerID
        {
            get { return ctrlCustomerCard1.CustomerID; }
        }

        public clsCustomerBll? SelecteCustomerInfo
        {
            get { return ctrlCustomerCard1.SelecteCustomerInfo; }
        }

        public void LoadCustomerInfo(int CustomerID)
        {


            txtFilterValue.Text = CustomerID.ToString();
            ctrlCustomerCard1.LoadCustomerInfo(CustomerID);

            if (OnCustomerSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnCustomerSelected(ctrlCustomerCard1.CustomerID);
        }



        private void btnFind_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;



            }

            ctrlCustomerCard1.LoadCustomerInfo(int.Parse(txtFilterValue.Text));
            if (OnCustomerSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnCustomerSelected(ctrlCustomerCard1.CustomerID);
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if person id is selected

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmAddUpdateCustomer frm1 = new frmAddUpdateCustomer();
          
            frm1.ShowDialog();

        }



    }
}
