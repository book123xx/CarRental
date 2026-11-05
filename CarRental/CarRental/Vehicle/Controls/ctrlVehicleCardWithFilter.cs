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

namespace CarRental.Vehicle.Controls
{
    public partial class ctrlVehicleCardWithFilter : UserControl
    {
      
        public event Action<int> OnVehicleSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnVehicleSelected;
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
        private int _VehicleID = -1;

        public int VehicleID
        {
            get { return ctrlVehicleCard1.VehicleID; }
        }

        public clsVehicleBll? SelectedVehicleInfo
        {
            get { return ctrlVehicleCard1.SelectedVehicleInfo; }
        }
  public ctrlVehicleCardWithFilter()
        {
            InitializeComponent();
        }
        public void LoadVehicleInfo(int VehicleID)
        {
            if (VehicleID <= 0)
            {
                MessageBox.Show("Invalid Vehicle ID: " + VehicleID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtFilterValue.Text = VehicleID.ToString();

            ctrlVehicleCard1.LoadVehicleInfo(VehicleID);
            if (OnVehicleSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnVehicleSelected(ctrlVehicleCard1.VehicleID);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            ctrlVehicleCard1.LoadVehicleInfo(int.Parse(txtFilterValue.Text));
            if (OnVehicleSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnVehicleSelected(ctrlVehicleCard1.VehicleID);
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
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if person id is selected

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAddUpdateVehicle frm = new frmAddUpdateVehicle();
            frm.DataBack += DataBackEvent;
        
            frm.ShowDialog();

       }

        private void DataBackEvent(object sender, int ID)
        {
          

            txtFilterValue.Text = ID.ToString();
            ctrlVehicleCard1.LoadVehicleInfo(ID);
        }
    }
}
