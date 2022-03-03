using FootballManager.Data;
using FootballManager.Data.Models;
using FootballManager.Services;
using FootballManager.ViewModels.Players;
using MyWebServer.Controllers;
using MyWebServer.Http;
using System.Linq;

namespace FootballManager.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IValidator validator;
        private readonly FootballManagerDbContext data;

        public PlayersController(
            IValidator validator,
            FootballManagerDbContext data)
        {
            this.validator = validator;
            this.data = data;
        }

        [Authorize]
        public HttpResponse All()
        {
            var playersQuery = this.data
                .Players
                .AsQueryable();

            var players = playersQuery
                .Select(c => new PlayerListingViewModel
                {
                    Id = c.Id.ToString(),
                    FullName = c.FullName,
                    ImageUrl = c.ImageUrl,
                    Position = c.Position,
                    Speed = c.Speed,
                    Endurance = c.Endurance,
                    Description = c.Description
                })
                .ToList();

            return View(players);
        }

        [Authorize]
        public HttpResponse Add()
        {
            if (!User.IsAuthenticated)
            {
                return Redirect("/Users/Login");
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public HttpResponse Add(AddPlayerFormModel model)
        {
            var modelErrors = this.validator.ValidatePlayer(model);

            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            var player = new Player
            {
                FullName = model.FullName,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                Speed = model.Speed,
                Endurance = model.Endurance,
                Position = model.Position
            };

            data.Players.Add(player);

            data.SaveChanges();

            return Redirect("/Players/All");
        }

        [Authorize]
        public HttpResponse AddToCollection(int playerId)
        {
            var user = data.Users
                .FirstOrDefault(u => u.Id == User.Id);

            var player = data.Players
                .FirstOrDefault(t => t.Id == playerId);

            data.UserPlayers.Add(new UserPlayer
            {
                PlayerId = playerId,
                Player = player,
                UserId = user.Id,
                User = user
            });

            data.SaveChanges();

            return this.Redirect($"/Players/All");
        }

        [Authorize]
        public HttpResponse Collection()
        {
            var playersQuery = this.data
               .Players
               .AsQueryable();

            var players = playersQuery
                .Select(c => new PlayerListingViewModel
                {
                    Id = c.Id.ToString(),
                    FullName = c.FullName,
                    ImageUrl = c.ImageUrl,
                    Position = c.Position,
                    Speed = c.Speed,
                    Endurance = c.Endurance,
                    Description = c.Description
                })
                .ToList();

            return View(players);
        }

        [Authorize]
        [HttpPost]
        public HttpResponse Add(CreatePlayerViewModel model)
        {
            if (!User.IsAuthenticated)
            {
                return Redirect("/Users/Login");
            }
            var checkForErrors = playerService.CreatePlayer(model, this.User.Id);
            if (checkForErrors.Count != 0)
            {
                return Error(checkForErrors);
            }
            return Redirect("/Players/All");
        }
    }
}
