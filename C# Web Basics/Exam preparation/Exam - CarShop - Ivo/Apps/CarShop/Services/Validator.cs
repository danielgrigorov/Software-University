using CarShop.Models.Cars;
using CarShop.Models.Users;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CarShop.Services
{
    using static Data.DataConstants;
    public class Validator : IValidator
    {
        public ICollection<string> ValidateCar(AddCarFormModel model)
        {
            var errors = new List<string>();

            if (model.ModelType.Length < CarModelMinLength || model.ModelType.Length > DefaultMaxLength)
            {
                errors.Add($"Model '{model.ModelType}' is not valid. It must be between {CarModelMinLength} and {DefaultMaxLength} characters long.");
            }

            if (model.Year < CarYearMinValue || model.Year > CarYearMaxValue)
            {
                errors.Add($"Year '{model.Year}' is not valid. It must be between {CarYearMinValue} and {CarYearMaxValue}.");
            }

            //if (Uri.IsWellFormedUriString(model.Image, UriKind.Absolute))
            //{
            //    errors.Add($"Image {model.Image} is not a valid URL.");
            //}

            if (Regex.IsMatch(model.PlateNumber, CarPlateNumberRegularExpression))
            {
                errors.Add($"Plate number {model.PlateNumber} is not valid. It should be in format 'AA0000AA'.");
            }

            return errors;
        }

        public ICollection<string> ValidateUserRegistration(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.Username.Length < UserMinUsername || model.Username.Length > DefaultMaxLength)
            {
                errors.Add($"{model.Username} is not valid. It must be between {UserMinUsername} and {DefaultMaxLength} characters long.");
            }

            if (model.Password.Length < UserMinPassowrd || model.Password.Length > DefaultMaxLength)
            {
                errors.Add($"The provided password is not valid. It must be between {UserMinPassowrd} and {DefaultMaxLength} characters long.");
            }

            if (model.Password != model.ConfirmPassword)
            {
                errors.Add("Password and its confirmation are different.");
            }

            if (model.UserType != UserTypeMechanic && model.UserType != UserTypeClient)
            {
                errors.Add($"User should be either a {UserTypeMechanic} or {UserTypeClient}.");
            }

            return errors;
        }
    }
}
