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
    public partial class seedAndMaterialForm : Form
    {
        BL.categories cat = new BL.categories();
        BL.SeedsAndMaterialClass seed = new BL.SeedsAndMaterialClass();
        public seedAndMaterialForm()
        {
            InitializeComponent();
            this.bunifuCustomDataGrid1.DataSource = cat.getCategoriesInfo();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            PL.insSeedsAndMaterial frm = new insSeedsAndMaterial();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            PL.DisplayMaterials frm = new DisplayMaterials();
            try
            {
                string cheack = seed.BringSeedsByType
                        (this.bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString()).Rows[0][0].ToString();
                frm.bunifuCustomDataGrid1.DataSource =
                seed.BringSeedsByType(this.bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString());
                frm.ShowDialog();
            }
            catch {
                MessageBox.Show("لا يوجد شيئ");
            }
            

        }
    }
}
