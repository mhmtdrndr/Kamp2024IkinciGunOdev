using KodlamaDev.DataAccess.Abstracts;
using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaDev.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {
            Category category = new Category();
            category.CategoryId = 001;
            category.CategoryName = "Programlama";
            category.CategoryDescription = "Yazılım Programlama Dilleri";

            categories = new List<Category> { category };
        }
        public void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetCategoryById(int Id)
        {
            foreach (var category in categories)
            {
                if(Id == category.CategoryId)
                {
                    return category;
                }
            }
            throw new Exception(Id + " id'li Kategori bulunamadı");
        }

        public void UpdateCategory(Category category)
        {
            Category UpdateCategory = GetCategoryById(category.CategoryId);
            if (UpdateCategory != null)
            {
                UpdateCategory.CategoryId = category.CategoryId;
                UpdateCategory.CategoryName = category.CategoryName;
                UpdateCategory.CategoryDescription = category.CategoryDescription;
            }
            else
            {
                UpdateCategory = null;
            }
        }
    }
}
