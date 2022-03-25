using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel5taReal.Reporteria.RPClientes
{
    public partial class FrmReporteClientes : Form
    {
        public FrmReporteClientes()
        {
            InitializeComponent();
        }

        private void FrmReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Cliente.Reserva' Puede moverla o quitarla según sea necesario.
            this.ReservaTableAdapter.Fill(this.Cliente.Reserva);
            this.reportViewer1.RefreshReport();
        }
    }
}
