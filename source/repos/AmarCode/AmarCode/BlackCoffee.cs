using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarCode
{
    class BlackCoffee : IFactory 
    {
        public string GetType()
        {
            return "Black Coffee";
        }

        public int GetPrice()
        {
            return 30;
        }
       
    }
}
