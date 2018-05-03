using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HermiteCurve
{
    public partial class HermiteCurveDemo : Form
    {
        private Queue<double> dataQueue;
        private const int DATA_LENGTH_INITAL_VALUE = 100;
        private const int DATA_HEIGHT_INITAL_VALUE = 1000;

        public HermiteCurveDemo()
        {
            InitializeComponent();
        }

        private void HermiteCurveDemo_Shown(object sender, EventArgs e)
        {
            this.dataHeight.Text = DATA_HEIGHT_INITAL_VALUE.ToString();
            this.dataLength.Text = DATA_LENGTH_INITAL_VALUE.ToString();

            this.DrawChart(DATA_LENGTH_INITAL_VALUE, DATA_HEIGHT_INITAL_VALUE);
            this.DrawSeries();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            this.DrawHermiteCurveCommand();
            this.DrawSeries();
        }

        private double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }

        private double hermite_curve(double currLocation, double startPos, double startSlope, double endPos, double endSlope)
        {
            return  (2 * Pow(currLocation, 3) - 3 * Pow(currLocation, 2) + 1) * startPos
                  + (Pow(currLocation, 3) - 2 * Pow(currLocation, 2) + currLocation) * startSlope
                  + (-2 * Pow(currLocation, 3) + 3 * Pow(currLocation, 2)) * endPos
                  + (Pow(currLocation, 3) - Pow(currLocation, 2)) * endSlope;
        }

        private void DrawHermiteCurveCommand()
        {
            int __maxSpeed = Convert.ToInt32(this.maxSpeed.Text);
            int __acceleration = Convert.ToInt32(this.acceleration.Text);
            int __startSpeed = Convert.ToInt32(this.inSpeed.Text);
            int __startSlope = Convert.ToInt32(this.inSlope.Text);
            int __endSpeed = Convert.ToInt32(this.outSpeed.Text);
            int __endSlope = Convert.ToInt32(this.outSlope.Text);
            int __length = Convert.ToInt32(this.dataLength.Text);

            if (__acceleration == 0)
            {
                MessageBox.Show("加速度為0無法計算");
                return;
            }

            int accTims = (__maxSpeed / __acceleration);
            int stableTims = __length - (accTims * 2);

            // clear queue empty data.
            this.dataQueue.Clear();

            if ((accTims * 2) <= __length)
            {
                // 第一階段加速
                for (int i = 0; i < accTims; i++)
                {
                    double t = (double)i / accTims;
                    double x = hermite_curve(t, __startSpeed, __startSlope, __maxSpeed, 0);
                    this.dataQueue.Enqueue(x);
                }

                // 最高速
                for (int i = 0; i < stableTims; i++)
                {
                    double t = (double)i / stableTims;
                    double x = hermite_curve(t, __maxSpeed, 0, __maxSpeed, 0);
                    this.dataQueue.Enqueue(x);
                }

                // 第三階段加速
                for (int i = 0; i < accTims; i++)
                {
                    double t = (double)i / accTims;
                    double x = hermite_curve(t, __maxSpeed, 0, __endSpeed, __endSlope);
                    this.dataQueue.Enqueue(x);
                }
            }
            else
            {
                double deltaVertex = __length / 2 * __acceleration;

                // 重新計算加減速時間
                accTims = __length / 2;

                // 第一階段加速
                for (int i = 0; i < accTims; i++)
                {
                    double t = (double)i / accTims;
                    double x = hermite_curve(t, __startSpeed, __startSlope, deltaVertex, __startSlope * -1);
                    this.dataQueue.Enqueue(x);
                }

                // 第二階段加速
                for (int i = 0; i < accTims; i++)
                {
                    double t = (double)i / accTims;
                    double x = hermite_curve(t, deltaVertex, 0, __endSpeed, __endSlope);
                    this.dataQueue.Enqueue(x);
                }
            }
        }

        private void DrawSeries()
        {
            this.chart1.Series[0].Points.Clear();
            for (int i = 0; i < dataQueue.Count; i++)
            {
                this.chart1.Series[0].Points.AddXY((i + 1), dataQueue.ElementAt(i));
            }
        }

        private void DrawChart(int length, int height)
        {
            this.dataQueue = new Queue<double>(length);
            for (int i = 0; i < length; i++)
            {
                this.dataQueue.Enqueue(0.0d);
            }

            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Series.Clear();
            Series series1 = new Series("加速度命令曲線");
            series1.ChartArea = "C1";
            this.chart1.Series.Add(series1);

            this.chart1.ChartAreas[0].AxisY.Minimum = height * -1;
            this.chart1.ChartAreas[0].AxisY.Maximum = height;
            this.chart1.ChartAreas[0].AxisX.Interval = 10;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Silver;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Silver;
            this.chart1.ChartAreas[0].AxisX.Title = "Times";
            this.chart1.ChartAreas[0].AxisY.Title = "Speed";


            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("加速度命令曲線");
            this.chart1.Titles[0].ForeColor = Color.RoyalBlue;
            this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            //設置圖表顯示樣式
            this.chart1.Series[0].Color = Color.Red;
            this.chart1.Titles[0].Text = "Hermite Curve 加速度演算法模擬";
            this.chart1.Series[0].ChartType = SeriesChartType.Line;
            this.chart1.Series[0].Points.Clear();
            this.chart1.ForeColor = Color.White;
        }

        private void chartConfig_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(this.dataLength.Text);
            int height = Convert.ToInt32(this.dataHeight.Text);

            this.DrawChart(length, height);
            this.DrawSeries();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 限制輸入區 僅有數字 '-' 'backspace' 允許使用
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 45);
        }

    }
}
