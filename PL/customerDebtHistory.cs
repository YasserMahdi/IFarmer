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
        public int id;
        public double oldDept;
        public customerDebtHistory()
        {
            InitializeComponent();
        }

        private void customerDebtHistory_Load(object sender, EventArgs e)
        {
            this.bunifuCustomDataGrid1.DataSource = debt.getDebtInfo(id);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btnREP_Click(object sender, EventArgs e)
        {
            PL.Pay frm = new Pay();
            frm.txtID.Text = this.id.ToString() ;
            frm.txtName.Text = this.bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            frm.OldDebt = oldDept;
            frm.txtOldDept.Text = string.Format("{0:n0}", oldDept);
            frm.State = "inv";
            frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.ReportForm frm = new Report.ReportForm();
            Report.debt rpt = new Report.debt();
            rpt.SetDataSource(debt.printDebt(id));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            PL.Pay frm = new Pay();
            frm.txtID.Text = this.id.ToString();
            frm.txtName.Text = this.bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            frm.OldDebt = oldDept;
            frm.txtOldDept.Text = string.Format("{0:n0}", oldDept);
            frm.State = "doc";
            frm.ShowDialog();
        }
    }
}
