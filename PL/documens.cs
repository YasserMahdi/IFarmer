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
    public partial class documens : Form
    {


        void clearBoxes()
        {
            txtMatNo.Clear();
            txtMatName.Clear();
            txtMatPrice.Clear();
            txtQte.Clear();
            txtAmount.Clear();
        }


        public documens()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.listCurrentSeasons frm = new listCurrentSeasons();
            frm.ShowDialog();
            this.txtSeasonName.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
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

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
