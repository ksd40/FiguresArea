using System;

namespace FiguresArea
{
    public class Triangle : Figure
    {
        private int _a;
        private int _b;
        private int _c;

        public int A
        {
            get { return _a; }
            private set
            {
                if (value < 0) throw new ArgumentException("Side A of a triangle cannot take a negative value!");
                _a = value;
            }
        }
        
        public int B
        {
            get { return _b; }
            private set
            {
                if (value < 0) throw new ArgumentException("Side B of a triangle cannot take a negative value!");
                _b = value;
            }
        }
        
        public int C
        {
            get { return _c; }
            private set
            {
                if (value < 0) throw new ArgumentException("Side C of a triangle cannot take a negative value!");
                _c = value;
            }
        }

        public Triangle() : base("Triangle") { }

        public Triangle(int a, int b, int c) : this()
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                A = a; 
                B = b;
                C = c;
            }
            else
                throw new ArgumentException("A triangle with given sides does not exist!");
        }

        public override double CalculateArea()
        {
            double halfPerimeter = (double)(_a + _b + _c) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _a) * (halfPerimeter - _b) * (halfPerimeter - _c));
        }

        public bool IsRectangular()
        {
            if (IsPifagorTheoryValid(_a, _b, _c) 
                || IsPifagorTheoryValid(_a, _c, _b) 
                || IsPifagorTheoryValid(_b, _c, _a))
                return true;
            return false;
        }

        private bool IsPifagorTheoryValid(int a, int b, int c)
        {
            return c * c == a * a + b * b;
        }
    }
}
