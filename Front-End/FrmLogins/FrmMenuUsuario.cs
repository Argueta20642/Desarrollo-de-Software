using Hotel5taReal.Front_End.FrmAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel5taReal.Front_End.FrmLogins
{
    public partial class FrmMenuUsuario : Form
    {
        public FrmMenuUsuario()
        {
            InitializeComponent();
        }

        //--- INICIO BOTONES DE MENU---------------->
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            FrmLogin lo = new FrmLogin();
            lo.Show();
            this.Hide();

        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            FrmUser.FrmRecepcion rv = new FrmUser.FrmRecepcion();
            rv.Show();
            this.Hide();
        }
        //--- FIN BOTONES DE MENU---------------->
    }
}
