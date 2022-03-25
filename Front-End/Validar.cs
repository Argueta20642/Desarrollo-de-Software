using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel5taReal.Front_End
{
    class Validar
    {
        //------Metodo para verifacr solo letras---->
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (char.IsLetter(v.KeyChar))//validar si es una letra
            {
                v.Handled = false;
            }
            else if(char.IsSeparator(v.KeyChar))//validar si es un espacio
            {
                v.Handled = false;
            }

            else
            {
                v.Handled = true;
                MessageBox.Show("Solo letras");
            }
        }
        //---Fin Metodo--->
        //------Metodo para verificar solo Numeros---->
        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if(char.IsDigit(v.KeyChar))//validar si es un Digito
            {
                v.Handled = false;
            }
            else if (char.IsSeparator(v.KeyChar))//validar si es un espacio
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))//validar si es un control
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Numeros");
            }
        }
        //---Fin Metodo--->
        public static void Espacios(KeyPressEventArgs v)
        {
            v.Handled = v.KeyChar == Convert.ToChar(Keys.Space);
            MessageBox.Show("No se permite espacios.");
        }

       



    }
}
