using System;

namespace TemplateMethodPattern
{
    public abstract class CaffeinatedBeverage
    {
        // Template method (fixed steps/algo but allowed certain steps to vary in implementation)
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        // Allow different implementation by subclass
        public abstract void AddCondiments();

        // Allow different implementation by subclass
        public abstract void Brew();

        private void PourInCup()
        {
            Console.WriteLine("Pour beverage to a cup.");
        }

        private void BoilWater()
        {
            Console.WriteLine("Boil some water.");
        }
    }
}
