using System;

namespace TemplateMethodPattern
{
    public class Tea : CaffeinatedBeverage
    {
        // Specific implementation of AddCondiments for tea
        public override void AddCondiments()
        {
            Console.WriteLine("Add lemon.");
        }

        // This is how we make caffeinated drink of tea
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea.");
        }
    }
}
