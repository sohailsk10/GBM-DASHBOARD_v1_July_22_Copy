using System;
using System.Windows.Forms;

namespace GBM_Dashboard
{
    partial class GBM_IVA
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Content = new System.Windows.Forms.Panel();
            this.gbm_usecases_flow_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Controls.Add(this.gbm_usecases_flow_layout);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1181, 773);
            this.Content.TabIndex = 0;
            // 
            // gbm_usecases_flow_layout
            // 
            this.gbm_usecases_flow_layout.AutoScroll = true;
            this.gbm_usecases_flow_layout.BackColor = System.Drawing.Color.Black;
            this.gbm_usecases_flow_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbm_usecases_flow_layout.Location = new System.Drawing.Point(0, 0);
            this.gbm_usecases_flow_layout.Name = "gbm_usecases_flow_layout";
            this.gbm_usecases_flow_layout.Size = new System.Drawing.Size(1181, 773);
            this.gbm_usecases_flow_layout.TabIndex = 0;
            this.gbm_usecases_flow_layout.Paint += new System.Windows.Forms.PaintEventHandler(this.gbm_usecases_flow_layout_Paint);
            // 
            // GBM_IVA
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Content);
            this.Name = "GBM_IVA";
            this.Size = new System.Drawing.Size(1181, 773);
            this.Load += new System.EventHandler(this.GBM_IVA_Load);
            this.Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void gbm_usecases_flow_layout_Paint(object sender, PaintEventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.FlowLayoutPanel gbm_usecases_flow_layout;
    }
}
