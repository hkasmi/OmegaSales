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
                Price = dto.Price

            };
        }

        public static ProductDTO ProductToProductDTO(this Product product)
        {
            return new ProductDTO
            {
                id = product.Id,
                Name = product.Name,
                Price = product.Price

            };

        }
    }
}
