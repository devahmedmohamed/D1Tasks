using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1Task01
{

    public interface IShape
    {
        double GetArea();
    }
    public interface IVolume
    {
        double GetVolume();
    }
    public class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double GetArea()
        {
            return Height * Width;
        }
    }
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Square : IShape
    {
        public double Side { get; set; }
        public double GetArea()
        {
            return Side * Side;
        }
    }
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
    public class Cube : IVolume
    {
        public double Side { get; set; }
        public double GetVolume()
        {
            return Side * Side * Side;
        }
    }

    public class AreaCalculator
    {
        public double TotalArea(IShape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.GetArea();
            }
            return area;
        }
    }
    public class VolumeCalculator
    {
        public double TotalVolume(IVolume[] volumes)
        {
            double volume = 0;
            foreach (var vol in volumes)
            {
                volume += vol.GetVolume();
            }
            return volume;
        }
    }
}
