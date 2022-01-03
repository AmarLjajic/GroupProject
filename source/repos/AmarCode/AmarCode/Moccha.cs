using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarCode
{
    class Moccha : IFactory
    {
        public string GetType()
        {
            return "Moccha";
        }

        public int GetPrice()
        {
            return 20;
        }
    }
}
