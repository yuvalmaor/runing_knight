﻿using System;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing will start soon");
            Data.answers = new Queue<string>();
            Class1.start();
        }
    }
}