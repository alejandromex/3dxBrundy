using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class Mapa : UserControl
    {

        GMarkerGoogle marker;
        GMapOverlay mapOverlay;
        DataTable dt;

        int filaSeleccionada = 0;
        double LatInicial = 20.9688132813906;
        double LngInicial = -89.6250915527344;


        public Mapa()
        {
            InitializeComponent();
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            gMapa.DragButton = MouseButtons.Left;
            gMapa.CanDragMap = true;
            gMapa.MapProvider = GMapProviders.GoogleMap;
            gMapa.Position = new PointLatLng(LatInicial, LngInicial);
            gMapa.MinZoom = 0;
            gMapa.MaxZoom = 24;
            gMapa.Zoom = 9;
            gMapa.AutoScroll = true;
        }

        private void gMapa_Load(object sender, EventArgs e)
        {

        }
    }
}
