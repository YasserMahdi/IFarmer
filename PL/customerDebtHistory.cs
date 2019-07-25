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
    public partial class customerDebtHistory : Form
    {
        BL.debtClass debt = new BL.debtClass();
        public Int32 id;
        public customerDebtHistory()
        {
            InitializeComponent();
        }

        private void customerDebtHistory_Load(object sender, EventArgs e)
        {
            this.bunifuCustomDataGrid1.DataSource = debt.getDebtInfo(id);
        }
    }
}
