﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IBuyer
    {
        void BuyFood(int currentFood);

        public int Food { get; set; }
    }
}
