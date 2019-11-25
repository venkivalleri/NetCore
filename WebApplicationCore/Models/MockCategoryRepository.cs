using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category> {
                new Category{CategoryId=1,CategoryName="Fruit Pies",Description="All-Fruit Pies"},
                 new Category{CategoryId=2,CategoryName="Cheese Cakes",Description="Cheese all the Way"},
                  new Category{CategoryId=3,CategoryName="Seasonal Pies",Description="Get in the mood of the seasonal Pie"}
            };
    }
}
