using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GBM_Dashboard
{
    public partial class Tab : DevExpress.XtraEditors.XtraForm
    {
        public Tab()
        {
            InitializeComponent();
        }

        private void xtraTabControl1_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {

        }

        private void xtraTabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XtraForm4 xtraForm4 = new XtraForm4();
            //xtraForm4.Show();
            panel1.Controls.Add(xtraForm4);
        }
    }
}