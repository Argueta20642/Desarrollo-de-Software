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


namespace Hotel5taReal.Front_End.FrmAdmin
{
    public partial class FrmPlanilla : Form
    {
        public FrmPlanilla()
        {
            InitializeComponent();
        }
        //--Cadena de conexion--->
        SqlConnection conexion = new SqlConnection("Data Source=NEHIMAYA-PC\\NEHIMAYAPC;Initial Catalog=Hotel5taReal;Integrated Security=True");
        private void FrmPlanilla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotel5taRealDataSet.Planilla' Puede moverla o quitarla según sea necesario.
            this.planillaTableAdapter.Fill(this.hotel5taRealDataSet.Planilla);


        }
        //-------------Evento click celdas--------->
        private void planillaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            bntNuevo.Enabled = false;
            btnAgregar.Enabled = false;
        }
        //---Fin--Celdas----->
        //---Inicio Botones-------->
        //---btnNUevo---->
        private void bntNuevo_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;


            limipiar();
        }
        //---btnModificar---->
        private void btnModificar_Click(object sender, EventArgs e)
        {

            btnAgregar.Enabled = false;
            bntNuevo.Enabled = false;


        }
        //---btnAgregar---->
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CamposVacios();


            int num1;


            num1 = Convert.ToInt32(cod_TrabajadorTextBox.Text);


          
            try

            {
                if (num1 <= 0)
                {
                    MessageBox.Show("error");
                }

                string query = "insert into Planilla  (Cod_Trabajador,NombreTrabajador,ApellidoTrabajador,DNI,Email,Sueldo,Estado) values (@Cod_Trabajador,@NombreTrabajador,@ApellidoTrabajador,@DNI,@Email,@Sueldo,@Estado)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Cod_Trabajador", cod_TrabajadorTextBox.Text);
                comando.Parameters.AddWithValue("@NombreTrabajador", nombreTrabajadorTextBox.Text);
                comando.Parameters.AddWithValue("@ApellidoTrabajador", apellidoTrabajadorTextBox.Text);
                comando.Parameters.AddWithValue("@DNI", dNITextBox.Text);
                comando.Parameters.AddWithValue("@Email", emailTextBox.Text);
                comando.Parameters.AddWithValue("@Sueldo", sueldoTextBox.Text);
                comando.Parameters.AddWithValue("@Estado", estadoTextBox.Text);
                comando.ExecuteNonQuery();
                planillaDataGridView.Refresh();
                MessageBox.Show("Trabajador Agregado¡");
                limipiar();
                conexion.Close();
                ErrorPlanilla.SetError(cod_TrabajadorTextBox,"");
                ErrorPlanilla.SetError(nombreTrabajadorTextBox,"");
                ErrorPlanilla.SetError(apellidoTrabajadorTextBox,"");
                ErrorPlanilla.SetError(dNITextBox,"");
                ErrorPlanilla.SetError(emailTextBox,"");
                ErrorPlanilla.SetError(sueldoTextBox,"");
                ErrorPlanilla.SetError(estadoTextBox, "");


            }
            catch (Exception)
            {
                MessageBox.Show("Error al Ingresar");
            }
            


        }
        //--Fin Botones------>

        //-----Metodo----para limpiar textbox
        private void limipiar()
        {
            cod_TrabajadorTextBox.Text = "";
            nombreTrabajadorTextBox.Text = "";
            apellidoTrabajadorTextBox.Text = "";
            dNITextBox.Text = "";
            emailTextBox.Text = "";
            sueldoTextBox.Text = "";
            estadoTextBox.Text = "";

        }
        //---Fin---Metodo----->

        //-----Inicion de Valaidacion----->
        private void cod_TrabajadorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            //Validacion de espacios----->
            if (cod_TrabajadorTextBox.Text.Contains(" "))
                {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
            if (cod_TrabajadorTextBox.Text.Contains(" 0"))
            {
                MessageBox.Show("No se permite 0");
                return;  //Sale
            }




        }

        private void nombreTrabajadorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            //Validacion de espacios----->
            if (nombreTrabajadorTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }

        }

        private void apellidoTrabajadorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            //Validacion de espacios----->
            if (apellidoTrabajadorTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

        private void dNITextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            //Validacion de espacios----->
            if (dNITextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

        private void sueldoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            if (sueldoTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }

        private void estadoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            if (estadoTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
        }
        //Valicacion de camposVacios------>
        private bool CamposVacios()
        {
            bool ok = true;
            if (cod_TrabajadorTextBox.Text == "")
            {
                ok = false;
                ErrorPlanilla.SetError(cod_TrabajadorTextBox, "Ingresar el cod");
            }
            
            if(nombreTrabajadorTextBox.Text=="")
            {
                ok = false;
                ErrorPlanilla.SetError(nombreTrabajadorTextBox, "Ingresar nombre");
            }
            if (apellidoTrabajadorTextBox.Text=="")
            {
                ok = false;
                ErrorPlanilla.SetError(apellidoTrabajadorTextBox, "Ingresar Aprellido");
            }
            if (dNITextBox.Text== "")
            {
                ok = false;
                ErrorPlanilla.SetError(dNITextBox, "Ingresar DNI");
            }
            if (emailTextBox.Text == "")
            {
                ok = false;
                ErrorPlanilla.SetError(emailTextBox, "Ingresar Email");
            }

            if (sueldoTextBox.Text== "")
            {
                ok = false;
                ErrorPlanilla.SetError(sueldoTextBox, "Ingresar Sueldo");
            }
            if (estadoTextBox.Text== "")
            {
                ok = false;
                ErrorPlanilla.SetError(estadoTextBox, "Ingresar Estado");
            }
            return ok;
        }


        //-----Inicion de Valaidacion----->




    }
}
