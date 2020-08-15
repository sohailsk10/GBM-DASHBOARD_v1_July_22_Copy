namespace GBM_Dashboard
{
    partial class XtraForm3
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.violationsmilieflagviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dashboardDataSet = new GBM_Dashboard.dashboardDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colg_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colviolation_indicator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.violation_smilie_flag_viewTableAdapter = new GBM_Dashboard.dashboardDataSetTableAdapters.violation_smilie_flag_viewTableAdapter();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.label1 = new System.Windows.Forms.Label();
            this.gbmivasummaryviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbm_iva_summary_viewTableAdapter = new GBM_Dashboard.dashboardDataSetTableAdapters.gbm_iva_summary_viewTableAdapter();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.digitalGauge1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationsmilieflagviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbmivasummaryviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.violationsmilieflagviewBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(106, 140);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // violationsmilieflagviewBindingSource
            // 
            this.violationsmilieflagviewBindingSource.DataMember = "violation_smilie_flag_view";
            this.violationsmilieflagviewBindingSource.DataSource = this.dashboardDataSet;
            // 
            // dashboardDataSet
            // 
            this.dashboardDataSet.DataSetName = "dashboardDataSet";
            this.dashboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colg_id,
            this.colviolation_indicator});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colg_id
            // 
            this.colg_id.FieldName = "g_id";
            this.colg_id.Name = "colg_id";
            this.colg_id.Visible = true;
            this.colg_id.VisibleIndex = 0;
            // 
            // colviolation_indicator
            // 
            this.colviolation_indicator.FieldName = "violation_indicator";
            this.colviolation_indicator.Name = "colviolation_indicator";
            this.colviolation_indicator.Visible = true;
            this.colviolation_indicator.VisibleIndex = 1;
            // 
            // violation_smilie_flag_viewTableAdapter
            // 
            this.violation_smilie_flag_viewTableAdapter.ClearBeforeFill = true;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(737, 154);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(250, 250);
            this.gaugeControl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gbmivasummaryviewBindingSource, "violations_count", true));
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "11.05";
            // 
            // gbmivasummaryviewBindingSource
            // 
            this.gbmivasummaryviewBindingSource.DataMember = "gbm_iva_summary_view";
            this.gbmivasummaryviewBindingSource.DataSource = this.dashboardDataSet;
            // 
            // gbm_iva_summary_viewTableAdapter
            // 
            this.gbm_iva_summary_viewTableAdapter.ClearBeforeFill = true;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.DataSource = this.gbmivasummaryviewBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(404, 61);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(665, 73);
            this.dataNavigator1.TabIndex = 3;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#EAECF1");
            this.digitalGauge1.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#7184BA");
            this.digitalGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent1});
            this.digitalGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 238, 238);
            this.digitalGauge1.DigitCount = 5;
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.digitalGauge1.Text = "00,000";
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(265.8125F, 99.9625F);
            this.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style16;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // XtraForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 801);
            this.Controls.Add(this.dataNavigator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gaugeControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "XtraForm3";
            this.Text = "XtraForm3";
            this.Load += new System.EventHandler(this.XtraForm3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationsmilieflagviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbmivasummaryviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dashboardDataSet dashboardDataSet;
        private System.Windows.Forms.BindingSource violationsmilieflagviewBindingSource;
        private dashboardDataSetTableAdapters.violation_smilie_flag_viewTableAdapter violation_smilie_flag_viewTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colg_id;
        private DevExpress.XtraGrid.Columns.GridColumn colviolation_indicator;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource gbmivasummaryviewBindingSource;
        private dashboardDataSetTableAdapters.gbm_iva_summary_viewTableAdapter gbm_iva_summary_viewTableAdapter;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent1;
    }
}