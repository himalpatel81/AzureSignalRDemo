using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager
{
    public class CoffeeManager : ICoffeeManager
    {
        public CoffeeManager()
        {
            System.Threading.Thread.Sleep(5000);
        }

        public Task getCoffee()
        {
            return Task.FromResult(0);
        }
    }
}
