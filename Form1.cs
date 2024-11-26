using System.Drawing.Drawing2D;

namespace рисовашки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int x1, y1;
        Point[] points = new Point[10];
        Pen pen = new Pen(Color.Red, 2);
        Pen pens = new Pen(Color.Blue, 2);
        Pen penss = new Pen(Color.White, 2);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.DrawRectangle(pen, 30, 50, 750, 350);
            SolidBrush brush = new SolidBrush(Color.DeepSkyBlue);
            Pen dottedPen = new Pen(Color.White, 2);
            dottedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.FillRectangle(brush, 30, 50, 750, 350);
            for (int i = 0; i < 50; i++)
            {
                g.DrawLine(dottedPen, 4 * i + 50, 750, 4 * i + 20, 50);
            }
            g.DrawEllipse(dottedPen, 570, 200, 200, 100);
            SolidBrush abrush = new SolidBrush(Color.Yellow);
            SolidBrush aabrush = new SolidBrush(Color.White);
            g.FillEllipse(abrush, 300, 200, 200, 100);
            Point[] polygonPoints =
            {
            new Point(100,100),
            new Point(150,50),
            new Point(200,100),
            new Point(180,150),
            new Point(120,150)
        };
            g.FillPolygon(aabrush, polygonPoints);
            g.DrawPolygon(penss, polygonPoints);
            Point[] splinePoints =
                {
            new Point(300, 200),
            new Point(350, 100),
            new Point(400, 200),
            new Point(450, 100),
            new Point(500, 200)
        };
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddCurve(splinePoints);
                g.FillPath(aabrush, path);
                g.DrawPath(penss, path);
                Region region = new Region(path);
                g.FillRegion(aabrush, region);

            }
            Point[] points = new Point[50];
            g.DrawLines(pen, points);
            Graphics j = e.Graphics;
            Brush brush5 = Brushes.Black;
            j.FillEllipse(brush5, 700, 100, 70, 70);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          

        }
    }
}

