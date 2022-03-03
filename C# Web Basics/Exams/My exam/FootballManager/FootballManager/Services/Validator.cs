using FootballManager.ViewModels.Players;
using FootballManager.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FootballManager.Services
{
    using static Data.DataConstants;

    public class Validator : IValidator
    {
        public ICollection<string> ValidateUser(RegisterUserFormModel user)
        {
            var errors = new List<string>();

            if (user.Username == null || user.Username.Length < UserMinUsername || user.Username.Length > DefaultMaxLength)
            {
                errors.Add($"Username '{user.Username}' is not valid. It must be between {UserMinUsername} and {DefaultMaxLength} characters long.");
            }

            if (user.Email == null || !Regex.IsMatch(user.Email, UserEmailRegularExpression) || user.Email.Length < UserMinEmail || user.Email.Length > UserMaxEmail)
            {
                errors.Add($"Email '{user.Email}' is not a valid e-mail address. It must be between {UserMinEmail} and {UserMaxEmail} characters long.");
            }

            if (user.Password == null || user.Password.Length < UserMinPassword || user.Password.Length > DefaultMaxLength)
            {
                errors.Add($"The provided password is not valid. It must be between {UserMinPassword} and {DefaultMaxLength} characters long.");
            }

            if (user.Password != null && user.Password.Any(x => x == ' '))
            {
                errors.Add($"The provided password cannot contain whitespaces.");
            }

            if (user.Password != user.ConfirmPassword)
            {
                errors.Add("Password and its confirmation are different.");
            }

            return errors;
        }

        public ICollection<string> ValidatePlayer(AddPlayerFormModel player)
        {
            var errors = new List<string>();

            if (player.FullName == null || player.FullName.Length < FootballPlayerFullNameMinLength || player.FullName.Length > FootballPlayerFullNameMaxLength)
            {
                errors.Add($"Player '{player.FullName}' is not valid. It must be between {FootballPlayerFullNameMinLength} and {FootballPlayerFullNameMaxLength} characters long.");
            }

            if (player.Position == null || player.Position.Length < FootballPlayerPositionMinLength || player.Position.Length > DefaultMaxLength)
            {
                errors.Add($"Position '{player.Position}' is not valid. It must be between {FootballPlayerPositionMinLength} and {DefaultMaxLength} characters long.");
            }

            //if (player.ImageUrl == null)
            //{
            //    errors.Add($"Image '{player.ImageUrl}' is not valid. It must be a valid URL.");
            //}

            if (player.Speed == null || player.Speed < FootballPlayerQualitiesMin || player.Speed > FootballPlayerQualitiesMax)
            {
                errors.Add($"Speed value '{player.Speed}' is not valid. It cannot be negative or bigger than 10.");
            }

            if (player.Endurance == null || player.Endurance < FootballPlayerQualitiesMin || player.Speed > FootballPlayerQualitiesMax)
            {
                errors.Add($"Endurance value '{player.Endurance}' is not valid. It cannot be negative or bigger than 10.");
            }

            if (player.Description == null || player.Description.Length > FootballPlayerDescriptionMaxLength)
            {
                errors.Add($"Player description '{player.FullName}' is not valid. It cannot be bigger than {FootballPlayerDescriptionMaxLength} characters long.");
            }

            if (player.Position != PositionTypeGoalkeeper && player.Position != PositionTypeLeftFullback && player.Position != PositionTypeRightFullback && player.Position != PositionTypeCenterFullback && player.Position != PositionTypeStriker && player.Position != PositionTypeWinger && player.Position != PositionTypeDefender)
            {
                errors.Add($"The player can be either a '{PositionTypeGoalkeeper}' or a '{PositionTypeLeftFullback}' or a '{PositionTypeRightFullback}' or a '{PositionTypeCenterFullback}' or a '{PositionTypeStriker}' or a '{PositionTypeWinger}' or a '{PositionTypeDefender}'.");
            }

            return errors;
        }
    }
}
