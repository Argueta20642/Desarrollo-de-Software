using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
namespace Hotel5taReal.Front_End.FrmAdmin
{
    public partial class FrmHomeAd : Form
    {
        public FrmHomeAd()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=NEHIMAYA-PC\\NEHIMAYAPC;Initial Catalog=Hotel5taReal;Integrated Security=True");
        private void FrmHomeAd_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotel5taRealDataSet.Reserva' Puede moverla o quitarla según sea necesario.
            this.reservaTableAdapter.Fill(this.hotel5taRealDataSet.Reserva);
            // TODO: esta línea de código carga datos en la tabla 'hotel5taRealDataSet.facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.Fill(this.hotel5taRealDataSet.facturas);
            // TODO: esta línea de código carga datos en la tabla 'producto._Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter1.Fill(this.producto._Producto);
            // TODO: esta línea de código carga datos en la tabla 'hotel5taRealDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
            this.habitacionesTableAdapter.Fill(this.hotel5taRealDataSet.Habitaciones);

            // TODO: esta línea de código carga datos en la tabla 'hotel5taRealDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.hotel5taRealDataSet.Producto);
            string[] series = { "", "", "" };
            int[] puntos = { 23, 10, 79 };

            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Titles.Add("Cliente top");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);

                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }

          
            chart2.Titles.Add("producto top");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart2.Series.Add(series[i]);

                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }

        }

        private void pnlHD_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
