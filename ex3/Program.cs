using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>();
                List<float> floatList = new List<float>();
                StreamWriter sw;
                while (true)
                {
                    int intInput;
                    float floatInput;
                    Console.WriteLine("Input integer or float. Anything else to exit.");
                    string input = Console.ReadLine();                   
                    if (Int32.TryParse(input, out intInput))
                        intList.Add(intInput);
                    else if (float.TryParse(input, out floatInput))
                        floatList.Add(floatInput);
                    else
                        break;
                }
                sw = new StreamWriter("integers.txt");
                intList.ForEach(x => sw.WriteLine(x));
                sw.Close();
                sw = new StreamWriter("floats.txt");
                floatList.ForEach(x => sw.WriteLine(x));
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey(true);
            }
        }
    }
}
