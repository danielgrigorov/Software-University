using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarShop.Data.Models
{
    using static DataConstants;

    public class Issue
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]

        public string Description { get; set; }

        public bool IsFixed { get; set; }

        [Required]

        public string CarId { get; set; }

        public Car Car { get; set; }
    }
}
