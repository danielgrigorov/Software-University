using CarShop.Data;
using CarShop.Data.Models;
using CarShop.Models.Cars;
using CarShop.Services;
using SUS.HTTP;
using SUS.MvcFramework;
using System.Linq;

namespace CarShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IValidator validator;
        private readonly IUsersService usersService;
        private readonly ApplicationDbContext data;

        public CarsController(
            IValidator validator, 
            ApplicationDbContext data,
            IUsersService usersService)
        {
            this.validator = validator;
            this.data = data;
            this.usersService = usersService;
        }

        public HttpResponse Add()
        {
            if (this.usersService.IsUserMechanic(this.GetUserId()))
            {
                return Error("Not authorized.");
            }

            return View();
        }

        [HttpPost]
        public HttpResponse Add(AddCarFormModel model)
        {
            if (this.usersService.IsUserMechanic(this.GetUserId()))
            {
                return Error("Not authorized.");
            }

            var modelErrors = this.validator.ValidateCar(model);

            if (modelErrors.Any())
            {
                return View(modelErrors, "Error");
            }

            var car = new Car
            {
                Model = model.ModelType,
                Year = model.Year,
                PictureUrl = model.Image,
                PlateNumber = model.PlateNumber,
                OwnerId = this.GetUserId()
            };

            this.data.Cars.Add(car);
            this.data.SaveChanges();

            return Redirect("Cars/All");
        }

        public HttpResponse All()
        {
            var carsQuery = this.data.Cars.AsQueryable();

            if (this.usersService.IsUserMechanic(this.GetUserId()))
            {
                carsQuery = carsQuery
                    .Where(c => c.Issues.Any(i => !i.IsFixed));
            }
            else
            {
                carsQuery = carsQuery
                   .Where(c => c.OwnerId == this.GetUserId());
            }

            var cars = carsQuery
                .Select(c => new CarListingViewModel
                {
                    Id = c.Id,
                    Model = c.Model,
                    PlateNumber = c.PlateNumber,
                    Image = c.PictureUrl,
                    Year = c.Year,
                    FixedIssues = c.Issues.Where(i => i.IsFixed).Count(),
                    RemainingIssues = c.Issues.Where(i => !i.IsFixed).Count()
                })
                    .ToList();

            return View(cars);
        }
    }
}
