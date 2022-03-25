using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel5taReal.Front_End.FrmLogins
{
    public partial class FrmManuReporte : Form
    {
        public FrmManuReporte()
        {
            InitializeComponent();
        }
        //---PROGRAMACION DE BOTONES----->
        //---BOTON REPORTE CLIENTE----->
        private void btnReporteCLiente_Click(object sender, EventArgs e)
        {
            Reporteria.RPClientes.FrmReporteClientes FC = new Reporteria.RPClientes.FrmReporteClientes();
            FC.Show();
            this.Hide();

        }
        //---BOTON REPORTE VENTA----->
        private void bntReporteVEnta_Click(object sender, EventArgs e)
        {
            Reporteria.RPVentas.FrmReporteVenta fv = new Reporteria.RPVentas.FrmReporteVenta();
            fv.Show();
            this.Hide();
        }
        //---BOTON REPORTE PRODUCTO----->
        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            Reporteria.RProductos.FrmReportProducto RV = new Reporteria.RProductos.FrmReportProducto();
            RV.Show();
            this.Hide();
        }

        
        //---FIN PROGRAMACION DE BOTONES----->
    }
}
