using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hotel5taReal.Front_End.FrmAdmin
{
    public partial class FrmAdministrador : Form
    {
        //---VARIABLE DE LOS BORDES----------------------------------->
        private int borderSize = 2;
        private Size formSize;

        public FrmAdministrador()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244);//Border color

        }
        //---INICIO  IMPORTACION DEL USER32.DLL----------------------->
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //---FIN USER32.DL----------------------->



        //---INICIO DE LOS BOTONES----------------------->
        //---BOTON HOME----------------------->
        private void btnHome_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmHomeAd());
        }
        //---BOTON PLANILLA----------------------->
        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmPlanilla());
        }
        //---BOTON FACTURAS----------------------->
        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmFacturas());
        }
        //---BOTON RESERVAR----------------------->
        private void btnReservar_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmReservar());
        }
        //---BOTON SALIR----------------------->
        private void bntSalir_Click(object sender, EventArgs e)
        {
            FrmLogins.FrmMenuUsuario frmUS = new FrmLogins.FrmMenuUsuario();
            frmUS.Show();
            this.Hide();
        }
        //---BOTON MINIMIZAR----------------------->
        private void bntMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //---BOTON MAXIMIZAR----------------------->
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }
        //---BOTON EXIT----------------------->
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //---BOTON REPORTERIA-------------->
        private void btnReporte_Click(object sender, EventArgs e)
        {
            Front_End.FrmLogins.FrmManuReporte Rt = new FrmLogins.FrmManuReporte();
            Rt.Show();
                
        }
        //---FIN DE LOS BOTONES----------------------->

        //----INICIO- CLASE PARA ABRIR EL FROMULARIO EN EL PANEL-------------->
        private void Abrirformhijo(object formhijo)
        {
            if (this.pnlEscritorio.Controls.Count > 0) this.pnlEscritorio.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlEscritorio.Controls.Add(fh);
            this.pnlEscritorio.Tag = fh;
            fh.Show();
        }
        //----FIN- CLASE PARA ABRIR EL FROMULARIO EN EL PANEL-------------->

        //---EVENTO  RESIZE DEL FRMADMINISTRADOR----------------------->
        private void FrmAdministrador_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        //---FIN EVENTO  RESIZE DEL FRMADMINISTRADOR----------------------->

        //---INICIO - OCULTAR BORDE DE FORMULARIO----------------------------------->
        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        //METODO PRIVADO PARA ADJUSTAR EL FRM------>
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void pnlBorder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //FIN METODO--------->
        //---FIN - - OCULTAR BORDE DE FORMULARIO----------------------------------->



    }
}
