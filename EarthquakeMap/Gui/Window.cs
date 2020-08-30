using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EarthquakeMap.Model;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace EarthquakeMap.Gui
{
    public partial class Window : Form
    {
        //Atributes
        private DataManager manager;

        //Constructor
        public Window()
        {
            InitializeComponent();
        }

        //Triggers
        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();

            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                this.manager = new DataManager(fileChooser.FileName);
                //Init
                GenerateMap();
            }
        }

        //Generators
        private void GenerateMap()
        {
            //Config
            gMap.DragButton = MouseButtons.Left;
            gMap.CanDragMap = true;
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.Position = new PointLatLng(manager.Earthquakes[0].Latitude, manager.Earthquakes[0].Longitude);
            gMap.MinZoom = 0;
            gMap.MaxZoom = 24;
            gMap.Zoom = 9;
            gMap.AutoScroll = true;
            //...
            foreach (Earthquake eq in manager.Earthquakes)
            {
                GMapOverlay markers = new GMapOverlay("markers");
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(eq.Latitude, eq.Longitude), GMarkerGoogleType.red_dot);
                markers.Markers.Add(marker);
                gMap.Overlays.Add(markers);
            }
        }
    }
}
