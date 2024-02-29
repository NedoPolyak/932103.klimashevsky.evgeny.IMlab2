using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal maxHeight=0, t, x, y, v0, cosa, sina, S, m, k, vx, vy;
        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;

        private void btLaunch_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                chart1.Series[0].Points.Clear();
                t = 0;
                x = 0;
                y = Convert.ToDecimal(inputHeight.Text);
                v0 = Convert.ToDecimal(inputSpeed.Text);
                double a = Convert.ToDouble(inputAngle.Text) * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                S = Convert.ToDecimal(inputSize.Text);
                m = Convert.ToDecimal(inputWeight.Text);
                k = 0.5M * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;
                chart1.Series[0].Points.AddXY(x, y);
                timer1.Start();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal dt = Convert.ToDecimal(inputTimeStep.Text);
            t += dt;
            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            if (y > maxHeight) maxHeight = y;
            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0)
            {
                decimal distance = x;
                decimal speedAtEndPoint = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
                outputDistance.Text = distance.ToString();
                outputMaxHeight.Text = maxHeight.ToString();
                outputSpeed.Text = speedAtEndPoint.ToString();
                timer1.Stop();
            }
        }
    }
}
