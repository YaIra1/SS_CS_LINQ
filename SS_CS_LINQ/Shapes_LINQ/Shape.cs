namespace Shapes_LINQ
{
    public abstract class Shape : IComparable<Shape>
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape? other)
        {
            ArgumentNullException.ThrowIfNull(other);

            return Area().CompareTo(other.Area());
        }
    }
}
