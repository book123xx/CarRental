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

namespace CarRental.Booking.Controls
{
    public partial class ctrlBookingCardWithFilter : UserControl
    {
        public event Action<int> OnBookingSelected;

        protected virtual void BookingSelected(int BookingID)
        {
            Action<int> handler = OnBookingSelected;
            if (handler != null)
            {
                handler(BookingID); // Raise the event with the parameter
            }
        }


        //private bool _ShowAddbooking = true;
        //public bool ShowAddbooking
        //{
        //    get
        //    {
        //        return _ShowAddbooking;
        //    }
        //    set
        //    {
        //        _ShowAddbooking = value;
        //        //btnAddNewPerson.Visible = _ShowAddPerson;
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
        public ctrlBookingCardWithFilter()
        {
            InitializeComponent();
        }
        private int _BookiID = -1;

        public int BookingID
        {
            get { return ctrlBookingCard1.BookingID; }
        }

        public clsBookingBll? SelectedbookingInfo
        {
            get { return ctrlBookingCard1.SelectedBookingInfo; }
        }
        public void LoadBookingInfo(int bookingID)
        {
            if (bookingID <= 0)
            {

                MessageBox.Show("Invalid BookingID = " + bookingID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox1.Text = bookingID.ToString();
            ctrlBookingCard1.LoadBookingInfo(bookingID);
            ctrlCustomerCard1.LoadCustomerInfo(ctrlBookingCard1.SelectedBookingInfo!.CustomerId);
            ctrlVehicleCard1.LoadVehicleInfo(ctrlBookingCard1.SelectedBookingInfo.VehicleId);
            if (OnBookingSelected != null && FilterEnabled)

                OnBookingSelected(ctrlBookingCard1.BookingID);


        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (int.TryParse(textBox1.Text.Trim(), out int bookingID))
            {

                ctrlBookingCard1.LoadBookingInfo(bookingID);


                if (ctrlBookingCard1.SelectedBookingInfo == null)
                {
                    MessageBox.Show("No Booking with ID = [" + bookingID + "] was found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                ctrlCustomerCard1.LoadCustomerInfo(ctrlBookingCard1.SelectedBookingInfo.CustomerId);
                ctrlVehicleCard1.LoadVehicleInfo(ctrlBookingCard1.SelectedBookingInfo.VehicleId);
                if (OnBookingSelected != null && FilterEnabled)
                {
                    OnBookingSelected(ctrlBookingCard1.BookingID);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Booking ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }



            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);



        }

        private void ctrlBookingCard1_Load(object sender, EventArgs e)
        {
            //frmAddUpdateBooking frm = new frmAddUpdateBooking();
            //frm.ShowDialog();
            //LoadBookingInfo(_BookiID);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddUpdateBooking frm = new frmAddUpdateBooking();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();

        }
        private void DataBackEvent(object sender, int ID)
        {



            textBox1.Text = ID.ToString();
            ctrlBookingCard1.LoadBookingInfo(ID);
        }
    }
}
    