using System;

namespace TemplateMethodPattern
{
    public class Coffee : CaffeinatedBeverage
    {
        // Specific implementation of AddCondiments for coffee
        public override void AddCondiments()
        {
            Console.WriteLine("Add sugar and milk.");
        }

        // This is how we make caffeinated beverage for coffee -> specific implementation
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through the filter.");
        }
    }
}
