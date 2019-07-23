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
    public partial class Companies : Form
    {
        BL.CompaniesClass comp = new BL.CompaniesClass();
        public Companies()
        {
            InitializeComponent();
            this.dataGridView1.DataSource= comp.fetchCompanyNames();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            PL.insCompanies frm = new insCompanies();
            frm.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            PL.CompanyProfile frm = new CompanyProfile();
            
            frm.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            

            BL.debtClass dbt = new BL.debtClass();
            try
            {
                frm.txtTotalDebt.Text = dbt.fetchCompaniesDebts(dataGridView1.CurrentRow.Cells[1].Value.ToString()).Rows[0][0].ToString();
            }
            catch 
            {
                
            }

            frm.ShowDialog();
        }

        private void Companies_Load(object sender, EventArgs e)
        {

        }
    }
}
