using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GBM_Dashboard
{
    public class showDemo
    {
        public bool isDemo()
        {
            try
            {
                string wd = Environment.CurrentDirectory;
                string pd = System.IO.Directory.GetParent(wd).Parent.FullName;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(wd + "\\demo_config\\demo_config.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/showDemo");
                foreach (XmlNode node in nodeList)
                {
                    return Convert.ToBoolean(node.SelectSingleNode("isDemoOn").InnerText);
                }
                return false;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public string get_video_path(string use_case_id)
        {
            string video_path = "";
            try
            {
                string wd = Environment.CurrentDirectory;
                string pd = System.IO.Directory.GetParent(wd).Parent.FullName;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(wd + "\\demo_config\\demo_config.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/showDemo/usecase");
                foreach (XmlNode node in nodeList)
                {
                    if (use_case_id == node.SelectSingleNode("id").InnerText.ToString())
                    {
                        video_path = node.SelectSingleNode("video_path").InnerText.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return video_path;
        }
    }

    public class DbConnection
    {

        public string getConnection()
        {
            string strDbConnection = "";
            try
            {
                // This will get the current WORKING directory (i.e. \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = System.IO.Directory.GetParent(workingDirectory).Parent.FullName;
                string userName = "";
                string userPass = "";
                string server = "";
                //MessageBox.Show("workingDirectory:" + workingDirectory);
                //MessageBox.Show("projectDirectory:" + projectDirectory);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(workingDirectory + "\\dbconnection\\connection.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/DbConnection/MYSQL");
                //string proID = "", proName = "", price = "";
                foreach (XmlNode node in nodeList)
                {
                    userName = node.SelectSingleNode("user_name").InnerText;
                    userPass = node.SelectSingleNode("password").InnerText;
                    server = node.SelectSingleNode("server").InnerText;
                    //MessageBox.Show(userName + " " + userPass + " " + server);
                }
                strDbConnection = "server=" + server + ";database=dashboard;uid=" + userName + ";pwd=" + userPass + ";";
                //MessageBox.Show(strDbConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("no connnection file");
            }
            return strDbConnection;
        }
    }

    public class IPaddress
    {
        //test
        /*public string getIpaddress()
        {
            string strIpaddress = "";
            try
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = System.IO.Directory.GetParent(workingDirectory).Parent.FullName;
                string IpAddress = "";
                string userPass = "";
                string server = "";
                //MessageBox.Show("workingDirectory:" + workingDirectory);
                //MessageBox.Show("projectDirectory:" + projectDirectory);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(workingDirectory + "\\dbconnection\\connection.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/DbConnection/MYSQL");
                //string proID = "", proName = "", price = "";
                foreach (XmlNode node in nodeList)
                {
                    IpAddress = node.SelectSingleNode("user_name").InnerText;
                    userPass = node.SelectSingleNode("password").InnerText;
                    server = node.SelectSingleNode("server").InnerText;
                    //MessageBox.Show(userName + " " + userPass + " " + server);
                }
                strIpaddress = "server=" + server + ";database=dashboard;uid=" + userName + ";pwd=" + userPass + ";";
                //MessageBox.Show(strDbConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Ip Address Found");
            }
            return strIpaddress;
        }*/

    }
}
