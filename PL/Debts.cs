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
            this.bunifuCustomDataGrid1.DataSource = debt.getDebtInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
