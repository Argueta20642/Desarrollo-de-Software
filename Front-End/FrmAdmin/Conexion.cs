using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hotel5taReal
{
   public class Conexion
    {
        string cadena = "Data Source=NEHIMAYA-PC\\NEHIMAYAPC;Initial Catalog=Hotel5taReal;Integrated Security=True";
        public SqlConnection conexion = new SqlConnection("Data Source=NEHIMAYA-PC\\NEHIMAYAPC;Initial Catalog=Hotel5taReal;Integrated Security=True");

        //Constructor
        public Conexion()
        {
            conexion.ConnectionString = cadena;
            
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD ", ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            conexion.Close();
        }

    }
}