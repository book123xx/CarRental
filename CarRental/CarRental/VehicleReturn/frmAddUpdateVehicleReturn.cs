
 using CarRenta_Buisness;
using CarRental.Booking.Controls;
using CarRental.Classes;
using CarRental.People.Controls;
using CarRental.Properties;
using CarRental.Vehicle.Controls;
using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.VehicleReturn
{
    public partial class frmAddUpdateVehicleReturn : Form
    {
      

        public enum enMode { AddNew = 0, Update = 1 };

        clsRentalTransactionBll? RentalTransaction;
        private enMode _Mode;
        private int _ReturnID = -1;
        clsVehicleReturnBll? _VehicleReturn;

        public frmAddUpdateVehicleReturn()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateVehicleReturn(int ReturnID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _ReturnID = ReturnID;
        }

        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Vehicle Return";
                this.Text = "Add New Vehicle Return";
                _VehicleReturn = new clsVehicleReturnBll();
                tpVehicleReturns.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Update Vehicle Return";
                this.Text = "Update Vehicle Return";
                tpVehicleReturns.Enabled = true;
                btnSave.Enabled = true;
            }

            dateTimePicker1.Value = DateTime.Now;
            txtMileage.Text = "";
            lblConsumedMileage.Text = "0";
            txtFinalCheckNotes.Text = "";
            txtAdditionalCharges.Text = "0";
            lblActualTotalDueAmount.Text = "0.00";
            lblTotalRefundedAmount.Text = "0.00";
            lblTotalRemaining.Text = "0.00";
            lblActualRentalDays.Text = "0";
        }

        private void frmAddUpdateVehicleReturn_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

         
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
        }

        private void DateTimePicker1_ValueChanged(object? sender, EventArgs e)
        {
            _CalculateReturnDetails();
        }

        private void _CalculateReturnDetails()
        {
            if (ctrlBookingCardWithFilter1.SelectedbookingInfo == null) return;

            DateTime rentalStartDate = ctrlBookingCardWithFilter1.SelectedbookingInfo.RentalStartDate.Date;
            DateTime returnDate = dateTimePicker1.Value.Date;

            if (returnDate < rentalStartDate)
            {
                lblActualRentalDays.Text = "0";
                return;
            }

            int totalDays = (returnDate - rentalStartDate).Days;
            if (totalDays <= 0) totalDays = 1;

            lblActualRentalDays.Text = totalDays.ToString();

            decimal rentalPricePerDay = ctrlBookingCardWithFilter1.SelectedbookingInfo.Vehicleinfo?.RentalPricePerDay ?? 0;

            decimal additionalCharges = 0;
            decimal.TryParse(txtAdditionalCharges.Text.Trim(), out additionalCharges);

            decimal totalDueAmount = (totalDays * rentalPricePerDay) + additionalCharges;
            lblActualTotalDueAmount.Text = totalDueAmount.ToString("0.00");

           
            decimal paidInitial = ctrlBookingCardWithFilter1.SelectedbookingInfo.RentalTransactionInfo?.PaidInitialTotalDueAmount ?? 0;
            decimal difference = totalDueAmount - paidInitial;
         if (difference < 0)
            {
               
                lblTotalRefundedAmount.Text = Math.Abs(difference).ToString("0.00");
                lblTotalRemaining.Text = "0.00";
            }
            else
            {
              
                lblTotalRefundedAmount.Text = "0.00";
                lblTotalRemaining.Text = difference.ToString("0.00");
            }
        }

        private void _LoadData()
        {
            _VehicleReturn = clsVehicleReturnBll.Find(_ReturnID);

            if (_VehicleReturn == null)
            {
                MessageBox.Show("No Vehicle Return found with ID = " + _ReturnID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

           

            dateTimePicker1.Value = _VehicleReturn.ActualReturnDate;
            lblActualRentalDays.Text = _VehicleReturn.ActualRentalDays.ToString();
            txtMileage.Text = _VehicleReturn.Mileage.ToString();
            lblConsumedMileage.Text = _VehicleReturn.ConsumedMileage.ToString();
            txtFinalCheckNotes.Text = _VehicleReturn.FinalCheckNotes;
            txtAdditionalCharges.Text = _VehicleReturn.AdditionalCharges.ToString();
            lblActualTotalDueAmount.Text = _VehicleReturn.ActualTotalDueAmount.ToString("0.00");

            lblReturenID.Text = _VehicleReturn.ReturenId.ToString();
            ctrlBookingCardWithFilter1.LoadBookingInfo(_VehicleReturn.BookingId);
            ctrlBookingCardWithFilter1.FilterEnabled = false;

            RentalTransaction = clsRentalTransactionBll.FindByBookingID(_VehicleReturn.BookingId); 
            if (RentalTransaction != null)
            {
                lblTotalRefundedAmount.Text = RentalTransaction.TotalRefundedAmount.ToString();
                lblTotalRemaining.Text = RentalTransaction.TotalRemaining.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpVehicleReturns.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tpVehicleReturns"];
                return;
            }

            if (ctrlBookingCardWithFilter1.BookingID != -1)
            {
                if (clsVehicleReturnBll.IsbookingExist(ctrlBookingCardWithFilter1.BookingID))
                {
                    MessageBox.Show("This booking has already been returned!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                    tpVehicleReturns.Enabled = false;
                    return;
                }
                else
                {
                    btnSave.Enabled = true;
                    tpVehicleReturns.Enabled = true;
                    tabControl1.SelectedTab = tabControl1.TabPages["tpVehicleReturns"];
                    _CalculateReturnDetails();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Booking first.", "Select a Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool _ValidateFields()
        {

            if (string.IsNullOrWhiteSpace(txtFinalCheckNotes.Text) ||
                string.IsNullOrWhiteSpace(txtMileage.Text) ||
                
                string.IsNullOrWhiteSpace(txtAdditionalCharges.Text))
              
            {


                return false;
            }

            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateFields())
            {
                MessageBox.Show("Some fields are not valid or missing!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


         int currentMileage = 0;
            int.TryParse(txtMileage.Text.Trim(), out  currentMileage);

            decimal additionalCharges = 0;
            decimal.TryParse(txtAdditionalCharges.Text.Trim(), out additionalCharges);
         _VehicleReturn!.BookingId = ctrlBookingCardWithFilter1.BookingID;
            _VehicleReturn.ActualReturnDate = dateTimePicker1.Value;
            _VehicleReturn.Mileage = currentMileage;
            _VehicleReturn.FinalCheckNotes = txtFinalCheckNotes.Text.Trim();
            _VehicleReturn.AdditionalCharges = additionalCharges;

         
            DateTime rentalStartDate = ctrlBookingCardWithFilter1.SelectedbookingInfo!.RentalStartDate.Date;
            int totalDays = (dateTimePicker1.Value.Date - rentalStartDate).Days;
            if (totalDays <= 0) totalDays = 1;

            _VehicleReturn.ActualRentalDays = Convert.ToByte(totalDays);
            lblActualRentalDays.Text = totalDays.ToString();

            int startMileage = ctrlBookingCardWithFilter1.SelectedbookingInfo?.Vehicleinfo?.Mileage ?? 0;
            int consumedMileage = currentMileage - startMileage;
            _VehicleReturn.ConsumedMileage = consumedMileage ;

         
            decimal rentalPricePerDay = ctrlBookingCardWithFilter1.SelectedbookingInfo?.Vehicleinfo?.RentalPricePerDay ?? 0;
            decimal actualTotalDueAmount = (totalDays * rentalPricePerDay) + additionalCharges;
            _VehicleReturn.ActualTotalDueAmount = actualTotalDueAmount;
            lblActualTotalDueAmount.Text = actualTotalDueAmount.ToString("0.00");

            if (_VehicleReturn.Save())
            {
                lblReturenID.Text = _VehicleReturn.ReturenId.ToString();

                lblConsumedMileage.Text = _VehicleReturn.ConsumedMileage.ToString();

                _Mode = enMode.Update;
                lblTitle.Text = "Update Vehicle Return";
                this.Text = "Update Vehicle Return";
                decimal paidInitial = ctrlBookingCardWithFilter1.SelectedbookingInfo?.RentalTransactionInfo?.PaidInitialTotalDueAmount ?? 0;
                decimal difference = actualTotalDueAmount - paidInitial;

                decimal refunded = 0;
                decimal remaining = 0;

                if (difference < 0)
                {
                    refunded = Math.Abs(difference);
                }
                else
                {
                    remaining = difference;
                }

                lblTotalRefundedAmount.Text = refunded.ToString("0.00");
                lblTotalRemaining.Text = remaining.ToString("0.00");

                RentalTransaction = clsRentalTransactionBll.FindByBookingID(ctrlBookingCardWithFilter1.BookingID); 
                if (RentalTransaction != null)
                {
                    RentalTransaction.ReturnId = _VehicleReturn.ReturenId;
                    RentalTransaction.ActualTotalDueAmount = _VehicleReturn.ActualTotalDueAmount;
                    RentalTransaction.TotalRefundedAmount = refunded;
                    RentalTransaction.TotalRemaining = remaining;
                    RentalTransaction.UpdatedTransactionDate = _VehicleReturn.ActualReturnDate;
                    RentalTransaction.Save();
                }
              

                if (ctrlBookingCardWithFilter1.SelectedbookingInfo?.Vehicleinfo != null)
                {
                    ctrlBookingCardWithFilter1.SelectedbookingInfo.Vehicleinfo.IsAvailableForRent = true;
                    ctrlBookingCardWithFilter1.SelectedbookingInfo.Vehicleinfo.Mileage = currentMileage;
                    ctrlBookingCardWithFilter1.SelectedbookingInfo.Vehicleinfo.Save();
                }

             

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
