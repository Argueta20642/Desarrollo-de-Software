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
    public partial class FrmLoad : Form
    {
        public FrmLoad()
        {
            InitializeComponent();
        }

      
        // Evento para que el panel fucione como scrollbar--------->
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 599)
            {
                timer1.Stop();
                FrmMenuUsuario frmMu = new FrmMenuUsuario();
                frmMu.Show();
                this.Hide();

            }
        }
    }
}
