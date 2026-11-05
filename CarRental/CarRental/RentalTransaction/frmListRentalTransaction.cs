using CarRenta_Buisness;
using CarRental.User;
using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;


namespace CarRental.RentalTransaction
{
    public partial class frmListRentalTransaction : Form
    {
        private static DataTable _dtAllRentalTransaction;
        public frmListRentalTransaction()
        {
            InitializeComponent();
        }

        private void frmListRentalTransaction_Load(object sender, EventArgs e)
        {

            _dtAllRentalTransaction = clsRentalTransactionBll.GetAllRentalTransaction();
            dgvTransaction.DataSource = _dtAllRentalTransaction;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvTransaction.Rows.Count.ToString();
            if (dgvTransaction.Rows.Count > 0)
            {

                dgvTransaction.Columns[0].HeaderText = "TransactionID";
                dgvTransaction.Columns[0].Width = 110;

                dgvTransaction.Columns[1].HeaderText = "BookingID";
                dgvTransaction.Columns[1].Width = 120;

                dgvTransaction.Columns[2].HeaderText = "ReturnID";
                dgvTransaction.Columns[2].Width = 150;

                dgvTransaction.Columns[3].HeaderText = "Payment Details";
                dgvTransaction.Columns[3].Width = 120;

                dgvTransaction.Columns[4].HeaderText = "PaidInitial Total Due Amount";
                dgvTransaction.Columns[4].Width = 120;

                dgvTransaction.Columns[5].HeaderText = "Actual Total Due Amount";
                dgvTransaction.Columns[5].Width = 110;

                dgvTransaction.Columns[6].HeaderText = "Total Remaining";
                dgvTransaction.Columns[6].Width = 120;

                dgvTransaction.Columns[7].HeaderText = "Total RefundedAmount";
                dgvTransaction.Columns[7].Width = 150;

                dgvTransaction.Columns[8].HeaderText = "Transaction Date";
                dgvTransaction.Columns[8].Width = 160;

                dgvTransaction.Columns[9].HeaderText = "Updated Transaction Date";
                dgvTransaction.Columns[9].Width = 170;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");


            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {


            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "TransactionID":
                    FilterColumn = "TransactionID";
                    break;
                case "PaidInitial Total Due Amount":
                    FilterColumn = "PaidInitialTotalDueAmount";
                    break;

                case "Actual Total Due Amount":
                    FilterColumn = "ActualTotalDueAmount";
                    break;


                case "Total Remaining":
                    FilterColumn = "TotalRemaining";
                    break;

                case "Total Refunded Amount":
                    FilterColumn = "TotalRefundedAmount";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllRentalTransaction.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvTransaction.Rows.Count.ToString();
                return;
            }


            _dtAllRentalTransaction.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());


            lblRecordsCount.Text = _dtAllRentalTransaction.Rows.Count.ToString();
        }

        private void transactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowRentalTransactionInfo Frm1 = new frmShowRentalTransactionInfo((int)dgvTransaction.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
           
        }
    }
}
