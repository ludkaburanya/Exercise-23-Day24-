using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string text = "Домик";

            g.Clear(Color.MidnightBlue);

            SolidBrush sB4 = new SolidBrush(Color.WhiteSmoke);
            g.FillEllipse(sB4, 400, 20, 300, 300);

            SolidBrush zB = new SolidBrush(Color.DarkGreen);
            g.FillRectangle(zB, 0, 220, 800, 820);

            SolidBrush cB = new SolidBrush(Color.DarkSlateGray);

            g.FillPolygon(cB, new Point[]
            {
                new Point(100,100),new Point(200,2),
                new Point(100,100),new Point(600,400),
                new Point(600,400),new Point(200,400),
                new Point(200,400),new Point(100,300)
            }
            );
            SolidBrush sB = new SolidBrush(Color.SandyBrown);
            g.FillRectangle(sB, 100, 100, 200, 120);

            SolidBrush tB = new SolidBrush(Color.SaddleBrown);
            g.FillRectangle(tB, 250, 140, 40, 80);

            SolidBrush bB = new SolidBrush(Color.SaddleBrown);
            g.FillRectangle(bB, 50, 60, 300, 40);

            SolidBrush rB = new SolidBrush(Color.SaddleBrown);
            g.FillRectangle(rB, 125, 40, 150, 40);

            SolidBrush aB = new SolidBrush(Color.SaddleBrown);
            g.FillRectangle(aB, 155, 20, 90, 40);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
