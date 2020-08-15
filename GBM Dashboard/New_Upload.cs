using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraGrid;
using DevExpress.Xpo.DB.Helpers;
using System.Threading;

namespace GBM_Dashboard
{


    public partial class New_Upload : UserControl
    {
        DbConnection dbCon = new DbConnection();
        string connetionString = null;
        MySqlConnection con = null;
        MySqlDataAdapter mda;
        MySqlCommand cmd = null;
        private string video_name;
        private System.Windows.Forms.Timer timer1;

        List<int> applist = new List<int>();
        List<int> sitelist = new List<int>();
        List<string> videolist = new List<string>();
        List<string> video_list_under_process = new List<string>();
        List<int> cameralist = new List<int>();
        ProgressBar[] p_bars;
        Label[] labels;
        
        public New_Upload()
        {
            InitializeComponent();
        }
        private void New_Upload_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet1.videos_list_tbl' table. You can move, or remove it, as needed.
            this.videos_list_tblTableAdapter.Fill(this.dashboardDataSet1.videos_list_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.camera_configuration_tbl' table. You can move, or remove it, as needed.
            this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.configuration_tbl' table. You can move, or remove it, as needed.
            this.configuration_tblTableAdapter.Fill(this.dashboardDataSet.configuration_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.configuration_type_tbl' table. You can move, or remove it, as needed.
            this.configuration_type_tblTableAdapter.Fill(this.dashboardDataSet.configuration_type_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.videos' table. You can move, or remove it, as needed.
            // this.videosTableAdapter.Fill(this.dashboardDataSet.videos);
            // TODO: This line of code loads data into the 'dashboardDataSet.camera_configuration_tbl' table. You can move, or remove it, as needed.
            this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.configuration_tbl' table. You can move, or remove it, as needed.
            this.configuration_tblTableAdapter.Fill(this.dashboardDataSet.configuration_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.configuration_type_tbl' table. You can move, or remove it, as needed.
            this.configuration_type_tblTableAdapter.Fill(this.dashboardDataSet.configuration_type_tbl);
            /*gridView1.SelectAll();
            gridView2.SelectAll();
            gridView3.SelectAll();*/
       // }

            //progressBarControl1.Visible = false;
        }
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            string str_config_type_id = "";
            getlistofAppID();
            for (int i = 0; i < applist.Count; i++)
            {
                if (i == 0)
                {
                    str_config_type_id = applist[i].ToString();
                }
                else
                {
                    str_config_type_id = str_config_type_id + ", " + applist[i].ToString();
                }
            }

            //  MessageBox.Show(str_config_type_id);
            ColumnView view = gridView2;
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["config_type_id"]);
            }
            view.ActiveFilter.Add(view.Columns["config_type_id"],
              new ColumnFilterInfo("[config_type_id] in (" + str_config_type_id + ")", ""));
        }
        private void getlistofAppID()
        {
            ArrayList rows = new ArrayList();
            applist.Clear();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            //applist = new List<string>(selectedRowHandles.Length);
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
                DataRow row = rows[i] as DataRow;
                applist.Add((int)row[0]);
                //applist.Add(gridView1.GetRowCellValue(selectedRowHandle, "configuration_description_fld").ToString());
            }
        }
        private void getlistofSiteID()
        {
            ArrayList rows = new ArrayList();
            sitelist.Clear();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView2.GetSelectedRows();
            //sitelist = new List<string>(selectedRowHandles.Length);
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView2.GetDataRow(selectedRowHandle));
                //sitelist.Add(gridView2.GetRowCellValue(selectedRowHandle, "configuaration_description_fld").ToString());
                DataRow row = rows[i] as DataRow;
                sitelist.Add((int)row[0]);
            }
        }
        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            string str_config_id = "";
            getlistofSiteID();
            for (int i = 0; i < sitelist.Count; i++)
            {
                if (i == 0)
                {
                    str_config_id = sitelist[i].ToString();

                }
                else
                {
                    str_config_id = str_config_id + ", " + sitelist[i].ToString();
                }

            }
            
            ColumnView view = gridView3;
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["config_id_fld"]);
            }
            view.ActiveFilter.Add(view.Columns["config_id_fld"],
              new ColumnFilterInfo("[config_id_fld] in (" + str_config_id + ")", ""));

        }
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            //delete every row from temp table 

            DbConnection dbCon = new DbConnection();
            string connetionString = dbCon.getConnection();
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlCommand cmd = new MySqlCommand();
            string query = "truncate TABLE videos_list_tbl";
            cnn.Open();
            MySqlCommand cmdDelete = new MySqlCommand(query, cnn);
            cmdDelete.ExecuteNonQuery();
            cnn.Close();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var files = "";
                string[] fileArrayMp4 = Directory.GetFiles(folderBrowserDialog1.SelectedPath + "\\", "*.mp4");
                string[] fileArrayAvi = Directory.GetFiles(folderBrowserDialog1.SelectedPath + "\\", "*.avi");
                for (int i = 0; i < fileArrayMp4.Length; i++)
                {
                    //database entry
                    cnn.Open();
                    string temp = fileArrayMp4[i].Replace("\\", "\\\\");
                    string query_to_insert = "INSERT INTO videos_list_tbl VALUES('" + temp + "', '', '', '');";
                    cmd = new MySqlCommand(query_to_insert, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    //files = files + fileArrayMp4[i] + Environment.NewLine;
                }
                for (int i = 0; i < fileArrayAvi.Length; i++)
                {
                    cnn.Open();
                    string temp = fileArrayAvi[i].Replace("\\", "\\\\");
                    //MessageBox.Show(fileArrayAvi[i]);
                    //MessageBox.Show(temp);
                    string query_to_insert = "INSERT INTO videos_list_tbl VALUES('" + temp + "', '', '', '');";
                    //MessageBox.Show(query_to_insert);
                    cmd = new MySqlCommand(query_to_insert, cnn);
                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteReader();
                    //MessageBox.Show("inserted");
                    cnn.Close();
                    //files = files + fileArrayAvi[i] + Environment.NewLine;
                }

                this.dashboardDataSet1.DataSetName = "dashboardDataSet1";
                this.dashboardDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                this.videoslisttblBindingSource.DataMember = "videos_list_tbl";
                this.videoslisttblBindingSource.DataSource = this.dashboardDataSet1;
                this.gridControl4.DataSource = this.videoslisttblBindingSource;
                this.gridView4.GridControl = this.gridControl4;

                this.Validate();
                this.videos_list_tblTableAdapter.ClearBeforeFill = true;
                this.videos_list_tblTableAdapter.Update(this.dashboardDataSet1.videos_list_tbl);
                this.videos_list_tblTableAdapter.Fill(this.dashboardDataSet1.videos_list_tbl);
                this.videos_list_tblTableAdapter.GetData();
                this.dashboardDataSet.videos_list_tbl.AcceptChanges();
                this.videos_list_tblTableAdapter.Fill(this.dashboardDataSet1.videos_list_tbl);
            }
        }
        private void gridView4_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            getSelectedVideo();
            string str_video_path = "";
            for (int i = 0; i < videolist.Count; i++)
            {
                if (i == 0)
                {
                    str_video_path = videolist[i].ToString();
                }
                else
                {
                    str_video_path = str_video_path + ", " + videolist[i].ToString();
                }
            }
        }
        private void getSelectedVideo()
        {
            ArrayList rows = new ArrayList();
            videolist.Clear();
            Int32[] selectedRowHandles = gridView4.GetSelectedRows();
            videolist = new List<string>(selectedRowHandles.Length);
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView4.GetDataRow(selectedRowHandle));
                //rows.Add(gridView4.GetDataRow(selectedRowHandle));
                //rows.Add(gridView4.GetRowCellValue(i, "video_name_fid").ToString());
                //DataRow row = rows[i] as DataRow;
                videolist.Add(gridView4.GetRowCellValue(selectedRowHandle, "video_name_fld").ToString());
                // gridView4.GetRowCellValue(selectedRowHandle, 0);
                // MessageBox.Show(gridView4.GetRowCellValue(selectedRowHandle, "video_name_fld").ToString());
            }
        }
        private void getSelectedCamera()
        {
            ArrayList rows = new ArrayList();
            cameralist.Clear();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView3.GetSelectedRows();
            //cameralist = new List<string>(selectedRowHandles.Length);
            //applist = new List<string>(selectedRowHandles.Length);
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView3.GetDataRow(selectedRowHandle));
                //cameralist.Add(gridView3.GetRowCellValue(selectedRowHandle, "camera_ip_fid").ToString());
                DataRow row = rows[i] as DataRow;
                cameralist.Add((int)row[0]);
            }
        }
        private void btnProcess_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < videolist.Count; i++)
            {
                string video_name = videolist[i];
                Object[] add_New_Row = new Object[4];
                add_New_Row[0] = video_name;
                for (int j = 0; j < applist.Count; j++)
                {
                    add_New_Row[1] = applist[j];
                    add_New_Row[2] = sitelist[0];
                    add_New_Row[3] = cameralist[0];
                    dataGridView1.Rows.Add(add_New_Row);
                }

            }
        }
        private void gridView3_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            string str_camera_config_id = "";

            getSelectedCamera();
            for (int i = 0; i < cameralist.Count; i++)
            {
                if (i == 0)
                {
                    str_camera_config_id = cameralist[i].ToString();
                }
                else
                {
                    str_camera_config_id = str_camera_config_id + ", " + cameralist[i].ToString();
                }
            }
        }
        public int getStatus(string video_name)
        {
            int process_status = 0;
            DbConnection dbCon = new DbConnection();
            string connetionString = dbCon.getConnection();
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader row;
            cnn.Open(); 
            string process_status_query = "SELECT process_status FROM common_script where video_name='" + video_name + "'";
            cmd = new MySqlCommand(process_status_query, cnn);
            row = cmd.ExecuteReader();
            while (row.Read())
            {
                process_status = Convert.ToInt32(row["process_status"]);
            }
            cnn.Close();
            
            return process_status;
        }
        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000; // in miliseconds
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < video_list_under_process.Count; i++)
            {
                int ps = getStatus(video_list_under_process[i]);
                if (ps != 0)
                {
                    p_bars[i].Style = ProgressBarStyle.Continuous;
                    p_bars[i].MarqueeAnimationSpeed = 0;
                    labels[i].Text = video_list_under_process[i] + " Completed";
                }

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DbConnection dbCon = new DbConnection();
            string connetionString = dbCon.getConnection();
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd1 = new MySqlCommand();
            MySqlDataReader row1;
            int row_count = dataGridView1.RowCount - 1;
            video_list_under_process.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row_count == 0)
                {
                    dataGridView1.Rows.Clear();
                    gridView4.ClearSelection();
                }
                else
                {
                    video_name = row.Cells["video_list"].Value.ToString().Replace("\\","\\\\");
                    string usecase = row.Cells["ApplicationList"].Value.ToString();
                    string site = row.Cells["Site"].Value.ToString();
                    string camera = row.Cells["Camera"].Value.ToString();
                    string video_insert = "INSERT INTO common_script(video_name, usecase_id, camera_id, site_id, update_status, process_status) VALUES('" + video_name + "'," + usecase + "," + camera + "," + site + ", 1, 0)";
                    cnn.Open();
                    cmd = new MySqlCommand(video_insert, cnn);
                    cmd.ExecuteReader();
                    cnn.Close();
                    row_count -= 1;
                    video_list_under_process.Add(video_name);
                }
            }

            p_bars = new ProgressBar[video_list_under_process.Count];
            labels = new Label[video_list_under_process.Count];
            for (int i = 0; i < video_list_under_process.Count; i++)
            {
                labels[i] = new Label();
                labels[i].Name = video_list_under_process[i];
                //labels[i].Text = video_list_under_process[i] + " is under process.";
                labels[i].Height = 30;
                labels[i].AutoSize = true;
                labels[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labels[i].Width = 100;
                labels[i].Text = video_list_under_process[i] + " is under process.";
                label_flow_layout.Controls.Add(labels[i]);

                p_bars[i] = new ProgressBar();
                p_bars[i].Location = new System.Drawing.Point(0, 0);
                p_bars[i].Name = video_list_under_process[i];
                p_bars[i].Width = 300;
                p_bars[i].Height = 15;
                p_bars[i].Value = 100;
                p_bars[i].TabIndex = i;
                p_bars[i].Style = ProgressBarStyle.Marquee;
                p_bars[i].MarqueeAnimationSpeed = 70;
                flowLayoutPanel1.Controls.Add(p_bars[i]);
            }
            InitTimer();
            //int ps = getStatus(video_name);
            //if (ps != 0)
            //{
            //    flowLayoutPanel1.Controls.Remove();
            //    //p_bars[i].Style = ProgressBarStyle.Marquee;
            ////    p_bars[i].MarqueeAnimationSpeed = 80;
            //}

            //progress_label();
            //getStatus(video_name);
            //int ps = getStatus(video_name);
            //if (ps == 0)
            //{
            //    p_bars[i].Style = ProgressBarStyle.Marquee;
            //    p_bars[i].MarqueeAnimationSpeed = 80;
            //}
            //else
            //{

            //}

            // to clear selection after save
            gridView4.ClearSelection();
            gridView1.ClearSelection();
            gridView2.ClearSelection();
            gridView3.ClearSelection();
            //  videolist.Clear();
            //Make Thread 
            //bool loop = false;
            //do
            //{
                
            //    if ((flowLayoutPanel1.Controls.Count == 0) && (label_flow_layout.Controls.Count == 0))
            //    {
            //        loop = true;
            //    }
            //} while (!loop);
            //progressThread(video_name);
            //getStatus(video_name);

        }
        private void progressThread(string video_name)
        {
            //progress_label();
            //timerThread = new Thread(() => getStatus(video_name));
            //timerThread.IsBackground = true;
            //timerThread.Start();
            //for (int i = 0; i < video_list_under_process.Count; i++)
            //{
            //    int ps = getStatus(video_list_under_process[i]);
            //    if (ps == 0)
            //    {
            //        if (p_bars[i].Value >= 100)
            //        {
            //            p_bars[i].Value = 0;
            //        }
            //        p_bars[i].Value += 1;
            //    }
            //    else
            //    {
            //        if (p_bars[i].Name == video_list_under_process[i])
            //        {
            //            flowLayoutPanel1.Controls.Remove(p_bars[i]);
            //        }
            //        //loop = true;
            //    }
            //}
        }
        private void btnUnselect_Click(object sender, EventArgs e)
        {
            gridView4.ClearSelection();
            gridView1.ClearSelection();
            gridView2.ClearSelection();
            gridView3.ClearSelection();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }
    }
}

