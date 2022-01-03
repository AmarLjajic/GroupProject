using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarCode
{
    class Latte : IFactory
    {
        public string GetType()
        {
            return "Latte";
        }

        public int GetPrice()
        {
            return 30;
        }
    }
}
