using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GBM_Dashboard
{
    public partial class Main_Form : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
           
            Dashboard_Tab dashboard_Tab = new Dashboard_Tab();
            MainControlClass.showControl(dashboard_Tab, Content);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            /*GBM_IVA gBM_IVA = new GBM_IVA();
            MainControlClass.showControl(gBM_IVA, Content);*/
            Dashboard_Tab dashboard_Tab = new Dashboard_Tab();
            MainControlClass.showControl(dashboard_Tab, Content);

        }
        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            MainControlClass.showControl(configuration, Content);
        }
        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            New_Upload new_Upload = new New_Upload();
            MainControlClass.showControl(new_Upload, Content);
        }


        private void panel1_Layout(object sender, LayoutEventArgs e)
        {
            //gbmlogo.Location = new Point((Main_Form.width / 2) - Main_Form.coordionWidth, 0);
            pictureBox1.Location = new Point(this.Width / 3);
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            GBM_IVA gBM_IVA = new GBM_IVA();
            MainControlClass.showControl(gBM_IVA, Content);
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            XtraForm1 xtraForm1 = new XtraForm1();
            MainControlClass.showControl(xtraForm1, Content);
        }
    }
}
