using CarRenta_Buisness;
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

namespace CarRental.Customer
{
    public partial class frmListCustomer : Form
    {

        private DataTable _dtAllCustomers;

        public frmListCustomer()
        {
            InitializeComponent();
        }

        private void frmListCustomer_Load(object sender, EventArgs e)
        {




            cbFilterBy.SelectedIndex = 0;
            _dtAllCustomers = clsCustomerBll.GetAllCustomers1();
            dgvCustomers.DataSource = _dtAllCustomers;
            x.Text = dgvCustomers.Rows.Count.ToString();
            if (dgvCustomers.Rows.Count > 0)
            {
                dgvCustomers.Columns[0].HeaderText = "CustomerID";
                dgvCustomers.Columns[0].Width = 120;

                dgvCustomers.Columns[1].HeaderText = "Person ID";
                dgvCustomers.Columns[1].Width = 120;

                dgvCustomers.Columns[2].HeaderText = "Full Name";
                dgvCustomers.Columns[2].Width = 240;

                

                dgvCustomers.Columns[3].HeaderText = "Phone";
                dgvCustomers.Columns[3].Width = 170;

                dgvCustomers.Columns[4].HeaderText = "Driver License Number";
                dgvCustomers.Columns[4].Width = 150;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {


            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "CustomerID":
                    FilterColumn = "CustomerID";
                    break;

                case "PersonID":
                    FilterColumn = "PersonID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;



                case "Phone":
                    FilterColumn = "Phone";
                    break;



                case "Driver License Number":
                    FilterColumn = "DriverLicenseNumber";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllCustomers.DefaultView.RowFilter = "";
                x.Text = dgvCustomers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "CustomerID" && FilterColumn != "PersonID")
            {

                _dtAllCustomers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }
            else
            {
                _dtAllCustomers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());


            }
            x.Text = _dtAllCustomers.Rows.Count.ToString();

        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ID = (int)dgvCustomers.CurrentRow.Cells[0].Value;
            frmShowCustomernfo frm = new frmShowCustomernfo(ID);
            frm.ShowDialog();
            //refresh
            frmListCustomer_Load(null, null);

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvCustomers.CurrentRow.Cells[0].Value;
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.ShowDialog();
            frmListCustomer_Load(null, null);

        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvCustomers.CurrentRow.Cells[0].Value;
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer(ID);
            frm.ShowDialog();
            frmListCustomer_Load(null, null);

        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvCustomers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)


            {

                //Perform Delele and refresh 
                if (ClsCustomer.DeleteCustomer((int)dgvCustomers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListCustomer_Load(null, null);
                }

            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm =new  frmAddUpdateCustomer();
            frm.ShowDialog();
            frmListCustomer_Load(null, null);
        }
    }
}
