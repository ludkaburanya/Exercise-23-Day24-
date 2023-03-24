using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            double xmin = double.Parse(textBox2.Text);
            double xmax = double.Parse(textBox1.Text);
            double step = double.Parse(textBox3.Text);
            int count = (int)Math.Ceiling((xmax - xmin) / step) + 1;
            double[] y1 = new double[count];
            double[] x = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = xmin + step * i;
                y1[i] = (a * x[i]) + b;
            }
            chart1.ChartAreas[0].AxisX.Minimum = xmin;
            chart1.ChartAreas[0].AxisX.Maximum = xmax;

            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;

            chart1.Series[0].Points.DataBindXY(x, y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
