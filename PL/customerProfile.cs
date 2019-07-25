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
    public partial class customerProfile : Form
    {
        public int id;
        BL.orderClass order = new BL.orderClass();
        public customerProfile()
        {
            InitializeComponent();
        }

        private void customerProfile_Load(object sender, EventArgs e)
        {
            try
            {
                this.bunifuCustomDataGrid1.DataSource = order.notPaidInCash(id);
            }
            catch
            {

            }
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            PL.customerDebtHistory frm = new customerDebtHistory();
            frm.id = this.id;
            frm.ShowDialog();
        }
    }
}
