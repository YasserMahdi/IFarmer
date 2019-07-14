using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFarmer.PL
{
    public partial class customerForm : Form
    {
        BL.CustomerClass customer = new BL.CustomerClass();
        public customerForm()
        {
            InitializeComponent();
            this.bunifuCustomDataGrid1.DataSource = customer.getCustomerInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PL.insertCustomer frm = new insertCustomer();
            frm.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
