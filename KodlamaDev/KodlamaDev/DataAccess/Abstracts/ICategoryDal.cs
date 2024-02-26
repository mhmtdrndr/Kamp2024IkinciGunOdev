using KodlamaDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaDev.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
        List<Category> GetAll();
        Category GetCategoryById(int id);
    }
}
