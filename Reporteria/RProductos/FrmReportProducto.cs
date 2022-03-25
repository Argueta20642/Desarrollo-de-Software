using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel5taReal.Reporteria.RProductos
{
    public partial class FrmReportProducto : Form
    {
        public FrmReportProducto()
        {
            InitializeComponent();
        }

        private void FrmReportProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Producto.Producto' Puede moverla o quitarla según sea necesario.
            this.ProductoTableAdapter.Fill(this.Producto._Producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
