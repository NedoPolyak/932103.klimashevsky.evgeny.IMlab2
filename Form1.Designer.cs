using System;

namespace lab1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLaunch = new System.Windows.Forms.Button();
            this.inputHeight = new System.Windows.Forms.TextBox();
            this.inputSpeed = new System.Windows.Forms.TextBox();
            this.inputAngle = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputSize = new System.Windows.Forms.TextBox();
            this.inputWeight = new System.Windows.Forms.TextBox();
            this.inputTimeStep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.outputDistance = new System.Windows.Forms.TextBox();
            this.outputMaxHeight = new System.Windows.Forms.TextBox();
            this.outputSpeed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angle";
            // 
            // btLaunch
            // 
            this.btLaunch.Location = new System.Drawing.Point(645, 498);
            this.btLaunch.Name = "btLaunch";
            this.btLaunch.Size = new System.Drawing.Size(75, 23);
            this.btLaunch.TabIndex = 3;
            this.btLaunch.Text = "Execute";
            this.btLaunch.UseVisualStyleBackColor = true;
            this.btLaunch.Click += new System.EventHandler(this.btLaunch_Click);
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(446, 410);
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(100, 20);
            this.inputHeight.TabIndex = 4;
            // 
            // inputSpeed
            // 
            this.inputSpeed.Location = new System.Drawing.Point(446, 451);
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(100, 20);
            this.inputSpeed.TabIndex = 5;
            // 
            // inputAngle
            // 
            this.inputAngle.Location = new System.Drawing.Point(446, 485);
            this.inputAngle.Name = "inputAngle";
            this.inputAngle.Size = new System.Drawing.Size(100, 20);
            this.inputAngle.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 392);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Weight";
            // 
            // inputSize
            // 
            this.inputSize.Location = new System.Drawing.Point(446, 520);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(100, 20);
            this.inputSize.TabIndex = 10;
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(446, 555);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(100, 20);
            this.inputWeight.TabIndex = 11;
            // 
            // inputTimeStep
            // 
            this.inputTimeStep.Location = new System.Drawing.Point(146, 427);
            this.inputTimeStep.Name = "inputTimeStep";
            this.inputTimeStep.Size = new System.Drawing.Size(100, 20);
            this.inputTimeStep.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "TimeStep";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Distance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "maxHeight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "endSpeed";
            // 
            // outputDistance
            // 
            this.outputDistance.Location = new System.Drawing.Point(146, 462);
            this.outputDistance.Name = "outputDistance";
            this.outputDistance.Size = new System.Drawing.Size(100, 20);
            this.outputDistance.TabIndex = 17;
            // 
            // outputMaxHeight
            // 
            this.outputMaxHeight.Location = new System.Drawing.Point(146, 501);
            this.outputMaxHeight.Name = "outputMaxHeight";
            this.outputMaxHeight.Size = new System.Drawing.Size(100, 20);
            this.outputMaxHeight.TabIndex = 18;
            // 
            // outputSpeed
            // 
            this.outputSpeed.Location = new System.Drawing.Point(146, 534);
            this.outputSpeed.Name = "outputSpeed";
            this.outputSpeed.Size = new System.Drawing.Size(100, 20);
            this.outputSpeed.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.outputSpeed);
            this.Controls.Add(this.outputMaxHeight);
            this.Controls.Add(this.outputDistance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputTimeStep);
            this.Controls.Add(this.inputWeight);
            this.Controls.Add(this.inputSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.inputAngle);
            this.Controls.Add(this.inputSpeed);
            this.Controls.Add(this.inputHeight);
            this.Controls.Add(this.btLaunch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLaunch;
        private System.Windows.Forms.TextBox inputHeight;
        private System.Windows.Forms.TextBox inputSpeed;
        private System.Windows.Forms.TextBox inputAngle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputSize;
        private System.Windows.Forms.TextBox inputWeight;
        private System.Windows.Forms.TextBox inputTimeStep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox outputDistance;
        private System.Windows.Forms.TextBox outputMaxHeight;
        private System.Windows.Forms.TextBox outputSpeed;
    }
}

