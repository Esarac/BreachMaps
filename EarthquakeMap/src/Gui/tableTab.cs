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
    public partial class TableTab : UserControl
    {
        //Attributes
        private DataManager manager;

        //Constructor
        public TableTab()
        {
            InitializeComponent();
            InitializeFilterButton();
            InitializeAttributeComboBox();
        }

        //Initializers
        public void InitializeTable(DataManager manager)
        {
            this.manager = manager;
            GenerateTable();
            attributeComboBox.Enabled = true;
            stringTextBox.Enabled = true;
            filterButton.Enabled = true;
        }

        private void InitializeFilterButton()
        {
            filterButton.FlatAppearance.MouseOverBackColor = filterButton.BackColor;
            filterButton.BackColorChanged += (s, e) => {
                filterButton.FlatAppearance.MouseOverBackColor = filterButton.BackColor;
            };
        }

        private void InitializeAttributeComboBox()
        {
            attributeComboBox.Items.AddRange(new string[] { "All", "Id", "Latitude", "Longitude", "Date", "Type", "Depth", "Magnitude", "Magnitude type" });
            attributeComboBox.SelectedIndex = 0;
        }

        private void InitializeTypeComboBox()
        {
            enumComboBox.Items.Clear();
            enumComboBox.Items.AddRange(new Enum[] { Earthquake.EarthquakeType.EARTHQUAKE, Earthquake.EarthquakeType.EXPLOSION, 
                Earthquake.EarthquakeType.NUCLEAR_EXPLOSION, Earthquake.EarthquakeType.ROCK_BURST });
            enumComboBox.SelectedIndex = 0;
            enumComboBox.Size = new System.Drawing.Size(168, 30);
        }

        private void InitializeMagnitudeTypeComboBox()
        {
            enumComboBox.Items.Clear();
            enumComboBox.Items.AddRange(new Enum[] { Earthquake.EarthquakeMagnitudeType.MB, Earthquake.EarthquakeMagnitudeType.MD, Earthquake.EarthquakeMagnitudeType.MH, 
                Earthquake.EarthquakeMagnitudeType.ML, Earthquake.EarthquakeMagnitudeType.MS, Earthquake.EarthquakeMagnitudeType.MW, Earthquake.EarthquakeMagnitudeType.MWB, 
                Earthquake.EarthquakeMagnitudeType.MWC, Earthquake.EarthquakeMagnitudeType.MWR, Earthquake.EarthquakeMagnitudeType.MWW, Earthquake.EarthquakeMagnitudeType.NAN });
            enumComboBox.SelectedIndex = 0;
            enumComboBox.Size = new System.Drawing.Size(70, 30);
        }

        //Generators
        private void GenerateTable()
        {
            //Config
            table.DataSource = manager.GenerateDataTable();
            table.EnableHeadersVisualStyles = false;
            table.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            table.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            //...
            foreach (DataGridViewColumn column in table.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        //Triggers
        private void OnMouseHoverFilterButton(object sender, EventArgs e)
        {
            filterButton.BackColor = Color.DarkOrange;
            filterButton.ForeColor = Color.White;
        }

        private void OnMouseLeaveFilterButton(object sender, EventArgs e)
        {
            filterButton.BackColor = Color.White;
            filterButton.ForeColor = Color.Black;
        }

        private void attributeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = attributeComboBox.SelectedIndex;

            switch (index)
            {
                //All
                case 0:
                    enumComboBox.Visible = false;
                    stringTextBox.Visible = false;
                    minTextBox.Visible = false;
                    maxTextBox.Visible = false;
                    minDate.Visible = false;
                    maxDate.Visible = false;
                    break;

                //id
                case 1:

                    enumComboBox.Visible = false;
                    stringTextBox.Visible = true;
                    stringTextBox.Clear();
                    minTextBox.Visible = false;
                    maxTextBox.Visible = false;
                    minDate.Visible = false;
                    maxDate.Visible = false;
                    break;
                
                //date
                case 4:

                    enumComboBox.Visible = false;
                    stringTextBox.Visible = false;
                    stringTextBox.Clear();
                    minTextBox.Visible = false;
                    maxTextBox.Visible = false;
                    minDate.Visible = true;
                    maxDate.Visible = true;
                    break;
                
                //type
                case 5:

                    enumComboBox.Visible = true;
                    stringTextBox.Visible = false;
                    minTextBox.Visible = false;
                    maxTextBox.Visible = false;
                    minDate.Visible = false;
                    maxDate.Visible = false;
                    InitializeTypeComboBox();
                    break;
                
                //magnitudeType
                case 8:
                    enumComboBox.Visible = true;
                    stringTextBox.Visible = false;
                    minTextBox.Visible = false;
                    maxTextBox.Visible = false;
                    minDate.Visible = false;
                    maxDate.Visible = false;
                    InitializeMagnitudeTypeComboBox();
                    break;
                

                //latitude, longitude, depth and magnitude
                default:

                    enumComboBox.Visible = false;
                    stringTextBox.Visible = false;
                    minTextBox.Visible = true;
                    minTextBox.Clear();
                    maxTextBox.Visible = true;
                    maxTextBox.Clear();
                    minDate.Visible = false;
                    maxDate.Visible = false;
                    break;
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            int index = attributeComboBox.SelectedIndex;

            switch (index)
            {
                //All
                case 0:

                    table.DataSource = manager.GenerateDataTable();
                    break;

                //id
                case 1:

                    table.DataSource = manager.GenerateIdTable(stringTextBox.Text);
                    break;

                //latitude
                case 2:

                    try
                    {
                        double min = Convert.ToDouble(minTextBox.Text);
                        double max = Convert.ToDouble(maxTextBox.Text);
                        table.DataSource = manager.GenerateLatitudeTable(min, max);
                    }
                    catch
                    {
                        table.DataSource = manager.GenerateEmptyTable();
                    }
                    break;

                //latitude
                case 3:

                    try
                    {
                        double min = Convert.ToDouble(minTextBox.Text);
                        double max = Convert.ToDouble(maxTextBox.Text);
                        table.DataSource = manager.GenerateLongitudeTable(min, max);
                    }
                    catch
                    {
                        table.DataSource = manager.GenerateEmptyTable();
                    }
                    break;

                //date
                case 4:

                    table.DataSource = manager.GenerateDateTable(minDate.Value, maxDate.Value);
                    break;

                //type
                case 5:
                    table.DataSource = manager.GenerateTypeTable((Earthquake.EarthquakeType)enumComboBox.SelectedItem);
                    break;

                //latitude
                case 6:

                    try
                    {
                        double min = Convert.ToDouble(minTextBox.Text);
                        double max = Convert.ToDouble(maxTextBox.Text);
                        table.DataSource = manager.GenerateDepthTable(min, max);
                    }
                    catch
                    {
                        table.DataSource = manager.GenerateEmptyTable();
                    }
                    break;

                //latitude
                case 7:

                    try
                    {
                        double min = Convert.ToDouble(minTextBox.Text);
                        double max = Convert.ToDouble(maxTextBox.Text);
                        table.DataSource = manager.GenerateMagnitudeTable(min, max);
                    }
                    catch
                    {
                        table.DataSource = manager.GenerateEmptyTable();
                    }
                    break;


                //magnitudeType
                case 8:

                    table.DataSource = manager.GenerateMagnitudeTypeTable((Earthquake.EarthquakeMagnitudeType) enumComboBox.SelectedItem);
                    break;
            }
        }
    }
}
