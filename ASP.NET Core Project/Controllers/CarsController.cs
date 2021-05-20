using ASP.NET_Core_Project.Date.Interfaces;
using ASP.NET_Core_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Project.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _cars;
        private readonly ICarsCategory _categories;

        public CarsController(IAllCars cars, ICarsCategory categories)
        {
            _cars = cars;
            _categories = categories;
        }

        public ViewResult List()
        {
            CarsListViewModel vm = new CarsListViewModel();
            vm.Cars = _cars.Cars;
            vm.CurrentCategory = "Автомобили";

            return View(vm);
        }
    }
}