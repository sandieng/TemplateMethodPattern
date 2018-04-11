using System;
using TemplateMethodPattern;

namespace TemplateMethodClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea lemonTea = new Tea();
            lemonTea.PrepareBeverage();

            Console.WriteLine();

            Coffee coffeeWithMilkAndSugar = new Coffee();
            coffeeWithMilkAndSugar.PrepareBeverage();

            Console.ReadKey();
        }
    }
}
