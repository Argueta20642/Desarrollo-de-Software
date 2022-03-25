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
    public partial class FrmHabitaciones : Form
    {
        public FrmHabitaciones()
        {
            InitializeComponent();
        }


        SqlConnection conexion = new SqlConnection("server= NEHIMAYA-PC\\NEHIMAYAPC; database = Hotel5taReal; Integrated Security = True");



        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            this.habitacionesTableAdapter.Fill(this.hotel5taRealDataSet.Habitaciones);

        }
        //----BOTONES------>
        //---BtnAgregar----->
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Camposvacio();
            try
            {
                string query = "insert  Habitaciones (Cod_Habitaciones,Nombres,Precio,Estado) values (@Cod_Habitaciones,@Nombres,@Precio,@Estado)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Cod_Habitaciones", cod_HabitacionesTextBox.Text);
                comando.Parameters.AddWithValue("@Nombres", nombresTextBox.Text);
                comando.Parameters.AddWithValue("@Precio", precioTextBox.Text);
                comando.Parameters.AddWithValue("@Estado", estadoTextBox.Text);
                comando.ExecuteNonQuery();
                habitacionesDataGridView.Refresh();
                MessageBox.Show("Habitacion Agregada¡");
                conexion.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error¡");
            }
        }
        //---BtnModificar----->
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Camposvacio();
            try
            {
               
            }
            catch(Exception )
            {
                MessageBox.Show("Error¡");
            }
        }
        //---BtnNuevo----->

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        //---FIN BOTONES---------->
        //METODO PARA LIMPIAR--->
        void limpiar()
        {
            
            cod_HabitacionesTextBox.Text = "";
            nombresTextBox.Text = "";
            precioTextBox.Text = "";
            estadoTextBox.Text = "";
          
        }
        //------fin-->

      
        //-----Eventos del Datagridview----->
        

       

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.habitacionesTableAdapter.FillBy(this.hotel5taRealDataSet.Habitaciones);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //---Fin--Eventos---->

        //Validacion de los campos------>
        
        private void cod_HabitacionesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            //Validacion de espacios----->
            if (cod_HabitacionesTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
           
        }

        private void nombresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            //Validacion de espacios----->
            if (cod_HabitacionesTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            //Validacion de espacios----->
            if (precioTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

        private void estadoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            //Validacion de espacios----->
            if (estadoTextBox.Text.Contains(" "))
            {   
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }
        //Validacion de Campos Vacios---->
        private bool Camposvacio()
        {
            bool ok = false;
            if (cod_HabitacionesTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cod_HabitacionesTextBox, "Ingresar Codigo");
            }
            if (nombresTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nombresTextBox, "Ingresar Nombre");
            }
            if (precioTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(precioTextBox, "Ingresar Precio");
            }
            if (estadoTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(estadoTextBox, "Ingresar Estado");
            }
           

            return ok;

        }

        //Fin Vaalidacion

        //--Fin--Validacion----->
    }
}
