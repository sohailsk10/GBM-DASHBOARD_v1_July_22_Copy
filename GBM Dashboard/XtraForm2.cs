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
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm2()
        {
            InitializeComponent();
        }

        private void dashboardViewer1_CustomParameters(object sender, DevExpress.DashboardCommon.CustomParametersEventArgs e)
        {
            e.Parameters[0].Value = 12; //g_id
             //e.Parameters[1].Value = 15; //app_id
            /*            foreach(param in  e.para)
                        {
                            MessageBox.Show(e.Parameters[i].ToString());
                            e.Parameters.
                        }
            */
        }
    }
}