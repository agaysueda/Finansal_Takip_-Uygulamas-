namespace Finansal_Takip__Uygulaması
{
    partial class ana_sayfa
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.Gider = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.finansal_takip_uygulamasiDataSet = new Finansal_Takip__Uygulaması.finansal_takip_uygulamasiDataSet();
            this.giderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giderTableAdapter = new Finansal_Takip__Uygulaması.finansal_takip_uygulamasiDataSetTableAdapters.giderTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uyenumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderkategorisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidermiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidertarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finansal_takip_uygulamasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(315, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gelir-Gider Takip";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gider
            // 
            this.Gider.BackColor = System.Drawing.Color.Salmon;
            this.Gider.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gider.Location = new System.Drawing.Point(82, 300);
            this.Gider.Name = "Gider";
            this.Gider.Size = new System.Drawing.Size(134, 107);
            this.Gider.TabIndex = 1;
            this.Gider.Text = "Gider";
            this.Gider.UseVisualStyleBackColor = false;
            this.Gider.Click += new System.EventHandler(this.Gider_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1011, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 107);
            this.button2.TabIndex = 2;
            this.button2.Text = "Gelir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(315, 134);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "gelir_gider";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(605, 492);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // finansal_takip_uygulamasiDataSet
            // 
            this.finansal_takip_uygulamasiDataSet.DataSetName = "finansal_takip_uygulamasiDataSet";
            this.finansal_takip_uygulamasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderBindingSource
            // 
            this.giderBindingSource.DataMember = "gider";
            this.giderBindingSource.DataSource = this.finansal_takip_uygulamasiDataSet;
            // 
            // giderTableAdapter
            // 
            this.giderTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uyenumarasiDataGridViewTextBoxColumn,
            this.giderkategorisiDataGridViewTextBoxColumn,
            this.gidermiktariDataGridViewTextBoxColumn,
            this.gidertarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(296, 661);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(664, 194);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // uyenumarasiDataGridViewTextBoxColumn
            // 
            this.uyenumarasiDataGridViewTextBoxColumn.DataPropertyName = "uye_numarasi";
            this.uyenumarasiDataGridViewTextBoxColumn.HeaderText = "uye_numarasi";
            this.uyenumarasiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.uyenumarasiDataGridViewTextBoxColumn.Name = "uyenumarasiDataGridViewTextBoxColumn";
            this.uyenumarasiDataGridViewTextBoxColumn.Width = 150;
            // 
            // giderkategorisiDataGridViewTextBoxColumn
            // 
            this.giderkategorisiDataGridViewTextBoxColumn.DataPropertyName = "gider_kategorisi";
            this.giderkategorisiDataGridViewTextBoxColumn.HeaderText = "gider_kategorisi";
            this.giderkategorisiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.giderkategorisiDataGridViewTextBoxColumn.Name = "giderkategorisiDataGridViewTextBoxColumn";
            this.giderkategorisiDataGridViewTextBoxColumn.Width = 150;
            // 
            // gidermiktariDataGridViewTextBoxColumn
            // 
            this.gidermiktariDataGridViewTextBoxColumn.DataPropertyName = "gider_miktari";
            this.gidermiktariDataGridViewTextBoxColumn.HeaderText = "gider_miktari";
            this.gidermiktariDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gidermiktariDataGridViewTextBoxColumn.Name = "gidermiktariDataGridViewTextBoxColumn";
            this.gidermiktariDataGridViewTextBoxColumn.Width = 150;
            // 
            // gidertarihDataGridViewTextBoxColumn
            // 
            this.gidertarihDataGridViewTextBoxColumn.DataPropertyName = "gider_tarih";
            this.gidertarihDataGridViewTextBoxColumn.HeaderText = "gider_tarih";
            this.gidertarihDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gidertarihDataGridViewTextBoxColumn.Name = "gidertarihDataGridViewTextBoxColumn";
            this.gidertarihDataGridViewTextBoxColumn.Width = 150;
            // 
            // ana_sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1244, 906);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Gider);
            this.Controls.Add(this.label1);
            this.Name = "ana_sayfa";
            this.Text = "s";
            this.Load += new System.EventHandler(this.ana_sayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finansal_takip_uygulamasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private finansal_takip_uygulamasiDataSet finansal_takip_uygulamasiDataSet;
        private System.Windows.Forms.BindingSource giderBindingSource;
        private finansal_takip_uygulamasiDataSetTableAdapters.giderTableAdapter giderTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyenumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderkategorisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidermiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidertarihDataGridViewTextBoxColumn;
    }
}