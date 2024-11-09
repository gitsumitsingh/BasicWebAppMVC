using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.SOLIDPrincipal
{
    public class Circle : I2DShapes
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : I2DShapes
    {
        public double Length { get; set; }
        public double Breath { get; set; }
        public double GetArea()
        {
            return Length * Breath;
        }
    }

    public class Square : I2DShapes
    {
        public double Side { get; set; }

        public double GetArea()
        {
            return Side * Side;
        }
    }
    public class Cube : I3DShapes
    {
        public double Side { get; set; }

        public double GetVolume()
        {
            return Side * Side * Side;
        }
    }

}
