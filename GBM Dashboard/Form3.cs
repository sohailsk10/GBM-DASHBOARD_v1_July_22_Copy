using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBM_Dashboard
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            load_ratios();
        }
        private void load_ratios()
        {
            const double screenHeight = 1080.0;
            const double screenWidth = 1920.0;
            double height = Screen.AllScreens[0].Bounds.Height;
            double width = Screen.AllScreens[0].Bounds.Width;
            double height_ratio = height / screenHeight;
            double width_ratio = width / screenWidth;
            MessageBox.Show(height_ratio.ToString());
            MessageBox.Show(width_ratio.ToString());
            //            MessageBox.Show( panel1.Left.ToString());
            // (int(110 * width_ratio) + int(6 * width_ratio), 1), (int(300 * width_ratio), int(251 * height_ratio))
            foreach (Control _control in this.Controls) { 
                if (_control.Visible == true)
                {
                    _control.Left = (int)(_control.Left * width_ratio);
                    _control.Top = (int)(_control.Top * height_ratio);
                    _control.Width = (int)(_control.Width * width_ratio);
                    _control.Height = (int)(_control.Height * height_ratio);

                }
            }
            //panel1.Bottom = panel1.Bottom * height_ratio;

        }
    }
}
