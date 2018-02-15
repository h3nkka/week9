using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("test.txt");
                string input = "0";
                while (input != "")
                {
                    Console.WriteLine("Input string to write to a file. Input a new line to exit.");
                    input = Console.ReadLine();
                    if (input != "") sw.WriteLine(input);
                }
                sw.Close();
                Console.WriteLine("Retrieving string from file.");
                string retrieved = File.ReadAllText("test.txt");
                Console.WriteLine("The strings you wrote in the file were: {0}", retrieved);
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: {0}", ex.ToString());
            }
        }
    }
}
