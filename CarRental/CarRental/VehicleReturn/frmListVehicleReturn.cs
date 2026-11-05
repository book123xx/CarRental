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
using System.Windows.Forms;

namespace CarRental.VehicleReturn
{
    public partial class frmListVehicleReturn : Form
    {

        private static DataTable? _dtAllVehicleReturn;

        public frmListVehicleReturn()
        {
            InitializeComponent();
        }

        private void frmListVehicleReturn_Load(object? sender, EventArgs? e)
        {



               _dtAllVehicleReturn = clsVehicleReturnBll.GetallVehicleReturns();
            dgvVehicleReturn.DataSource = _dtAllVehicleReturn;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvVehicleReturn.Rows.Count.ToString();
            if (dgvVehicleReturn.Rows.Count > 0)
            {

                dgvVehicleReturn.Columns[0].HeaderText = "ReturenID";
                dgvVehicleReturn.Columns[0].Width = 110;

                dgvVehicleReturn.Columns[1].HeaderText = "ActualReturnDate";
                dgvVehicleReturn.Columns[1].Width = 120;
                dgvVehicleReturn.Columns[2].HeaderText = "ActualRentalDays";
                dgvVehicleReturn.Columns[2].Width = 120;


                dgvVehicleReturn.Columns[3].HeaderText = "Mileage";
                dgvVehicleReturn.Columns[3].Width = 100;

                dgvVehicleReturn.Columns[4].HeaderText = "Consumed Mileage";
                dgvVehicleReturn.Columns[4].Width = 120;

                dgvVehicleReturn.Columns[5].HeaderText = "Final Check Notes";
                dgvVehicleReturn.Columns[5].Width = 120;

 dgvVehicleReturn.Columns[6].HeaderText = "AdditionalCharges";
                dgvVehicleReturn.Columns[6].Width = 120;

                dgvVehicleReturn.Columns[7].HeaderText = "Actual Total Due Amount";
                dgvVehicleReturn.Columns[7].Width = 350;
                dgvVehicleReturn.Columns[8].HeaderText = "BookingID";
                dgvVehicleReturn.Columns[8].Width = 120;
               

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
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "ReturenID":
                    FilterColumn = "ReturenID";
                    break;


                case "Mileage":
                    FilterColumn = "Mileage";
                    break;


                case "Consumed Mileage":
                    FilterColumn = "ConsumedMileage";
                    break;


                case "Final Check Notes":
                    FilterColumn = "FinalCheckNotes";
                    break;


                case "Additional Charges":
                    FilterColumn = "AdditionalCharges";
                    break;


                case "Actual Total Due Amount":
                    FilterColumn = "ActualTotalDueAmount";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }
            if (_dtAllVehicleReturn == null)
            {
                return;
            }
            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllVehicleReturn.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvVehicleReturn.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FinalCheckNotes")
            {
                _dtAllVehicleReturn.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
             
            }
            else
                _dtAllVehicleReturn.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());


          

            lblRecordsCount.Text = _dtAllVehicleReturn.Rows.Count.ToString();
        }

        private void addVehicleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateVehicleReturn Frm1 = new frmAddUpdateVehicleReturn();
            Frm1.ShowDialog();
            frmListVehicleReturn_Load(null, null);
        }

        private void updateVehicleReturnToolStripMenuItem_Click(object sender, EventArgs e)

        { 
            if (dgvVehicleReturn.CurrentRow == null) return;

            int ID = (int)dgvVehicleReturn.CurrentRow.Cells[0].Value;
            frmAddUpdateVehicleReturn frm = new frmAddUpdateVehicleReturn(ID);
            frm.ShowDialog();

            clsVehicleReturnBll? _Return = clsVehicleReturnBll.Find(ID);

           
            if (_Return?.bookinginfo?.Vehicleinfo != null)
            {
                _Return.bookinginfo.Vehicleinfo.Mileage = _Return.Mileage;
                _Return.bookinginfo.Vehicleinfo.Save();
            }

        

        
            frmListVehicleReturn_Load(null, null);

        }

        
        private void deleteVehicleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (dgvVehicleReturn.CurrentRow == null) return;

            int ID = (int)dgvVehicleReturn.CurrentRow.Cells[0].Value;

            clsVehicleReturnBll? _Return = clsVehicleReturnBll.Find(ID);
            if (_Return == null)
            {
                return;
            }

            
            if (_Return.bookinginfo?.Vehicleinfo != null)
            {
                _Return.bookinginfo.Vehicleinfo.IsAvailableForRent = true;
                _Return.bookinginfo.Vehicleinfo.Save();
            }

            if (clsVehicleReturnBll.DeleteVehicleReturn(ID))
            {
                MessageBox.Show("Vehicle return has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListVehicleReturn_Load(null, null);
            
            }
         
        }

     
        private void button1_Click(object sender, EventArgs e)
        {

            frmAddUpdateVehicleReturn Frm1 = new frmAddUpdateVehicleReturn();
            Frm1.ShowDialog();
            frmListVehicleReturn_Load(null, null);

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text!= "FinalCheckNotes")
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}