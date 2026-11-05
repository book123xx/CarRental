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
    public partial class frmShowBookingInfo : Form
    {
        public frmShowBookingInfo(int ID)
        {
            InitializeComponent();
            ctrlBookingCard1.LoadBookingInfo(ID);
        }

        private void ctrlBookingCard1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
