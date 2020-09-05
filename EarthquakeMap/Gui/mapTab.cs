using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using EarthquakeMap.Model;

namespace EarthquakeMap.Gui
{
    public partial class MapTab : UserControl
    {
        //Attributes
        private DataManager manager;

        public MapTab()
        {
            InitializeComponent();
            InitializeApplyButton();

        }

        private void InitializeApplyButton()
        {
            applyButton.FlatAppearance.MouseOverBackColor = applyButton.BackColor;
            applyButton.BackColorChanged += (s, e) => {
                applyButton.FlatAppearance.MouseOverBackColor = applyButton.BackColor;
            };
        }

        public void InitializeController(DataManager manager)
        {
            this.manager = manager;
            GenerateMap();
        }

        //Generator
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
        }

        private void yearTrack_Scroll(object sender, ScrollEventArgs e)
        {
            yearLabel.Text = yearTrack.Value.ToString();
        }

        private void OnMouseHoverApplyButton(object sender, EventArgs e)
        {
            applyButton.BackColor = Color.DarkOrange;
            applyButton.ForeColor = Color.White;
        }

        private void OnMouseLeaveApplyButton(object sender, EventArgs e)
        {
            applyButton.BackColor = Color.White;
            applyButton.ForeColor = Color.Black;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if(manager != null)
            {
                List<Earthquake> earthquakes = manager.GetEarthquakes(Int32.Parse(yearTrack.Value.ToString()));
                gMap.Overlays.Clear();

                GMapOverlay markers = new GMapOverlay("markers");

                foreach (Earthquake eq in earthquakes)
                {
                    GMapMarker marker = new GMarkerGoogle(new PointLatLng(eq.Latitude, eq.Longitude), GMarkerGoogleType.red_dot);
                    markers.Markers.Add(marker);
                    gMap.Overlays.Add(markers);
                }
            }
        }
    }
}
