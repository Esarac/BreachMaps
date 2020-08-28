using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EarthquakeMap.Model
{
    class DataManager
    {
        //Attributes
        private List<Earthquake> earthquakes;

        //Constructor
        public DataManager()
        {
            this.earthquakes = new List<Earthquake>();
        }

    }
}
