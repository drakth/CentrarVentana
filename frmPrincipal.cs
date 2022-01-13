using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace CentrarVentana
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //API para setear la posicion de la ventana.
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        //API para obtener el tamaño.
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        //API para buscar la ventana
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        Rectangle myRect = new Rectangle();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarProcesos();
        }

        void CargarProcesos()
        {
            //Obtenemos todos los window handles con el titulo de la ventana
            Process[] processlist = Process.GetProcesses();

            lstListaVentanas.Items.Clear();
            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    lstListaVentanas.Items.Add(process.Id.ToString() + "|" + process.MainWindowTitle);
                }
            }
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            CargarProcesos();
        }

        private void cmdCentrarVentana_Click(object sender, EventArgs e)
        {
            const short SWP_NOSIZE = 1;
            const short SWP_NOZORDER = 0X4;
            const int SWP_SHOWWINDOW = 0x0040;

            string valor = "";
            if(lstListaVentanas.SelectedIndex != -1)
            {
                valor = lstListaVentanas.Items[lstListaVentanas.SelectedIndex].ToString();
                string[] valores = valor.Split('|');

                Rectangle resolution = Screen.PrimaryScreen.Bounds;

                RECT rct;
                int idProceso = 0;
                idProceso = Convert.ToInt32(valores[0].ToString());

                IntPtr hwnd = FindWindow(null, valores[1]);

                if (!GetWindowRect(new HandleRef(hwnd, hwnd), out rct))
                {
                    MessageBox.Show("ERROR"); return;
                }

                myRect.X = rct.Left;
                myRect.Y = rct.Top;
                myRect.Width = rct.Right - rct.Left;
                myRect.Height = rct.Bottom - rct.Top;

                SetWindowPos(hwnd, 0, (resolution.Width / 2) - (myRect.Width / 2), (resolution.Height / 2) - (myRect.Height / 2), 0, 0, SWP_NOZORDER | SWP_NOSIZE | SWP_SHOWWINDOW);

            }else
            {
                MessageBox.Show("Seleccione un proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}