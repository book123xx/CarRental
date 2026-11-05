using CarRenta_Buisness;
using CarRental.Customer.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.People.Controls
{
    public partial class ctrlPersonCardWithFilter2 : UserControl
    {
        //public event Action<int> OnPersonSelected;
        //// Create a protected method to raise the event with a parameter
        //protected virtual void PersonSelected(int PersonID)
        //{
        //    Action<int> handler = OnPersonSelected;
        //    if (handler != null)
        //    {
        //        handler(PersonID); // Raise the event with the parameter
        //    }
        //}
        public ctrlPersonCardWithFilter2()
        {
            InitializeComponent();
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
                groupBox1.Enabled = _FilterEnabled;
            }
        }

        private int _PersonID = -1;

        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPeopleBll? SelectePersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }

        public void LoadPersonInfo(int PersonID)
        {


            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);

            //if (OnPersonSelected != null && FilterEnabled)
            //    // Raise the event with a parameter
            //    OnPersonSelected(ctrlPersonCard1.PersonID);
        }


      
        private void btnFind_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;



            }

            ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
            //if (OnPersonSelected != null && FilterEnabled)
            //    // Raise the event with a parameter
            //    OnPersonSelected(ctrlPersonCard1.PersonID);
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            //frm.DataBack += DataBackEvent;

        }
    }
}
