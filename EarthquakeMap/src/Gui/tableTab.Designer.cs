namespace EarthquakeMap.Gui
{
    partial class TableTab
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.attributeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.enumComboBox = new MetroFramework.Controls.MetroComboBox();
            this.minTextBox = new MetroFramework.Controls.MetroTextBox();
            this.maxTextBox = new MetroFramework.Controls.MetroTextBox();
            this.stringTextBox = new MetroFramework.Controls.MetroTextBox();
            this.minDate = new MetroFramework.Controls.MetroDateTime();
            this.maxDate = new MetroFramework.Controls.MetroDateTime();
            this.filterButton = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.attributeComboBox);
            this.flowLayoutPanel1.Controls.Add(this.enumComboBox);
            this.flowLayoutPanel1.Controls.Add(this.minTextBox);
            this.flowLayoutPanel1.Controls.Add(this.maxTextBox);
            this.flowLayoutPanel1.Controls.Add(this.stringTextBox);
            this.flowLayoutPanel1.Controls.Add(this.minDate);
            this.flowLayoutPanel1.Controls.Add(this.maxDate);
            this.flowLayoutPanel1.Controls.Add(this.filterButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(963, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // attributeComboBox
            // 
            this.attributeComboBox.Enabled = false;
            this.attributeComboBox.FormattingEnabled = true;
            this.attributeComboBox.ItemHeight = 24;
            this.attributeComboBox.Location = new System.Drawing.Point(11, 7);
            this.attributeComboBox.Margin = new System.Windows.Forms.Padding(11, 7, 3, 2);
            this.attributeComboBox.Name = "attributeComboBox";
            this.attributeComboBox.Size = new System.Drawing.Size(169, 30);
            this.attributeComboBox.TabIndex = 0;
            this.attributeComboBox.UseSelectable = true;
            this.attributeComboBox.SelectedIndexChanged += new System.EventHandler(this.attributeComboBox_SelectedIndexChanged);
            // 
            // enumComboBox
            // 
            this.enumComboBox.FormattingEnabled = true;
            this.enumComboBox.ItemHeight = 24;
            this.enumComboBox.Location = new System.Drawing.Point(187, 7);
            this.enumComboBox.Margin = new System.Windows.Forms.Padding(4, 7, 3, 2);
            this.enumComboBox.Name = "enumComboBox";
            this.enumComboBox.Size = new System.Drawing.Size(231, 30);
            this.enumComboBox.TabIndex = 1;
            this.enumComboBox.UseSelectable = true;
            this.enumComboBox.Visible = false;
            // 
            // minTextBox
            // 
            // 
            // 
            // 
            this.minTextBox.CustomButton.Image = null;
            this.minTextBox.CustomButton.Location = new System.Drawing.Point(95, 2);
            this.minTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minTextBox.CustomButton.Name = "";
            this.minTextBox.CustomButton.Size = new System.Drawing.Size(36, 33);
            this.minTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.minTextBox.CustomButton.TabIndex = 1;
            this.minTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.minTextBox.CustomButton.UseSelectable = true;
            this.minTextBox.CustomButton.Visible = false;
            this.minTextBox.Lines = new string[0];
            this.minTextBox.Location = new System.Drawing.Point(424, 10);
            this.minTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.minTextBox.MaxLength = 32767;
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.PasswordChar = '\0';
            this.minTextBox.PromptText = "Min";
            this.minTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.minTextBox.SelectedText = "";
            this.minTextBox.SelectionLength = 0;
            this.minTextBox.SelectionStart = 0;
            this.minTextBox.ShortcutsEnabled = true;
            this.minTextBox.Size = new System.Drawing.Size(101, 32);
            this.minTextBox.TabIndex = 4;
            this.minTextBox.UseSelectable = true;
            this.minTextBox.Visible = false;
            this.minTextBox.WaterMark = "Min";
            this.minTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.minTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // maxTextBox
            // 
            // 
            // 
            // 
            this.maxTextBox.CustomButton.Image = null;
            this.maxTextBox.CustomButton.Location = new System.Drawing.Point(95, 2);
            this.maxTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxTextBox.CustomButton.Name = "";
            this.maxTextBox.CustomButton.Size = new System.Drawing.Size(36, 33);
            this.maxTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.maxTextBox.CustomButton.TabIndex = 1;
            this.maxTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.maxTextBox.CustomButton.UseSelectable = true;
            this.maxTextBox.CustomButton.Visible = false;
            this.maxTextBox.Lines = new string[0];
            this.maxTextBox.Location = new System.Drawing.Point(531, 10);
            this.maxTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.maxTextBox.MaxLength = 32767;
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.PasswordChar = '\0';
            this.maxTextBox.PromptText = "Max";
            this.maxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.maxTextBox.SelectedText = "";
            this.maxTextBox.SelectionLength = 0;
            this.maxTextBox.SelectionStart = 0;
            this.maxTextBox.ShortcutsEnabled = true;
            this.maxTextBox.Size = new System.Drawing.Size(101, 32);
            this.maxTextBox.TabIndex = 5;
            this.maxTextBox.UseSelectable = true;
            this.maxTextBox.Visible = false;
            this.maxTextBox.WaterMark = "Max";
            this.maxTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.maxTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // stringTextBox
            // 
            // 
            // 
            // 
            this.stringTextBox.CustomButton.Image = null;
            this.stringTextBox.CustomButton.Location = new System.Drawing.Point(125, 2);
            this.stringTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stringTextBox.CustomButton.Name = "";
            this.stringTextBox.CustomButton.Size = new System.Drawing.Size(36, 33);
            this.stringTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.stringTextBox.CustomButton.TabIndex = 1;
            this.stringTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.stringTextBox.CustomButton.UseSelectable = true;
            this.stringTextBox.CustomButton.Visible = false;
            this.stringTextBox.Enabled = false;
            this.stringTextBox.Lines = new string[0];
            this.stringTextBox.Location = new System.Drawing.Point(638, 10);
            this.stringTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.stringTextBox.MaxLength = 32767;
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.PasswordChar = '\0';
            this.stringTextBox.PromptText = "Type the id";
            this.stringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stringTextBox.SelectedText = "";
            this.stringTextBox.SelectionLength = 0;
            this.stringTextBox.SelectionStart = 0;
            this.stringTextBox.ShortcutsEnabled = true;
            this.stringTextBox.Size = new System.Drawing.Size(124, 32);
            this.stringTextBox.TabIndex = 6;
            this.stringTextBox.UseSelectable = true;
            this.stringTextBox.WaterMark = "Type the id";
            this.stringTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.stringTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // minDate
            // 
            this.minDate.Location = new System.Drawing.Point(3, 51);
            this.minDate.Margin = new System.Windows.Forms.Padding(3, 7, 3, 2);
            this.minDate.MaxDate = new System.DateTime(2016, 12, 30, 0, 0, 0, 0);
            this.minDate.MinDate = new System.DateTime(1965, 1, 2, 0, 0, 0, 0);
            this.minDate.MinimumSize = new System.Drawing.Size(4, 30);
            this.minDate.Name = "minDate";
            this.minDate.Size = new System.Drawing.Size(267, 30);
            this.minDate.TabIndex = 7;
            this.minDate.Value = new System.DateTime(1965, 1, 2, 0, 0, 0, 0);
            this.minDate.Visible = false;
            // 
            // maxDate
            // 
            this.maxDate.Location = new System.Drawing.Point(276, 51);
            this.maxDate.Margin = new System.Windows.Forms.Padding(3, 7, 3, 2);
            this.maxDate.MaxDate = new System.DateTime(2016, 12, 30, 0, 0, 0, 0);
            this.maxDate.MinDate = new System.DateTime(1965, 1, 2, 0, 0, 0, 0);
            this.maxDate.MinimumSize = new System.Drawing.Size(4, 30);
            this.maxDate.Name = "maxDate";
            this.maxDate.Size = new System.Drawing.Size(267, 30);
            this.maxDate.TabIndex = 8;
            this.maxDate.Value = new System.DateTime(2016, 12, 30, 0, 0, 0, 0);
            this.maxDate.Visible = false;
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.White;
            this.filterButton.Enabled = false;
            this.filterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(551, 53);
            this.filterButton.Margin = new System.Windows.Forms.Padding(5, 9, 3, 2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(99, 34);
            this.filterButton.TabIndex = 3;
            this.filterButton.TabStop = false;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            this.filterButton.MouseLeave += new System.EventHandler(this.OnMouseLeaveFilterButton);
            this.filterButton.MouseHover += new System.EventHandler(this.OnMouseHoverFilterButton);
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 50);
            this.table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.table.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(963, 514);
            this.table.TabIndex = 3;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // TableTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TableTab";
            this.Size = new System.Drawing.Size(963, 564);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroComboBox attributeComboBox;
        private MetroFramework.Controls.MetroComboBox enumComboBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.DataGridView table;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox minTextBox;
        private MetroFramework.Controls.MetroTextBox maxTextBox;
        private MetroFramework.Controls.MetroTextBox stringTextBox;
        private MetroFramework.Controls.MetroDateTime minDate;
        private MetroFramework.Controls.MetroDateTime maxDate;
    }
}
