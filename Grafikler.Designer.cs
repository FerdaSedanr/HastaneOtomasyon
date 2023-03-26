namespace HastaneOtomasyon
{
    partial class Grafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartKlinik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoktor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartKlinik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // chartKlinik
            // 
            chartArea1.Name = "ChartArea1";
            this.chartKlinik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartKlinik.Legends.Add(legend1);
            this.chartKlinik.Location = new System.Drawing.Point(58, 138);
            this.chartKlinik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartKlinik.Name = "chartKlinik";
            this.chartKlinik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Klinikler";
            this.chartKlinik.Series.Add(series1);
            this.chartKlinik.Size = new System.Drawing.Size(440, 417);
            this.chartKlinik.TabIndex = 0;
            this.chartKlinik.Text = "chart1";
            this.chartKlinik.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chartDoktor
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDoktor.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDoktor.Legends.Add(legend2);
            this.chartDoktor.Location = new System.Drawing.Point(659, 138);
            this.chartDoktor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartDoktor.Name = "chartDoktor";
            this.chartDoktor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Doktorlar";
            this.chartDoktor.Series.Add(series2);
            this.chartDoktor.Size = new System.Drawing.Size(440, 417);
            this.chartDoktor.TabIndex = 1;
            this.chartDoktor.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kliniklere Göre Hasta Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(655, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doktorlara Göre Hasta Sayısı";
            // 
            // Grafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1174, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDoktor);
            this.Controls.Add(this.chartKlinik);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Grafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.Grafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartKlinik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoktor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartKlinik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}