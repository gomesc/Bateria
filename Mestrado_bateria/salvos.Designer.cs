﻿namespace Moura
{
    partial class f_salvos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_file = new System.Windows.Forms.ComboBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.chart_ten_file = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_current_file = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ten_file)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_current_file)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivo:";
            // 
            // cB_file
            // 
            this.cB_file.FormattingEnabled = true;
            this.cB_file.Location = new System.Drawing.Point(65, 10);
            this.cB_file.Name = "cB_file";
            this.cB_file.Size = new System.Drawing.Size(512, 21);
            this.cB_file.TabIndex = 1;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(583, 8);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // chart_ten_file
            // 
            chartArea7.Name = "ChartArea1";
            this.chart_ten_file.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart_ten_file.Legends.Add(legend7);
            this.chart_ten_file.Location = new System.Drawing.Point(16, 137);
            this.chart_ten_file.Name = "chart_ten_file";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Tensão";
            this.chart_ten_file.Series.Add(series7);
            this.chart_ten_file.Size = new System.Drawing.Size(300, 300);
            this.chart_ten_file.TabIndex = 4;
            this.chart_ten_file.Text = "chart1";
            // 
            // chart_current_file
            // 
            chartArea8.Name = "ChartArea1";
            this.chart_current_file.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart_current_file.Legends.Add(legend8);
            this.chart_current_file.Location = new System.Drawing.Point(361, 137);
            this.chart_current_file.Name = "chart_current_file";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Corrente";
            this.chart_current_file.Series.Add(series8);
            this.chart_current_file.Size = new System.Drawing.Size(300, 300);
            this.chart_current_file.TabIndex = 5;
            this.chart_current_file.Text = "chart2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(642, 91);
            this.textBox1.TabIndex = 6;
            // 
            // f_salvos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart_current_file);
            this.Controls.Add(this.chart_ten_file);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.cB_file);
            this.Controls.Add(this.label1);
            this.Name = "f_salvos";
            this.Text = "Dados Salvos";
            ((System.ComponentModel.ISupportInitialize)(this.chart_ten_file)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_current_file)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_file;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ten_file;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_current_file;
        private System.Windows.Forms.TextBox textBox1;
    }
}