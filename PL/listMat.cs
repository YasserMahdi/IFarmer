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
    public partial class listMat : Form
    {
        BL.SeedsAndMaterialClass sam = new BL.SeedsAndMaterialClass();
        public listMat()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = sam.getMatirialInfo();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
