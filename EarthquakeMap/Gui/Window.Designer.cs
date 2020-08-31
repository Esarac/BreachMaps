namespace EarthquakeMap.Gui
{
    partial class Window
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.importLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.importButton = new System.Windows.Forms.Button();
            this.tabMenu = new MetroFramework.Controls.MetroTabControl();
            this.tabMap = new MetroFramework.Controls.MetroTabPage();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.tabTable = new MetroFramework.Controls.MetroTabPage();
            this.tabCharts = new MetroFramework.Controls.MetroTabPage();
            this.table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.importLayoutPanel.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.tabTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.Owner = this;
            this.styleManager.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // importLayoutPanel
            // 
            this.importLayoutPanel.Controls.Add(this.importButton);
            this.importLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.importLayoutPanel.Location = new System.Drawing.Point(20, 60);
            this.importLayoutPanel.Name = "importLayoutPanel";
            this.importLayoutPanel.Size = new System.Drawing.Size(1240, 45);
            this.importLayoutPanel.TabIndex = 0;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.White;
            this.importButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(15, 11);
            this.importButton.Margin = new System.Windows.Forms.Padding(15, 11, 3, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(98, 34);
            this.importButton.TabIndex = 1;
            this.importButton.TabStop = false;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.Import_Click);
            this.importButton.MouseEnter += new System.EventHandler(this.OnMouseHoverImportButton);
            this.importButton.MouseLeave += new System.EventHandler(this.OnMouseLeaveImportButton);
            this.importButton.MouseHover += new System.EventHandler(this.OnMouseHoverImportButton);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabMap);
            this.tabMenu.Controls.Add(this.tabTable);
            this.tabMenu.Controls.Add(this.tabCharts);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(20, 105);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 1;
            this.tabMenu.Size = new System.Drawing.Size(1240, 595);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.UseSelectable = true;
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.gMap);
            this.tabMap.HorizontalScrollbarBarColor = true;
            this.tabMap.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMap.HorizontalScrollbarSize = 0;
            this.tabMap.Location = new System.Drawing.Point(4, 38);
            this.tabMap.Name = "tabMap";
            this.tabMap.Size = new System.Drawing.Size(1232, 553);
            this.tabMap.TabIndex = 0;
            this.tabMap.Text = "  Map";
            this.tabMap.VerticalScrollbarBarColor = true;
            this.tabMap.VerticalScrollbarHighlightOnWheel = false;
            this.tabMap.VerticalScrollbarSize = 0;
            // 
            // gMap
            // 
            this.gMap.BackColor = System.Drawing.Color.White;
            this.gMap.Bearing = 0F;
            this.gMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
            this.gMap.Margin = new System.Windows.Forms.Padding(4);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(1232, 553);
            this.gMap.TabIndex = 1;
            this.gMap.Zoom = 0D;
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.table);
            this.tabTable.HorizontalScrollbar = true;
            this.tabTable.HorizontalScrollbarBarColor = true;
            this.tabTable.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTable.HorizontalScrollbarSize = 0;
            this.tabTable.Location = new System.Drawing.Point(4, 38);
            this.tabTable.Name = "tabTable";
            this.tabTable.Size = new System.Drawing.Size(1232, 553);
            this.tabTable.TabIndex = 1;
            this.tabTable.Text = "  Table";
            this.tabTable.VerticalScrollbar = true;
            this.tabTable.VerticalScrollbarBarColor = true;
            this.tabTable.VerticalScrollbarHighlightOnWheel = false;
            this.tabTable.VerticalScrollbarSize = 0;
            // 
            // tabCharts
            // 
            this.tabCharts.HorizontalScrollbarBarColor = true;
            this.tabCharts.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCharts.HorizontalScrollbarSize = 10;
            this.tabCharts.Location = new System.Drawing.Point(4, 38);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.Size = new System.Drawing.Size(1019, 387);
            this.tabCharts.TabIndex = 2;
            this.tabCharts.Text = "  Charts";
            this.tabCharts.VerticalScrollbarBarColor = true;
            this.tabCharts.VerticalScrollbarHighlightOnWheel = false;
            this.tabCharts.VerticalScrollbarSize = 10;
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.table.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(1232, 553);
            this.table.TabIndex = 2;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.importLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Window";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Breach Maps";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.importLayoutPanel.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMap.ResumeLayout(false);
            this.tabTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager styleManager;
        private MetroFramework.Controls.MetroTabControl tabMenu;
        private MetroFramework.Controls.MetroTabPage tabMap;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private MetroFramework.Controls.MetroTabPage tabTable;
        private MetroFramework.Controls.MetroTabPage tabCharts;
        private System.Windows.Forms.FlowLayoutPanel importLayoutPanel;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.DataGridView table;
    }
}

