using ASP.NET_Core_Project.Date.Interfaces;
using ASP.NET_Core_Project.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP.NET_Core_Project.Date.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get 
            {
                return new List<Car>
                {
                    new Car { Name = "Tesla", 
                        ShortDesc = "Хорошая машина", 
                        LongDesc = "Хорошоя электро-машина", 
                        Img = "https://www.ixbt.com/img/n1/news/2021/0/6/lhd-model-3-social_large.png", 
                        Price = 45000, 
                        IsFavorite = false, 
                        Available = true, 
                        Category =  _categoryCars.Categories.First()
                    },
                    new Car { Name = "Tesla 2",
                        ShortDesc = "Хорошая машина",
                        LongDesc = "Хорошоя электро-машина",
                        Img = "https://www.ixbt.com/img/n1/news/2021/0/6/lhd-model-3-social_large.png",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category =  _categoryCars.Categories.Last()
                    },
                    new Car { Name = "Tesla 3",
                        ShortDesc = "Хорошая машина",
                        LongDesc = "Хорошоя электро-машина",
                        Img = "https://www.ixbt.com/img/n1/news/2021/0/6/lhd-model-3-social_large.png",
                        Price = 45000,
                        IsFavorite = false,
                        Available = false,
                        Category =  _categoryCars.Categories.Last()
                    },
                    new Car { Name = "Tesla 4",
                        ShortDesc = "Хорошая машина",
                        LongDesc = "Хорошоя электро-машина",
                        Img = "https://www.ixbt.com/img/n1/news/2021/0/6/lhd-model-3-social_large.png",
                        Price = 45000,
                        IsFavorite = true,
                        Available = false,
                        Category =  _categoryCars.Categories.First()
                    },
                    new Car { Name = "Tesla 5",
                        ShortDesc = "Хорошая машина",
                        LongDesc = "Хорошоя электро-машина",
                        Img = "https://www.ixbt.com/img/n1/news/2021/0/6/lhd-model-3-social_large.png",
                        Price = 12444,
                        IsFavorite = true,
                        Available = false,
                        Category =  _categoryCars.Categories.First()
                    },
                    new Car { Name = "Tesla 6",
                        ShortDesc = "Хорошая машина",
                        LongDesc = "Хорошоя электро-машина",
                        Img = "https://www.ixbt.com/img/n1/news/2021/0/6/lhd-model-3-social_large.png",
                        Price = 4111,
                        IsFavorite = true,
                        Available = false,
                        Category =  _categoryCars.Categories.First()
                    },
                };
            }
        }
        public IEnumerable<Car> FavoriteCars { get; set; }

        public Car GetCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
