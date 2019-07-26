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
    public partial class listInvoice : Form
    {
        BL.orderClass order = new BL.orderClass();
        public listInvoice()
        {
            InitializeComponent();
        }

        private void listInvoice_Load(object sender, EventArgs e)
        {
            this.bunifuCustomDataGrid1.DataSource = order.listinvo();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {

            this.bunifuCustomDataGrid1.DataSource = order.searchinInvo(txtSearch.Text);
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            PL.showInvoice frm = new showInvoice();
            frm.id = Convert.ToInt32(bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);
            frm.txtName.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            frm.txtNote.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            frm.txtID.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            frm.txtTotal.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
            frm.txtAmountReceived.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            frm.ShowDialog();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
