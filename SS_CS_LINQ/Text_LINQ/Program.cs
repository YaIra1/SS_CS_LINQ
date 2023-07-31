namespace Text_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Repos\\SS_CS_LINQ\\SS_CS_LINQ\\SS_CS_LINQ\\Program.cs";
            List<string> list = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            list.ForEach(s=> Console.WriteLine(s.Length));

            var filtered = list.Where(s=>!string.IsNullOrWhiteSpace(s));
            int min = filtered.Min(s=>s.Length);
            int max = filtered.Max(s=>s.Length);

            string shortestLine = filtered.First(s=>s.Length == min);
            string longestLine = filtered.First(s => s.Length == max);

            Console.WriteLine(shortestLine);
            Console.WriteLine(longestLine);

            var onlyVars = filtered.Where(s=>s.Contains("var"));
            foreach (var line in onlyVars)
            {
                Console.WriteLine(line);
            }
        }
    }
}