namespace Git.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Commit
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Required]
        public string CreatorId { get; set; }

        public User Creator { get; set; }

        [Required]
        public string RepositoryId { get; set; }

        public Repository Repository { get; set; }
    }
}

//•	Has an Id – a string, Primary Key
//•	Has a Description – a string with min length 5 (required)
//•	Has a CreatedOn – a datetime (required)
//•	Has a CreatorId – a string
//•	Has Creator – a User object
//•	Has RepositoryId – a string
//•	Has Repository– a Repository object
