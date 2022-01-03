using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarCode
{
    class BakeryFactory
    {
        public static IFactory GetBakery(string bakeryType)
        {
            IFactory bakeryDetails = null;

            if (bakeryType == "Bagels")
            {
                bakeryDetails = new Bagels();
            }
            else if (bakeryType == "Buns")
            {
                bakeryDetails = new Buns();
            }
            else if (bakeryType == "Rolls")
            {
                bakeryDetails = new Rolls();
            }
            else if (bakeryType == "Biscuits")
            {
                bakeryDetails = new Biscuits();
            }
            else if (bakeryType == "Loaf Breads")
            {
                bakeryDetails = new LoafBreads();
            }

            return bakeryDetails;

        }
    }
}
