using System;
using System.Collections.Generic;
using System.Text;

namespace WarCroft.Entities.Inventory.Contracts
{
    public class Backpack : Bag
    {
        private const int backpackCapacity = 100;
        public Backpack() : base(backpackCapacity)
        {
        }
    }
}
