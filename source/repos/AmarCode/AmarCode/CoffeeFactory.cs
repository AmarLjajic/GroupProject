using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarCode
{
    class CoffeeFactory
    {
        public static IFactory GetCoffee(string coffeeType)
        {
            IFactory coffeDetails = null;

            if (coffeeType == "Moccha")
            {
                coffeDetails = new Moccha();
            }
            else if (coffeeType == "Expresso")
            {
                coffeDetails = new Expresso();
            }
            else if (coffeeType == "Latte")
            {
                coffeDetails = new Latte();
            }
            else if (coffeeType == "Black Coffee")
            {
                coffeDetails = new BlackCoffee();
            }
            else if (coffeeType == "Coffee With Milk")
            {
                coffeDetails = new CoffeeWithMilk();
            }

            return coffeDetails;
        }
    }
}
