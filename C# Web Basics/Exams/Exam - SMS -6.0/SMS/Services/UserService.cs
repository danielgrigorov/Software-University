using SMS.Contracts;
using SMS.Data.Common;
using SMS.Data.Models;
using SMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;

        private readonly IValidationService validationService;

        public UserService(
            IRepository _repo,
            IValidationService _validationService)
        {
            repo = _repo;
            validationService = _validationService;
        }

        public string GetUsername(string userId)
        {
            return repo.All<User>()
                .FirstOrDefault(u => u.Id == userId)?.Username;
        }

        public string Login(LoginViewModel model)
        {
            var user = repo.All<User>()
                .Where(u => u.Username == model.Username)
                .Where(u => u.Password == CalculateHash(model.Password))
                .SingleOrDefault();

            return user?.Id;
        }

        public (bool registered, string error) Register(RegisterViewModel model)
        {
            bool registered = false;
            string error = null;

            var (isValid, validationError) = validationService.ValidateModel(model);

            if (!isValid)
            {
                return (isValid, validationError);
            }

            Cart cart = new Cart();

            User user = new User()
            {
                Email = model.Email,
                Password = CalculateHash(model.Password),
                Username = model.Username,
                Cart = cart,
                CartId = cart.Id
            };

            try
            {
                repo.Add(user);
                repo.SaveChanges();
                registered = true;
            }
            catch (Exception)
            {
                error = "Could not save user in DB";
            }

            return (registered, error);
        }

       

        private string CalculateHash(string password)
        {
            byte[] passwordArray = Encoding.UTF8.GetBytes(password);

            using (SHA256 sha256 = SHA256.Create())
            {
                return Convert.ToBase64String(sha256.ComputeHash(passwordArray));
            }
        }

        //private (bool isValid, string error) ValidateRegisterModel(RegisterViewModel model)
        //{
        //    bool isValid = true;
        //    StringBuilder error = new StringBuilder();

        //    if (model == null)
        //    {
        //        return (false, "Register model is required");
        //    }

        //    if (string.IsNullOrEmpty(model.Username) || model.Username.Length < 5 || model.Username.Length > 20)
        //    {
        //        isValid = false;
        //        error.AppendLine("Username must be between 5 and 20 characters");
        //    }

        //    if (string.IsNullOrEmpty(model.Email))
        //    {
        //        isValid = false;
        //        error.AppendLine("Email must be valid email");
        //    }

        //    if (string.IsNullOrEmpty(model.Password) || model.Password.Length < 6 || model.Password.Length > 20)
        //    {
        //        isValid = false;
        //        error.AppendLine("Password must be between 6 and 20 characters");
        //    }

        //    if (model.Password != model.ConfirmPassword)
        //    {
        //        isValid = false;
        //        error.AppendLine("Password and ConfirmPassword must be equal");
        //    }

        //    return (isValid, error.ToString());
        //}
    }
}
