using CarRenta_Buisness;
using CarRental.Booking.Controls;
using CarRental.Customer.Controls;
using CarRental.People;
using CarRental.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRental.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID);
            }
        }


        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddNewPerson.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }
        private int _PersonID = -1;

        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPeopleBll SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }

        public void LoadPersonInfo(int PersonID)
        {

            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);

            if (OnPersonSelected != null && FilterEnabled)

                OnPersonSelected(ctrlPersonCard1.PersonID);

        }
        //private void FindNow()

        //{

        //    if (!this.ValidateChildren())
        //    {
        //        MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }


        //    if (int.TryParse(txtFilterValue.Text.Trim(), out int ID))
        //    {


        //        ctrlPersonCard1.LoadPersonInfo(ID);





        //        if (OnPersonSelected != null && FilterEnabled)
        //        {
        //            OnPersonSelected(ctrlPersonCard1.PersonID);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter a valid numeric Person ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }






        //}



        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // 1. التأكد أن حقل النص ليس فارغاً
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                MessageBox.Show("Please enter a Person ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFilterValue.Focus();
                return;
            }

            // 2. تحويل النص إلى رقم بشكل آمن
            if (int.TryParse(txtFilterValue.Text.Trim(), out int ID))
            {
                // === خطوة هامة جداً: تفريغ الكارت أولاً لتجنب بقاء بيانات البحث القديم في الذاكرة ===
                ctrlPersonCard1.ResetPersonInfo(); // تأكد من استدعاء دالة التفريغ التي أنشأناها

                // 3. محاولة جلب بيانات المعرف الجديد من القاعدة
                ctrlPersonCard1.LoadPersonInfo(ID);

                // 4. التحقق هل الشخص الجديد موجود أم لا؟
                if (ctrlPersonCard1.SelectedPersonInfo == null)
                {
                    MessageBox.Show("No Person with ID = [" + ID + "] was found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFilterValue.Focus();
                    txtFilterValue.SelectAll(); // لتسهيل مسح الرقم القديم وكتابة معرف جديد فوراً
                    return;
                }

                // 5. إذا وُجد المعرف، قم برفع الحدث بالمعرف الجديد الحقيقي
                if (OnPersonSelected != null && FilterEnabled)
                {
                    OnPersonSelected(ctrlPersonCard1.PersonID);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Person ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFilterValue.Focus();
                txtFilterValue.SelectAll();
            }
        }
        //    // 1. التأكد أن حقل النص ليس فارغاً
        //    if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
        //    {
        //        MessageBox.Show("Please enter a Person ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtFilterValue.Focus();
        //        return;
        //    }

        //    // 2. تحويل النص إلى رقم بشكل آمن
        //    if (int.TryParse(txtFilterValue.Text.Trim(), out int ID))
        //    {
        //        // === خطوة هامة جداً: تفريغ الكارت أولاً لتجنب بقاء بيانات البحث القديم في الذاكرة ===
        //        ctrlPersonCard1.ResetPersonInfo(); // تأكد من استدعاء دالة التفريغ التي أنشأناها

        //        // 3. محاولة جلب بيانات المعرف الجديد من القاعدة
        //        ctrlPersonCard1.LoadPersonInfo(ID);

        //        // 4. التحقق هل الشخص الجديد موجود أم لا؟
        //        if (ctrlPersonCard1.SelectedPersonInfo == null)
        //        {
        //            MessageBox.Show("No Person with ID = [" + ID + "] was found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            txtFilterValue.Focus();
        //            txtFilterValue.SelectAll(); // لتسهيل مسح الرقم القديم وكتابة معرف جديد فوراً
        //            return;
        //        }

        //        // 5. إذا وُجد المعرف، قم برفع الحدث بالمعرف الجديد الحقيقي
        //        if (OnPersonSelected != null && FilterEnabled)
        //        {
        //            OnPersonSelected(ctrlPersonCard1.PersonID);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter a valid numeric Person ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtFilterValue.Focus();
        //        txtFilterValue.SelectAll();
        //    }
        //}

        //          if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
        //          {
        //              MessageBox.Show("Please enter a Person ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //              txtFilterValue.Focus();
        //              return;
        //          }


        //          if (int.TryParse(txtFilterValue.Text.Trim(), out int ID))
        //          {

        //              string enteredText = txtFilterValue.Text;


        //              ctrlPersonCard1.LoadPersonInfo(ID);

        //              txtFilterValue.Text = enteredText;


        //              if (ctrlPersonCard1.SelectedPersonInfo == null)
        //              {

        //ctrlPersonCard1.ResetPersonInfo();

        //                  MessageBox.Show("No Person with ID = [" + ID + "] was found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                  //txtFilterValue.Focus();

        //                  //txtFilterValue.SelectAll(); 

        //                  return;
        //              }


        //              if (OnPersonSelected != null && FilterEnabled)
        //              {
        //                  OnPersonSelected(ctrlPersonCard1.PersonID);
        //              }
        //          }
        //          else
        //          {
        //              MessageBox.Show("Please enter a valid numeric Person ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //              txtFilterValue.Focus();
        //          }




        //if (int.TryParse(txtFilterValue.Text.Trim(), out int ID))
        //{

        //    ctrlPersonCard1.LoadPersonInfo(ID);


        //    if (ctrlPersonCard1.SelectedPersonInfo == null)
        //    {
        //        MessageBox.Show("No Person  with ID = [" + ID + "] was found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }


        //    if (OnPersonSelected != null && FilterEnabled)

        //        OnPersonSelected(ctrlPersonCard1.PersonID);


        //}



        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm1 = new frmAddUpdatePerson();
            frm1.DataBack += DataBackEvent; 
            frm1.ShowDialog();
        }
        private void DataBackEvent(object sender, int PersonID)
        {
            


            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1.PerformClick();
               
            }

          

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void gbFilters_Enter(object sender, EventArgs e)
        {

        }

  
    }
}
//using CarRenta_Buisness;
//using CarRental.People.Controls;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace CarRental.Customer.Controls
//{
//    public partial class ctrlCustomerCardWithFilter : UserControl
//    {
//        public ctrlCustomerCardWithFilter()
//        {
//            InitializeComponent();
//        }
//        public event Action<int> OnCustomerSelected;
//        // Create a protected method to raise the event with a parameter
//        protected virtual void PersonSelected(int PersonID)
//        {
//            Action<int> handler = OnCustomerSelected;
//            if (handler != null)
//            {
//                handler(PersonID); // Raise the event with the parameter
//            }
//        }


