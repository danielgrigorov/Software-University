using CarShop.Data;
using CarShop.Models.Cars.Issues;
using CarShop.Services;
using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarShop.Controllers
{
    public class IssuesController : Controller
    {
        private readonly IUsersService usersService;
        private readonly ApplicationDbContext data;

        public IssuesController(
            IUsersService usersService,
            ApplicationDbContext data)
        {
            this.usersService = usersService;
            this.data = data;
        }

        public HttpResponse CarIssues(string carId)
        {
            if (!this.usersService.IsUserMechanic(this.GetUserId()))
            {
                var userOwnsCar = this.data.Cars.Any(c => c.Id == carId && c.OwnerId == this.GetUserId());

                if (!userOwnsCar)
                {
                    return Error("You do not have access to this car.");
                }
            }

            var issues = this.data
                .Issues
                .Where(i => i.CarId == carId)
                .Select(i => new IssueListingViewModel
                {
                    CarYear = i.Car.Year,
                    IssueId = i.Id,
                    Description = i.Description,
                    IsFixed = i.IsFixed,
                    CarModel = i.Car.Model,
                    CarId = i.CarId
                })
                .ToList();

            return View(issues);
        }
    }
}
