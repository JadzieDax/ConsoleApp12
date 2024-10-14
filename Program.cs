﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static double Calc(double x)
        {
            return (Math.Abs(x) + 2 * Math.Sin(Math.Pow(Math.Tan(x), 2) + 4)) / (5.5 * x);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double y = Calc(x);
            Console.WriteLine($"Значение функции f(x) при x = {x}: {y}");
            Console.ReadLine();
        }
    }
}