using System;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Main(args, Create);
        }

        static void Main(string[] args, Create create)
        {
            Console.WriteLine("Printing will start soon");
            Data.answers = new Queue<string>();
            create.start();
        }
    }
}