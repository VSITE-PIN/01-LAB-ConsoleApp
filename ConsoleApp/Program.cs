using ConsoleApp.Modeli;

﻿namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Proizvod proizvod = new Proizvod("Laptop", 7500.00m, 10);
            proizvod.IspisiInformacije();
        }
    }
}
