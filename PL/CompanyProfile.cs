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
    public partial class CompanyProfile : Form
    {
        BL.CompaniesClass comp = new BL.CompaniesClass();

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

        void createColumns()
        {
            dt.Columns.Add("Column1");// اسم المادة
            dt.Columns.Add("Column2");//  qte
            dt.Columns.Add("Column3");// price
            dt.Columns.Add("Column4");// total amount


            this.bunifuCustomDataGrid1.DataSource = dt;
        }

        void clearBoxes()
        {

            txtMatName.Clear();
            txtMatPrice.Clear();
            txtQte.Clear();
            txtAmount.Clear();
        }

        public CompanyProfile()
        {
            InitializeComponent();
            createColumns();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CompanyProfile_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtOrderID.Text = comp.getIdForCompOrder().Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
               
                try
                {
                    for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count - 1; i++)
                    {
                        if (bunifuCustomDataGrid1.Rows[i].Cells[0].Value.ToString() == txtMatName.Text)
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



                r[0] = txtMatName.Text;
                r[1] = Priceformatted;
                r[2] = txtQte.Text;
                r[3] = txtAmount.Text;
                dt.Rows.Add(r);


                bunifuCustomDataGrid1.DataSource = dt;
                clearBoxes();



                string totalamount = (from DataGridViewRow row in bunifuCustomDataGrid1.Rows
                                      where row.Cells[3].FormattedValue.ToString() != string.Empty
                                      select (Convert.ToDouble(row.Cells[3].FormattedValue))).Sum().ToString();

                txtTotal.Text = String.Format("{0:n0}", Convert.ToInt32(totalamount));

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
    }
}
