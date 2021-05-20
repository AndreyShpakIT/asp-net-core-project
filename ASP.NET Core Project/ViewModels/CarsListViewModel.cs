using ASP.NET_Core_Project.Date.Models;
using System.Collections.Generic;

namespace ASP.NET_Core_Project.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public string CurrentCategory { get; set; }
    }
}
