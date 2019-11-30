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
    public partial class listDocument : Form
    {
        BL.DocumentClass doc = new BL.DocumentClass();
        public listDocument()
        {
            InitializeComponent();
        }

        private void listDocument_Load(object sender, EventArgs e)
        {
            this.bunifuCustomDataGrid1.DataSource = doc.listDoc();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            this.bunifuCustomDataGrid1.DataSource = doc.searchinDoc(txtSearch.Text);
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            PL.showDoc frm = new showDoc();
            frm.docID = Convert.ToInt32(this.bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void bunifuCustomDataGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    ContextMenu m = new ContextMenu();
            //    m.MenuItems.Add(new MenuItem("فتح"));
            //    m.MenuItems.Add(new MenuItem("تعديل"));

            //    int currentMouseOverRow = bunifuCustomDataGrid1.HitTest(e.X, e.Y).RowIndex;

            //    if (currentMouseOverRow >= 0)
            //    {
            //        m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
            //    }

            //    m.Show(bunifuCustomDataGrid1, new Point(e.X, e.Y));

            //}
        }

 
    }
}
