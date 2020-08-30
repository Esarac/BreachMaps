using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace EarthquakeMap.Model
{
    class DataManager
    {
        //Attributes
        private List<Earthquake> earthquakes;

        //Properties
        public List<Earthquake> Earthquakes
        {
            get { return earthquakes; }
            set { this.earthquakes = value; }
        }

        //Constructor
        public DataManager(string path)
        {
            this.earthquakes = new List<Earthquake>();
            Load(path);
        }

        //Methods
        public void Load(string path)
        {
            string[] info = File.ReadAllLines(path);
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");

            for (int i = 1; i < info.Length; i++)
            {
                //Split
                string[] dataInfo = Regex.Split(info[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                //...

                //Add
                try
                {
                    string id = dataInfo[16];
                    double latitude = Double.Parse(dataInfo[2], culture);
                    double longitude = Double.Parse(dataInfo[3], culture);

                    string[] dateInfo = dataInfo[0].Split('/');
                    string[] timeInfo = dataInfo[1].Split(':');
                    DateTime date = new DateTime(Int32.Parse(dateInfo[2]), Int32.Parse(dateInfo[0]), Int32.Parse(dateInfo[1]), Int32.Parse(timeInfo[0]), Int32.Parse(timeInfo[1]), Int32.Parse(timeInfo[2]));

                    string type = dataInfo[4];
                    double depth = Double.Parse(dataInfo[5], culture);
                    double magnitude = Double.Parse(dataInfo[8], culture);
                    string magnitudeType = dataInfo[9];

                    Earthquake eq = new Earthquake(id, latitude, longitude, date, type, depth, magnitude, magnitudeType);
                    earthquakes.Add(eq);
                }
                catch (IndexOutOfRangeException) {
                    Console.WriteLine("Error en dato!");
                }
                //...
            }
        }

        public override string ToString()
        {
            string toString = "Data:";
            for (int i = 0; i < earthquakes.Count; i++)
            {
                toString += "\n-" + earthquakes[i];
            }
            return toString;
        }
    }
}