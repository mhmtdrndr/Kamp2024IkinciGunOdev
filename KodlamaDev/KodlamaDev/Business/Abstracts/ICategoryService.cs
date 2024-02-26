using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaDev.Business.Abstracts
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void GetCategoryList();
        void DeleteCategory(Category category);
        Course GetCategoryById(int Id);
        Course GetCategoryByName(string Name);
        void UpdateCategory(Category category);
    }
}
