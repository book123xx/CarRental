using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.User
{
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int ID)
        {
            InitializeComponent();
            ctrlUserCard1.LoadUserInfo(ID);
        }
    }
}
