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
    public partial class Seasons : Form
    {
        BL.Seasons son = new BL.Seasons();
        public Seasons()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = son.fetchSeasonsNames();
        }

        private void btnAddSeason_Click(object sender, EventArgs e)
        {
            PL.insSeason frm = new insSeason();
            frm.ShowDialog();
        }
    }
}
