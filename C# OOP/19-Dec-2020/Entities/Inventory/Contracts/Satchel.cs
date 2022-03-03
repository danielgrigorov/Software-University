using System;
using System.Collections.Generic;
using System.Text;

namespace WarCroft.Entities.Inventory.Contracts
{
    public class Satchel : Bag
    {
        private const int satchelCapacity = 20;
        public Satchel() : base(satchelCapacity)
        {
        }
    }
}
