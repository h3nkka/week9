using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> readList = new List<string>();
                if (File.Exists("ex2.txt"))
                {
                    readList = File.ReadAllLines("ex2.txt").ToList();
                }
                int listCount = readList.Count;
                int unique = (from x in readList
                           select x).Distinct().Count();
                readList.Sort();
                var g = readList.GroupBy(i => i);
                Console.WriteLine("Found {0} rows with {1} different names.",listCount,unique);
                foreach (var grp in g)
                {
                    Console.WriteLine("{0} {1}", grp.Key, grp.Count());
                }
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred! {0}", ex.ToString());
                Console.ReadKey(true);
            }
        }
    }
}
