using System.ComponentModel.DataAnnotations;

namespace FootballManager.Data.Models
{
    public class UserPlayer
    {
        [Required]
        public string UserId { get; set; }

        public User User { get; set; }

        [Required]
        public int PlayerId { get; set; }

        public Player Player { get; set; }
    }
}