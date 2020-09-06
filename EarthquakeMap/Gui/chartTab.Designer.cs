namespace EarthquakeMap.Gui
{
    partial class ChartTab
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitPanel1 = new System.Windows.Forms.SplitContainer();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitPanel2 = new System.Windows.Forms.SplitContainer();
            this.pointChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.Panel1.SuspendLayout();
            this.splitPanel1.Panel2.SuspendLayout();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.Panel1.SuspendLayout();
            this.splitPanel2.Panel2.SuspendLayout();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitPanel1
            // 
            this.splitPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // splitPanel1.Panel1
            // 
            this.splitPanel1.Panel1.Controls.Add(this.barChart);
            // 
            // splitPanel1.Panel2
            // 
            this.splitPanel1.Panel2.Controls.Add(this.splitPanel2);
            this.splitPanel1.Size = new System.Drawing.Size(1263, 604);
            this.splitPanel1.SplitterDistance = 421;
            this.splitPanel1.TabIndex = 0;
            // 
            // barChart
            // 
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            this.barChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(0, 0);
            this.barChart.Name = "barChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "s";
            this.barChart.Series.Add(series1);
            this.barChart.Size = new System.Drawing.Size(421, 604);
            this.barChart.TabIndex = 0;
            this.barChart.Text = "chart1";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPanel2.Location = new System.Drawing.Point(0, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // splitPanel2.Panel1
            // 
            this.splitPanel2.Panel1.Controls.Add(this.pointChart);
            // 
            // splitPanel2.Panel2
            // 
            this.splitPanel2.Panel2.Controls.Add(this.pieChart);
            this.splitPanel2.Size = new System.Drawing.Size(838, 604);
            this.splitPanel2.SplitterDistance = 399;
            this.splitPanel2.TabIndex = 0;
            // 
            // pointChart
            // 
            chartArea2.Name = "ChartArea1";
            this.pointChart.ChartAreas.Add(chartArea2);
            this.pointChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.pointChart.Legends.Add(legend2);
            this.pointChart.Location = new System.Drawing.Point(0, 0);
            this.pointChart.Name = "pointChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "s";
            this.pointChart.Series.Add(series2);
            this.pointChart.Size = new System.Drawing.Size(399, 604);
            this.pointChart.TabIndex = 0;
            this.pointChart.Text = "chart2";
            // 
            // pieChart
            // 
            chartArea3.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea3);
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.pieChart.Legends.Add(legend3);
            this.pieChart.Location = new System.Drawing.Point(0, 0);
            this.pieChart.Name = "pieChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "s";
            this.pieChart.Series.Add(series3);
            this.pieChart.Size = new System.Drawing.Size(435, 604);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "chart3";
            // 
            // chartTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitPanel1);
            this.Name = "chartTab";
            this.Size = new System.Drawing.Size(1263, 604);
            this.splitPanel1.Panel1.ResumeLayout(false);
            this.splitPanel1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.splitPanel2.Panel1.ResumeLayout(false);
            this.splitPanel2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitPanel1;
        private System.Windows.Forms.SplitContainer splitPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pointChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
    }
}
