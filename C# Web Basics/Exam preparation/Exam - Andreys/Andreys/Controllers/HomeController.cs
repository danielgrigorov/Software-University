namespace Andreys.App.Controllers
{
    using Andreys.Services;
    using SIS.HTTP;
    using SIS.MvcFramework;

    public class HomeController : Controller
    {
        private readonly IProdcutsService prodcutsService;

        public HomeController(IProdcutsService prodcutsService)
        {
            this.prodcutsService = prodcutsService;
        }

        [HttpGet("/")]
        public HttpResponse IndexSlash()
        {
            return this.Index();
        }

        public HttpResponse Index()
        {
            if (this.IsUserLoggedIn())
            {
                var allProducts = prodcutsService.GetAll();

                return this.View(allProducts, "Home");
            }

            return this.View();
        }
    }
}
