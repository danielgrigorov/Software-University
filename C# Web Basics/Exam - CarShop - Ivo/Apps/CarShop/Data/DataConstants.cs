using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop.Data
{
    public class DataConstants
    {
        public const int DefaultMaxLength = 20;

        public const int IdMaxLength = 40;

        public const int PlateNumberMaxLength = 8;

        public const int UserMinUsername = 4;

        public const int UserMinPassowrd = 5;

        public const string UserTypeClient = "Client";

        public const string UserTypeMechanic = "Mechanic";

        public const int CarModelMinLength = 5;

        public const string CarPlateNumberRegularExpression = @"[A-Z]{2}[0-9]{2}[A-Z]{2}";

        public const int CarYearMinValue = 1900;

        public const int CarYearMaxValue = 2100;

    }
}
