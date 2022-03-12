using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAccess;


namespace DataAccess
{
    public abstract class ConnectionSQL
    {
        

        public ConnectionSQL()
        {
            
        }

        //--Metodo pUblico para devolver el string de conexion-->
        public SqlConnection creaConexion()
        {
            //variable de tipo sqlconnection
            SqlConnection cadena = new SqlConnection();
            try
            {
                //crear cadena de conexion--->
                cadena.ConnectionString = "Data Source = NEHIMAYA - PC\\NEHIMAYAPC; Initial Catalog = Hotel5taReal; Integrated Security = True";
                


            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;//mostramos error establecido
            }

            return cadena;
        }
        //--FIN --->

      
        

        //----METODO PARA LISTAR---------->
        public DataTable Listar()
        {
            SqlDataReader Resultado;//nos permite leer una secuencia de filas en una tabla dentro de sql
            DataTable Tabla = new DataTable();
            SqlConnection consql = new SqlConnection();
            try
            {
                consql = creaConexion();
                SqlCommand comando = new SqlCommand("listar", consql);
                comando.CommandType = CommandType.StoredProcedure;
                consql.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (consql.State == ConnectionState.Open) consql.Close();
            }
        }
        //---FIN PARA LISTAR----->

        //---Buscar------>
        public DataTable buscar(string valor)
        {

            SqlDataReader Resultado;//nos permite leer una secuencia de filas en una tabla dentro de sql
            DataTable Tabla = new DataTable();
            SqlConnection consql = new SqlConnection();
            try
            {
                consql = creaConexion();
                SqlCommand comando = new SqlCommand("buscar", consql);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                consql.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (consql.State == ConnectionState.Open) consql.Close();
            }


        }

        //metodo para insertar datos
       


    }
}
