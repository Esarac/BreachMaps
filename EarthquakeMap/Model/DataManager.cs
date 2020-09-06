using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace EarthquakeMap.Model
{
    public class DataManager
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
        public List<Earthquake> GetEarthquakes(int year)
        {
            List<Earthquake> list = new List<Earthquake>();

            foreach (Earthquake earthquake in earthquakes)
            {
                if(earthquake.Date.Year == year)
                {
                    list.Add(earthquake);
                }
            }
            
            return list;
        }

            //Table
        public DataTable GenerateEmptyTable()
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

            return table;
        }

        public DataTable GenerateDataTable()
        {
            DataTable table = GenerateEmptyTable();

            foreach (Earthquake earthquake in earthquakes)
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

        public DataTable GenerateIdTable(string id)//String
        {
            DataTable table = GenerateEmptyTable();
            int stringSize = id.Length;

            foreach (Earthquake earthquake in earthquakes)
            {
                if (stringSize <= earthquake.Id.Length)
                {
                    if (id.Equals(earthquake.Id.Substring(0, stringSize)))
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
                }
            }

            return table;
        }

        public DataTable GenerateDateTable(DateTime start, DateTime end)//Date
        {
            DataTable table = GenerateEmptyTable();

            foreach (Earthquake earthquake in earthquakes)
            {
                if ((earthquake.Date.CompareTo(start) >= 0) && (earthquake.Date.CompareTo(end) <= 0))
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
            }

            return table;
        }

        public DataTable GenerateLatitudeTable(double start, double end)//Number
        {
            DataTable table = GenerateEmptyTable();

            foreach (Earthquake earthquake in earthquakes)
            {
                if ((start <= earthquake.Latitude) && (earthquake.Latitude <= end))
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
            }

            return table;
        }

        public DataTable GenerateLongitudeTable(double start, double end)//Number
        {
            DataTable table = GenerateEmptyTable();

            foreach (Earthquake earthquake in earthquakes)
            {
                if ((start <= earthquake.Longitude) && (earthquake.Longitude <= end))
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
            }

            return table;
        }

        public DataTable GenerateTypeTable(Earthquake.EarthquakeType type)//Enum
        {
            DataTable table = GenerateEmptyTable();

            foreach (Earthquake earthquake in earthquakes)
            {
                if (type == earthquake.Type)
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
            }

            return table;
        }

        public DataTable GenerateDepthTable(double start, double end)//Number
        {
            DataTable table = GenerateEmptyTable();

            foreach (Earthquake earthquake in earthquakes)
            {
                if ((start <= earthquake.Depth) && (earthquake.Depth <= end))
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
            }

            return table;
        }

        public DataTable GenerateMagnitudeTable(double start, double end)//Number
        {
            DataTable table = GenerateEmptyTable();

            foreach (Earthquake earthquake in earthquakes)
            {
                if ((start <= earthquake.Magnitude) && (earthquake.Magnitude <= end))
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
            }

            return table;
        }

        public DataTable GenerateMagnitudeTypeTable(Earthquake.EarthquakeMagnitudeType type)//Enum
        {
            DataTable table = GenerateEmptyTable();

            foreach (Earthquake earthquake in earthquakes)
            {
                if (type == earthquake.MagnitudeType)
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
            }

            return table;
        }

            //Chart
        public DataTable GenerateBarChart()//MagnitudeType vs Quantity
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

        public DataTable GeneratePointChart()//Years vs AverageMagnitude
        {
            DataTable table = new DataTable();

            table.Columns.Add("X", typeof(int));
            table.Columns.Add("Y", typeof(double));

            for (int i = 0; i < earthquakes.Count; i++)
            {
                bool exist = false;
                for(int j = table.Rows.Count-1; (j >= 0) && !exist; j--)
                {
                    Console.WriteLine(earthquakes[i].Date.Year);
                    Console.WriteLine(table.Rows[j]["X"]);
                    if (((int)table.Rows[j]["X"]) == earthquakes[i].Date.Year)
                    {
                        exist = true;
                    }
                }

                if (!exist)
                {
                    DataRow row = table.NewRow();

                    row["X"] = earthquakes[i].Date.Year;
                    row["Y"] = AverageMagnitude(earthquakes[i].Date.Year);

                    table.Rows.Add(row);
                }
            }

            return table;
        }

        public DataTable GeneratePieChart()//Type vs AverageMagnitude
        {
            DataTable table = new DataTable();

            table.Columns.Add("X", typeof(string));
            table.Columns.Add("Y", typeof(double));

            for (int i = 0; i < earthquakes.Count; i++)
            {
                bool exist = false;
                for (int j = table.Rows.Count - 1; (j >= 0) && !exist; j--)
                {
                    if (((string)table.Rows[j]["X"]).Equals(earthquakes[i].Type.ToString()))
                    {
                        exist = true;
                    }
                }

                if (!exist)
                {
                    DataRow row = table.NewRow();

                    row["X"] = earthquakes[i].Type;
                    row["Y"] = AverageMagnitude(earthquakes[i].Type);

                    table.Rows.Add(row);
                }
            }

            return table;
        }

            //Load
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
                    //Id
                    string id = dataInfo[16];
                    //Latitude
                    double latitude = Double.Parse(dataInfo[2], culture);
                    //Latitude
                    double longitude = Double.Parse(dataInfo[3], culture);
                    //Date
                    string[] dateInfo = dataInfo[0].Split('/');
                    string[] timeInfo = dataInfo[1].Split(':');
                    DateTime date = new DateTime(Int32.Parse(dateInfo[2]), Int32.Parse(dateInfo[0]), Int32.Parse(dateInfo[1]), Int32.Parse(timeInfo[0]), Int32.Parse(timeInfo[1]), Int32.Parse(timeInfo[2]));
                    //Type
                    string typeS = dataInfo[4].Replace(' ', '_').ToUpper();
                    Earthquake.EarthquakeType type = (Earthquake.EarthquakeType)Enum.Parse(typeof(Earthquake.EarthquakeType), typeS);
                    //Depth
                    double depth = Double.Parse(dataInfo[5], culture);
                    //Magnitude
                    double magnitude = Double.Parse(dataInfo[8], culture);
                    //MagnitudeType
                    Earthquake.EarthquakeMagnitudeType magnitudeType = Earthquake.EarthquakeMagnitudeType.NAN;
                    if (!String.IsNullOrEmpty(dataInfo[9]))
                    {
                        magnitudeType = (Earthquake.EarthquakeMagnitudeType)Enum.Parse(typeof(Earthquake.EarthquakeMagnitudeType), dataInfo[9]);
                    }

                    Earthquake eq = new Earthquake(id, latitude, longitude, date, type, depth, magnitude, magnitudeType);
                    earthquakes.Add(eq);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Error en dato!");
                }
                //...
            }
        }

            //Suport
        public double AverageMagnitude(int year)
        {
            double average = 0;

            int quanity = 0;
            foreach (Earthquake earthquake in earthquakes){ 
                if(earthquake.Date.Year == year)
                {
                    average += earthquake.Magnitude;
                    quanity++;
                }
            }
            average /= quanity;

            return average;
        }

        public double AverageMagnitude(Earthquake.EarthquakeType type)
        {
            double average = 0;

            int quanity = 0;
            foreach (Earthquake earthquake in earthquakes)
            {
                if (earthquake.Type == type)
                {
                    average += earthquake.Magnitude;
                    quanity++;
                }
            }
            average /= quanity;

            return average;
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