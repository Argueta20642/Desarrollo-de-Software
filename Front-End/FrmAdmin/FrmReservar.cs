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

    public partial class FrmReservar : Form
    {

        public FrmReservar()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=NEHIMAYA-PC\\NEHIMAYAPC;Initial Catalog=Hotel5taReal;Integrated Security=True");    
        private void FrmReservar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotel5taRealDataSet.Reserva' Puede moverla o quitarla según sea necesario.
            this.reservaTableAdapter.Fill(this.hotel5taRealDataSet.Reserva);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.RECEPCION' Puede moverla o quitarla según sea necesario.


        }


        //EVENTO SELECION PARA MODIFICAR--->

        //---BOTONES------->
        //----BTNmodificar----->
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            bntNuevo.Enabled = true;
            btnModificar.Enabled = false;
            


        }
        //----BTNNuevo----->
        private void bntNuevo_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            limpiar();
        }
        //----BTNAgregar----->
        private void btnAgregar_Click(object sender, EventArgs e)
        {
                
            CamposVacios();
            try
            {
                string query = "insert into Reserva (Cod_Reservas,NombreCliente,ApellidoCliente,DNI,Ciudad,Pais,Precio,NumerodeHabitacion,FechaIngreso,FechaSalida,mora) values (@Cod_Reservas,@NombreCliente,@ApellidoCliente,@DNI,@Ciudad,@Pais,@Precio,@NumerodeHabitacion,@FechaIngreso,@FechaSalida,@mora)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Cod_Reservas", cod_ReservasTextBox.Text);
                comando.Parameters.AddWithValue("@NombreCliente", nombreClienteTextBox.Text);
                comando.Parameters.AddWithValue("@ApellidoCliente", apellidoClienteTextBox.Text);
                comando.Parameters.AddWithValue("@DNI", dNITextBox.Text);
                comando.Parameters.AddWithValue("@Ciudad", ciudadTextBox.Text);
                comando.Parameters.AddWithValue("@Pais", paisTextBox.Text);
                comando.Parameters.AddWithValue("@Precio", precioTextBox.Text);
                comando.Parameters.AddWithValue("@NumerodeHabitacion", numerodeHabitacionTextBox.Text);
                comando.Parameters.AddWithValue("@FechaIngreso", fechaIngresoTextBox.Text);
                comando.Parameters.AddWithValue("@FechaSalida", fechaSalidaTextBox.Text);
                comando.Parameters.AddWithValue("@mora", moraTextBox.Text);
                comando.ExecuteNonQuery();
                reservaDataGridView.Refresh();
                btnAgregar.Enabled = false;
                MessageBox.Show("Reserva Agregada¡");
                conexion.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("ERROR¡");
            }

        }
        //----BTNHabitaciones----->
        private void btnHabitaciones_Click(object sender, EventArgs e)
        {


        }
        //---fiN BOTONES-------->
        //METODO PARA LIMPIAR--->
        void limpiar()
        {
            
            cod_ReservasTextBox.Text = "";
            nombreClienteTextBox.Text = "";
            apellidoClienteTextBox.Text = "";
            dNITextBox.Text = "";
            ciudadTextBox.Text = "";
            paisTextBox.Text = "";
            numerodeHabitacionTextBox.Text = "";
            fechaIngresoTextBox.Text = "";
            precioTextBox.Text = "";
            fechaSalidaTextBox.Text = "";
            moraTextBox.Text = "";
        } //---Fin Metodo---->

        
        //---Fin Eventos Del DataGridview--------->
        private void reservaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotel5taRealDataSet);

        }

        private void reservaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        //---Fin Eventos Del DataGridview--------->
        //-----Inicion de Valaidacion----->
        private void cod_ReservasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            if(cod_ReservasTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

        private void nombreClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            if(nombreClienteTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

        private void apellidoClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            if(apellidoClienteTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

        private void dNITextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            if(dNITextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
            else if (dNITextBox.Text.Contains("0"))
            {
                MessageBox.Show("No se permite 0.");
                return;  //Sale
            }

        }

        private void ciudadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            if(ciudadTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

        private void paisTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            if(paisTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }

        }

        private void numerodeHabitacionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            if(numerodeHabitacionTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

       
        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            if(precioTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

       
        private void moraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            if(moraTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

        //validacion de Campos vacios 
        private bool CamposVacios()
        {
            bool ok = true;
            if(cod_ReservasTextBox.Text=="")
            {
                ok = false;
                errorProvider1.SetError(cod_ReservasTextBox, "Ingrese codigo");
            }
            if (nombreClienteTextBox.Text=="")
            {
                ok = false;
                errorProvider1.SetError(nombreClienteTextBox, "Ingrese Nombre");
            }
            if (apellidoClienteTextBox.Text=="")
            {
                ok = false;
                errorProvider1.SetError(apellidoClienteTextBox, "Ingrese apellido");
            }
            if (dNITextBox.Text=="")
            {
                ok = false;
                errorProvider1.SetError(dNITextBox, "Ingrese la DNI");
            }
            if (ciudadTextBox.Text=="")
            {
                ok = false;
                errorProvider1.SetError(ciudadTextBox, "Ingrese la Ciudad");
            }
            if (paisTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(paisTextBox, "Ingrese Pais");
            }
            if (numerodeHabitacionTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(numerodeHabitacionTextBox, "Ingrese Numero Habitacion");
            }
            if (fechaIngresoTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(fechaIngresoTextBox, "Ingrese Fecha Ingreso");
            }
            if (precioTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(precioTextBox, "Ingrese el Precio");
            }
            if (fechaSalidaTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(fechaSalidaTextBox, "Ingrese Fecha Salida");
            }
            if (moraTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(moraTextBox, "Ingrese la mora");
            }
            return ok;
        }

        private void reservaDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            bntNuevo.Enabled = false;
            btnAgregar.Enabled = false;
        }
        //-----Fin de Valaidacion----->
    }
}
