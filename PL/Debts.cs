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
    public partial class Debts : Form
    {
        BL.debtClass debt = new BL.debtClass();
        public Debts()
        {
            InitializeComponent();
            this.bunifuCustomDataGrid1.DataSource = debt.final_status_of_debts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
           
        }
    }
}
