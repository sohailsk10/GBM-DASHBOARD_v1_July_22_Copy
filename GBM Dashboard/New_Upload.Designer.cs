namespace GBM_Dashboard
{
    partial class New_Upload
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
            this.configurationtypetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dashboardDataSet = new GBM_Dashboard.dashboardDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colconfiguration_description_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.configurationtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colconfiguaration_description_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.cameraconfigurationtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcamera_ip_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.configuration_type_tblTableAdapter = new GBM_Dashboard.dashboardDataSetTableAdapters.configuration_type_tblTableAdapter();
            this.configuration_tblTableAdapter = new GBM_Dashboard.dashboardDataSetTableAdapters.configuration_tblTableAdapter();
            this.camera_configuration_tblTableAdapter = new GBM_Dashboard.dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.dashboardDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoslisttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videos_list_tblTableAdapter = new GBM_Dashboard.dashboardDataSet1TableAdapters.videos_list_tblTableAdapter();
            this.btnProcess = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Video_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dashboardDataSet1 = new GBM_Dashboard.dashboardDataSet1();
            this.adminTableAdapter1 = new GBM_Dashboard.dashboardDataSetTableAdapters.adminTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_flow_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtypetblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraconfigurationtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoslisttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet1)).BeginInit();
            this.Content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.configurationtypetblBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(328, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(300, 251);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // configurationtypetblBindingSource
            // 
            this.configurationtypetblBindingSource.DataMember = "configuration_type_tbl";
            this.configurationtypetblBindingSource.DataSource = this.dashboardDataSet;
            // 
            // dashboardDataSet
            // 
            this.dashboardDataSet.DataSetName = "dashboardDataSet";
            this.dashboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colconfiguration_description_fld});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // colconfiguration_description_fld
            // 
            this.colconfiguration_description_fld.Caption = "Application List";
            this.colconfiguration_description_fld.FieldName = "configuration_description_fld";
            this.colconfiguration_description_fld.Name = "colconfiguration_description_fld";
            this.colconfiguration_description_fld.OptionsColumn.AllowEdit = false;
            this.colconfiguration_description_fld.Visible = true;
            this.colconfiguration_description_fld.VisibleIndex = 1;
            this.colconfiguration_description_fld.Width = 205;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.configurationtblBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(632, 47);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(300, 251);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // configurationtblBindingSource
            // 
            this.configurationtblBindingSource.DataMember = "configuration_tbl";
            this.configurationtblBindingSource.DataSource = this.dashboardDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colconfiguaration_description_fld});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView2.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            // 
            // colconfiguaration_description_fld
            // 
            this.colconfiguaration_description_fld.Caption = "Site List";
            this.colconfiguaration_description_fld.FieldName = "configuaration_description_fld";
            this.colconfiguaration_description_fld.Name = "colconfiguaration_description_fld";
            this.colconfiguaration_description_fld.Visible = true;
            this.colconfiguaration_description_fld.VisibleIndex = 1;
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.cameraconfigurationtblBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(936, 47);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(300, 251);
            this.gridControl3.TabIndex = 5;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // cameraconfigurationtblBindingSource
            // 
            this.cameraconfigurationtblBindingSource.DataMember = "camera_configuration_tbl";
            this.cameraconfigurationtblBindingSource.DataSource = this.dashboardDataSet;
            // 
            // gridView3
            // 
            this.gridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.gridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcamera_ip_fid});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView3.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView3.OptionsSelection.MultiSelect = true;
            this.gridView3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowDetailButtons = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView3_SelectionChanged_1);
            // 
            // colcamera_ip_fid
            // 
            this.colcamera_ip_fid.Caption = "Camera List";
            this.colcamera_ip_fid.FieldName = "camera_ip_fid";
            this.colcamera_ip_fid.Name = "colcamera_ip_fid";
            this.colcamera_ip_fid.Visible = true;
            this.colcamera_ip_fid.VisibleIndex = 1;
            // 
            // configuration_type_tblTableAdapter
            // 
            this.configuration_type_tblTableAdapter.ClearBeforeFill = true;
            // 
            // configuration_tblTableAdapter
            // 
            this.configuration_tblTableAdapter.ClearBeforeFill = true;
            // 
            // camera_configuration_tblTableAdapter
            // 
            this.camera_configuration_tblTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl4
            // 
            this.gridControl4.Location = new System.Drawing.Point(24, 47);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(300, 251);
            this.gridControl4.TabIndex = 2;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.gridView4.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView4.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView4.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView4.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView4.OptionsSelection.CheckBoxSelectorColumnWidth = 20;
            this.gridView4.OptionsSelection.MultiSelect = true;
            this.gridView4.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowDetailButtons = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView4_SelectionChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Video List";
            this.gridColumn1.FieldName = "video_name_fld";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 225;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChooseFile.Location = new System.Drawing.Point(24, 6);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(95, 30);
            this.btnChooseFile.TabIndex = 1;
            this.btnChooseFile.Text = "ChooseFile";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select Videos";
            // 
            // dashboardDataSetBindingSource
            // 
            this.dashboardDataSetBindingSource.DataSource = this.dashboardDataSet;
            this.dashboardDataSetBindingSource.Position = 0;
            // 
            // videos_list_tblTableAdapter
            // 
            this.videos_list_tblTableAdapter.ClearBeforeFill = true;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProcess.Location = new System.Drawing.Point(1138, 310);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(95, 30);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Video_list,
            this.ApplicationList,
            this.Site,
            this.Camera});
            this.dataGridView1.Location = new System.Drawing.Point(24, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1212, 194);
            this.dataGridView1.TabIndex = 10;
            // 
            // Video_list
            // 
            this.Video_list.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Video_list.HeaderText = "Video ";
            this.Video_list.Name = "Video_list";
            // 
            // ApplicationList
            // 
            this.ApplicationList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ApplicationList.HeaderText = "Usecase";
            this.ApplicationList.Name = "ApplicationList";
            // 
            // Site
            // 
            this.Site.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Site.HeaderText = "Site";
            this.Site.Name = "Site";
            // 
            // Camera
            // 
            this.Camera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Camera.HeaderText = "Camera";
            this.Camera.Name = "Camera";
            this.Camera.ReadOnly = true;
            // 
            // dashboardDataSet1
            // 
            this.dashboardDataSet1.DataSetName = "dashboardDataSet1";
            this.dashboardDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Location = new System.Drawing.Point(1138, 557);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUnselect
            // 
            this.btnUnselect.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUnselect.Location = new System.Drawing.Point(985, 310);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(95, 30);
            this.btnUnselect.TabIndex = 7;
            this.btnUnselect.Text = "Unselect";
            this.btnUnselect.UseVisualStyleBackColor = false;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Location = new System.Drawing.Point(985, 557);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.SystemColors.Window;
            this.Content.Controls.Add(this.panel1);
            this.Content.Controls.Add(this.button1);
            this.Content.Controls.Add(this.btnSave);
            this.Content.Controls.Add(this.gridControl3);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1383, 807);
            this.Content.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label_flow_layout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 214);
            this.panel1.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(471, 214);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // label_flow_layout
            // 
            this.label_flow_layout.AutoScroll = true;
            this.label_flow_layout.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_flow_layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.label_flow_layout.Location = new System.Drawing.Point(477, 0);
            this.label_flow_layout.Name = "label_flow_layout";
            this.label_flow_layout.Size = new System.Drawing.Size(906, 214);
            this.label_flow_layout.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(817, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show Status";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // New_Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUnselect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.gridControl4);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.Content);
            this.Name = "New_Upload";
            this.Size = new System.Drawing.Size(1383, 807);
            this.Load += new System.EventHandler(this.New_Upload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtypetblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraconfigurationtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoslisttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet1)).EndInit();
            this.Content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colconfiguration_description_fld;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colconfiguaration_description_fld;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_ip_fid;
        private dashboardDataSet dashboardDataSet;
        private System.Windows.Forms.BindingSource configurationtypetblBindingSource;
        private dashboardDataSetTableAdapters.configuration_type_tblTableAdapter configuration_type_tblTableAdapter;
        private System.Windows.Forms.BindingSource configurationtblBindingSource;
        private dashboardDataSetTableAdapters.configuration_tblTableAdapter configuration_tblTableAdapter;
        private System.Windows.Forms.BindingSource cameraconfigurationtblBindingSource;
        private dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter camera_configuration_tblTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource dashboardDataSetBindingSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.BindingSource videoslisttblBindingSource;
        private dashboardDataSet1TableAdapters.videos_list_tblTableAdapter videos_list_tblTableAdapter;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dashboardDataSet1 dashboardDataSet1;
        private dashboardDataSetTableAdapters.adminTableAdapter adminTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camera;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel Content;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel label_flow_layout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}