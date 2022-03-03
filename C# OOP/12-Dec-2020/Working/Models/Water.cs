﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models
{
    public class Water : Drink
    {
        private const decimal waterPrice = 1.5m;
        public Water(string name, int portion, string brand) : base(name, portion, waterPrice, brand)
        {
        }
    }
}
