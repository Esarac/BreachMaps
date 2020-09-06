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
            Track();

        }

        //Intializer
        private void InitializeApplyButton()
        {
            applyButton.FlatAppearance.MouseOverBackColor = applyButton.BackColor;
            applyButton.BackColorChanged += (s, e) => {
                applyButton.FlatAppearance.MouseOverBackColor = applyButton.BackColor;
            };
        }

        public void InitializeMap(DataManager manager)
        {
            this.manager = manager;
            GenerateMap();
            yearTrack.Enabled = true;
            yearLabel.Enabled = true;
            applyButton.Enabled = true;
        }

        private void Track()
        {
            yearTrack.UseStyleColors = true;
        }

        //Generator
        private void GenerateMap()
        {
            //Config
            gMap.DragButton = MouseButtons.Left;
            gMap.CanDragMap = true;
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.Position = new PointLatLng(0,0);
            gMap.MinZoom = 3;
            gMap.MaxZoom = 24;
            gMap.Zoom = 9;
            gMap.AutoScroll = true;
        }

        //Triggers
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
            List<Earthquake> earthquakes = manager.GetEarthquakes(Int32.Parse(yearTrack.Value.ToString()));
            gMap.Overlays.Clear();

            GMapOverlay markers = new GMapOverlay("markers");

            foreach (Earthquake eq in earthquakes)
            {
                GMarkerGoogleType pin = GMarkerGoogleType.red_small;

                switch (eq.Type)
                {
                    case Earthquake.EarthquakeType.EXPLOSION:
                        pin = GMarkerGoogleType.blue_small;
                        break;

                    case Earthquake.EarthquakeType.NUCLEAR_EXPLOSION:
                        pin = GMarkerGoogleType.green_small;
                        break;

                    case Earthquake.EarthquakeType.ROCK_BURST:
                        pin = GMarkerGoogleType.yellow_small;
                        break;
                }
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(eq.Latitude, eq.Longitude), pin);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("\n{0}\nID: {1}\nCOORDINATES: {2},{3}\nDATE: {4}\nDEPTH: {5}\nMAGNITUDE: {6} {7}", eq.Type.ToString(), eq.Id, eq.Latitude, eq.Longitude, eq.Date.ToString(), eq.Depth, eq.Magnitude, eq.MagnitudeType.ToString());
                markers.Markers.Add(marker);
            }

            gMap.Overlays.Add(markers);
        }
    }
}
