using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1Task01
{
    // try this solution 1

    public interface IShape3
    {
    }
    public class Rectangle3 : IShape3
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }
    public class Square3 : IShape3
    {
        public double Side { get; set; }
    }

    // try this solution 2

    public interface IShape2 
    {
        void setHeight(double height);
        void setWidth(double width);
    }
    public class Rectangle2 : IShape2
    {
        private double height;
        private double width;
        public void setHeight(double height)
        {
            this.height = height;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
    }
    public class Square2 : IShape2
    {
        private double side;
        public void setHeight(double height)
        {
            this.side = height;
        }
        public void setWidth(double width)
        {
            this.side = width;
        }
    }

}
