using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Data
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => 
            new List<Category> { 
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Fruit pies",
                    Description="Pies with fruits"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Cheese pies",
                    Description="Pies with Cheese"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Meat pies",
                    Description="Pies with meat"
                }
            };
    }
}
