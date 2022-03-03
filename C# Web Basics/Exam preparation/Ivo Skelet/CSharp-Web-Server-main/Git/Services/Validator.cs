namespace Git.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Git.Models.Repositories;
    using Git.Models.Users;

    using static Data.DataConstants;

    public class Validator : IValidator
    {
        public ICollection<string> ValidateRepository(CreateRepositoryFormModel model)
        {
            var errors = new List<string>();

            if (model.Name.Length < RepositoryNameMinLength || model.Name.Length > RepositoryNameMaxLength)
            {
                errors.Add($"Repository '{model.Name}' is not valid. It must be between {RepositoryNameMinLength} and {RepositoryNameMaxLength} characters long.");
            }

            if (model.RepositoryType != RepositoryPublicType && model.RepositoryType != RepositoryPrivateType)
            {
                errors.Add($"Repository type can be either '{RepositoryPublicType}' or '{RepositoryPrivateType}'.");
            }

            return errors;
        }

        public ICollection<string> ValidateUserRegistration(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.Username.Length < UsernameMinValue || model.Username.Length > DefaultMaxLength)
            {
                errors.Add($"Username '{model.Username}' is not valid. It must be between {UsernameMinValue} and {DefaultMaxLength} characters long.");
            }

            if (!Regex.IsMatch(model.Email, UserEmailRegularExpression))
            {
                errors.Add($"Email {model.Email} is not a valid e-mail address.");
            }

            if (model.Password.Length < PasswordMinValue || model.Password.Length > DefaultMaxLength)
            {
                errors.Add($"The provided password is not valid. It must be between {PasswordMinValue} and {DefaultMaxLength} characters long.");
            }

            if (model.Password.Any(x => x == ' '))
            {
                errors.Add($"The provided password cannot contain whitespaces.");
            }

            if (model.Password != model.ConfirmPassword)
            {
                errors.Add("Password and its confirmation are different.");
            }

            return errors;
        }
    }
}
