using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.PL
{
    public partial class DirSales : Form
    {
        BL.orderClass ord = new BL.orderClass();

        DataTable dt = new DataTable();

        int totalMoney;
        void calculateAmount()
        {
            if (txtQte.Text != string.Empty && txtMatPrice.Text != string.Empty)

                try
                {

                    txtAmount.Text = string.Format("{0:n0}", Convert.ToDouble(((Convert.ToDouble(txtMatPrice.Text) * Convert.ToInt32(txtQte.Text))).ToString()));
                }
                catch (Exception ex)
                {
                    return;
                }
        }

        void clearBoxes()
        {
            txtMatNo.Clear();
            txtMatName.Clear();
            txtMatPrice.Clear();
            txtQte.Clear();
            txtAmount.Clear();
        }

        void createColumns()
        {
            dt.Columns.Add("Column1"); //رقم المادة
            dt.Columns.Add("Column2");// اسم المادة
            dt.Columns.Add("Column3");//  qte
            dt.Columns.Add("Column4");// price
            dt.Columns.Add("Column5");// total amount


            this.dataGridView1.DataSource = dt;
        }




        public DirSales()
        {
            InitializeComponent();
            createColumns();
            txtID.Text = ord.getIDforInvoice().Rows[0][0].ToString();
            this.txtTotal.Text = "المبلغ الكلي";
            this.txtAmountReceived.Text = "المبلغ الواصل";
            this.txtTotal.Leave += new System.EventHandler(this.txtTotal_Leave);
            this.txtTotal.Enter += new System.EventHandler(this.txtTotal_Enter);
            this.txtAmountReceived.Leave += new System.EventHandler(this.txtAmountReceived_Leave);
            this.txtAmountReceived.Enter += new System.EventHandler(this.txtAmountReceived_Enter);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            PL.listCustomer frm = new listCustomer();
            frm.ShowDialog();

            try
            {


                this.txtName.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtCusID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();


            }
            catch (Exception)
            {
                return;
            }

        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            PL.listMat mat = new listMat();
            mat.ShowDialog();
            try
            {
                clearBoxes();
                txtMatNo.Text = mat.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMatName.Text = mat.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtMatPrice.Text = mat.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtQte.Focus();


            }
            catch
            {
                mat.Close();

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Text = ord.getIDforInvoice().Rows[0][0].ToString();
            clearBoxes();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int rAmount; int.TryParse(txtAmountReceived.Text, out rAmount);
                int total; int.TryParse(txtTotal.Text, out total);
                if (txtName.Text == string.Empty)
                {
                    MessageBox.Show("الرجاء ادخال اسم الزبون");
                }
                else if (txtAmountReceived.Text == string.Empty)
                {
                    MessageBox.Show("الرجاء ادخال المبلغ الواصل");
                }
                else if ((totalMoney - rAmount) == 0) // If the invoice is paid
                {

                    //insert the informations of invoive
                    ord.add_order(Convert.ToInt32(txtCusID.Text), txtID.Text, "", Convert.ToDouble(txtTotal.Text),
                        Convert.ToDouble(0), "YES");

                    //insert the detiles of invoive
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {


                        ord.add_order_detail(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(txtID.Text)
                            , Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value)
                            , Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value)
                           );

                    }

                    if (MessageBox.Show("تم الحفظ بنجاح هل تريد طباعة الفاتورة ", "الطباعه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                    }

                }
                //if there are debt 
                else if ((totalMoney - rAmount) > 1)
                {
                    //insert the informations of invoive
                    ord.add_order(Convert.ToInt32(txtCusID.Text), txtID.Text, "", Convert.ToDouble(txtTotal.Text),
                        Convert.ToDouble(0), "NO");

                    //insert the detiles of invoive
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {


                        ord.add_order_detail(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(txtID.Text)
                            , Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value)
                            , Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value)
                           );

                    }

                    BL.debtClass debt = new BL.debtClass();
                    debt.add_debt_detail(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtCusID.Text)
                        , Convert.ToDouble(totalMoney - rAmount));


                    if (MessageBox.Show("تم حفظ الفاتورة و الدين هل تريد طباعة الفاتورة", "الطباعه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtMatNo.Text)
                        {
                            MessageBox.Show("هذا المنتج موجود مسبقاً", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                DataRow r = dt.NewRow();

                string Priceformatted = string.Format("{0:n0}", Convert.ToDouble(txtMatPrice.Text));

                r[0] = txtMatNo.Text;
                r[1] = txtMatName.Text;
                r[2] = Priceformatted;
                r[3] = txtQte.Text;
                r[4] = txtAmount.Text;
                dt.Rows.Add(r);

                dataGridView1.DataSource = dt;
                clearBoxes();

                string totalamount = (from DataGridViewRow row in dataGridView1.Rows
                                      where row.Cells[4].FormattedValue.ToString() != string.Empty
                                      select (Convert.ToDouble(row.Cells[4].FormattedValue))).Sum().ToString();

                txtTotal.Text = String.Format("{0:n0}", Convert.ToInt32(totalamount));
                totalMoney = Convert.ToInt32(totalamount);


            }

        }

        private void txtMatPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQte_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
        }

        private void txtMatPrice_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtMatNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMatName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtQte.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtMatPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                txtQte.Focus();
                calculateAmount();
            }
            catch
            {
                return;
            }
        }




        private void txtTotal_Leave(object sender, EventArgs e)
        {
            if (txtTotal.Text.Length == 0)
            {
                txtTotal.Text = "المبلغ الكلي";
                txtTotal.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            if (txtTotal.Text == "المبلغ الكلي")
            {
                txtTotal.Text = "";
                txtTotal.ForeColor = SystemColors.WindowText;
            }
        }


        private void txtAmountReceived_Leave(object sender, EventArgs e)
        {
            if (txtAmountReceived.Text.Length == 0)
            {
                txtAmountReceived.Text = "المبلغ الواصل";
                txtAmountReceived.ForeColor = SystemColors.GrayText;
            }

        }

        private void txtAmountReceived_Enter(object sender, EventArgs e)
        {
            if (txtAmountReceived.Text == "المبلغ الواصل")
            {
                txtAmountReceived.Text = "";
                txtAmountReceived.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtAmountReceived_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAmountReceived.Text.Equals("المبلغ الواصل"))
                {
                    return;
                }
                else if (txtAmountReceived.Text.Equals(""))
                {
                    return;
                }
                else
                {
                    

                    int rRec; int.TryParse(txtAmountReceived.Text, out rRec);
                    int rReam = (totalMoney - rRec);
                    txtReamining.Text =Convert.ToString(rReam);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n Error in Text changed");
            }
        }
    }
}
