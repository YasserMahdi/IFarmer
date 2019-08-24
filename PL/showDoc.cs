using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IFarmer.PL
{
    public partial class showDoc : Form
    {
        public int docID;
        BL.DocumentClass doc = new BL.DocumentClass();
        public showDoc()
        {
            InitializeComponent();
        }

        private void showDoc_Load(object sender, EventArgs e)
        {
            this.txtID.Text = doc.docHead(docID).Rows[0][0].ToString();
            this.txtName.Text = doc.docHead(docID).Rows[0][1].ToString();
            this.txtNote.Text = doc.docHead(docID).Rows[0][2].ToString();
            this.bunifuDatepicker1.Value = Convert.ToDateTime(doc.docHead(docID).Rows[0][3].ToString());
            this.txtTotal.Text = doc.docHead(docID).Rows[0][4].ToString();
            this.txtAmountReceived.Text = doc.docHead(docID).Rows[0][5].ToString();
            this.txtReamining.Text = doc.docHead(docID).Rows[0][6].ToString();
            this.txtSeasonID.Text = doc.docHead(docID).Rows[0][7].ToString();
            this.txtSeasonName.Text = doc.docHead(docID).Rows[0][8].ToString();
            this.dataGridView1.DataSource = doc.docTail(docID);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
