using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Ornament : Decoration
    {
        private const int comfortDefaultValue = 1;
        private const decimal priceDefaultValue = 5m;

        public Ornament() : base(comfortDefaultValue, priceDefaultValue)
        {
        }
    }
}
