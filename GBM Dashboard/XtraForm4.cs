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
using DevExpress.XtraGrid.Columns;
using MySql.Data.MySqlClient;

namespace GBM_Dashboard
{
    public partial class XtraForm4 :XtraUserControl //DevExpress.XtraEditors.XtraUserControl
    {
        //string label6 = "";
        int int_gbm_iva_id = Dashboard_Tab.id;

        //int int_gbm_iva_id = 12;
        public XtraForm4()
        {
            InitializeComponent();
        }

        

        private void XtraForm4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet3.barchart_view' table. You can move, or remove it, as needed.
            this.barchart_viewTableAdapter1.Fill(this.dashboardDataSet3.barchart_view);
            // TODO: This line of code loads data into the 'dashboardDataSet2.barchart_view' table. You can move, or remove it, as needed.
            this.barchart_viewTableAdapter.Fill(this.dashboardDataSet2.barchart_view);
            //string label6 = "";
            DbConnection dbCon = new DbConnection();
            string connetionString = dbCon.getConnection();
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            /*string query_to_get_app_tab = "SELECT * FROM dashboard.barchart_view where app_id = " + Dashboard_Tab.id + "; ";
            //MessageBox.Show(query_to_get_app_tab);
            cmd = new MySqlCommand(query_to_get_app_tab, cnn);
            row = cmd.ExecuteReader();
            int temp3;
            int temp6;
            int temp9;
            int temp12;
            int temp24;
            int total;

            while (row.Read())
            {
                temp3 = Convert.ToInt32(row["c_0_3"]);
                temp6 = Convert.ToInt32(row["c_4_6"]);
                temp9 = Convert.ToInt32(row["c_7_9"]);
                temp12 = Convert.ToInt32(row["c_10_12"]);
                temp24 = Convert.ToInt32(row["c_13_24"]);
                total = temp3 + temp6 + temp9 + temp12 + temp24;
                MessageBox.Show(temp3.ToString() + temp6.ToString() + total.ToString());

                lbl3hrs.Text = temp3.ToString();
                lbl6hrs.Text = temp6.ToString();
                lbl9hrs.Text = temp9.ToString();
                lbl12hrs.Text = temp12.ToString();
                lbl24hrs.Text = temp24.ToString();
                lbl_total.Text = total.ToString();
            }
            row.Close();*/


            /* *//*foreach (GridColumn item in gridView1.Columns)
             {
                 if (item == gridView1.Columns["c_0_3"])
                 {
                     MessageBox.Show(item.ToString());
                     label6.Text = item.
                 }
             }*/

            //lbl3hrs.Text = this.colc_0_3
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            /*ColumnView view = gridView1;
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["c_0_3"]);
            }
            view.ActiveFilter.Add(view.Columns["config_type_id"],
              new ColumnFilterInfo("[fk_gbm_iva_id] = " + int_gbm_iva_id.ToString(), ""));*/
        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {

        }
        /*protected void GWCase_RowDataBound(object sender, GridViewRowEventArgs e)
{

   if (e.Row.DataItem != null)
   {
       Label5.Text = e.Row.Cells[1].Text;

   }
}*/

    }
}