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

            if (MessageBox.Show("هل تريد طباعة الفاتورة", "الطباعه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

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
                catch(Exception ex)
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
    }
}
