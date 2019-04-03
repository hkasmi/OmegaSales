using Common.DTO;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ExtensionsMethods
{
    public static class Converters
    {
        
        public static Product ProductDTOToProducts(this ProductDTO dto)
        {
            return new Product
            {
                Id = dto.id,
                Name = dto.Name,
                Price = dto.Price,
                Category = dto.category.ProductCategoryDTOToProductCategory()
                

            };
        }

        public static ProductDTO ProductToProductDTO(this Product product)
        {
            return new ProductDTO
            {
                id = product.Id,
                Name = product.Name,
                Price = product.Price,
                category = product.Category.ProductCategoryToProductCategoryDTO()
            };

        }

        public static ProductCategory ProductCategoryDTOToProductCategory(this CategoryDTO dto)
        {
            return new ProductCategory
            {
                Id = dto.id,
                Name = dto.Name
            };
        }
        public static CategoryDTO ProductCategoryToProductCategoryDTO(this ProductCategory category)
        {
            return new CategoryDTO
            {
                id = category.Id,
                Name = category.Name
            };

        }
    }

}
