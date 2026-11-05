using CarRenta_Buisness;
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
//using Properties;
//using Buisness;
using System.Xml.Linq;
using System.IO;

namespace CarRental.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPeopleBll _Person;

        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPeopleBll SelectedPersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPeopleBll.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        public  void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";

            lblFullName.Text = "[????]";

            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";

            pbPersonImage.Image = Resources.Male_512;

        }
        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pbPersonImage.Image = Resources.Male;
            else
                pbPersonImage.Image = Resources.Female_1__3_;

            string? ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonId;
            lblPersonID.Text = _Person.PersonId.ToString();

            lblFullName.Text = _Person.FullName;
            lblGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();

            _LoadPersonImage();




        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

          
            LoadPersonInfo(_PersonID);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

