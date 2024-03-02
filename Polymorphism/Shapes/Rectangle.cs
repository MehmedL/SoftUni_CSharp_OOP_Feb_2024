using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double height { get; set; }
        public double width { get; set; }
        public override double CalculatePerimeter()
        {
            return 2 * (height + width);
        }

        public override double CalculateArea()
        {
            return height * width;
        }

        // Override method for drawing
        public override string Draw()
        {
            return base.Draw() + $" - Rectangle (Height: {height}, Width: {width})";
        }
    }
}
