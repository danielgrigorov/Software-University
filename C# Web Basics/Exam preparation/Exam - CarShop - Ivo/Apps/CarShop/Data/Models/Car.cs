using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Data.Models
{
    using static DataConstants;
    public class Car
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [MaxLength(DefaultMaxLength)]
        [Required]
        public string Model { get; set; }

        public int Year { get; set; }

        [Required]

        public string PictureUrl { get; set; }

        [Required]
        [MaxLength(PlateNumberMaxLength)]
        public string PlateNumber { get; set; }

        [Required]
        public string OwnerId { get; set; }

        public User Owner { get; set; }

        public ICollection<Issue> Issues { get; set; } = new List<Issue>();



    }
}
