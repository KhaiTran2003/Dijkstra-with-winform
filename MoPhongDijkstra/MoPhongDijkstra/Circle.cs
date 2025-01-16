using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MoPhongDijkstra
{
    public class Circle
    {
        public char Label { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public Color _color { get; set; }
        public Circle() { } // Constructor mặc định (không tham số)

        public Circle(char label, int x, int y, int radius)
        {
            Label = label;
            X = x;
            Y = y;
            Radius = radius;
            _color = Color.Blue;
        }
    }
}
