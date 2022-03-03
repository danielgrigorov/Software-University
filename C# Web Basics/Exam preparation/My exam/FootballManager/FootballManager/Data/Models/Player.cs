namespace FootballManager.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Player
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(FootballPlayerFullNameMaxLength)]
        public string FullName { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(DefaultMaxLength)]
        public string Position { get; set; }

        [Required]
        public byte Speed { get; set; }

        [Required]
        public byte Endurance { get; set; }

        [Required]
        [MaxLength(FootballPlayerDescriptionMaxLength)]
        public string Description { get; set; }

        public ICollection<UserPlayer> UserPlayers { get; set; } = new List<UserPlayer>();
    }
}