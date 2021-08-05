using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brundy3DX.Views
{
    public partial class DashBoard : UserControl
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDashBoard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvDashBoard_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblNombreMedicion.Text = "Nombre: " + dgvDashBoard.Columns[e.ColumnIndex].HeaderText;
        }
    }
}
