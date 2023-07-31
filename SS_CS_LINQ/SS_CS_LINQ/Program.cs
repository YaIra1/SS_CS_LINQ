namespace SS_CS_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task9();
        }

        public static void Task9()
        {
            int[] arr = new int[10] { 3, -7, 11, -89, 0, 34, -12, 66, 32, -1 };
            Console.WriteLine("Negative numbers:");
            var negativeNums = arr.Where(n => n < 0);
            Console.WriteLine(string.Join(" ", negativeNums));

            Console.WriteLine("Positive numbers:");
            var positiveNums = arr.Where(n => n >= 0);
            Console.WriteLine(string.Join(" ", positiveNums));

            int min = arr.Min();
            int max = arr.Max();
            int sum = arr.Sum();
            Console.WriteLine($"Min: {min}, max: {max}, sum: {sum}");

            var average = arr.Average();
            int firstLargestBelowAverage = arr.Where(n => n < average).Max();
            Console.WriteLine($"Average num: {average}, first largest num below average: {firstLargestBelowAverage}");

            Console.WriteLine("Ordered collection:");
            var ordered = arr.OrderBy(n => n);
            Console.WriteLine(string.Join(" ", ordered));
        }


    }
}