using CarRental.Booking;
using CarRental.Classes;
using CarRental.Customer;
using CarRental.People;
using CarRental.RentalTransaction;
using CarRental.User;
using CarRental.Vehicle;
using CarRental.VehicleReturn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CarRental
{
    public partial class frmMain : Form
    {
        FrmLogin? _frmLogin;

        public frmMain(FrmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;

        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            clsGlobal.CurrentUser = null;
            _frmLogin?.Show();
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
         
            lblLoggedInUser.Text = "LoggedIn User: " + clsGlobal.CurrentUser?.UserName;
            this.Refresh();
        }
        private void _OpenFormInPanel(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmListBooking frm = new frmListBooking();
            _OpenFormInPanel(frm);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmListCustomer frm = new frmListCustomer();
            _OpenFormInPanel(frm);
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            _OpenFormInPanel(frm);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmListRentalTransaction frm = new frmListRentalTransaction();
            _OpenFormInPanel(frm);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            frmListUsers frm = new frmListUsers();
            _OpenFormInPanel(frm);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListVehicle frm = new frmListVehicle();
            _OpenFormInPanel(frm);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmListVehicleReturn frm = new frmListVehicleReturn();
            _OpenFormInPanel(frm);
        }

        private void btnCurrentUser_Click(object sender, EventArgs e)
        {
            int ID = clsGlobal.CurrentUser?.UserId ?? 0;
            frmShowUserInfo frm = new frmShowUserInfo(ID);
            _OpenFormInPanel(frm);
        }

        private void btnLoginOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin?.Show();
            this.Close();
        }
    }
}

