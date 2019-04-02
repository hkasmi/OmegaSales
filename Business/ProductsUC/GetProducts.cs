using Common.DTO;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ProductsUC
{
    public partial class ProductsUC
    {
        public List<ProductDTO> GetProducts()
        {
            List<ProductDTO> messageDTO = new List<ProductDTO>() {
                new ProductDTO() {id=1, Name="Product1",Price=10 },
                new ProductDTO() {id=2, Name="Product2",Price=8.5 },
                new ProductDTO() {id=3, Name="Product3",Price=3.2 }
            };
            return messageDTO;
        }
    }
}
