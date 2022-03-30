using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace TSP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Add("points");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.ChartAreas[0].AxisY.Maximum = 20;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[0].ChartType= SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Point;
            chart1.Series[1]["PixelPointWidth"] = "10";
            double time = double.Parse(ModelingTIme.Text);
            double lambda = double.Parse(Lambda.Text);
            double mt = double.Parse(Mt.Text);
            double sigma = double.Parse(Sigma.Text);
            Modeling mod = new Modeling();
            var total = mod.Start(time, lambda, mt, sigma);

            foreach (var val in total)
            {
                chart1.Series[0].Points.AddXY(val.Item1, val.Item2);
                chart1.Series[1].Points.AddXY(val.Item1, val.Item2);
            }
            label3.Text = Convert.ToString(total.Count());
        }
    }
}
