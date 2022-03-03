using CarShop.Data;
using CarShop.Data.Models;
using CarShop.Models.Users;
using CarShop.Services;
using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarShop.Controllers
{
    using static Data.DataConstants;
    public class UsersController : Controller
    {
        private readonly IValidator validator;
        private readonly ApplicationDbContext data;
        private readonly IPasswordHasher passwordHasher;

        public UsersController(
            IValidator validator,
            IPasswordHasher passwordHasher,
            ApplicationDbContext data)
        {
            this.validator = validator;
            this.data = data;
            this.passwordHasher = passwordHasher;
        }

        //public HttpResponse BadRequest { get; private set; }

        public HttpResponse Login() => View();

        public HttpResponse Register() => View();

        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel model)
        {
            var modelErrors = this.validator.ValidateUserRegistration(model);

            if (this.data.Users.Any(u => u.Username == model.Username))
            {
                modelErrors.Add($"User with {model.Username} username already exists.");
            }

            if (this.data.Users.Any(u => u.Email == model.Email))
            {
                modelErrors.Add($"User with {model.Email} e-mail already exists.");
            }

            if (modelErrors.Any())
            {
                return View(modelErrors, "Error");
                //return Error(modelErrors);
            }

            User user = new User
            {
                Username = model.Username,
                Password = this.passwordHasher.HashPassword(model.Password),
                Email = model.Email,
                IsMechanic = model.UserType == UserTypeMechanic
            };

            data.Users.Add(user);
            data.SaveChanges();

            return Redirect("/Users/Login");
        }

        
        [HttpPost]
        public HttpResponse Login(LoginUserFormModel model)
        {
            var hashedPassword = this.passwordHasher.HashPassword(model.Password);

            var userId = this.data
                .Users
                .Where(u => u.Username == model.Username && u.Password == hashedPassword)
                .Select(u => u.Id)
                .FirstOrDefault();

            if (userId == null)
            {
                return Error("Username and password combination is not valid.");
            }

            this.SignIn(userId);

            return Redirect("/Cars/All");
        }

        public HttpResponse Logout()
        {
            this.SignOut();

            return Redirect("/");
        }
    }
}
