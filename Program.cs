using System;

namespace _.Net_Lesson_1__Savarankiskas_01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kokia tavo megstamiausia spalva?");
            string spalva = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Mano irgi {spalva}. :)");
            Console.ReadLine();
        }
    }
}
