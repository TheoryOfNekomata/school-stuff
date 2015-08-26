using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGon {
    public partial class NGon : Form {
        private Bitmap _bmp;
        private Graphics _g;
        private Pen _p = new Pen(Brushes.Black, 3);
        private int _sides = 18;

        public NGon() {
            InitializeComponent();
        }

        private double Rad(double deg) {
            return deg / 180.00 * Math.PI;
        }

        private void NGon_Load(object sender, EventArgs e) {
            this._bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = this._bmp;
            this._g = Graphics.FromImage(pictureBox1.Image);

            //var origin = new Point(250, 250);
            //var size = 150;

            //var step = 360 / _sides;

            int[,] points = {
                            {250, 400},
                            {301, 390},
                            {346, 364},
                            {379, 325},
                            {397, 276},
                            {397, 224},
                            {379, 176},
                            {346, 136},
                            {301, 110},
                            {250, 100},
                            {199, 110},
                            {154, 136},
                            {121, 175},
                            {103, 224},
                            {103, 276},
                            {121, 325},
                            {154, 364},
                            {199, 390}
                            };

            /*
            for(var t = 0; t < 360; t += step) {
                var x1 = (int) (Math.Sin(Rad(t - step)) * size) + origin.X;
                var y1 = (int) (Math.Cos(Rad(t - step)) * size) + origin.Y;
                var x2 = (int) (Math.Sin(Rad(t)) * size) + origin.X;
                var y2 = (int) (Math.Cos(Rad(t)) * size) + origin.Y;

                textBox1.Text += "{" + string.Format("{0}, {1}", x2, y2) + "},\r\n";
                this._g.DrawLine(_p, x1, y1, x2, y2);
                //textBox1.Text += string.Format("this._g.DrawLine(_p, {0}, {1}, {2}, {3});\r\n", x2, y2, origin.X, origin.Y);
                this._g.DrawLine(_p, x2, y2, origin.X, origin.Y);
            }
             */

            var pointCount = points.GetLength(0);
            for(var i = 1; i <= pointCount; i++) {
                var x1 = points[(i - 1) % pointCount, 0];
                var y1 = points[(i - 1) % pointCount, 1];
                var x2 = points[i % pointCount, 0];
                var y2 = points[i % pointCount, 1];
                this._g.DrawLine(_p, x1, y1, x2, y2);
                this._g.DrawLine(_p, x2, y2, 250, 250);
            }
        }
    }
}
