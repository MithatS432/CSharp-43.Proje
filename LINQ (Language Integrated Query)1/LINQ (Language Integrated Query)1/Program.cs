using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ__Language_Integrated_Query_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string> { "Ankara", "İstanbul", "İzmir", "Adana", "Antalya", "Bursa" };

            // 1. Temel LINQ Sorgusu (from, where, select)
            var aIleBaslayanlar = from sehir in sehirler
                                  where sehir.StartsWith("A")
                                  select sehir;

            Console.WriteLine("A harfi ile başlayan şehirler (query syntax):");
            foreach (var sehir in aIleBaslayanlar)
                Console.WriteLine(sehir);

            // 2. Lambda İfadesiyle LINQ (method syntax)
            var uzunIsimler = sehirler.Where(s => s.Length > 6).Select(s => s.ToUpper());

            Console.WriteLine("\nUzun şehir isimleri (lambda syntax):");
            foreach (var sehir in uzunIsimler)
                Console.WriteLine(sehir);
        }
    }
}
