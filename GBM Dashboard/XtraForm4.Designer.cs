namespace GBM_Dashboard
{
    partial class XtraForm4
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
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.dashboardViewer2 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.barchartviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dashboardDataSet2 = new GBM_Dashboard.dashboardDataSet2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl24hrs = new System.Windows.Forms.Label();
            this.lbl12hrs = new System.Windows.Forms.Label();
            this.lbl9hrs = new System.Windows.Forms.Label();
            this.lbl3hrs = new System.Windows.Forms.Label();
            this.barchartviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dashboardDataSet3 = new GBM_Dashboard.dashboardDataSet3();
            this.lbl6hrs = new System.Windows.Forms.Label();
            this.barchart_viewTableAdapter = new GBM_Dashboard.dashboardDataSet2TableAdapters.barchart_viewTableAdapter();
            this.barchart_viewTableAdapter1 = new GBM_Dashboard.dashboardDataSet3TableAdapters.barchart_viewTableAdapter();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barchartviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barchartviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardViewer1
            // 
            this.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.dashboardViewer1.Appearance.Options.UseBackColor = true;
            this.dashboardViewer1.DashboardSource = new System.Uri("E:\\GBM-DASHBOARD_v1_July_22_Copy\\GBM Dashboard\\dashboard_design\\multichart.xml", System.UriKind.Absolute);
            this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardViewer1.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer1.Name = "dashboardViewer1";
            this.dashboardViewer1.Size = new System.Drawing.Size(750, 732);
            this.dashboardViewer1.TabIndex = 0;
            // 
            // dashboardViewer2
            // 
            this.dashboardViewer2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.dashboardViewer2.Appearance.Options.UseBackColor = true;
            this.dashboardViewer2.DashboardSource = new System.Uri("E:\\GBM-DASHBOARD_v1_July_22_Copy\\GBM Dashboard\\dashboard_design\\PieChart_new.xml", System.UriKind.Absolute);
            this.dashboardViewer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dashboardViewer2.Location = new System.Drawing.Point(750, 337);
            this.dashboardViewer2.Name = "dashboardViewer2";
            this.dashboardViewer2.Size = new System.Drawing.Size(748, 395);
            this.dashboardViewer2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "3 Hours";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "09 Hours";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "06 Hours";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "12 Hours";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "24 Hours";
            // 
            // barchartviewBindingSource
            // 
            this.barchartviewBindingSource.DataMember = "barchart_view";
            this.barchartviewBindingSource.DataSource = this.dashboardDataSet2;
            // 
            // dashboardDataSet2
            // 
            this.dashboardDataSet2.DataSetName = "dashboardDataSet2";
            this.dashboardDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.lbl24hrs);
            this.panel1.Controls.Add(this.lbl12hrs);
            this.panel1.Controls.Add(this.lbl9hrs);
            this.panel1.Controls.Add(this.lbl3hrs);
            this.panel1.Controls.Add(this.lbl6hrs);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(750, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 337);
            this.panel1.TabIndex = 2;
            // 
            // lbl24hrs
            // 
            this.lbl24hrs.AutoSize = true;
            this.lbl24hrs.Font = new System.Drawing.Font("Tahoma", 36F);
            this.lbl24hrs.Location = new System.Drawing.Point(22, 215);
            this.lbl24hrs.Name = "lbl24hrs";
            this.lbl24hrs.Size = new System.Drawing.Size(176, 58);
            this.lbl24hrs.TabIndex = 15;
            this.lbl24hrs.Text = "label10";
            // 
            // lbl12hrs
            // 
            this.lbl12hrs.AutoSize = true;
            this.lbl12hrs.Font = new System.Drawing.Font("Tahoma", 36F);
            this.lbl12hrs.Location = new System.Drawing.Point(248, 215);
            this.lbl12hrs.Name = "lbl12hrs";
            this.lbl12hrs.Size = new System.Drawing.Size(150, 58);
            this.lbl12hrs.TabIndex = 14;
            this.lbl12hrs.Text = "label9";
            // 
            // lbl9hrs
            // 
            this.lbl9hrs.AutoSize = true;
            this.lbl9hrs.Font = new System.Drawing.Font("Tahoma", 36F);
            this.lbl9hrs.Location = new System.Drawing.Point(521, 215);
            this.lbl9hrs.Name = "lbl9hrs";
            this.lbl9hrs.Size = new System.Drawing.Size(150, 58);
            this.lbl9hrs.TabIndex = 13;
            this.lbl9hrs.Text = "label8";
            // 
            // lbl3hrs
            // 
            this.lbl3hrs.AutoSize = true;
            this.lbl3hrs.Font = new System.Drawing.Font("Tahoma", 36F);
            this.lbl3hrs.Location = new System.Drawing.Point(248, 64);
            this.lbl3hrs.Name = "lbl3hrs";
            this.lbl3hrs.Size = new System.Drawing.Size(150, 58);
            this.lbl3hrs.TabIndex = 12;
            this.lbl3hrs.Text = "label7";
            // 
            // barchartviewBindingSource1
            // 
            this.barchartviewBindingSource1.DataMember = "barchart_view";
            this.barchartviewBindingSource1.DataSource = this.dashboardDataSet3;
            // 
            // dashboardDataSet3
            // 
            this.dashboardDataSet3.DataSetName = "dashboardDataSet3";
            this.dashboardDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl6hrs
            // 
            this.lbl6hrs.AutoSize = true;
            this.lbl6hrs.Font = new System.Drawing.Font("Tahoma", 36F);
            this.lbl6hrs.Location = new System.Drawing.Point(521, 64);
            this.lbl6hrs.Name = "lbl6hrs";
            this.lbl6hrs.Size = new System.Drawing.Size(150, 58);
            this.lbl6hrs.TabIndex = 10;
            this.lbl6hrs.Text = "label6";
            // 
            // barchart_viewTableAdapter
            // 
            this.barchart_viewTableAdapter.ClearBeforeFill = true;
            // 
            // barchart_viewTableAdapter1
            // 
            this.barchart_viewTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Tahoma", 36F);
            this.lbl_total.Location = new System.Drawing.Point(32, 64);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(176, 58);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "label10";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 44);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total";
            // 
            // XtraForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashboardViewer2);
            this.Controls.Add(this.dashboardViewer1);
            this.Name = "XtraForm4";
            this.Size = new System.Drawing.Size(1498, 732);
            this.Load += new System.EventHandler(this.XtraForm4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barchartviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barchartviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer2;
        private dashboardDataSet2 dashboardDataSet2;
        private System.Windows.Forms.BindingSource barchartviewBindingSource;
        private dashboardDataSet2TableAdapters.barchart_viewTableAdapter barchart_viewTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private dashboardDataSet3 dashboardDataSet3;
        private System.Windows.Forms.BindingSource barchartviewBindingSource1;
        private dashboardDataSet3TableAdapters.barchart_viewTableAdapter barchart_viewTableAdapter1;
        private System.Windows.Forms.Label lbl6hrs;
        private System.Windows.Forms.Label lbl24hrs;
        private System.Windows.Forms.Label lbl12hrs;
        private System.Windows.Forms.Label lbl9hrs;
        private System.Windows.Forms.Label lbl3hrs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_total;
    }
}