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
    public partial class Pay : Form
    {
        BL.debtClass debt = new BL.debtClass();
        public double OldDebt;
        public string State;
        public Pay()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == "inv")
                {
                    if (OldDebt < Convert.ToInt32(txtPay.Text))
                    {

                        MessageBox.Show(" تم ادخال مبلغ اكبر من قيمة الدين", "السداد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        
                        debt.processOnDebtRepaymentForInvoice(Convert.ToInt32(txtID.Text), Convert.ToDouble(txtPay.Text));
                        MessageBox.Show(" تمت العملية بنجاح", "السداد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        debt.set_RepaymentForInvoice_in_the_tables(Convert.ToInt32(txtID.Text), Convert.ToDouble(txtPay.Text));
                    }
                }
                else
                {
                    debt.processOnDebtRepaymentForDoc(Convert.ToInt32(txtID.Text), Convert.ToDouble(txtPay.Text));
                    MessageBox.Show(" تمت العملية بنجاح", "السداد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    debt.set_RepaymentForDoc_in_the_tables(Convert.ToInt32(txtID.Text), Convert.ToDouble(txtPay.Text));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            // cheack !! 
            //BL.debtClass debt = new BL.debtClass();
            //DataTable Dt_not_paid_invo = debt.processOnDebtRepaymentForInvoice(15, 20000.0);
            //foreach (DataRow row in Dt_not_paid_invo.Rows)
            //{
            //    MessageBox.Show(Convert.ToString(row["recived"]));
            //}
        }
    }
}
