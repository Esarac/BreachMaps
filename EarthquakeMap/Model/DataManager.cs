using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;

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

                    Earthquake.EarthquakeMagnitudeType magnitudeType = Earthquake.EarthquakeMagnitudeType.NAN;
                    if (!String.IsNullOrEmpty(dataInfo[9]))
                    {
                        magnitudeType = (Earthquake.EarthquakeMagnitudeType)Enum.Parse(typeof(Earthquake.EarthquakeMagnitudeType), dataInfo[9]);
                    }
                    

                    Earthquake eq = new Earthquake(id, latitude, longitude, date, type, depth, magnitude, magnitudeType);
                    earthquakes.Add(eq);
                }
                catch (IndexOutOfRangeException) {
                    Console.WriteLine("Error en dato!");
                }
                //...
            }
        }

        public DataTable GenerateTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("DATE", typeof(DateTime));
            table.Columns.Add("LATITUDE", typeof(double));
            table.Columns.Add("LONGITUDE", typeof(double));
            table.Columns.Add("TYPE", typeof(string));
            table.Columns.Add("DEPTH", typeof(double));
            table.Columns.Add("MAGNITUDE", typeof(double));
            table.Columns.Add("MAGNITUDE TYPE", typeof(string));

            foreach(Earthquake earthquake in earthquakes)
            {
                DataRow row = table.NewRow();

                row["ID"] = earthquake.Id;
                row["DATE"] = earthquake.Date;
                row["LATITUDE"] = earthquake.Latitude;
                row["LONGITUDE"] = earthquake.Longitude;
                row["TYPE"] = earthquake.Type;
                row["DEPTH"] = earthquake.Depth;
                row["MAGNITUDE"] = earthquake.Magnitude;
                row["MAGNITUDE TYPE"] = earthquake.MagnitudeType;

                table.Rows.Add(row);
            }

            return table;
        }

        public DataTable GenerateMagnitudeTypeChart()
        {
            DataTable table = new DataTable();

            table.Columns.Add("X", typeof(string));
            table.Columns.Add("Y", typeof(int));

            string[] magnitudeTypes = Enum.GetNames(typeof(Earthquake.EarthquakeMagnitudeType));
            for (int i = 0; i < magnitudeTypes.Length; i++)
            {
                DataRow row = table.NewRow();

                row["X"] = magnitudeTypes[i];
                row["Y"] = 0;

                table.Rows.Add(row);
            }

            for (int i = 0; i < earthquakes.Count; i++)
            {
                table.Rows[(int)earthquakes[i].MagnitudeType]["Y"] = ((int)table.Rows[0]["Y"]) + 1;
            }

            for (int i = 0; i < magnitudeTypes.Length; i++)
            {
                Console.WriteLine(table.Rows[i]["X"]+": "+ table.Rows[i]["Y"]);
            }

            return table;
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