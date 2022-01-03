using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarCode
{
    class Bagels : IFactory
    {
        public string GetType()
        {
            return "Bagels";
        }

        public int GetPrice()
        {
            return 40;
        }
    }
}
