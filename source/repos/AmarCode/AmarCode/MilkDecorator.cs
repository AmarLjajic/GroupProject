using System;

namespace AmarCode
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee icoffee) : base(icoffee)
        {
        }

        public override ICoffee description()
        {
            icoffee.description();
            AddMilk(icoffee);
            return icoffee;
        }

        public void AddMilk(ICoffee icoffee)
        {
            if (icoffee is BlackCoffee)
            {
                BlackCoffee BlackCoffee = (BlackCoffee)icoffee;
                Console.WriteLine("Added Milk to the Coffee");
            }
        }
    }
}