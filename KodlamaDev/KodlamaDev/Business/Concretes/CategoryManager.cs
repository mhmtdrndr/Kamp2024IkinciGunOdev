using KodlamaDev.Business.Abstracts;
using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaDev.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryService _categoryService;
        public CategoryManager(ICategoryService categoryService) {
            _categoryService = categoryService;
        }
        public void AddCategory(Category category)
        {
            _categoryService.AddCategory(category);
            Console.WriteLine("\n" + category.CategoryName + " Eklendi...");
        }

        public void DeleteCategory(Category category)
        {
            _categoryService.DeleteCategory(category);
            Console.WriteLine("\n" + category.CategoryName + " Silindi...");
        }

        public Course GetCategoryById(int Id)
        {
            return _categoryService.GetCategoryById(Id);
        }

        public Course GetCategoryByName(string Name)
        {
            return _categoryService.GetCategoryByName(Name);
        }

        public void GetCategoryList()
        {
            _categoryService.GetCategoryList();
        }

        public void UpdateCategory(Category category)
        {
            _categoryService.UpdateCategory(category);
        }
    }
}
