using CarRenta_Buisness;
using CarRental.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;






namespace CarRental.Booking.Controls
{
    public partial class ctrlBookingCard : UserControl
    {
        private clsBookingBll? _Booking;

        private int _BookingID = -1;

        public int BookingID
        {
            get { return _BookingID; }
        }

        public clsBookingBll? SelectedBookingInfo
        {
            get { return _Booking; }
        }
        public ctrlBookingCard()
        {
            InitializeComponent();
        }
        public void LoadBookingInfo(int bookingID)
        {
            _Booking = clsBookingBll.Find(bookingID);
            if (_Booking == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No found Booking = " + bookingID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        private void _FillPersonInfo()
        {
            linkLabel1.Enabled = true;

            _BookingID = _Booking!.BookingId;
            lblBookingID.Text = _Booking.BookingId.ToString();
            lblCustomerID.Text = _Booking.CustomerId.ToString();
            lblVehicleID.Text = _Booking.VehicleId.ToString();
            lblRentalStartDate.Text = _Booking.RentalStartDate.ToShortDateString();
            lblRentalEndDate.Text = _Booking.RentalEndDate.ToShortDateString();
            lblPickupLocation.Text = _Booking.PickupLocation;
            lblDropoffLocation.Text = _Booking.DropoffLocation;
            lblInitialRentalDays.Text = _Booking.InitialRentalDays.ToString();
            lblInitialTotalDueAmount.Text = _Booking.InitialTotalDueAmount.ToString();
            lblInitialCheckNotes.Text = _Booking.InitialCheckNotes;
            lblRentalPricePerDay.Text = _Booking.RentalPricePerDay.ToString();





        }
        public void ResetPersonInfo()
        {

            _BookingID = -1;
            lblBookingID.Text = "..?";
            lblCustomerID.Text = "..?";
            lblVehicleID.Text = "..?";
            lblRentalStartDate.Text = "..?";
            lblRentalEndDate.Text = "..?";
            lblPickupLocation.Text = "..?";
            lblDropoffLocation.Text = "..?";
            lblInitialRentalDays.Text = "..?";
            lblInitialTotalDueAmount.Text = "..?";
            lblInitialCheckNotes.Text = "..?";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           frmAddUpdateBooking frm = new frmAddUpdateBooking(_BookingID);
           frm.ShowDialog();
        //LoadBookingInfo(_BookingID);
        
        }

        private void lblInitialTotalDueAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
