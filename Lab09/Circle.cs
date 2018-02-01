using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Circle
    {
        private double radius;
        private const double PI = Math.PI;

        public Circle(double rad)
        {
            this.radius = rad;
            CalculateCircumference(this.radius);
            CalculateArea(this.radius);
        }

        public double CalculateArea(double radius)
        {
            double area = PI * (radius * radius);
            return Math.Round(area, 2);
        }

        public double CalculateCircumference(double radius)
        {
            double circumference = 2 * (PI * radius);
            return Math.Round(circumference, 2);
        }
    }
}
