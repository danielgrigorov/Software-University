using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        private const int comfortDefaultValue = 5;
        private const decimal priceDefaultValue = 10m;
        public Plant() : base(comfortDefaultValue, priceDefaultValue)
        {
        }
    }
}
