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
using CarRenta_Buisness;
namespace CarRental.RentalTransaction.Controls
{
    public partial class ctrlRentalTransactionCard : UserControl
    {
        private  clsRentalTransactionBll? _RentalTransaction;

        private int _TransactionID = -1;

        public int TransactionID
        {
            get { return _TransactionID; }
        }

        public clsRentalTransactionBll? SelectedRentalTransactionInfo
        {
            get { return _RentalTransaction; }
        }
        public ctrlRentalTransactionCard()
        {
            InitializeComponent();
        }


        public void LoadRentalTransactionInfo(int TransactionID)
        {
            _RentalTransaction = clsRentalTransactionBll.Find(TransactionID);
            if (_RentalTransaction == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + TransactionID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        private void _FillPersonInfo()
        {
            //llEditPersonInfo.Enabled = true;
            _TransactionID = _RentalTransaction!.TransactionId;
            lblTransactionID.Text = _RentalTransaction!.TransactionId.ToString();
            lblReturnID.Text = _RentalTransaction.ReturnId.ToString();
            lblBookingID.Text = _RentalTransaction.BookingId.ToString();
            lblPaymentDetails.Text = _RentalTransaction.PaymentDetails;
            lblPaidInitialTotalDueAmount.Text = _RentalTransaction.PaidInitialTotalDueAmount.ToString();
            lblActualTotalDueAmount.Text = _RentalTransaction.ActualTotalDueAmount.ToString();
            lblTotalRemaining.Text = _RentalTransaction.TotalRemaining.ToString();

            lblTotalRefundedAmount.Text = _RentalTransaction.TotalRefundedAmount.ToString();
            lblTransactionDate.Text = _RentalTransaction.TransactionDate.ToShortDateString();
            lblUpdatedTransactionDate.Text = _RentalTransaction.UpdatedTransactionDate?.ToShortDateString();

           



        }
        public void ResetPersonInfo()
        {
           
            _TransactionID = -1;
            lblTransactionID.Text = "... ?";
            lblReturnID.Text = "... ?";
            lblBookingID.Text = "... ?";
            lblPaymentDetails.Text = "... ?";
            lblPaidInitialTotalDueAmount.Text = "... ?";
            lblActualTotalDueAmount.Text = "... ?";
            lblTotalRemaining.Text = "... ?";

            lblTotalRefundedAmount.Text = "... ?";
            lblTransactionDate.Text = "... ?";
            lblUpdatedTransactionDate.Text = "... ?";



        }


    }
}

