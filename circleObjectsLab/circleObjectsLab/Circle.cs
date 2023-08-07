using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleObjectsLab
{
    public class Circle
    {
        //properties
        private double radius;

        //constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        //methods
        public double CalculateDiameter()
        {
            return this.radius * 2;
        }

        public double CalculateCircumfrence()
        {
            return 2 * Math.PI * this.radius;
        }

        public double CalculateArea()
        {
            return Math.PI * this.radius * this.radius;
        }

        public void Grow()
        {
            this.radius *= 2;
        }

        public double GetRadius()
        {
            return this.radius;
        }
    }
}
