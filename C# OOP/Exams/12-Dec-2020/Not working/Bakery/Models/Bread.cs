using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models
{
    public class Bread : BakedFood
    {
        private const int initialBreadPortion = 200;

        public Bread(string name, decimal price) : base(name, initialBreadPortion, price)
        {
        }
    }
}
