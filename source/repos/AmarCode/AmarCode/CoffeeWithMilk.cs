using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarCode
{
    class CoffeeWithMilk : IFactory
    {
        public string GetType()
        {
            return "Coffee With Milk";
        }

        public int GetPrice()
        {
            return 30;
        }
    }
}
