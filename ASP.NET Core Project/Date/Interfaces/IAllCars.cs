using ASP.NET_Core_Project.Date.Models;
using System.Collections.Generic;

namespace ASP.NET_Core_Project.Date.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> FavoriteCars { get; set; }
        Car GetCar(int carId);
    }
}
