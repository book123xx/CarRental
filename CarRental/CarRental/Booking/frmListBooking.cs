using CarRenta_Buisness;
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
    public partial class frmListBooking : Form
    {
        private DataTable _dtAllBooking;

        public frmListBooking()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFilterValue_TextChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "BookingID":
                    FilterColumn = "BookingID";
                    break;

                case "CustomerID":
                    FilterColumn = "CustomerID";
                    break;

                case "VehicleID":
                    FilterColumn = "VehicleID";
                    break;


                case "Pickup Location":
                    FilterColumn = "PickupLocation";
                    break;
                case "Drop off Location":
                    FilterColumn = "DropoffLocation";
                    break;
                case "Initial Rental Days":
                    FilterColumn = "InitialRentalDays";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (cbFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllBooking.DefaultView.RowFilter = "";
                x.Text = dgvBooking.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "BookingID" && FilterColumn != "CustomerID" && FilterColumn != "VehicleID")
            {

                _dtAllBooking.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, cbFilterBy.Text.Trim());
            }
            else
            {

                _dtAllBooking.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, cbFilterBy.Text.Trim());
            }
            x.Text = _dtAllBooking.Rows.Count.ToString();

        }

        private void frmListBooking_Load(object sender, EventArgs e)
        {
         

            cbFilterBy.SelectedIndex = 0;
            _dtAllBooking = clsBookingBll.GetAllBooking();
            dgvBooking.DataSource = _dtAllBooking;
            x.Text = dgvBooking.Rows.Count.ToString();
            if (dgvBooking.Rows.Count > 0)
            {
                dgvBooking.Columns[0].HeaderText = "BookingID";
                dgvBooking.Columns[0].Width = 120;

                dgvBooking.Columns[1].HeaderText = "CustomerID";
                dgvBooking.Columns[1].Width = 120;


                dgvBooking.Columns[2].HeaderText = "VehicleID";
                dgvBooking.Columns[2].Width = 120;

                dgvBooking.Columns[3].HeaderText = "Rental Start Date";
                dgvBooking.Columns[3].Width = 140;

                dgvBooking.Columns[4].HeaderText = "Rental End Date";
                dgvBooking.Columns[4].Width = 160;

                dgvBooking.Columns[5].HeaderText = "Pickup Location";
                dgvBooking.Columns[5].Width = 170;

                dgvBooking.Columns[6].HeaderText = "Drop off Location";
                dgvBooking.Columns[6].Width = 150;
                dgvBooking.Columns[7].HeaderText = "Initial Rental Days";
                dgvBooking.Columns[7].Width = 150;
                dgvBooking.Columns[8].HeaderText = "Rental Price Per Day";
                dgvBooking.Columns[8].Width = 150;
                dgvBooking.Columns[9].HeaderText = "Initial Total Due Amount";
                dgvBooking.Columns[9].Width = 150;

                dgvBooking.Columns[10].HeaderText = "Initial Check Notes";
                dgvBooking.Columns[10].Width = 150;
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

        private void bookingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookingID = (int)dgvBooking.CurrentRow.Cells[0].Value;
            frmShowBookingInfo frm = new frmShowBookingInfo(BookingID);
            frm.ShowDialog();
            //refresh
            frmListBooking_Load(null, null);

        }

        private void addNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBooking frm = new frmAddUpdateBooking();
            frm.ShowDialog();
            frmListBooking_Load(null, null);
        }

        private void updateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookingID = (int)dgvBooking.CurrentRow.Cells[0].Value;
            frmAddUpdateBooking frm = new frmAddUpdateBooking(BookingID);
            frm.ShowDialog();
            frmListBooking_Load(null, null);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete booking [" + dgvBooking.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {


                int ID = (int)dgvBooking.CurrentRow.Cells[0].Value;


  clsBookingBll _booking = clsBookingBll.Find(ID);
                    _booking.Vehicleinfo.IsAvailableForRent = true;
                    _booking.Vehicleinfo.Save();

                if (clsBookingBll.DeleteBooking(ID))
                {
                    MessageBox.Show("Booking Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
  frmListBooking_Load(null, null);
                    return;

                }
              

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUpdateBooking frm = new frmAddUpdateBooking();
            frm.ShowDialog();
            frmListBooking_Load(null, null);
        }
    }
}

