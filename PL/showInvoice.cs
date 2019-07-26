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
    public partial class showInvoice : Form
    {
        BL.orderClass order = new BL.orderClass();
        public int id;
        public showInvoice()
        {
            InitializeComponent();
        }

        private void showInvoice_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = order.showInvoice(id);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
