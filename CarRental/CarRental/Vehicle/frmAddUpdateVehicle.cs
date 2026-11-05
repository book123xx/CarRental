using CarRenta_Buisness;
using CarRenta_Buisness1;
using CarRental.Classes;
using CarRental.Properties;
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
    public partial class frmAddUpdateVehicle : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int VehicleID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _VehicleID = -1;
        clsVehicleBll? _Vehicle;
        public frmAddUpdateVehicle()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public frmAddUpdateVehicle(int VehicleID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _VehicleID = VehicleID;
        }
        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillGetAllFuelTypesInComoboBox();
            _FillGetAllVehicleCategoriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Vehicle";
                _Vehicle = new clsVehicleBll();
            }
            else
            {
                lblTitle.Text = "Update Vehicle";
            }

          
            cbFuelType.SelectedIndex = 1;
            cbCarCategory.SelectedIndex = 1;

            txtMake.Text = "";
            txtModel.Text = "";
            txtVehicleYear.Text = "";
            txtMileage.Text = "";
            txtPlateNumber.Text = "";
            txtRentalPricePerDay.Text = "";

            checkBox1.Checked = true;

        }
        private void _FillGetAllVehicleCategoriesInComoboBox()
        {
            DataTable dtCarCategory = ClsVehicleCategory.GetAllVehicleCategories();

            foreach (DataRow row in dtCarCategory.Rows)
            {
                cbCarCategory.Items.Add(row["CategoryName"]);
            }
        }
        private void _FillGetAllFuelTypesInComoboBox()
        {
            DataTable dtFuelTypes = clsFuelTypeBll.GetAllFuelTypes();

            foreach (DataRow row in dtFuelTypes.Rows)
            {
                cbFuelType.Items.Add(row["FuelType"]);
            }
        }

        private void _LoadData()
        {

            _Vehicle = clsVehicleBll.Find(_VehicleID);

            if (_Vehicle == null)
            {
                MessageBox.Show("No Person with ID = " + _VehicleID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblVehicleID.Text = _VehicleID.ToString();
            txtMake.Text = _Vehicle.Make;
            txtMileage.Text = _Vehicle.Mileage.ToString();
            txtModel.Text = _Vehicle.Model;
            txtPlateNumber.Text = _Vehicle.PlateNumber;
            txtRentalPricePerDay.Text = _Vehicle.RentalPricePerDay.ToString();
            txtVehicleYear.Text = _Vehicle.Year.ToString();

            cbCarCategory.SelectedIndex = cbCarCategory.FindString(_Vehicle.CarCategoryInfo?.CategoryName);

            cbFuelType.SelectedIndex = cbFuelType.FindString(_Vehicle.FuelTypeInfo?.FuelType);

            checkBox1.Checked = _Vehicle.IsAvailableForRent;


        }

        private void frmAddUpdateVehicle_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private bool _ValidateFields()
        {

            if (string.IsNullOrWhiteSpace(txtMake.Text.Trim()) ||
               string.IsNullOrWhiteSpace(txtMileage.Text.Trim()) ||
               string.IsNullOrWhiteSpace(txtModel.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtPlateNumber.Text.Trim()) || string.IsNullOrWhiteSpace(txtRentalPricePerDay.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtVehicleYear.Text.Trim()))
            {


                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (! _ValidateFields())
            {
               
                MessageBox.Show("Some fileds are not valide!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

           

                int CategoryId = clsVehicleCategoryBll.FindByCategoryName(cbCarCategory.Text).CategoryId;
            int FuelTypeID = clsFuelTypeBll.FindByType(cbFuelType.Text).Id;

            _Vehicle!.Make = txtMake.Text.Trim();
            _Vehicle.Model = txtModel.Text.Trim();
            _Vehicle.Year = int.Parse(txtVehicleYear.Text.Trim());
            _Vehicle.Mileage = Convert.ToInt32(txtMileage.Text.Trim());
            _Vehicle.PlateNumber = txtPlateNumber.Text.Trim();
            _Vehicle.RentalPricePerDay = decimal.Parse(txtRentalPricePerDay.Text.Trim());
            _Vehicle.FuelTypeId = FuelTypeID;
            _Vehicle.CarCategoryId = CategoryId;
            _Vehicle.IsAvailableForRent = checkBox1.Checked;
            

            if (_Vehicle.Save())
            {
                lblVehicleID.Text = _Vehicle.VehicleId.ToString();
               
                _Mode = enMode.Update;
                lblTitle.Text = "Update Vehicle";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this,_Vehicle.VehicleId);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}

