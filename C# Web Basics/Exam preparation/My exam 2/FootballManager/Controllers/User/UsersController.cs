namespace FootballManager.Controllers.User
{
    using System.Linq;

    using MyWebServer.Http;
    using MyWebServer.Controllers;

    using FootballManager.Data;
    using FootballManager.Data.Models;
    using FootballManager.Services;
    using FootballManager.ViewModels.Users;

    using static Data.DataConstants;

    public class UsersController : Controller
    {
        private readonly IValidator validator;
        private readonly IPasswordHasher passwordHasher;
        private readonly FootballManagerDbContext db;

        public UsersController(
            IValidator validator,
            IPasswordHasher passwordHasher,
            FootballManagerDbContext db)
        {
            this.validator = validator;
            this.passwordHasher = passwordHasher;
            this.db = db;
        }

        public HttpResponse Index()
        {
            return this.View();
        }

        public HttpResponse Login()
        {
            if (User.IsAuthenticated)
            {
                return Redirect("/Players/All");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Login(UserLoginModel model)
        {
            var hashedPassword = passwordHasher.HashPassword(model.Password);

            var userId = this.db
                .Users
                .Where(u => u.Username == model.Username && u.Password == hashedPassword)
                .Select(u => u.Id)
                .FirstOrDefault();

            if (userId == null)
            {
                return Error("Username and password combination is not valid.");
            }

            this.SignIn(userId);

            return Redirect("/Players/All");
        }

        public HttpResponse Register()
        {
            if (User.IsAuthenticated)
            {
                return Redirect("/Players/All");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Register(UserRegisterModel model)
        {
            var modelErrors = this.validator.ValidateUser(model);

            if (this.db.Users.Any(u => u.Username == model.Username))
            {
                modelErrors.Add($"User with '{model.Username}' already exists.");
            }

            if (this.db.Users.Any(u => u.Email == model.Email))
            {
                modelErrors.Add($"User with this email already exists. Please provide a new email");
            }

            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            var user = new User
            {
                Username = model.Username,
                Password = this.passwordHasher.HashPassword(model.Password),
                Email = model.Email,
            };

            this.db.Users.Add(user);
            this.db.SaveChanges();

            return Redirect("/Users/Login");
        }

        public HttpResponse Logout()
        {
            if (User.IsAuthenticated)
            {
                this.SignOut();

                return Redirect("/");
            }

            return this.Redirect("/Users/Register");
        }
    }
}
