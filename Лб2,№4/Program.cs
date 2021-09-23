using System;

namespace Лб2__4
{
    class Point
    {
        private int _x, _y;
        private string _name;

        public int x
        {
            get
            {
                return _x;
            }
        }
        public int y
        {
            get
            {
                return _y;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
        }

        public Point(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }
    }

    class Figure
    {
        private string fig;
        private double _perimeter;
        private double AB, BC, CD, DE;

        public Figure(Point A, Point B, Point C)
        {
            fig = "Трикутник";
            AB = LengthSide(A, B);
            BC = LengthSide(B, C);
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            fig = "Чотирикутник";
            AB = LengthSide(A, B);
            BC = LengthSide(B, C);
            CD = LengthSide(C, D);
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            fig = "П'ятикутник";
            AB = LengthSide(A, B);
            BC = LengthSide(B, C);
            CD = LengthSide(C, D);
            DE = LengthSide(D, E);
        }

        public double LengthSide(Point A, Point B)
        {
            double lengthSide = Math.Sqrt(Math.Pow(B.x - A.x, 2) + Math.Pow(B.y - A.y, 2));
            return lengthSide;
        }
        public void PerimeterCalculator()
        {
            _perimeter = AB + BC + CD + DE;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Назва многокутника: {fig}");
            Console.WriteLine($"Периметр многокутника: {_perimeter}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;

            Point A = new Point(9, 6, "A");
            Point B = new Point(6, 5, "B");
            Point C = new Point(14, 3, "C");
            Point D = new Point(1, 12, "D");

            Figure figure = new Figure(A, B, C, D);

            figure.PerimeterCalculator();
            figure.GetInfo();
        }

    }
}
