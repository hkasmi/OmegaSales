using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTO;
using DAL.Entities;
using DAL.ExtensionsMethods;

namespace DAL.Repositories
{
    public class CategoryRepository
    {
        private DbProductsContext DbCategory;

        public CategoryRepository(DbProductsContext dbContext)
        {
            DbCategory = dbContext;
        }

        public List<CategoryDTO> RetrieveAll()
        {
            List<CategoryDTO> catDto = new List<CategoryDTO>();

            foreach (var item in DbCategory.category.ToList())
            {
                catDto.Add(item.CategoryToCategoryDTO());
            }
            return catDto;
        }
    }
}
