using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double radius { get; set; }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Override method for drawing
        public override string Draw()
        {
            return base.Draw() + $" - Circle (Radius: {radius})";
        }
    }
}
