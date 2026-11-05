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

namespace CarRental.People
{
    public partial class frmListPeople : Form
    {
        private static DataTable _dtAllpeople;

        public frmListPeople()
        {
            InitializeComponent();
        }


        private void frmListPeople_Load(object sender, EventArgs e)
        {
           
            _dtAllpeople = clsPeopleBll.GetAllPeople();
            dgvPeople.DataSource = _dtAllpeople;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
            if (dgvPeople.Rows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "PersonID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "Full Name";
                dgvPeople.Columns[1].Width = 220;

                dgvPeople.Columns[2].HeaderText = "DateOfBirth";
                dgvPeople.Columns[2].Width = 150;

                dgvPeople.Columns[3].HeaderText = "Gender";
                dgvPeople.Columns[3].Width = 120;
                dgvPeople.Columns[4].HeaderText = "Phone";
                dgvPeople.Columns[4].Width = 150;

                dgvPeople.Columns[5].HeaderText = "Email";
                dgvPeople.Columns[5].Width = 120;
                dgvPeople.Columns[6].HeaderText = "ImagePath";
                dgvPeople.Columns[6].Width = 350;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;


                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllpeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "PersonID")
                //in this case we deal with numbers not string.
                _dtAllpeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());


            else
                _dtAllpeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllpeople.Rows.Count.ToString();
        }

        private void personDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            frmShowPeopleInfo frm = new frmShowPeopleInfo(ID);
            frm.ShowDialog();

            frmListPeople_Load(null, null);
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            frmListPeople_Load(null, null);

        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvPeople.CurrentRow.Cells[0].Value;

            frmAddUpdatePerson frm = new frmAddUpdatePerson(ID);
            frm.ShowDialog();
            frmListPeople_Load(null, null);
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                int ID = (int)dgvPeople.CurrentRow.Cells[0].Value;
                if (clsPeopleBll.DeletePerson(ID))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListPeople_Load(null, null);

                }

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            frmListPeople_Load(null, null);
        }
    }
}
