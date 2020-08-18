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
using MySql.Data.MySqlClient;
using DevExpress.XtraTab;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Control;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System.IO;
//using Document = iTextSharp.text.Document;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing.Imaging;
using DevExpress.XtraRichEdit;
//using DevExpress.Pdf;
//using DevExpress.Pdf;

namespace GBM_Dashboard
{
    public partial class Dashboard_Tab : UserControl
    {
        ScreenCapture capScreen = new ScreenCapture();

        public static int id = -1;
        public Dashboard_Tab()
        {
            InitializeComponent();
        }
        
        private void Dashboard_Tab_Load(object sender, EventArgs e)
        {
            DbConnection dbCon = new DbConnection();
            string connetionString = dbCon.getConnection();
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            string query_to_get_app_tab = "SELECT ID,configuration_description_fld FROM dashboard.configuration_type_tbl; ";
            cmd = new MySqlCommand(query_to_get_app_tab, cnn);
            row = cmd.ExecuteReader();
            
            List<string> app_name = new List<string>();
            List<int> app_id = new List<int>();

            while (row.Read())
            {
                app_name.Add(row["configuration_description_fld"].ToString());
                app_id.Add(Convert.ToInt32(row["ID"]));
            }
            row.Close();

            XtraTabPage[] xtraTabPages = new XtraTabPage[app_name.Count];
            Button[] button = new Button[app_name.Count];
            for (int i = 0; i < app_name.Count; i++)
            {
                if (i == 0)
                {
                   id = app_id[i];
                }
                button[i] = new Button();
                button[i].Size = new System.Drawing.Size(100, 45);
                button[i].Dock = DockStyle.Top;
                button[i].Tag = app_id[i];
                button[i].Name = app_name[i].ToString();
                button[i].Text = app_name[i].ToString();
                flowLayoutPanel1.Controls.Add(button[i]);
                button[i].Click += new EventHandler(this.button_click);
            }
            this.Refresh();
            dashboardViewer1.ReloadDataAsync();
            dashboardViewer1.Refresh();
            dashboardViewer1.Update();
            button_tab();
        }

        private void button_tab()
        {
            DbConnection dbCon = new DbConnection();
            string connetionString = dbCon.getConnection();
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();
        
            string query_to_get_app_tab = "SELECT * FROM dashboard.barchart_view where app_id = " + id + "; ";
            cmd = new MySqlCommand(query_to_get_app_tab, cnn);
            row = cmd.ExecuteReader();

            while (row.Read())
            {
               int temp3 = Convert.ToInt32(row["c_0_3"]);
               int temp6 = Convert.ToInt32(row["c_4_6"]);
               int temp9 = Convert.ToInt32(row["c_7_9"]);
               int temp12 = Convert.ToInt32(row["c_10_12"]);
               int temp24 = Convert.ToInt32(row["c_13_24"]);
               int total = temp3 + temp6 + temp9 + temp12 + temp24;

               lbl3hrs.Text = temp3.ToString();
               lbl6hrs.Text = temp6.ToString();
               lbl9hrs.Text = temp9.ToString();
               lbl12hrs.Text = temp12.ToString();
               lbl24hrs.Text = temp24.ToString();
               lbl_total.Text = total.ToString();
            }
            row.Close();
        }

        private void button_click(object sender, EventArgs e)
        {
            id = Convert.ToInt32((sender as Button).Tag);
            dashboardViewer1.ReloadDataAsync();
            button_tab();
        }

        private void dashboardViewer1_CustomParameters(object sender, DevExpress.DashboardCommon.CustomParametersEventArgs e)
        {
            e.Parameters[0].Value = id;
        }

        Bitmap bmp;


        private void captureScreen()
        {
            try
            {
                // Call the CaptureAndSave method from the ScreenCapture class 
                // And create a temporary file in C:\Temp
                capScreen.CaptureAndSave(@"C:\Temp\test.png", CaptureMode.Window, ImageFormat.Png);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            captureScreen();
            using (RichEditDocumentServer server = new RichEditDocumentServer())
            {
                DevExpress.XtraRichEdit.API.Native.DocumentImage docImage = server.Document.Images.Append(DevExpress.XtraRichEdit.API.Native.DocumentImageSource.FromFile(@"C:\Temp\test.png"));
                server.Document.Sections[0].Page.Width = docImage.Size.Width + server.Document.Sections[0].Margins.Right + server.Document.Sections[0].Margins.Left;
                server.Document.Sections[0].Page.Height = docImage.Size.Height + server.Document.Sections[0].Margins.Top + server.Document.Sections[0].Margins.Bottom;
           
                // Displays a SaveFileDialog so the user can save the PDF
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF File|*.pdf";
                saveFileDialog1.Title = "Save PDF";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    server.ExportToPdf(fs);
                    MessageBox.Show("File Saved Successfully !!!");
                }
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}