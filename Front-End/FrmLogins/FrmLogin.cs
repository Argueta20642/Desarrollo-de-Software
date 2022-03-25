using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel5taReal.Front_End.FrmAdmin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //--Cadena de conexion--->
        

       
        //------Boton---Acceder---->
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=NEHIMAYA-PC\\NEHIMAYAPC;Initial Catalog=Hotel5taReal;Integrated Security=True");
            CamposVacios();
            try
            {
               //verificacion de Usuario-------->
                if(usuarioTextBox.Text !="Admin")
                    {
                    MessageBox.Show("Error Usuario");
                    usuarioTextBox.Clear();
                    }
                if(contraseñaTextBox.Text != "Password")
                {
                    MessageBox.Show("Error Contraseña");
                    contraseñaTextBox.Clear();
                }
                //fin Verificacion------>
                conexion.Open();
                string consulata = "select *from Usuario where Usuario='" +usuarioTextBox.Text+"' and Contraseña='" + contraseñaTextBox.Text+ "'";
                SqlCommand comando = new SqlCommand(consulata, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                MessageBox.Show("Acceso con Exito");

                if (lector.Read())
                {
                    errorProvider1.SetError(usuarioTextBox, "");
                    errorProvider1.SetError(contraseñaTextBox, "");
                    FrmAdmin.FrmAdministrador FAD = new FrmAdmin.FrmAdministrador();
                    FAD.Show();
                    this.Hide();
                    MessageBox.Show("Bienvenido");
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("DATOS INCORECTOS");
                }
                             

            }
            catch(Exception)
            {
                MessageBox.Show("Error");
                conexion.Close();
            }

            

        }
        //---Fin Boton--->
        //----Eventos---->
        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotel5taRealDataSet);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotel5taRealDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.hotel5taRealDataSet.Usuario);

        }
        //---Fin Evento----->

        //--Validacio de Campos---->
        private void usuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool ok = true;

            Validar.SoloLetras(e);
            //Validacion de espacios----->If
            if (usuarioTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
           

        }

        private void contraseñaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Validar.SoloLetras(e);
            //Validacion de espacios----->
            if (contraseñaTextBox.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale
            }
            if(contraseñaTextBox.Text.Contains("."))
            {
                e.Handled = false;
            }
            else

            {
                e.Handled = true;
                MessageBox.Show("No se permiten los puntos.");
            }
                

        }
        //Validacion de Campos Vacios
        private bool CamposVacios()
        {
            bool ok = true;
            if (usuarioTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(usuarioTextBox, "Ingresar usuario");
            }
            if (contraseñaTextBox.Text == "")
            {
                ok= false;
                errorProvider1.SetError(contraseñaTextBox, "Ingresar Contraseña");
            }
            return ok;
        }

        //------Fin Validacion---->
    }
}
