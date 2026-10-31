using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PR7.classes
{
    public class gemFig
    {
        protected Canvas canvas;
        public Brush Color { get; set; }

        public gemFig(Canvas canvas, Brush Color)
        {
            this.Color = Color;
            this.canvas = canvas;

        }
    }

    class Round : gemFig
    {
        private Ellipse el;
        public double radiys { get; set; }
        public Round(Brush Color, double radiys, Canvas canvas) : base(canvas, Color)
        {
            this.radiys = radiys;
            double diametr = radiys * 2;
            el = new Ellipse
            {
                Width = diametr,
                Height = diametr,
                Fill = Color,
                StrokeThickness = 2
            };

        }
        public void Draw()
        {
            if (!canvas.Children.Contains(el))
                canvas.Children.Add(el);
        }
    }

    class Trangl : gemFig
    {
        private Polygon pol;

        public Trangl(Brush Color, Canvas canvas, Point p1, Point p2, Point p3) : base(canvas, Color)
        {
            pol = new Polygon
            {
                Fill = Color,
                StrokeThickness = 2,
                Points = new PointCollection { p1, p2, p3 }
            };
        }

        public void Draw()
        {
            if (!canvas.Children.Contains(pol))
                canvas.Children.Add(pol);
        }



    }
}
