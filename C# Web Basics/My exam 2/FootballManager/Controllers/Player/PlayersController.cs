namespace FootballManager.Controllers.Player
{
    using System.Linq;

    using MyWebServer.Http;
    using MyWebServer.Controllers;

    using FootballManager.Data;
    using FootballManager.Data.Models;
    using FootballManager.Services;
    using FootballManager.ViewModels.Players;
    using System.Collections.Generic;

    public class PlayersController : Controller
    {

        private readonly IValidator validator;
        private readonly FootballManagerDbContext dbContext;

        public PlayersController(
            IValidator validator,
            FootballManagerDbContext dbContext)
        {
            this.validator = validator;
            this.dbContext = dbContext;
        }

        [Authorize]
        public HttpResponse All()
        {
            var allPlayers = this.dbContext.Players
                .Select(p => new AllPlayersModel
                {
                    Id = p.Id,
                    FullName = p.FullName,
                    ImageUrl = p.ImageUrl,
                    Position = p.Position,
                    Speed = p.Speed,
                    Endurance = p.Endurance,
                    Description = p.Description,
                }).ToList();

            return this.View(allPlayers);
        }

        [Authorize]
        public HttpResponse Collection()
        {
            var collection = this.dbContext.UserPlayers
                .Where(x => x.UserId == User.Id)
                .Select(x => new PlayersCollectionModel
                {
                    Id = x.Player.Id,
                    FullName = x.Player.FullName,
                    ImageUrl = x.Player.ImageUrl,
                    Position = x.Player.Position,
                    Speed = x.Player.Speed,
                    Endurance = x.Player.Endurance,
                    Description = x.Player.Description,
                }).ToList();

            return this.View(collection);
        }

        [Authorize]
        public HttpResponse Add()
        {
            if (!User.IsAuthenticated)
            {
                return this.Redirect("/Users/Register");
            }

            return this.View();
        }

        [HttpPost]
        [Authorize]
        public HttpResponse Add(AddPlayerModel model)
        {
            var modelErrors = this.validator.ValidateAddPlayer(model);

            if (modelErrors.Any())
            {
                return this.Error(modelErrors);
            }

            var newPalyer = new Player
            {
                FullName = model.FullName,
                ImageUrl = model.ImageUrl,
                Position = model.Position,
                Speed = model.Speed,
                Endurance = model.Endurance,
                Description = model.Description,
            };

            this.dbContext.Players.Add(newPalyer);
            this.dbContext.SaveChanges();

            return this.Redirect("/Players/All");
        }

        [Authorize]
        public HttpResponse AddToCollection(int playerId)
        {
            var player = this.dbContext.Players.Find(playerId);

            if (player == null)
            {
                return this.Redirect("/Players/All");
            }

            if (this.dbContext.UserPlayers
                .Where(up => up.UserId == this.User.Id && up.PlayerId == playerId)
                .Any())
            {
                return this.Error("You already have that player in your collection. Please choose another one from the menu.");
            }

            var addPlayer = new UserPlayer
            {
                UserId = User.Id,
                PlayerId = playerId
            };

            this.dbContext.UserPlayers.Add(addPlayer);
            this.dbContext.SaveChanges();

            return this.Redirect("/Players/All");
        }

        public HttpResponse RemoveFromCollection(int playerId)
        {
            var player = this.dbContext.Players.Find(playerId);

            if (player == null)
            {
                return this.Redirect("/Players/Collection");
            }

            var removePlayer = this.dbContext.UserPlayers.FirstOrDefault(x => x.UserId == User.Id && x.PlayerId == playerId);

            if (removePlayer == null)
            {
                return this.Redirect("/Players/All");
            }

            this.dbContext.UserPlayers.Remove(removePlayer);
            this.dbContext.SaveChanges();

            return this.Redirect("/Players/Collection");
        }
    }
}
