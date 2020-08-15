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
using DevExpress.XtraGrid.Views.Base;

namespace GBM_Dashboard
{
    public partial class XtraForm3 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm3()
        {
            InitializeComponent();
        }
        int int_gbm_iva_id = 12;

        private void XtraForm3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet.gbm_iva_summary_view' table. You can move, or remove it, as needed.
            this.gbm_iva_summary_viewTableAdapter.Fill(this.dashboardDataSet.gbm_iva_summary_view);
            // TODO: This line of code loads data into the 'dashboardDataSet.violation_smilie_flag_view' table. You can move, or remove it, as needed.
            this.violation_smilie_flag_viewTableAdapter.Fill(this.dashboardDataSet.violation_smilie_flag_view);

        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            //ColumnView view = gridView1;
            //if (view.ActiveFilterString.Length > 0)
            //{
               // view.ActiveFilter.Remove(view.Columns["g_id"]);
            //}
            //view.ActiveFilter.Add(view.Columns["g_id"],
              //new DevExpress.XtraGrid.Columns.ColumnFilterInfo("[g_id] = " + int_gbm_iva_id.ToString(), ""));
        }
    }
}