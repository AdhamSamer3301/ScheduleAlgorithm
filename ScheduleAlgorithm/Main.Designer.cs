
namespace ScheduleAlgorithm
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Calc_Btn = new System.Windows.Forms.Button();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProcessTime_TxtBox = new System.Windows.Forms.TextBox();
            this.GanttChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProcessTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BurstTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaitTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TurnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.AvgWTTime_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GanttChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Calc_Btn
            // 
            this.Calc_Btn.Location = new System.Drawing.Point(54, 93);
            this.Calc_Btn.Name = "Calc_Btn";
            this.Calc_Btn.Size = new System.Drawing.Size(75, 23);
            this.Calc_Btn.TabIndex = 0;
            this.Calc_Btn.Text = "Calculate";
            this.Calc_Btn.UseVisualStyleBackColor = true;
            this.Calc_Btn.Click += new System.EventHandler(this.Calc_Btn_Click);
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.Location = new System.Drawing.Point(178, 92);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(75, 23);
            this.Reset_Btn.TabIndex = 1;
            this.Reset_Btn.Text = "Reset";
            this.Reset_Btn.UseVisualStyleBackColor = true;
            this.Reset_Btn.Click += new System.EventHandler(this.Reset_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Algorithm Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. of Processes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "FCFS";
            // 
            // ProcessTime_TxtBox
            // 
            this.ProcessTime_TxtBox.Location = new System.Drawing.Point(135, 52);
            this.ProcessTime_TxtBox.Name = "ProcessTime_TxtBox";
            this.ProcessTime_TxtBox.Size = new System.Drawing.Size(100, 20);
            this.ProcessTime_TxtBox.TabIndex = 4;
            // 
            // GanttChart
            // 
            chartArea2.Name = "ChartArea1";
            this.GanttChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GanttChart.Legends.Add(legend2);
            this.GanttChart.Location = new System.Drawing.Point(12, 138);
            this.GanttChart.Name = "GanttChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "GanttChart";
            this.GanttChart.Series.Add(series2);
            this.GanttChart.Size = new System.Drawing.Size(353, 257);
            this.GanttChart.TabIndex = 5;
            this.GanttChart.Text = "GanttChart";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessTime,
            this.BurstTime,
            this.WaitTime,
            this.TurnTime});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(371, 11);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(417, 337);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ProcessTime
            // 
            this.ProcessTime.Text = "Process Time";
            this.ProcessTime.Width = 78;
            // 
            // BurstTime
            // 
            this.BurstTime.Text = "Burst Time";
            this.BurstTime.Width = 69;
            // 
            // WaitTime
            // 
            this.WaitTime.Text = "Wait Time";
            // 
            // TurnTime
            // 
            this.TurnTime.Text = "Turn Around Time";
            this.TurnTime.Width = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Avg. Waiting TIme:";
            // 
            // AvgWTTime_Label
            // 
            this.AvgWTTime_Label.AutoSize = true;
            this.AvgWTTime_Label.Location = new System.Drawing.Point(503, 382);
            this.AvgWTTime_Label.Name = "AvgWTTime_Label";
            this.AvgWTTime_Label.Size = new System.Drawing.Size(35, 13);
            this.AvgWTTime_Label.TabIndex = 8;
            this.AvgWTTime_Label.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AvgWTTime_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.GanttChart);
            this.Controls.Add(this.ProcessTime_TxtBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.Calc_Btn);
            this.Name = "Form1";
            this.Text = "ScheduleAlgorithm";
            ((System.ComponentModel.ISupportInitialize)(this.GanttChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calc_Btn;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ProcessTime_TxtBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart GanttChart;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ProcessTime;
        private System.Windows.Forms.ColumnHeader BurstTime;
        private System.Windows.Forms.ColumnHeader WaitTime;
        private System.Windows.Forms.ColumnHeader TurnTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AvgWTTime_Label;
    }
}

