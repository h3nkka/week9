using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex5
{
    class TVProgram
    {
        public string Name { get; set; }
        public int Channel { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Info { get; set; }

        public void WriteToFile()
        {
            try
            {
                StreamWriter sw = new StreamWriter("ex5.txt");
                sw.WriteLine(Name);
                sw.WriteLine(Channel);
                sw.WriteLine(Start);
                sw.WriteLine(End);
                sw.WriteLine(Info);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void ReadFromFile()
        {
            try
            {
                if (File.Exists("ex5.txt"))
                {
                    List<string> parsedFile = new List<string>();
                    StreamReader sr = new StreamReader("ex5.txt");
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        parsedFile.Add(line);
                    }
                    sr.Close();

                    
                    Name = parsedFile[0];
                    Channel = Int32.Parse(parsedFile[1]);
                    Start = DateTime.Parse(parsedFile[2]);
                    End = DateTime.Parse(parsedFile[3]);
                    Info = parsedFile[4];

                    Console.WriteLine("Loaded TV program info from file.");
                }
                else
                {
                    Console.WriteLine("File does not exist!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
