using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema12_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Graphics g;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();


            Brush blueBrush = new SolidBrush(Color.Blue);

            Color cl = Color.FromArgb(255, 255, 255);
            g.Clear(cl);
            Pen myPen = new Pen(Color.Black, 1);
            // Create points that define polygon.
            Point points1 = new Point(20, 60);
            Point points2 = new Point(60, 40);
            Point points3 = new Point(120, 20);
            Point points4 = new Point(200, 40);
            Point points5 = new Point(160, 60);
            Point points6 = new Point(120, 100);
            Point points7 = new Point(40, 80);
            Point[] curvePoints = {
                points1, points2 , points3 , points4 ,  points5 , points6, points7 ,
            };

            g.DrawPolygon(myPen, curvePoints);
            float tension = 0.5F;
            g.DrawClosedCurve(myPen, curvePoints, tension, FillMode.Alternate);



        }
    }
}
