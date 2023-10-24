namespace solsysBekeSz
{
    internal class Program
    {
        static double atlagB(List<solsys> s)
        {
            return s.Average(a => a.holdszam);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("3. feladat:");
            var bolygok = new List<solsys>();
            foreach (var i in File.ReadAllLines(@"..\..\src\solsys.txt"))
            {
                bolygok.Add(new solsys(i));
            }
            Console.WriteLine($"\t3.1: {bolygok.Count} bolgó van a naprendszerben");

            Console.WriteLine($"\t3.2: a naprandszerben a bolygóknak átlagosan {atlagB(bolygok)} holdja van");

            var f3 = bolygok.OrderBy(a => a.bterfogat).Last();
            Console.WriteLine($"\t3.3: a legnagyobb térfogatú bolgó: {f3.bneve}");

            Console.Write($"\t3.4: írd be a keresett bolygó nevét: ");
            string beirt = Console.ReadLine();
            var f4 = bolygok.SingleOrDefault(x => x.bneve == beirt);
            Console.WriteLine(f4 != null ? "\tVan ilyen bolygó a naprendszerben." : "\tsajnos nincs ilyen nevű bolygó a naprendszerben");
           
            Console.Write("\t3.5 írj be egy egész számot: ");
            string beirt2 = Console.ReadLine();
            var f5 = bolygok.Where(x => x.holdszam > int.Parse(beirt2));
            Console.WriteLine($"\ta következő bolygóknak van {beirt2}-nél több holdja: ");
            foreach (var i in f5)
            {
                Console.Write($"\t[{i.bneve}],");
            }

            Console.ReadKey(true);
        }
    }
}