using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.RentalTransaction
{
    public partial class frmShowRentalTransactionInfo : Form
    {
        public frmShowRentalTransactionInfo(int ID)
        {
            InitializeComponent();
           ctrlRentalTransactionCard1.LoadRentalTransactionInfo(ID);
        }
    }
}
