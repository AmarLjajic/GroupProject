using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarCode
{
    interface IFactory
    {
        string GetType();
        int GetPrice();
    }
}
