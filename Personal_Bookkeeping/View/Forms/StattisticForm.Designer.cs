namespace Personal_Bookkeeping.View.Forms
{
    partial class StattisticForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SpendVsEarnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpendVsEarnChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SpendVsEarnChart
            // 
            this.SpendVsEarnChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.SpendVsEarnChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SpendVsEarnChart.Legends.Add(legend1);
            this.SpendVsEarnChart.Location = new System.Drawing.Point(549, 210);
            this.SpendVsEarnChart.Name = "SpendVsEarnChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.Name = "Transaction";
            this.SpendVsEarnChart.Series.Add(series1);
            this.SpendVsEarnChart.Size = new System.Drawing.Size(265, 249);
            this.SpendVsEarnChart.TabIndex = 0;
            this.SpendVsEarnChart.Text = "1";
            // 
            // StatisticChart
            // 
            this.StatisticChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.StatisticChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.StatisticChart.Legends.Add(legend2);
            this.StatisticChart.Location = new System.Drawing.Point(12, 104);
            this.StatisticChart.Name = "StatisticChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Black;
            series2.Name = "Spendings";
            series2.YValuesPerPoint = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Legend = "Legend1";
            series3.Name = "Earnings";
            this.StatisticChart.Series.Add(series2);
            this.StatisticChart.Series.Add(series3);
            this.StatisticChart.Size = new System.Drawing.Size(527, 355);
            this.StatisticChart.TabIndex = 1;
            this.StatisticChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(571, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spendings vs Earnings sum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(130, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transaction statistic for today";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Personal_Bookkeeping.Properties.Resources.statistic1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(667, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 141);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // StattisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatisticChart);
            this.Controls.Add(this.SpendVsEarnChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StattisticForm";
            this.Text = "StattisticForm";
            this.Load += new System.EventHandler(this.StattisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpendVsEarnChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SpendVsEarnChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart StatisticChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}