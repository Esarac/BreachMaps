using System;
using System.Collections.Generic;
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
            Earthquake,
            Explosion,
            NuclearExplosion,
            RockBurst
        }

        //Attributes
        private string id;

        private double latitude;
        private double longitude;

        private DateTime date;
        private EarthquakeType type;

        private double depth;

        private double magnitude;
        private string magnitudeType;

        //Constructor
        public Earthquake(string id, double latitude, double longitude, DateTime date, EarthquakeType type, double depth, double magnitude, string magnitudeType)
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

    }
}
