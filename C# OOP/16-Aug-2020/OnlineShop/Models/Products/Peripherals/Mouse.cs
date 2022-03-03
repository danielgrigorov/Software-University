using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    public class Mouse : Peripheral
    {
        public Mouse(int id, string manufacturer, string model, decimal price) : base(id, manufacturer, model, price, overallPerformance)
        {
        }
    }
}
