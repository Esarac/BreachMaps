using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EarthquakeMap.Model;

namespace EarthquakeMap.Gui
{
    public partial class ChartTab : UserControl
    {
        //Attribute
        private DataManager manager;

        //Constructor
        public ChartTab()
        {
            InitializeComponent();
        }

        //Initializers
        public void InitializeCharts(DataManager manager){
            this.manager = manager;
            GenerateBarChart();
            GeneratePointChart();
            GeneratePieChart();
        }

        //Generators
        private void GenerateBarChart()
        {
            //Config
            barChart.Series["s"].XValueMember = "X";
            barChart.Series["s"].YValueMembers = "Y";
            //...
            barChart.DataSource = manager.GenerateBarChart();
            barChart.DataBind();
        }

        private void GeneratePointChart()
        {
            //Config
            pointChart.Series["s"].XValueMember = "X";
            pointChart.Series["s"].YValueMembers = "Y";
            //...
            pointChart.DataSource = manager.GeneratePointChart();
            pointChart.DataBind();
        }

        private void GeneratePieChart()
        {
            //Config
            pieChart.Series["s"].XValueMember = "X";
            pieChart.Series["s"].YValueMembers = "Y";
            //...
            pieChart.DataSource = manager.GeneratePieChart();
            pieChart.DataBind();
        }

    }
}
