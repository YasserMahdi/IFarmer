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
    public partial class insCompanies : Form
    {
        public insCompanies()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            BL.CompaniesClass comp = new BL.CompaniesClass();
            comp.insCompanies(txtInsComp.Text);
        }
    }
}
