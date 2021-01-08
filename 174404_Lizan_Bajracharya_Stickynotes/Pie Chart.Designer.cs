namespace _174404_Lizan_Bajracharya_Stickynotes
{
    partial class Pie_Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIncompleted = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIncomplete = new System.Windows.Forms.Label();
            this.lblComplete = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIncom = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIncomple = new System.Windows.Forms.Label();
            this.lblComplet = new System.Windows.Forms.Label();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblIncompleted);
            this.panel1.Controls.Add(this.lblCompleted);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 216);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Today Chart";
            // 
            // lblIncompleted
            // 
            this.lblIncompleted.AutoSize = true;
            this.lblIncompleted.Location = new System.Drawing.Point(206, 125);
            this.lblIncompleted.Name = "lblIncompleted";
            this.lblIncompleted.Size = new System.Drawing.Size(65, 13);
            this.lblIncompleted.TabIndex = 2;
            this.lblIncompleted.Text = "Incompleted";
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(214, 104);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(57, 13);
            this.lblCompleted.TabIndex = 1;
            this.lblCompleted.Text = "Completed";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series1.Legend = "Legend1";
            series1.Name = "CurrentDate";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(302, 210);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblIncomplete);
            this.panel2.Controls.Add(this.lblComplete);
            this.panel2.Controls.Add(this.chart3);
            this.panel2.Location = new System.Drawing.Point(323, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 216);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Week Chart";
            // 
            // lblIncomplete
            // 
            this.lblIncomplete.AutoSize = true;
            this.lblIncomplete.Location = new System.Drawing.Point(183, 125);
            this.lblIncomplete.Name = "lblIncomplete";
            this.lblIncomplete.Size = new System.Drawing.Size(65, 13);
            this.lblIncomplete.TabIndex = 3;
            this.lblIncomplete.Text = "Incompleted";
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Location = new System.Drawing.Point(191, 104);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(57, 13);
            this.lblComplete.TabIndex = 2;
            this.lblComplete.Text = "Completed";
            // 
            // chart3
            // 
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(0, 0);
            this.chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series2.Legend = "Legend1";
            series2.Name = "OneWeek";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(291, 210);
            this.chart3.TabIndex = 1;
            this.chart3.Text = "chart3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblIncom);
            this.panel3.Controls.Add(this.lblComp);
            this.panel3.Controls.Add(this.chart2);
            this.panel3.Location = new System.Drawing.Point(6, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 222);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Month Chart";
            // 
            // lblIncom
            // 
            this.lblIncom.AutoSize = true;
            this.lblIncom.Location = new System.Drawing.Point(198, 130);
            this.lblIncom.Name = "lblIncom";
            this.lblIncom.Size = new System.Drawing.Size(65, 13);
            this.lblIncom.TabIndex = 5;
            this.lblIncom.Text = "Incompleted";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(206, 108);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(57, 13);
            this.lblComp.TabIndex = 4;
            this.lblComp.Text = "Completed";
            this.lblComp.Click += new System.EventHandler(this.label4_Click);
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series3.Legend = "Legend1";
            series3.Name = "OneMonth";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(305, 210);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblIncomple);
            this.panel4.Controls.Add(this.lblComplet);
            this.panel4.Controls.Add(this.chart4);
            this.panel4.Location = new System.Drawing.Point(323, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 222);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year Chart";
            // 
            // lblIncomple
            // 
            this.lblIncomple.AutoSize = true;
            this.lblIncomple.Location = new System.Drawing.Point(183, 130);
            this.lblIncomple.Name = "lblIncomple";
            this.lblIncomple.Size = new System.Drawing.Size(65, 13);
            this.lblIncomple.TabIndex = 5;
            this.lblIncomple.Text = "Incompleted";
            // 
            // lblComplet
            // 
            this.lblComplet.AutoSize = true;
            this.lblComplet.Location = new System.Drawing.Point(191, 108);
            this.lblComplet.Name = "lblComplet";
            this.lblComplet.Size = new System.Drawing.Size(57, 13);
            this.lblComplet.TabIndex = 4;
            this.lblComplet.Text = "Completed";
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(5, 6);
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series4.Legend = "Legend1";
            series4.Name = "Oneyear";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(291, 210);
            this.chart4.TabIndex = 1;
            this.chart4.Text = "chart4";
            // 
            // Pie_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 453);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Pie_Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pie_Chart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pie_Chart_FormClosed);
            this.Load += new System.EventHandler(this.Pie_Chart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Label lblIncompleted;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblIncomplete;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Label lblIncom;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblIncomple;
        private System.Windows.Forms.Label lblComplet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}