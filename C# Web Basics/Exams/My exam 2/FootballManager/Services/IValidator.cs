namespace FootballManager.Services
{
    using System.Collections.Generic;
    using FootballManager.ViewModels.Players;
    using FootballManager.ViewModels.Users;

    public interface IValidator
    {
        ICollection<string> ValidateUser(UserRegisterModel model);
        ICollection<string> ValidateAddPlayer(AddPlayerModel model);

        // public ICollection<string> ValidateAddTrip(PlayerAddModel model);

    }
}
