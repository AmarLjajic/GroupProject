using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarCode
{
    class Expresso : IFactory
    {
        public string GetType()
        {
            return "Expresso";
        }

        public int GetPrice()
        {
            return 30;
        }
    }
}
