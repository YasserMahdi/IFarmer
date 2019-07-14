﻿using System;
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
    public partial class insSeedsAndMaterial : Form
    {
        BL.SeedsAndMaterialClass sam = new BL.SeedsAndMaterialClass();
        public insSeedsAndMaterial()
        {
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCatSave_Click(object sender, EventArgs e)
        {
            try
            {
                sam.insertCat(txtCatName.Text);
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntMatSave_Click(object sender, EventArgs e)
        {
            try
            {
                sam.insertMtr(txtCatName.Text,Convert.ToDouble( txtBprice.Text),Convert.ToDouble(
                txtSprice.Text),Convert.ToInt32( txtQte.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
