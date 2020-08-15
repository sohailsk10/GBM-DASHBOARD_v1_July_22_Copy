using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;


namespace GBM_Dashboard
{
    public partial class Home_New : DevExpress.XtraEditors.XtraUserControl
    {
        PictureBox picture = new PictureBox();
        AxWMPLib.AxWindowsMediaPlayer wmp_player = null;
       
        
        

        public Home_New()
        {
            InitializeComponent();

            picture.Visible = false;
            if (wmp_player != null)
            {
                //frame.ControlRemoved(wmp_player);
                wmp_player.uiMode = "invisible";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GBM_IVA gBM_IVA = new GBM_IVA();
            MainControlClass.showControl(gBM_IVA, Content);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void breadcrumb_container_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Home_New_Load(object sender, EventArgs e)
        {
            var gbm_iva_id = 0;
            //DbConnection dbCon = new DbConnection();
            //string connetionString = dbCon.getConnection();
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            //MessageBox.Show(connetionString);
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row, row2;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();
            //sites_CheckBox.Items.Add("SELECT ALL", true);
            //camera_checkbox.Items.Add("SELECT ALL", true);
            //videos_checkbox.Items.Add("SELECT ALL", true);

            string get_gbm_iva_id = "SELECT ID FROM gbm_iva where Name = '" + GBM_IVA.Form2 + "';";
            //MessageBox.Show(get_gbm_iva_id);
            cmd = new MySqlCommand(get_gbm_iva_id, cnn);
            row = cmd.ExecuteReader();
            while (row.Read())
            {
                gbm_iva_id = Convert.ToInt32(row["ID"].ToString());
            }
            row.Close();

            string query = "SELECT * FROM configuration_type_tbl WHERE fk_gbm_iva_id = " + gbm_iva_id + " and active_fld = 1;";
            cmd = new MySqlCommand(query, cnn);
            row = cmd.ExecuteReader();
            var count_of_records = 0;
            var Sub_Cases = "";
            List<string> cases = new List<string>();
            List<string> images = new List<string>();
            List<int> config_type_id = new List<int>();

            while (row.Read())
            {
                string col1Value = row["configuration_description_fld"].ToString();
                cases.Add(col1Value);
                config_type_id.Add(Convert.ToInt32(row["ID"]));
                count_of_records += 1;
            }
            row.Close();

            var MainRow = 0;
            for (int j = 0; j < cases.Count; j++)
            {
                sub_Cases_CheckedComboBox.Properties.PopupFormSize = new Size(200, 200);
                Sub_Cases = sub_Cases_CheckedComboBox.Properties.Items.Add(cases[j]).ToString();

                List<int> conf_id = get_site_id(cases[j]);

                for (int k = 0; k < conf_id.Count; k++)
                {
                    List<string> conf_desc_list;
                    List<int> conf_id_list;

                    (conf_desc_list, conf_id_list) = get_sites_from_conf_id(conf_id[k]);

                    for (int a = 0; a < conf_id_list.Count; a++)
                    {
                        sites_CheckBox.Items.Add(conf_desc_list[a], true);
                    }

                    for (int l = 0; l < conf_id_list.Count; l++)
                    {
                        List<int> camera_id_list;
                        List<string> camera_ip_list, camera_port_list, camera_user_list, camera_pwd_list;
                        (camera_id_list, camera_ip_list, camera_port_list, camera_user_list, camera_pwd_list) = get_camera_from_site_id(conf_id_list[l]);

                        for (int b = 0; b < camera_ip_list.Count; b++)
                        {
                            camera_checkbox.Items.Add(camera_ip_list[b] + " - " + camera_port_list[b], true);
                        }

                        for (int m = 0; m < camera_id_list.Count; m++)
                        {
                            List<int> video_id_list;
                            List<string> video_name_list, video_path_list, video_datetime_list;
                            (video_id_list, video_name_list, video_path_list, video_datetime_list) = get_video_from_camera_id(camera_id_list[m]);

                            for (int n = 0; n < video_name_list.Count; n++)
                            {
                                videos_checkbox.Items.Add(video_name_list[n] + " - " + video_datetime_list[n], true);
                            }

                            for (int o = 0; o < video_id_list.Count; o++)
                            {
                                List<string> violation_video_path_list, violation_frame_path_list, violation_datetime_list;
                                List<int> violation_id_list;
                                (violation_id_list, violation_video_path_list, violation_frame_path_list, violation_datetime_list) = get_violation_from_video_id(camera_id_list[o]);

                                SimpleButton[] label_violation = new SimpleButton[violation_video_path_list.Count * 3];
                                var srno = 1;

                                for (int x = 0; x < violation_video_path_list.Count; x++)
                                {
                                    for (int y = 0; y < 5; y++)
                                    {
                                        var rowValue = 1;
                                        var colValue = 0;
                                        label_violation[x] = new SimpleButton();
                                        label_violation[x].Dock = System.Windows.Forms.DockStyle.Top;
                                        //MessageBox.Show(rowValue.ToString() + "-" + x.ToString() + "-" + MainRow.ToString());

                                        if (y == 0)
                                        {
                                            label_violation[x].Name = violation_datetime_list[x];
                                            label_violation[x].TabIndex = rowValue + x + y;
                                            label_violation[x].Text = violation_datetime_list[x];
                                            this.violation_tablePanel.SetColumn(label_violation[x], colValue + y + 1);
                                            this.violation_tablePanel.SetRow(label_violation[x], rowValue + x + MainRow);
                                        }           //time-stamp
                                        else if (y == 1)
                                        {
                                            label_violation[x].Name = violation_id_list[x].ToString();
                                            label_violation[x].TabIndex = rowValue + x + y;
                                            label_violation[x].Text = violation_id_list[x].ToString();
                                            //label_violation[x].Click += new EventHandler(this.show_frame);
                                            this.violation_tablePanel.SetColumn(label_violation[x], colValue + y + 1);
                                            this.violation_tablePanel.SetRow(label_violation[x], rowValue + x + MainRow);
                                        }       //violation-id
                                        else if (y == 2)
                                        {
                                            label_violation[x].Name = violation_frame_path_list[x];
                                            label_violation[x].TabIndex = rowValue + y + x;
                                            label_violation[x].Text = violation_frame_path_list[x];
                                            //label_violation[x].Click += new EventHandler(this.play_video);
                                            this.violation_tablePanel.SetColumn(label_violation[x], colValue + y + 1);
                                            this.violation_tablePanel.SetRow(label_violation[x], rowValue + x + MainRow);
                                            label_violation[x].Click += new EventHandler(this.show_frame);
                                        }       // violation-image
                                        else if (y == 3)
                                        {
                                            label_violation[x].Name = violation_video_path_list[x].ToString();
                                            label_violation[x].TabIndex = rowValue + y + x;
                                            label_violation[x].Text = violation_video_path_list[x].ToString();
                                            this.violation_tablePanel.SetColumn(label_violation[x], colValue + y + 1);
                                            this.violation_tablePanel.SetRow(label_violation[x], rowValue + x + MainRow);
                                            label_violation[x].Click += new EventHandler(this.play_video);
                                        }       //violation-video
                                        else if (y == 4)
                                        {
                                            label_violation[x].Name = "action" + srno.ToString();
                                            label_violation[x].TabIndex = rowValue + y + x;
                                            label_violation[x].Text = "Actions";
                                            this.violation_tablePanel.SetColumn(label_violation[x], colValue + y + 1);
                                            this.violation_tablePanel.SetRow(label_violation[x], rowValue + x + MainRow);
                                        }       //violation-action-btn
                                        this.violation_tablePanel.Controls.Add(label_violation[x]);
                                    }
                                    this.violation_tablePanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
                                        new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 42F),
                                        new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
                                    MainRow += 1;
                                    srno += 1;
                                }
                            }
                        }
                    }
                }


            }
        }

        private void play_video(object sender, EventArgs e)
        {
            this.picture.Visible = false;


            try
            {
                // wmp_player = new AxWMPLib.AxWindowsMediaPlayer();

                ((System.ComponentModel.ISupportInitialize)(wmp_player)).BeginInit();
                wmp_player.Name = "wmPlayer";
                wmp_player.Enabled = true;
                wmp_player.Dock = System.Windows.Forms.DockStyle.Fill;
                frame.Controls.Add(wmp_player);
                ((System.ComponentModel.ISupportInitialize)(wmp_player)).EndInit();

                // After initialization you can customize the Media Player
                wmp_player.uiMode = "full";
                wmp_player.URL = (sender as SimpleButton).Text.ToString();
                wmp_player.Ctlcontrols.play();
                wmp_player.settings.setMode("loop", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }

        }

        private void show_frame(object sender, EventArgs e)
        {
            this.frame.Visible = true;
            //this.wmp_video.Visible = false;
            frame.Controls.Remove(wmp_player);
            wmp_player = null;
            this.frame.Controls.Clear();
            var image_path = (sender as SimpleButton).Text.ToString();
            picture = new PictureBox
            {
                Name = "show_frame_path",
                Image = Image.FromFile(image_path),
                Location = new Point(1, 391),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill,
            };
            this.frame.Controls.Add(picture);
        }

        private (List<int> violation_id_list, List<string> violation_video_path_list, List<string> violation_frame_path_list, List<string> violation_datetime_list) get_violation_from_video_id(int video_id)
        {
            //DbConnection dbCon = new DbConnection();
            //string connetionString = dbCon.getConnection();
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            string get_violations_query = "SELECT * FROM violation_tbl WHERE fk_video_id = '" + video_id + "';";
            cmd = new MySqlCommand(get_violations_query, cnn);
            row = cmd.ExecuteReader();

            List<int> violation_id_list = new List<int>();
            List<string> violation_video_path_list = new List<string>();
            List<string> violation_frame_path_list = new List<string>();
            List<string> violation_datetime_list = new List<string>();

            while (row.Read())
            {
                violation_id_list.Add(Convert.ToInt32(row["ID"]));
                violation_video_path_list.Add(row["violation_video_path_fld"].ToString());
                violation_frame_path_list.Add(row["violation_frame_path_fld"].ToString());
                violation_datetime_list.Add(row["violation_datetime_fld"].ToString());
            }
            row.Close();
            cnn.Close();
            return (violation_id_list, violation_video_path_list, violation_frame_path_list, violation_datetime_list);
        }

        private (List<int> video_id_list, List<string> video_name_list, List<string> video_path_list, List<string> video_datetime_list) get_video_from_camera_id(int camera_id)
        {
            //DbConnection dbCon = new DbConnection();
            //string connetionString = dbCon.getConnection();
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            string get_videos_query = "SELECT * FROM videos WHERE camera_config_id = '" + camera_id + "';";
            cmd = new MySqlCommand(get_videos_query, cnn);
            row = cmd.ExecuteReader();

            List<int> video_id_list = new List<int>();
            List<string> video_name_list = new List<string>();
            List<string> video_path_list = new List<string>();
            List<string> video_datetime_list = new List<string>();

            while (row.Read())
            {
                video_id_list.Add(Convert.ToInt32(row["Id"]));
                video_name_list.Add(row["video_name_fld"].ToString());
                video_path_list.Add(row["video_path_fld"].ToString());
                video_datetime_list.Add(row["video_datetime_fld"].ToString());
            }
            row.Close();
            cnn.Close();
            return (video_id_list, video_name_list, video_path_list, video_datetime_list);
        }

        private List<int> get_site_id(string applicationName)
        {
            //DbConnection dbCon = new DbConnection();
            //string connetionString = dbCon.getConnection();
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            string get_conf_id_query = "SELECT ID FROM configuration_type_tbl WHERE configuration_description_fld = '" + applicationName + "';";
            cmd = new MySqlCommand(get_conf_id_query, cnn);
            row = cmd.ExecuteReader();

            List<int> conf_id = new List<int>();
            while (row.Read())
            {
                conf_id.Add(Convert.ToInt32(row["ID"]));
            }
            row.Close();
            cnn.Close();
            return conf_id;
        }

        private (List<string>, List<int>) get_sites_from_conf_id(int conf_id)
        {
            //DbConnection dbCon = new DbConnection();
            //string connetionString = dbCon.getConnection();
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            string get_sites_query = "SELECT * FROM configuration_tbl WHERE config_type_id = '" + conf_id + "';";
            cmd = new MySqlCommand(get_sites_query, cnn);
            row = cmd.ExecuteReader();

            List<string> conf_desc_list = new List<string>();
            List<int> conf_id_list = new List<int>();
            while (row.Read())
            {
                conf_desc_list.Add(row["configuaration_description_fld"].ToString());
                conf_id_list.Add(Convert.ToInt32(row["ID"]));
            }
            row.Close();
            cnn.Close();
            return (conf_desc_list, conf_id_list);
        }

        private (List<int>, List<string>, List<string>, List<string>, List<string>) get_camera_from_site_id(int site_id)
        {
            // DbConnection dbCon = new DbConnection();
            //string connetionString = dbCon.getConnection();
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            string get_cameras_query = "SELECT * FROM camera_configuration_tbl WHERE config_id_fld = '" + site_id + "';";
            cmd = new MySqlCommand(get_cameras_query, cnn);
            row = cmd.ExecuteReader();

            List<int> camera_id_list = new List<int>();
            List<string> camera_ip_list = new List<string>();
            List<string> camera_port_list = new List<string>();
            List<string> camera_user_list = new List<string>();
            List<string> camera_pwd_list = new List<string>();

            while (row.Read())
            {
                camera_id_list.Add(Convert.ToInt32(row["ID"]));
                camera_ip_list.Add(row["camera_ip_fid"].ToString());
                camera_port_list.Add(row["camera_port_no_fid"].ToString());
                camera_user_list.Add(row["camera_user_id"].ToString());
                camera_pwd_list.Add(row["camera_password_fid"].ToString());
            }
            row.Close();
            cnn.Close();
            return (camera_id_list, camera_ip_list, camera_port_list, camera_user_list, camera_pwd_list);
        }

 

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < sites_CheckBox.Items.Count; i++)
            {
                if (checkBox2.Checked == true)
                {
                    sites_CheckBox.SetItemChecked(i, true);
                }
                else
                {
                    sites_CheckBox.SetItemChecked(i, false);
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < camera_checkbox.Items.Count; i++)
            {
                if (checkBox3.Checked == true)
                {
                    camera_checkbox.SetItemChecked(i, true);
                }
                else
                {
                    camera_checkbox.SetItemChecked(i, false);
                }
            }

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < videos_checkbox.Items.Count; i++)
            {
                if (checkBox1.Checked == true)
                {
                    videos_checkbox.SetItemChecked(i, true);
                }
                else
                {
                    videos_checkbox.SetItemChecked(i, false);
                }
            }
        }
    }
}
