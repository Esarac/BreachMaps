using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EarthquakeMap.Model;

namespace EarthquakeMap.Gui
{
    public partial class Window : MetroFramework.Forms.MetroForm
    {
        //Atributes
        private DataManager manager;

        //Constructor
        public Window()
        {
            InitializeComponent();
            InitializeImportButton();
        }

        //Initializers
        private void InitializeImportButton()
        {
            importButton.FlatAppearance.MouseOverBackColor = importButton.BackColor;
            importButton.BackColorChanged += (s, e) => {
                importButton.FlatAppearance.MouseOverBackColor = importButton.BackColor;
            };
        }

        //Triggers
        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();

            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                this.manager = new DataManager(fileChooser.FileName);
                //Init
                mapTab.InitializeController(manager);
                GenerateTable();
                chartTab.InitializeCharts(manager);
            }
        }

        private void OnMouseHoverImportButton(object sender, EventArgs e)
        {
            importButton.BackColor = Color.DarkOrange;
            importButton.ForeColor = Color.White;
        }

        private void OnMouseLeaveImportButton(object sender, EventArgs e)
        {
            importButton.BackColor = Color.White;
            importButton.ForeColor = Color.Black;
        }

        //Generators
        private void GenerateTable()
        {
            table.DataSource = manager.GenerateDataTable();
            table.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            foreach (DataGridViewColumn column in table.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

    }
}
