using SharedTrip.Data.Models.Users;
using SharedTrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedTrip.Contracts
{
    public interface IUserService
    {
        (bool isValid,IEnumerable<ErrorViewModel> errors) ValidateModel(RegisterViewModel model);
        void RegisterUser(RegisterViewModel model);
        (string userId, bool isCorrect) IsLoginCorrect(LoginViewModel model);
    }
}
