using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class FreshwaterFish : Fish
    {
        private const int freshWaterFishInitialSize = 3;
        private const int freshWaterFishIncreaseSize = 3;
        
        public FreshwaterFish(string name, string species, decimal price) : base(name, species, price)
        {
            this.Size = freshWaterFishInitialSize;
        }

        public override void Eat()
        {
            this.Size += freshWaterFishIncreaseSize;
        }
    }
}
