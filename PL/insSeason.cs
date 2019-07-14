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
    public partial class insSeason : Form
    {
        BL.Seasons son = new BL.Seasons();
        public insSeason()
        {
            InitializeComponent();
        }

        private void insSeason_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            son.insSeasons(txtNameSeason.Text,Convert.ToDateTime( dateTimePicker1.Text),Convert.ToDateTime(
                dateTimePicker2.Text));
        }
    }
}
