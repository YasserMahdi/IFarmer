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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            PL.seedAndMaterialForm frm = new seedAndMaterialForm();
            frm.ShowDialog();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            PL.customerForm frm = new customerForm();
            frm.ShowDialog();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void نسخToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void قصToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void بيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.DirSales frm = new DirSales();
            frm.ShowDialog();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            PL.DirSales frm = new DirSales();
            frm.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            PL.documens frm = new documens();
            frm.ShowDialog();
        }

        private void استعلامعنالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.categoriesQue frm = new categoriesQue();
            frm.ShowDialog();
        }

        private void عرضالشركاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Companies frm = new Companies();
            frm.ShowDialog();
        }

        private void المواسمToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.Seasons frm = new Seasons();
            frm.ShowDialog();
        }

        private void المواسمالحاليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.CurrentSeasons frm = new CurrentSeasons();
            frm.ShowDialog();
        }

        private void المواسمالمنتهيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FinishedSeasons frm = new FinishedSeasons();
            frm.ShowDialog();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            PL.Expenses frm = new Expenses();
            frm.ShowDialog();
        }
    }
}