﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Matrix Console");
            Console.WriteLine();
            
            var r = new Random();
            while (true)
            {
                Console.ForegroundColor = (ConsoleColor)r.Next(0, 15);

                // Write a random character
                Console.Write((char)r.Next(20, 255));
            }
        }
    }
}
