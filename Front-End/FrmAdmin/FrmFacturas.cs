using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Hotel5taReal.Front_End.FrmAdmin
{
    public partial class FrmFacturas :Form
    {
       
        public FrmFacturas()
        {
            InitializeComponent();
        }
        //--Cadena de Conexion----->
        SqlConnection conexion = new SqlConnection("server= NEHIMAYA-PC\\NEHIMAYAPC; database = Hotel5taReal; Integrated Security = True");



        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotel5taRealDataSet.facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.Fill(this.hotel5taRealDataSet.facturas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.RECEPCION' Puede moverla o quitarla según sea necesario.


        }
        //----Inicio botones--->
        //btn Buscar--->
        private void bntBuscar_Click(object sender, EventArgs e)
        {
            
            CamposVacios();
            
        }


        //---Fin botones
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            txtBuscar.Clear();
        }
        private bool CamposVacios()
        {
            bool ok = true;
            if (txtBuscar.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtBuscar, "Ingresar ID");
            }
            return ok;
        }


    }
}
