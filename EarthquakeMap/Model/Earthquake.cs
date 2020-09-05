using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthquakeMap.Model
{
    class Earthquake
    {
        //Constants
        public enum EarthquakeType
        {
            EARTQUAKE,
            NUCLEAR_EXPLOSION,
            EXPLOSION,
            ROCK_BURST
        }

        public enum EarthquakeMagnitudeType
        {
            MW,
            MWC,
            MB,
            MWB,
            MWW,
            ML,
            MH,
            MS,
            MD,
            MWR,
            NAN
        }

        //Attributes
        private string id;

        private double latitude;
        private double longitude;

        private DateTime date;
        private EarthquakeType type;

        private double depth;

        private double magnitude;
        private EarthquakeMagnitudeType magnitudeType;

        //Properties
        public string Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public double Latitude
        {
            get { return latitude; }
            set { this.latitude = value; }
        }

        public double Longitude
        {
            get { return longitude; }
            set { this.longitude = value; }
        }

        public DateTime Date 
        {
            get { return date; }
            set { this.date = value; }
        }

        public EarthquakeType Type
        {
            get { return type; }
            set { this.type = value; }
        }

        public double Depth
        {
            get { return depth; }
            set { this.depth = value; }
        }

        public double Magnitude
        {
            get { return magnitude; }
            set { this.magnitude = value; }
        }

        public EarthquakeMagnitudeType MagnitudeType
        {
            get { return magnitudeType; }
            set { this.magnitudeType = value; }
        }

        //Constructor
        public Earthquake(string id, double latitude, double longitude, DateTime date, EarthquakeType type, double depth, double magnitude, EarthquakeMagnitudeType magnitudeType)
        {
            this.id = id;
            this.latitude = latitude;
            this.longitude = longitude;
            this.date = date;
            this.type = type;
            this.depth = depth;
            this.magnitude = magnitude;
            this.magnitudeType = magnitudeType;
        }

        //Methods
        public override string ToString()
        {
            return "[id:"+id+", latitude:"+latitude+", longitude:"+longitude+", date:"+date.ToString()+", type:"+type+", depth:"+depth+", magnitude:"+magnitude+", magnitude type:"+magnitudeType+"]";
        }

    }
}
