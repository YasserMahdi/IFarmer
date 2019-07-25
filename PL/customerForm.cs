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
        BL.debtClass debt = new BL.debtClass();

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

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            PL.customerProfile frm = new customerProfile();
            try
            {
                frm.txtName.Text = this.bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
                frm.txtDebt.Text = debt.userTotalDebt(Convert.ToInt32(this.bunifuCustomDataGrid1.CurrentRow.Cells[0].Value)).Rows[0][0].ToString();
                frm.id = Convert.ToInt32(this.bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);
                
            }
            catch
            {
               
            }
            frm.ShowDialog();
        }
    }
}
