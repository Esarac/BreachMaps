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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.importLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.importButton = new System.Windows.Forms.Button();
            this.tabMenu = new MetroFramework.Controls.MetroTabControl();
            this.tabMap = new MetroFramework.Controls.MetroTabPage();
            this.tabTable = new MetroFramework.Controls.MetroTabPage();
            this.tabCharts = new MetroFramework.Controls.MetroTabPage();
            this.mapTab = new EarthquakeMap.Gui.MapTab();
            this.tableTab = new EarthquakeMap.Gui.TableTab();
            this.chartTab = new EarthquakeMap.Gui.ChartTab();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.importLayoutPanel.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.tabTable.SuspendLayout();
            this.tabCharts.SuspendLayout();
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
            this.importLayoutPanel.Location = new System.Drawing.Point(20, 74);
            this.importLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importLayoutPanel.Name = "importLayoutPanel";
            this.importLayoutPanel.Size = new System.Drawing.Size(1240, 34);
            this.importLayoutPanel.TabIndex = 0;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.White;
            this.importButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(15, 0);
            this.importButton.Margin = new System.Windows.Forms.Padding(15, 0, 3, 2);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(99, 34);
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
            this.tabMenu.Location = new System.Drawing.Point(20, 108);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1240, 592);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.UseSelectable = true;
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.mapTab);
            this.tabMap.HorizontalScrollbarBarColor = true;
            this.tabMap.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMap.HorizontalScrollbarSize = 0;
            this.tabMap.Location = new System.Drawing.Point(4, 38);
            this.tabMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMap.Name = "tabMap";
            this.tabMap.Size = new System.Drawing.Size(1232, 550);
            this.tabMap.TabIndex = 0;
            this.tabMap.Text = "  Map";
            this.tabMap.VerticalScrollbarBarColor = true;
            this.tabMap.VerticalScrollbarHighlightOnWheel = false;
            this.tabMap.VerticalScrollbarSize = 0;
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.tableTab);
            this.tabTable.HorizontalScrollbar = true;
            this.tabTable.HorizontalScrollbarBarColor = true;
            this.tabTable.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTable.HorizontalScrollbarSize = 0;
            this.tabTable.Location = new System.Drawing.Point(4, 38);
            this.tabTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTable.Name = "tabTable";
            this.tabTable.Size = new System.Drawing.Size(1232, 550);
            this.tabTable.TabIndex = 1;
            this.tabTable.Text = "  Table";
            this.tabTable.VerticalScrollbar = true;
            this.tabTable.VerticalScrollbarBarColor = true;
            this.tabTable.VerticalScrollbarHighlightOnWheel = false;
            this.tabTable.VerticalScrollbarSize = 0;
            // 
            // tabCharts
            // 
            this.tabCharts.Controls.Add(this.chartTab);
            this.tabCharts.HorizontalScrollbarBarColor = true;
            this.tabCharts.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCharts.HorizontalScrollbarSize = 0;
            this.tabCharts.Location = new System.Drawing.Point(4, 38);
            this.tabCharts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.Size = new System.Drawing.Size(1232, 550);
            this.tabCharts.TabIndex = 2;
            this.tabCharts.Text = "  Charts";
            this.tabCharts.VerticalScrollbarBarColor = true;
            this.tabCharts.VerticalScrollbarHighlightOnWheel = false;
            this.tabCharts.VerticalScrollbarSize = 0;
            // 
            // mapTab
            // 
            this.mapTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapTab.Location = new System.Drawing.Point(0, 0);
            this.mapTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapTab.Name = "mapTab";
            this.mapTab.Size = new System.Drawing.Size(1232, 550);
            this.mapTab.TabIndex = 2;
            // 
            // tableTab
            // 
            this.tableTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTab.Location = new System.Drawing.Point(0, 0);
            this.tableTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableTab.Name = "tableTab";
            this.tableTab.Size = new System.Drawing.Size(1232, 550);
            this.tableTab.TabIndex = 2;
            // 
            // chartTab
            // 
            this.chartTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTab.Location = new System.Drawing.Point(0, 0);
            this.chartTab.Margin = new System.Windows.Forms.Padding(5);
            this.chartTab.Name = "chartTab";
            this.chartTab.Size = new System.Drawing.Size(1232, 550);
            this.chartTab.TabIndex = 2;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.importLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 601);
            this.Name = "Window";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Breach Maps";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.importLayoutPanel.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMap.ResumeLayout(false);
            this.tabTable.ResumeLayout(false);
            this.tabCharts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager styleManager;
        private MetroFramework.Controls.MetroTabControl tabMenu;
        private MetroFramework.Controls.MetroTabPage tabMap;
        private MetroFramework.Controls.MetroTabPage tabTable;
        private MetroFramework.Controls.MetroTabPage tabCharts;
        private System.Windows.Forms.FlowLayoutPanel importLayoutPanel;
        private System.Windows.Forms.Button importButton;
        private MapTab mapTab;
        private ChartTab chartTab;
        private TableTab tableTab;
    }
}

