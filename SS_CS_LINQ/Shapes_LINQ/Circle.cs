namespace Shapes_LINQ
{
    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }

        public Circle(string name, double radius) : base(name)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * _radius;
        }

        public override string ToString()
        {
            return $"The {Name} with radius: {Radius} has area: {Area()} and perimeter: {Perimeter()}";
        }
    }
}
