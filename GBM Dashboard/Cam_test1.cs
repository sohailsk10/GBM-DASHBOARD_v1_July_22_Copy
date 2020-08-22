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
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using MySql.Data.MySqlClient;

namespace GBM_Dashboard
{
    public partial class Cam_test1 : DevExpress.XtraEditors.XtraForm
    {
        Socket socket = null;
        private Thread timerThread;
        string cam_id = "";
        public Cam_test1()
        {
            InitializeComponent();
        }

        string cams_id = Configuration.camera_id;
        string ip = "", port = "", user = "", pwd = "";

        private void Cam_test1_Load(object sender, EventArgs e)
        {
            DbConnection dbCon = new DbConnection();
            string connetionString = dbCon.getConnection();
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            string query_to_get_counts = "SELECT camera_ip_fid,camera_user_id,camera_password_fid,camera_port_no_fid FROM dashboard.camera_configuration_tbl where ID = " + cams_id.ToString() + ";";
            MessageBox.Show(query_to_get_counts);
            cmd = new MySqlCommand(query_to_get_counts, cnn);
            row = cmd.ExecuteReader();
            while (row.Read())
            {
                ip = row["camera_ip_fid"].ToString();
                user = row["camera_user_id"].ToString();
                pwd = row["camera_password_fid"].ToString();
                port = row["camera_port_no_fid"].ToString();
            }
            try
            {
                startThread(ip, user, pwd, port, cams_id.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void startThread(string ip, string user, string pwd, string port, string cams_id)
        {
            timerThread = new Thread(() => StartClient(ip, user, pwd, port, cams_id.ToString()));
            timerThread.IsBackground = true;
            timerThread.Start();
        }

        private void StartClient(string ip, string user, string pwd, string port, string cams_id)
        {
            byte[] bytes = new byte[9048];

            try
            {
                IPaddress ip_A = new IPaddress();
                string connect_ip = ip_A.getIpaddress();
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipaddr = IPAddress.Parse(connect_ip);
                IPEndPoint remoteEP = new IPEndPoint(ipaddr, 5006);
                socket = new Socket(ipaddr.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    socket.Connect(remoteEP);
                    string cam_url = "0";
                    if (ip == "0")
                    {
                        cam_url = ip + "~" + cams_id + "~0";
                    }
                    else
                    {
                        cam_url = "rtsp://" + user + ":" + pwd + "@" + ip + ":" + port + "/H264?ch=1&subtype=0~" + cams_id + "~0";
                    }
                    // cam_url = "http://"+ ip + ":" + port + "/videofeed?user=&password=~" + cam_id + "~0";
                    //cam_url = "rtsp://"+user+":"+pwd+"@"+ip+":"+port+"/H264?ch=1&subtype=0";
                    //cam_url = "rtspsrc location=rtsp://admin:India12345@195.229.90.117:4444 latency=2000 ! rtph264depay ! h264parse ! decodebin ! videoconvert ! appsink";
                    Console.WriteLine("Socket connected to {0}",
                        socket.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(cam_url);
                    int bytesSent = socket.Send(msg);
                    string dataStr = "";
                    while (true)
                    {
                        int bytesRec = socket.Receive(bytes);
                        dataStr += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (dataStr.Contains("END!"))
                        {
                            int index2 = dataStr.IndexOf("END!");
                            int totLen = dataStr.Length;
                            string mainData = dataStr.Substring(0, index2);
                            Image image = byteArrayToImage(mainData);
                            SetPicture(image);
                            if (dataStr.Length == index2 + 4)
                            {
                                dataStr = "";
                            }
                            else if (dataStr.Length > (index2 + 4))
                            {
                                string dataStr1 = dataStr.Substring(index2 + 4, (totLen - (index2 + 4)));
                                dataStr = dataStr1;
                            }
                            else
                            {

                            }
                        }
                    }
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();

                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("No Ip Found");
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());

                }
                catch (SocketException se)
                {
                    MessageBox.Show("No Socket Found");
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void SetPicture(Image img)
        {
            if (cam_picture.InvokeRequired)
            {
                cam_picture.Invoke(new MethodInvoker(
                delegate ()
                {
                    cam_picture.Image = img;
                }));
            }
            else
            {
                cam_picture.Image = img;
            }
        }

        private Image byteArrayToImage(string strDataImage)
        {
            byte[] bytedata = GetBytes(strDataImage);
            return Base64StringToBitmap(strDataImage);
        }
        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        public static Bitmap Base64StringToBitmap(string base64String)
        {
            Bitmap bmpReturn = null;
            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);
            memoryStream.Position = 0;
            bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);
            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;
            return bmpReturn;
        }
    }
}