using CarRenta_Buisness;
using CarRenta_Buisness;
using CarRenta_Buisness1;
using CarRental.Booking.Controls;
using CarRental.Classes;
using CarRental.People.Controls;
using CarRental.Properties;
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

namespace CarRental.Booking
{
    public partial class frmAddUpdateBooking : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler? DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _BookingID = -1;
        clsBookingBll? _Booking;
        clsRentalTransactionBll? _RentalTransaction;

        public frmAddUpdateBooking()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateBooking(int ID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _BookingID = ID;
        }

        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lbltitle.Text = "Add New Booking";
                _Booking = new clsBookingBll();
                tpBookinginfo.Enabled = false;
                tpVehicleInfo.Enabled = false;
               
            }
            else
            {
                tpVehicleInfo.Enabled = true;
                tpBookinginfo.Enabled = true;
                btnSave.Enabled = true;
                lbltitle.Text = "Update Booking";
            }

            dtpRentalStartDate.Value = DateTime.Now;
            dtpRentalEndDate.Value = DateTime.Now;
            txtDropoffLocation.Text = "";
            txtPickupLocation.Text = "";
            txtPaymentDetails.Text = "";
            txtPaidInitialTotalDueAmount.Text = "";
            txtInitialCheckNotes.Text = "";

          
            _CalculateRentalCosts();
        }

       
        private void _CalculateRentalCosts()
        {
            if (dtpRentalEndDate.Value.Date < dtpRentalStartDate.Value.Date)
            {
                lblInitialRentalDays.Text = "0";
                lblInitialTotalDueAmount.Text = "0.00";
                return;
            }

            TimeSpan rentalDays = dtpRentalEndDate.Value.Date - dtpRentalStartDate.Value.Date;
            int totalDays = rentalDays.Days;

            if (totalDays <= 0)
                totalDays = 1;

            decimal rentalPricePerDay = 0;
            if (ctrlVehicleCardWithFilter1.SelectedVehicleInfo != null)
            {
                rentalPricePerDay = ctrlVehicleCardWithFilter1.SelectedVehicleInfo.RentalPricePerDay;
                lblRentalPricePerDay.Text = rentalPricePerDay.ToString("0.00");
            }
            else
            {
                lblRentalPricePerDay.Text = "0.00";
            }

            decimal totalDueAmount = totalDays * rentalPricePerDay;

            lblInitialRentalDays.Text = totalDays.ToString();
            lblInitialTotalDueAmount.Text = totalDueAmount.ToString("0.00");
        }

        private void _LoadData()
        {
            _Booking = clsBookingBll.Find(_BookingID);

            ctrlCustomerCardWithFilter1.FilterEnabled = false;
            ctrlVehicleCardWithFilter1.FilterEnabled = false;

            if (_Booking == null)
            {
                MessageBox.Show("No Booking with ID = " + _BookingID, "Booking Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
         lblBookingID.Text = _Booking.BookingId.ToString();
            txtDropoffLocation.Text = _Booking.DropoffLocation;
            txtPickupLocation.Text = _Booking.PickupLocation;

          
            dtpRentalStartDate.Value = _Booking.RentalStartDate;
            dtpRentalEndDate.Value = _Booking.RentalEndDate;

            txtPaymentDetails.Text = _Booking.RentalTransactionInfo?.PaymentDetails ?? "";
            txtPaidInitialTotalDueAmount.Text = _Booking.RentalTransactionInfo?.PaidInitialTotalDueAmount.ToString() ?? "";
            txtInitialCheckNotes.Text = _Booking.InitialCheckNotes ?? "";

            ctrlVehicleCardWithFilter1.LoadVehicleInfo(_Booking.VehicleId);
            ctrlCustomerCardWithFilter1.LoadCustomerInfo(_Booking.CustomerId);

            lblRentalPricePerDay.Text = ctrlVehicleCardWithFilter1.SelectedVehicleInfo?.RentalPricePerDay.ToString() ?? "";
            lblInitialTotalDueAmount.Text = _Booking.InitialTotalDueAmount.ToString("0.00");
            lblInitialRentalDays.Text = _Booking.InitialRentalDays.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmAddUpdateBooking_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

   
            dtpRentalStartDate.ValueChanged += DtpRentalDates_ValueChanged;
            dtpRentalEndDate.ValueChanged += DtpRentalDates_ValueChanged;
        }

        private void DtpRentalDates_ValueChanged(object? sender, EventArgs e)
        {
            _CalculateRentalCosts();
        }

        private bool _ValidateFields()
        {

            if (string.IsNullOrWhiteSpace(txtDropoffLocation.Text) ||
                string.IsNullOrWhiteSpace(txtPickupLocation.Text) ||
                string.IsNullOrWhiteSpace(txtPaidInitialTotalDueAmount.Text) ||
                string.IsNullOrWhiteSpace(txtPaymentDetails.Text) ||
                (dtpRentalStartDate.Value > dtpRentalEndDate.Value))
            {
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( !_ValidateFields())
            {
                MessageBox.Show("Some fields are not valid!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ctrlCustomerCardWithFilter1.CustomerID
                
                 == -1 || ctrlVehicleCardWithFilter1.VehicleID == -1)
            {
                MessageBox.Show("Please select a valid Customer and Vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Booking!.DropoffLocation = txtDropoffLocation.Text.Trim();
            _Booking.PickupLocation = txtPickupLocation.Text.Trim();
            _Booking.RentalStartDate = dtpRentalStartDate.Value;
            _Booking.RentalEndDate = dtpRentalEndDate.Value;
            _Booking.InitialCheckNotes = txtInitialCheckNotes.Text.Trim();
            _Booking.CustomerId = ctrlCustomerCardWithFilter1.CustomerID;
            _Booking.VehicleId = ctrlVehicleCardWithFilter1.VehicleID;

            decimal rentalPricePerDay = ctrlVehicleCardWithFilter1.SelectedVehicleInfo?.RentalPricePerDay ?? 0;
            _Booking.RentalPricePerDay = rentalPricePerDay;

            TimeSpan rentalDays = dtpRentalEndDate.Value.Date - dtpRentalStartDate.Value.Date;
            int totalDays = rentalDays.Days;
            if (totalDays <= 0)
                totalDays = 1;
              _Booking.InitialTotalDueAmount = Convert.ToDecimal(totalDays * rentalPricePerDay);
            _Booking.InitialRentalDays = Convert.ToByte(totalDays);

            if (_Booking.Save())
            {
                lblInitialRentalDays.Text = _Booking.InitialRentalDays.ToString();
                lblInitialTotalDueAmount.Text = _Booking.InitialTotalDueAmount.ToString("0.00");
                lblBookingID.Text = _Booking.BookingId.ToString();

                _RentalTransaction = clsRentalTransactionBll.FindByBookingID(_Booking.BookingId);
                if (_RentalTransaction == null)
                {
                    _RentalTransaction = new clsRentalTransactionBll();

                }
                _RentalTransaction.BookingId = _Booking.BookingId;
                _RentalTransaction.PaymentDetails = txtPaymentDetails.Text.Trim();

                if (decimal.TryParse(txtPaidInitialTotalDueAmount.Text.Trim(), out decimal paidAmount))
                {
                    _RentalTransaction.PaidInitialTotalDueAmount = paidAmount;
                }
                else
                {
                    _RentalTransaction.PaidInitialTotalDueAmount = 0;
                }

                _RentalTransaction.TransactionDate = DateTime.Now;
                _RentalTransaction.Save();

                if (ctrlVehicleCardWithFilter1.SelectedVehicleInfo != null)
                {
                    ctrlVehicleCardWithFilter1.SelectedVehicleInfo.IsAvailableForRent = false;
                    ctrlVehicleCardWithFilter1.SelectedVehicleInfo.Save();
                }

                _Mode = enMode.Update;
                lbltitle.Text = "Update Booking";
                this.Text = "Update Booking";
                DataBack?.Invoke(this, _Booking.BookingId);
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpVehicleInfo.Enabled = true;
                tpBookinginfo.Enabled = true;
                tcBookingInfo.SelectedTab = tcBookingInfo.TabPages["tpBookinginfo"];
                return;
            }

            if (ctrlCustomerCardWithFilter1.CustomerID != -1)
            {
                if (clsCustomerBll.IsCustomerExist(ctrlCustomerCardWithFilter1.CustomerID))
                {
                    tpVehicleInfo.Enabled = true;
                    tcBookingInfo.SelectedTab = tcBookingInfo.TabPages["tpVehicleInfo"];
                }
                else
                {
                    MessageBox.Show("Customer Is Not Found ", "Select a Customer ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select a Customer", "Select a Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpVehicleInfo.Enabled = true;
                tpBookinginfo.Enabled = true;
                tcBookingInfo.SelectedTab = tcBookingInfo.TabPages["tpBookinginfo"];
                _CalculateRentalCosts();
                return;
            }

            if (ctrlVehicleCardWithFilter1.VehicleID != -1)
            {
                if (clsVehicleBll.IsVehicleExist(ctrlVehicleCardWithFilter1.VehicleID)
                   && ctrlVehicleCardWithFilter1.SelectedVehicleInfo?.IsAvailableForRent == true)
                {
                    tpBookinginfo.Enabled = true;
                    tcBookingInfo.SelectedTab = tcBookingInfo.TabPages["tpBookinginfo"];
                    _CalculateRentalCosts();
                }
                else
                {
                    MessageBox.Show("Vehicle Is Not Found or not available for rent", "Select Vehicle ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select vehicle", "Select vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}