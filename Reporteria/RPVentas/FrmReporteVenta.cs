using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel5taReal.Reporteria.RPVentas
{
    public partial class FrmReporteVenta : Form
    {
        public FrmReporteVenta()
        {
            InitializeComponent();
        }

        private void FrmReporteVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Ventas.OrdenItems' Puede moverla o quitarla según sea necesario.
            this.OrdenItemsTableAdapter.Fill(this.Ventas.OrdenItems);

            this.reportViewer1.RefreshReport();
        }
    }
}
