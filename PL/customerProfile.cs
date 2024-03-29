﻿using System;
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
    public partial class customerProfile : MetroFramework.Forms.MetroForm
    {
        public int id;
        BL.orderClass order = new BL.orderClass();
        BL.debtClass debt = new BL.debtClass();
        BL.DocumentClass doc = new BL.DocumentClass();

        private void UpDateInfo()
        {
            this.invoDataGrid1.DataSource = debt.getDebtInfo(id);


            this.invoDataGrid1.DataSource = order.notPaidInCash(id);


            this.docDataGrid2.DataSource = doc.unPaidDoc(id);
            this.txtDebt.Text =string.Format("{0:n0}", (debt.getTotalInvDebt(id) + debt.getTotalDocDebt(id)));
        }
        public customerProfile()
        {
            InitializeComponent();
        }

        private void customerProfile_Load(object sender, EventArgs e)
        {
            try
            {
                UpDateInfo();
                
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
            //PL.showInvoice frm = new showInvoice();
            PL.updateInvoice frm = new updateInvoice();
            frm.id = Convert.ToInt32(this.invoDataGrid1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDocRep_Click(object sender, EventArgs e)
        {
            PL.Pay frm = new Pay();
            frm.txtID.Text = this.id.ToString();
            frm.txtName.Text = txtName.Text;
            //frm.OldDebt = (debt.getTotalInvDebt(id) + debt.getTotalDocDebt(id));
            frm.txtOldDept.Text = string.Format("{0:n0}", debt.getTotalDocDebt(id));
            frm.temp = Convert.ToInt32(debt.getTotalDocDebt(id));
            frm.State = "doc";
            frm.ShowDialog();
            UpDateInfo();
        }

        private void btnREP_Click(object sender, EventArgs e)
        {
            PL.Pay frm = new Pay();
            frm.txtID.Text = this.id.ToString();
            frm.txtName.Text = this.txtName.Text;
            //frm.OldDebt = (debt.getTotalInvDebt(id) + debt.getTotalDocDebt(id));
            frm.txtOldDept.Text = string.Format("{0:n0}", debt.getTotalInvDebt(id));
            frm.temp = Convert.ToInt32(debt.getTotalInvDebt(id));
            frm.State = "inv";
            frm.ShowDialog();
            UpDateInfo();
        }

        private void docDataGrid2_DoubleClick(object sender, EventArgs e)
        {
            PL.UpdateDoc frm = new UpdateDoc();
            frm.docID = Convert.ToInt32(this.docDataGrid2.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            //PL.showDoc frm = new showDoc();
            //frm.docID = Convert.ToInt32(this.docDataGrid2.CurrentRow.Cells[0].Value);
            //frm.ShowDialog();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i < this.invoDataGrid1.Rows.Count - 1; i++)
            //{

                try
                {
                    Report.unpaidInvoice rpt = new Report.unpaidInvoice();
                    Report.ReportForm frm = new Report.ReportForm();
                    rpt.SetDataSource(order.notPaidInCash(Convert.ToInt32(id)));
                    frm.crystalReportViewer1.ReportSource = rpt;

                    frm.ShowDialog();
                    //frm.crystalReportViewer1.PrintReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            //}

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Report.UnpaidDocuments rpt = new Report.UnpaidDocuments();
                Report.ReportForm frm = new Report.ReportForm();
                rpt.SetDataSource(doc.unPaidDoc(Convert.ToInt32(id)));
                frm.crystalReportViewer1.ReportSource = rpt;

                frm.ShowDialog();
                frm.crystalReportViewer1.PrintReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
