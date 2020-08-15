namespace GBM_Dashboard
{
    partial class Dashboard_Tab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Tab));
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl24hrs = new System.Windows.Forms.Label();
            this.lbl12hrs = new System.Windows.Forms.Label();
            this.lbl9hrs = new System.Windows.Forms.Label();
            this.lbl3hrs = new System.Windows.Forms.Label();
            this.lbl6hrs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardViewer2 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // flow
            // 
            this.flow.BackColor = System.Drawing.Color.Black;
            this.flow.Location = new System.Drawing.Point(1, 1);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(1688, 39);
            this.flow.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1690, 47);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dashboardViewer2);
            this.panel1.Controls.Add(this.dashboardViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1690, 729);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Controls.Add(this.lbl24hrs);
            this.panel2.Controls.Add(this.lbl12hrs);
            this.panel2.Controls.Add(this.lbl9hrs);
            this.panel2.Controls.Add(this.lbl3hrs);
            this.panel2.Controls.Add(this.lbl6hrs);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(780, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 262);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Export to Pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(642, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 44);
            this.label7.TabIndex = 29;
            this.label7.Text = "Total";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Bold);
            this.lbl_total.ForeColor = System.Drawing.Color.Red;
            this.lbl_total.Location = new System.Drawing.Point(624, 304);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(237, 68);
            this.lbl_total.TabIndex = 28;
            this.lbl_total.Text = "label10";
            // 
            // lbl24hrs
            // 
            this.lbl24hrs.AutoSize = true;
            this.lbl24hrs.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Bold);
            this.lbl24hrs.ForeColor = System.Drawing.Color.Red;
            this.lbl24hrs.Location = new System.Drawing.Point(346, 308);
            this.lbl24hrs.Name = "lbl24hrs";
            this.lbl24hrs.Size = new System.Drawing.Size(237, 68);
            this.lbl24hrs.TabIndex = 27;
            this.lbl24hrs.Text = "label10";
            // 
            // lbl12hrs
            // 
            this.lbl12hrs.AutoSize = true;
            this.lbl12hrs.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Bold);
            this.lbl12hrs.ForeColor = System.Drawing.Color.Red;
            this.lbl12hrs.Location = new System.Drawing.Point(47, 304);
            this.lbl12hrs.Name = "lbl12hrs";
            this.lbl12hrs.Size = new System.Drawing.Size(201, 68);
            this.lbl12hrs.TabIndex = 26;
            this.lbl12hrs.Text = "label9";
            // 
            // lbl9hrs
            // 
            this.lbl9hrs.AutoSize = true;
            this.lbl9hrs.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Bold);
            this.lbl9hrs.ForeColor = System.Drawing.Color.Red;
            this.lbl9hrs.Location = new System.Drawing.Point(624, 132);
            this.lbl9hrs.Name = "lbl9hrs";
            this.lbl9hrs.Size = new System.Drawing.Size(201, 68);
            this.lbl9hrs.TabIndex = 25;
            this.lbl9hrs.Text = "label8";
            // 
            // lbl3hrs
            // 
            this.lbl3hrs.AutoSize = true;
            this.lbl3hrs.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Bold);
            this.lbl3hrs.ForeColor = System.Drawing.Color.Red;
            this.lbl3hrs.Location = new System.Drawing.Point(46, 132);
            this.lbl3hrs.Name = "lbl3hrs";
            this.lbl3hrs.Size = new System.Drawing.Size(201, 68);
            this.lbl3hrs.TabIndex = 24;
            this.lbl3hrs.Text = "label7";
            // 
            // lbl6hrs
            // 
            this.lbl6hrs.AutoSize = true;
            this.lbl6hrs.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Bold);
            this.lbl6hrs.ForeColor = System.Drawing.Color.Red;
            this.lbl6hrs.Location = new System.Drawing.Point(340, 132);
            this.lbl6hrs.Name = "lbl6hrs";
            this.lbl6hrs.Size = new System.Drawing.Size(201, 68);
            this.lbl6hrs.TabIndex = 23;
            this.lbl6hrs.Text = "label6";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 44);
            this.label5.TabIndex = 22;
            this.label5.Text = "24 Hours";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 44);
            this.label4.TabIndex = 21;
            this.label4.Text = "12 Hours";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 44);
            this.label3.TabIndex = 20;
            this.label3.Text = "06 Hours";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 44);
            this.label2.TabIndex = 19;
            this.label2.Text = "09 Hours";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "3 Hours";
            // 
            // dashboardViewer2
            // 
            this.dashboardViewer2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.dashboardViewer2.Appearance.Options.UseBackColor = true;
            this.dashboardViewer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dashboardViewer2.DashboardSource = new System.Uri("E:\\GBM_IVA_Dashboard-v1_complete\\GBM-DASHBOARD_v1_July_22_Copy\\GBM Dashboard\\dash" +
        "board_design\\PieChart_new.xml", System.UriKind.Absolute);
            this.dashboardViewer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dashboardViewer2.Location = new System.Drawing.Point(780, 262);
            this.dashboardViewer2.Name = "dashboardViewer2";
            this.dashboardViewer2.Size = new System.Drawing.Size(910, 467);
            this.dashboardViewer2.TabIndex = 1;
            // 
            // dashboardViewer1
            // 
            this.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.dashboardViewer1.Appearance.Options.UseBackColor = true;
            this.dashboardViewer1.DashboardSource = new System.Uri("E:\\GBM_IVA_Dashboard-v1_complete\\GBM-DASHBOARD_v1_July_22_Copy\\GBM Dashboard\\dash" +
        "board_design\\multichart.xml", System.UriKind.Absolute);
            this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardViewer1.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer1.Name = "dashboardViewer1";
            this.dashboardViewer1.Size = new System.Drawing.Size(780, 729);
            this.dashboardViewer1.TabIndex = 0;
            this.dashboardViewer1.CustomParameters += new DevExpress.DashboardCommon.CustomParametersEventHandler(this.dashboardViewer1_CustomParameters);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Dashboard_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Dashboard_Tab";
            this.Size = new System.Drawing.Size(1690, 776);
            this.Load += new System.EventHandler(this.Dashboard_Tab_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl24hrs;
        private System.Windows.Forms.Label lbl12hrs;
        private System.Windows.Forms.Label lbl9hrs;
        private System.Windows.Forms.Label lbl3hrs;
        private System.Windows.Forms.Label lbl6hrs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}