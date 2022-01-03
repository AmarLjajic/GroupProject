using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarCode
{
    public abstract class CoffeeDecorator : ICoffee
    {
        public ICoffee icoffee;

        public CoffeeDecorator(ICoffee icoffee)
        {
            this.icoffee = icoffee;
        }

        public virtual ICoffee description()
        {
            return icoffee.description();
        }
    }
}
