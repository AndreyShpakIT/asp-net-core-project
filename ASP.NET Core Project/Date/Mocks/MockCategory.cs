using ASP.NET_Core_Project.Date.Interfaces;
using ASP.NET_Core_Project.Date.Models;
using System.Collections.Generic;

namespace ASP.NET_Core_Project.Date.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category
                    {
                        CategoryName = "Электромобили",
                        Desc = "Современный вид транспорта"
                    },
                    new Category
                    {
                        CategoryName = "Классические автомобили",
                        Desc = "Машины с двигателем внутреннего сгорания"
                    }
                };
            }
        }
    }
}