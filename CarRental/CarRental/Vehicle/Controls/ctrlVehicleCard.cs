using CarRenta_Buisness;
using CarRental.People.Controls;
using CarRental_DataAccess.DTO;
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
using CarRental.Properties;



namespace CarRental.Vehicle.Controls
{

    public partial class ctrlVehicleCard : UserControl
    {


        private clsVehicleBll? _Vehicle;
        private int _VehicleID = -1;

        public int VehicleID
        {
            get { return _VehicleID; }
        }
        public clsVehicleBll? SelectedVehicleInfo
        {
            get { return _Vehicle; }
        }
        public ctrlVehicleCard()
        {
            InitializeComponent();
        }
        public void LoadVehicleInfo(int VehicleID)
        {
            _Vehicle = clsVehicleBll.Find(VehicleID);
            if (_Vehicle == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Vehicle with VehicleID = " + VehicleID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            _VehicleID = _Vehicle!.VehicleId;
            lblVehicleID.Text = _Vehicle!.VehicleId.ToString();
            lblMake.Text = _Vehicle.Make;
            lblModel.Text = _Vehicle.Model;
            lblyear.Text = _Vehicle.Year.ToString();
            lblMileage.Text = _Vehicle.Mileage.ToString();
            lblFuelType.Text = _Vehicle.FuelTypeId.ToString();
            lblPlateNumber.Text = _Vehicle.PlateNumber;
            lblCarCategory.Text = _Vehicle.CarCategoryId.ToString();
            lblPricePerDay.Text = _Vehicle.RentalPricePerDay.ToString();
            lblIsAvailsble.Text = _Vehicle.IsAvailableForRent ? "Yes" : "No";


        }
        private void _ResetPersonInfo()
        {
            _VehicleID = -1;
            lblVehicleID.Text = "..?";
            lblMake.Text = "..?";
            lblModel.Text = "..?";
            lblyear.Text = "..?";
            lblMileage.Text = "..?";
            lblFuelType.Text = "..?";
            lblPlateNumber.Text = "..?";
            lblCarCategory.Text = "..?";
            lblPricePerDay.Text = "..?";
            lblIsAvailsble.Text = "..?";



        }

        private void ctrlVehicleCard_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateVehicle frm = new frmAddUpdateVehicle(_VehicleID);
            frm.ShowDialog();
            LoadVehicleInfo(_VehicleID);
        }
    }

}
