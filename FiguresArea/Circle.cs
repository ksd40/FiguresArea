using System;

namespace FiguresArea
{
    public class Circle : Figure
    {
        private int _radius;
        public int Radius
        {
            get { return _radius; }
            private set 
            {
                if (value < 0) throw new ArgumentException("The radius of a circle cannot take a negative value!");
                _radius = value;
            }
        }

        public Circle() : base("Circle") { }

        public Circle(int radius) : this()
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
