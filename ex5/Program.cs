﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TVProgram tv = new TVProgram();
            tv.Name = "Death Note";
            tv.Channel = 6;
            tv.Start = DateTime.Today;
            tv.End = DateTime.MaxValue;
            tv.Info = @"A shinigami, as a god of death, can kill any person—provided they see their victim's face and write their victim's name in a notebook called a Death Note. One day, Ryuk, bored by the shinigami lifestyle and interested in seeing how a human would use a Death Note, drops one into the human realm.
                    High school student and prodigy Light Yagami stumbles upon the Death Note and—since he deplores the state of the world—tests the deadly notebook by writing a criminal's name in it. When the criminal dies immediately following his experiment with the Death Note, Light is greatly surprised and quickly recognizes how devastating the power that has fallen into his hands could be. 
                    With this divine capability, Light decides to extinguish all criminals in order to build a new world where crime does not exist and people worship him as a god.Police, however, quickly discover that a serial killer is targeting criminals and, consequently, try to apprehend the culprit. To do this, the Japanese investigators count on the assistance of the best detective in the world: a young and eccentric man known only by the name of L.";
            tv.WriteToFile();
            tv.Name = "Blablabla";
            tv.Channel = 420;
            tv.Info = "lol";
            tv.ReadFromFile();

            Console.WriteLine("TV Program Name: {0} Channel: {1} Start time: {2} End time: {3}\nInfo: {4}", tv.Name, tv.Channel, tv.Start, tv.End, tv.Info);
            Console.ReadKey(true);
        }
    }
}
