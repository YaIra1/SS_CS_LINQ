namespace Shapes_LINQ
{
    public class Square : Shape
    {
        private double _side;

        public double Side
        {
            get => _side;
            set => _side = value;
        }

        public Square(string name, double side) : base(name)
        {
            _side = side;
        }

        public override double Area()
        {
            return _side * _side;
        }

        public override double Perimeter()
        {
            return 4 * _side;
        }

        public override string ToString()
        {
            return $"The {Name} with side: {Side} has area: {Area()} and perimeter: {Perimeter()}";
        }
    }
}

