﻿
namespace Hotel5taReal.Reporteria.RPVentas
{
    partial class FrmReporteVenta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteVenta));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Ventas = new Hotel5taReal.Reporteria.RPVentas.Ventas();
            this.OrdenItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdenItemsTableAdapter = new Hotel5taReal.Reporteria.RPVentas.VentasTableAdapters.OrdenItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrdenItemsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hotel5taReal.Reporteria.RPVentas.ReporteVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Ventas
            // 
            this.Ventas.DataSetName = "Ventas";
            this.Ventas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdenItemsBindingSource
            // 
            this.OrdenItemsBindingSource.DataMember = "OrdenItems";
            this.OrdenItemsBindingSource.DataSource = this.Ventas;
            // 
            // OrdenItemsTableAdapter
            // 
            this.OrdenItemsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteVenta";
            this.Text = "FrmReporteVentas";
            this.Load += new System.EventHandler(this.FrmReporteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrdenItemsBindingSource;
        private Ventas Ventas;
        private VentasTableAdapters.OrdenItemsTableAdapter OrdenItemsTableAdapter;
    }
}