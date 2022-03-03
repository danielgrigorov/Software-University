using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop.Models.Cars.Issues
{
    public class IssueListingViewModel
    {
        public int CarYear { get; set; }

        public bool IsFixed { get; set; }

        public string CarModel { get; set; }

        public string IssueId { get; set; }

        public string CarId { get; set; }

        public string Description { get; set; }

        public bool MyProperty { get; set; }
    }
}
