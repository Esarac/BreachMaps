namespace EarthquakeMap.Gui
{
    partial class MapTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.yearTrack = new MetroFramework.Controls.MetroTrackBar();
            this.yearLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.Color.White;
            this.layoutPanel.Controls.Add(this.yearTrack);
            this.layoutPanel.Controls.Add(this.yearLabel);
            this.layoutPanel.Controls.Add(this.applyButton);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(836, 56);
            this.layoutPanel.TabIndex = 0;
            // 
            // yearTrack
            // 
            this.yearTrack.BackColor = System.Drawing.Color.Transparent;
            this.yearTrack.ForeColor = System.Drawing.Color.DarkOrange;
            this.yearTrack.Location = new System.Drawing.Point(11, 13);
            this.yearTrack.Margin = new System.Windows.Forms.Padding(11, 13, 3, 3);
            this.yearTrack.Maximum = 2016;
            this.yearTrack.Minimum = 1965;
            this.yearTrack.Name = "yearTrack";
            this.yearTrack.Size = new System.Drawing.Size(197, 23);
            this.yearTrack.Style = MetroFramework.MetroColorStyle.Orange;
            this.yearTrack.TabIndex = 0;
            this.yearTrack.Text = "yearTrack";
            this.yearTrack.Theme = MetroFramework.MetroThemeStyle.Light;
            this.yearTrack.UseCustomBackColor = true;
            this.yearTrack.Value = 1965;
            this.yearTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.yearTrack_Scroll);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(211, 15);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(0, 15, 3, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(40, 17);
            this.yearLabel.TabIndex = 1;
            this.yearLabel.Text = "1965";
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.White;
            this.applyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(257, 8);
            this.applyButton.Margin = new System.Windows.Forms.Padding(3, 8, 3, 2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(99, 34);
            this.applyButton.TabIndex = 2;
            this.applyButton.TabStop = false;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            this.applyButton.MouseLeave += new System.EventHandler(this.OnMouseLeaveApplyButton);
            this.applyButton.MouseHover += new System.EventHandler(this.OnMouseHoverApplyButton);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 56);
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
            this.gMap.Size = new System.Drawing.Size(836, 507);
            this.gMap.TabIndex = 1;
            this.gMap.Zoom = 0D;
            // 
            // MapTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.layoutPanel);
            this.Name = "MapTab";
            this.Size = new System.Drawing.Size(836, 563);
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private MetroFramework.Controls.MetroTrackBar yearTrack;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button applyButton;
    }
}
