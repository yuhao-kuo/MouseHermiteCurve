namespace HermiteCurve
{
    partial class HermiteCurveDemo
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inSpeed = new System.Windows.Forms.TextBox();
            this.outSpeed = new System.Windows.Forms.TextBox();
            this.inSlope = new System.Windows.Forms.TextBox();
            this.outSlope = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataLength = new System.Windows.Forms.TextBox();
            this.dataHeight = new System.Windows.Forms.TextBox();
            this.chartConfig = new System.Windows.Forms.Button();
            this.maxSpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.acceleration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1040, 460);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(864, 515);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(188, 54);
            this.draw.TabIndex = 9;
            this.draw.Text = "產生命令曲線";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "進入速度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "結束速度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "進入斜率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "結束斜率";
            // 
            // inSpeed
            // 
            this.inSpeed.Location = new System.Drawing.Point(521, 505);
            this.inSpeed.Name = "inSpeed";
            this.inSpeed.Size = new System.Drawing.Size(100, 22);
            this.inSpeed.TabIndex = 14;
            this.inSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // outSpeed
            // 
            this.outSpeed.Location = new System.Drawing.Point(521, 550);
            this.outSpeed.Name = "outSpeed";
            this.outSpeed.Size = new System.Drawing.Size(100, 22);
            this.outSpeed.TabIndex = 15;
            this.outSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // inSlope
            // 
            this.inSlope.Location = new System.Drawing.Point(742, 505);
            this.inSlope.Name = "inSlope";
            this.inSlope.Size = new System.Drawing.Size(100, 22);
            this.inSlope.TabIndex = 16;
            this.inSlope.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // outSlope
            // 
            this.outSlope.Location = new System.Drawing.Point(742, 550);
            this.outSlope.Name = "outSlope";
            this.outSlope.Size = new System.Drawing.Size(100, 22);
            this.outSlope.TabIndex = 17;
            this.outSlope.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "資料長度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "資料高度";
            // 
            // dataLength
            // 
            this.dataLength.Location = new System.Drawing.Point(106, 505);
            this.dataLength.Name = "dataLength";
            this.dataLength.Size = new System.Drawing.Size(100, 22);
            this.dataLength.TabIndex = 20;
            this.dataLength.Text = "100";
            this.dataLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // dataHeight
            // 
            this.dataHeight.Location = new System.Drawing.Point(106, 544);
            this.dataHeight.Name = "dataHeight";
            this.dataHeight.Size = new System.Drawing.Size(100, 22);
            this.dataHeight.TabIndex = 21;
            this.dataHeight.Text = "1000";
            this.dataHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // chartConfig
            // 
            this.chartConfig.Location = new System.Drawing.Point(231, 511);
            this.chartConfig.Name = "chartConfig";
            this.chartConfig.Size = new System.Drawing.Size(188, 54);
            this.chartConfig.TabIndex = 22;
            this.chartConfig.Text = "圖型設定";
            this.chartConfig.UseVisualStyleBackColor = true;
            this.chartConfig.Click += new System.EventHandler(this.chartConfig_Click);
            // 
            // maxSpeed
            // 
            this.maxSpeed.Location = new System.Drawing.Point(521, 600);
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.Size = new System.Drawing.Size(100, 22);
            this.maxSpeed.TabIndex = 24;
            this.maxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "最高速度";
            // 
            // acceleration
            // 
            this.acceleration.Location = new System.Drawing.Point(742, 597);
            this.acceleration.Name = "acceleration";
            this.acceleration.Size = new System.Drawing.Size(100, 22);
            this.acceleration.TabIndex = 26;
            this.acceleration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "加速度";
            // 
            // HermiteCurveDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 651);
            this.Controls.Add(this.acceleration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chartConfig);
            this.Controls.Add(this.dataHeight);
            this.Controls.Add(this.dataLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outSlope);
            this.Controls.Add(this.inSlope);
            this.Controls.Add(this.outSpeed);
            this.Controls.Add(this.inSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.chart1);
            this.Name = "HermiteCurveDemo";
            this.Text = "Hermite Curve Demo";
            this.Shown += new System.EventHandler(this.HermiteCurveDemo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inSpeed;
        private System.Windows.Forms.TextBox outSpeed;
        private System.Windows.Forms.TextBox inSlope;
        private System.Windows.Forms.TextBox outSlope;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dataLength;
        private System.Windows.Forms.TextBox dataHeight;
        private System.Windows.Forms.Button chartConfig;
        private System.Windows.Forms.TextBox maxSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox acceleration;
        private System.Windows.Forms.Label label8;
    }
}

