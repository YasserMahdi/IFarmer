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
    }
}
