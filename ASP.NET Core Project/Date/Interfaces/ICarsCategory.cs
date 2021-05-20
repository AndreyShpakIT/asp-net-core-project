using ASP.NET_Core_Project.Date.Models;
using System.Collections.Generic;

namespace ASP.NET_Core_Project.Date.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> Categories { get; }
    }
}
