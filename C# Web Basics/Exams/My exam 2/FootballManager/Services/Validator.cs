namespace FootballManager.Services
{
    using FootballManager.ViewModels.Players;
    using FootballManager.ViewModels.Users;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using static Data.DataConstants;

    public class Validator : IValidator
    {
        public ICollection<string> ValidateUser(UserRegisterModel model)
        {
            var errors = new List<string>();

            if (model.Username.Length < UserMinUsername || model.Username.Length > DefaultMaxLength)
            {
                errors.Add($"Username '{model.Username}' is not valid. It must be between {UserMinUsername} and {DefaultMaxLength} charecters long.");
            }

            if (!Regex.IsMatch(model.Email, UserEmailRegularExpression))
            {
                errors.Add($"Email '{model.Email}' is not a valid e-mail address.");
            }

            if (model.Password.Any(x => x == ' '))
            {
                errors.Add($"The provided password cannot contains any whitespaces.");
            }

            if (model.Password.Length < UserMinPassword
                || model.Password.Length > DefaultMaxLength)
            {
                errors.Add($"The provided password is not valid. It must be between {UserMinPassword} and {DefaultMaxLength} charecters long.");
            }

            if (model.Password != model.ConfirmPassword)
            {
                errors.Add($"Password and Confirm Password should be the same.");
            }

            return errors;
        }

        public ICollection<string> ValidateAddPlayer(AddPlayerModel model)
        {
            var errors = new List<string>();

            if (model.FullName.Length < PlayerMinFullName || PlayerMaxFullName < model.FullName.Length || model.FullName == null)
            {
                errors.Add($"Full name of the player '{model.FullName}' is not valid. It must be between {PlayerMinFullName} and {PlayerMaxFullName} charecters long.");
            }

            if (model.Position.Length < PlayerMinPosition || DefaultMaxLength < model.Position.Length || model.Position == null)
            {
                errors.Add($"Position '{model.Position}' is not valid. It must be between {PlayerMinPosition} and {DefaultMaxLength} charecters long.");
            }

            if (model.Speed < PlayerMinSpeed || PlayerMaxSpeed < model.Speed || model.Speed == null)
            {
                errors.Add($"The speed can be between {PlayerMinSpeed} and {PlayerMaxSpeed}. Please enter a valid number.");
            }

            if (model.Endurance < PlayerMinEndurance || PlayerMaxEndurance < model.Endurance || model.Endurance == null)
            {
                errors.Add($"The endurance can be between {PlayerMinEndurance} and {PlayerMaxEndurance}. Please enter a valid number.");
            }

            if (PlayerMaxDescription < model.Description.Length)
            {
                errors.Add($"Description of a player can be maximum {PlayerMaxDescription} charecters long.");
            }

            if (model.ImageUrl.Length == 0 || string.IsNullOrEmpty(model.ImageUrl))
            {
                errors.Add($"Image should be a valid string format. Please do not enter too big string.");
            }

            return errors;
        }
    }
}
