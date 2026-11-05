using CarRenta_Buisness;
using CarRental.User;
using CarRental.VehicleReturn;
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

namespace CarRental.Vehicle
{
    public partial class frmListVehicle : Form
    {
        private static DataTable _dtAllVehicles;



        public frmListVehicle()
        {
            InitializeComponent();
        }

        private void frmListVehicle_Load(object? sender, EventArgs? e)
        {


            _dtAllVehicles = clsVehicleBll.GetAllVehicle();
            dgvVehcile.DataSource = _dtAllVehicles;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvVehcile.Rows.Count.ToString();

            if (dgvVehcile.Rows.Count > 0)
            {
                dgvVehcile.Columns[0].HeaderText = "VehicleID";
                dgvVehcile.Columns[0].Width = 110;

                dgvVehcile.Columns[1].HeaderText = "Make";
                dgvVehcile.Columns[1].Width = 120;

                dgvVehcile.Columns[2].HeaderText = "Model";
                dgvVehcile.Columns[2].Width = 150;

                dgvVehcile.Columns[3].HeaderText = "Year";
                dgvVehcile.Columns[3].Width = 120;

                dgvVehcile.Columns[4].HeaderText = "Mileage";
                dgvVehcile.Columns[4].Width = 120;

                dgvVehcile.Columns[5].HeaderText = "Fuel TypeID";
                dgvVehcile.Columns[5].Width = 120;

                dgvVehcile.Columns[6].HeaderText = "Plate Number";
                dgvVehcile.Columns[6].Width = 120;

                dgvVehcile.Columns[7].HeaderText = "Car CategoryID";
                dgvVehcile.Columns[7].Width = 120;

                dgvVehcile.Columns[8].HeaderText = "RentalPricePerDay";
                dgvVehcile.Columns[8].Width = 120;

                dgvVehcile.Columns[9].HeaderText = "Is Available For Rent";
                dgvVehcile.Columns[9].Width = 120;
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
                case "VehicleID":
                    FilterColumn = "VehicleID";
                    break;
                case "Make":
                    FilterColumn = "Make";
                    break;

                case "Fuel TypeID":
                    FilterColumn = "FuelTypeID";
                    break;

                case "Plate Number":
                    FilterColumn = "PlateNumber";
                    break;
                case "Car CategoryID":
                    FilterColumn = "CarCategoryID";
                    break;



                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllVehicles.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvVehcile.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "PlateNumber" && FilterColumn != "Make")
            {
                _dtAllVehicles.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            }

            else
            {
                _dtAllVehicles.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = _dtAllVehicles.Rows.Count.ToString();
        }

        private void vehicleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowVehicleInfo Frm1 = new frmShowVehicleInfo((int)dgvVehcile.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();

            frmListVehicle_Load(null, null);
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateVehicle frm = new frmAddUpdateVehicle();
            frm.ShowDialog();
            frmListVehicle_Load(null, null);

        }

        private void updateVehcileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddUpdateVehicle frm = new frmAddUpdateVehicle((int)dgvVehcile.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListVehicle_Load(null, null);
        }

        private void deleteVehcileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvVehcile.CurrentRow.Cells[0].Value;
            if (clsVehicleBll.DeleteVehicle(ID))
            {
                MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListVehicle_Load(null, null);
            }

            else
                MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmAddUpdateVehicle frm = new frmAddUpdateVehicle();
            frm.ShowDialog();
            frmListVehicle_Load(null, null);
        }

        private void txtFilterValue_TextChanged_1(object sender, EventArgs e)
        {



            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "VehicleID":
                    FilterColumn = "VehicleID";
                    break;
                case "Make":
                    FilterColumn = "Make";
                    break;

                case "Fuel TypeID":
                    FilterColumn = "FuelTypeID";
                    break;

                case "Plate Number":
                    FilterColumn = "PlateNumber";
                    break;
                case "Car CategoryID":
                    FilterColumn = "CarCategoryID";
                    break;



                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllVehicles.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvVehcile.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "PlateNumber" && FilterColumn != "Make")
            {
                _dtAllVehicles.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            }

            else
            {
                _dtAllVehicles.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = _dtAllVehicles.Rows.Count.ToString();
        
    }
    }
}
