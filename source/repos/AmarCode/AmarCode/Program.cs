﻿using System;

namespace AmarCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello what would you want to order from the Menu, Coffee Or Bakery: ");
            string answer = Console.ReadLine();
            if (answer == "Coffee")
            {
                Console.WriteLine("What do you want order?");
                Console.WriteLine("--------------");
                Console.WriteLine("Moccha");
                Console.WriteLine("--------------");
                Console.WriteLine("Expresso");
                Console.WriteLine("--------------");
                Console.WriteLine("Latte");
                Console.WriteLine("--------------");
                Console.WriteLine("Black Coffee");
                Console.WriteLine("--------------");
                Console.WriteLine("Coffee With Milk");
                Console.WriteLine("--------------");
            }

            if (answer == "Coffee")
            {
                Console.Write("Please Enter What Coffee You Want: ");
                string choice = Console.ReadLine();

                IFactory coffeDetails = CoffeeFactory.GetCoffee(choice);

                if (coffeDetails != null)
                {
                    Console.WriteLine("CoffeeType : " + coffeDetails.GetType());
                    Console.WriteLine("CoffePrice : " + coffeDetails.GetPrice());
                }

                else
                {
                    Console.Write("Invalid Coffee Type");
                }
            }



        }
    }
}