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
        BL.debtClass debt = new BL.debtClass();
        BL.DocumentClass doc = new BL.DocumentClass();
        public customerProfile()
        {
            InitializeComponent();
        }

        private void customerProfile_Load(object sender, EventArgs e)
        {
            try
            {
                this.invoDataGrid1.DataSource = debt.getDebtInfo(id);
                
                
                    this.invoDataGrid1.DataSource = order.notPaidInCash(id);
                
                
                    this.docDataGrid2.DataSource = doc.unPaidDoc(id);
                
            }
            catch
            {

            }
            
        }



        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            PL.customerDebtHistory frm = new customerDebtHistory();
            frm.id = this.id;
            frm.oldDept = Convert.ToDouble(txtDebt.Text);
            frm.ShowDialog();
            this.invoDataGrid1.DataSource = order.notPaidInCash(id);
            this.docDataGrid2.DataSource = doc.unPaidDoc(id);
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            PL.showInvoice frm = new showInvoice();
            frm.id = Convert.ToInt32(this.invoDataGrid1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
