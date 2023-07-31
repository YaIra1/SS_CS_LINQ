namespace Shapes_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle("Circle1", 3),
                new Square("Square1", 200),
                new Circle("Circle2", 0.5),
                new Square("Square2", 7),
                new Circle("Circle3", 3.23),
                new Square("Square3", 2),
            };

            var filteredByArea = shapes.Where(s => s.Area() > 10 && s.Area() < 100);
            string path = "D:\\filtered by area.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (Shape shape in filteredByArea)
                    {
                        sw.WriteLine(shape.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            var containsA = shapes.Where(s => s.Name.Contains("A", StringComparison.InvariantCultureIgnoreCase));
            path = "D:\\shapes contains a.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (Shape shape in containsA)
                    {
                        sw.WriteLine(shape.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var perLess5 = shapes.Where(s => s.Perimeter() < 5).ToList();
            foreach (Shape shape in perLess5)
            {
                shapes.Remove(shape);
            }
            Console.WriteLine("Shapes with perimeter greater than 5:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}