//        //private bool _ShowAddPerson = true;
//        //public bool ShowAddPerson
//        //{
//        //    get
//        //    {
//        //        return _ShowAddPerson;
//        //    }
//        //    set
//        //    {
//        //        _ShowAddPerson = value;
//        //        btnAddNewPerson.Visible = _ShowAddPerson;
//        //    }
//        //}

//        private bool _FilterEnabled = true;
//        public bool FilterEnabled
//        {
//            get
//            {
//                return _FilterEnabled;
//            }
//            set
//            {
//                _FilterEnabled = value;
//                gbFilters.Enabled = _FilterEnabled;
//            }
//        }

//        private int _CustomerID = -1;

//        public int CustomerID
//        {
//            get { return ctrlCustomerCard1.CustomerID; }
//        }

//        public clsCustomerBll? SelecteCustomerInfo
//        {
//            get { return ctrlCustomerCard1.SelecteCustomerInfo; }
//        }

//        public void LoadCustomerInfo(int CustomerID)
//        {


//            txtFilterValue.Text = CustomerID.ToString();
//            ctrlCustomerCard1.LoadCustomerInfo(CustomerID);

//            if (OnCustomerSelected != null && FilterEnabled)
//                // Raise the event with a parameter
//                OnCustomerSelected(ctrlCustomerCard1.CustomerID);
//        }



//        private void btnFind_Click(object sender, EventArgs e)
//        {

//            if (!this.ValidateChildren())
//            {
//                //Here we dont continue becuase the form is not valid
//                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;



//            }

//            ctrlCustomerCard1.LoadCustomerInfo(int.Parse(txtFilterValue.Text));
//            if (OnCustomerSelected != null && FilterEnabled)
//                // Raise the event with a parameter
//                OnCustomerSelected(ctrlCustomerCard1.CustomerID);
//        }

//        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
//        {
//            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
//            {
//                e.Cancel = true;
//                errorProvider1.SetError(txtFilterValue, "This field is required!");
//            }
//            else
//            {
//                //e.Cancel = false;
//                errorProvider1.SetError(txtFilterValue, null);
//            }
//        }

//        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            // Check if the pressed key is Enter (character code 13)
//            if (e.KeyChar == (char)13)
//            {

//                btnFind.PerformClick();
//            }

//            //this will allow only digits if person id is selected

//            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

//        }

//        private void btnAdd_Click(object sender, EventArgs e)
//        {

//            frmAddUpdateCustomer frm1 = new frmAddUpdateCustomer();

//            frm1.ShowDialog();

//        }



//    }
//}
