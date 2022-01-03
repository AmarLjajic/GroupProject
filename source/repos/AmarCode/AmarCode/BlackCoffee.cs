using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarCode
{
    class BlackCoffee : IFactory, ICoffee
    {
        public string GetType()
        {
            return "Black Coffee";
        }

        public int GetPrice()
        {
            return 30;
        }

        public ICoffee description()
        {
            return this.description();
        }

    }
}
