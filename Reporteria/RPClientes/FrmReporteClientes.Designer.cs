
namespace Hotel5taReal.Reporteria.RPClientes
{
    partial class FrmReporteClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteClientes));
            this.ReservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cliente = new Hotel5taReal.Reporteria.RPClientes.Cliente();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReservaTableAdapter = new Hotel5taReal.Reporteria.RPClientes.ClienteTableAdapters.ReservaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservaBindingSource
            // 
            this.ReservaBindingSource.DataMember = "Reserva";
            this.ReservaBindingSource.DataSource = this.Cliente;
            // 
            // Cliente
            // 
            this.Cliente.DataSetName = "Cliente";
            this.Cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReservaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hotel5taReal.Reporteria.RPClientes.ReporteCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReservaTableAdapter
            // 
            this.ReservaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteClientes";
            this.Text = "FrmReporteClientes";
            this.Load += new System.EventHandler(this.FrmReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReservaBindingSource;
        private Cliente Cliente;
        private ClienteTableAdapters.ReservaTableAdapter ReservaTableAdapter;
    }
}