using Brundy3DX.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brundy3DX
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private Point spawnPositionViews = new Point(176, 107);
        Object lastViewInScreen;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Location = spawnPositionViews;
            lastViewInScreen = dash;
            Controls.Add(dash);
        }


        private void MoveWindow(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controls.Remove(((Control)lastViewInScreen));
            Application.Exit();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            Controls.Remove((Control)lastViewInScreen);
            DashBoard dash = new DashBoard();
            dash.Location = spawnPositionViews;
            lastViewInScreen = dash;
            Controls.Add(dash);
            lblTitulo.Text = "DashBoard";
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            Controls.Remove((Control)lastViewInScreen);
            Mapa map = new Mapa();
            map.Location = spawnPositionViews;
            lastViewInScreen = map;
            Controls.Add(map);
            lblTitulo.Text = "Mapa";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            Controls.Remove((Control)lastViewInScreen);
            Registros registros = new Registros();
            registros.Location = spawnPositionViews;
            lastViewInScreen = registros;
            Controls.Add(registros);
            lblTitulo.Text = "Registros";
        }
    }
}
