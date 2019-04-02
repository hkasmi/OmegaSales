using Common.DTO;
using Common.Interfaces;
using DAL.Entities;
using DAL.ExtensionsMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductRepository : IRepository<ProductDTO>
    {
        private DbProductsContext DbProduct;

        public ProductRepository(DbProductsContext Db)
        {
            DbProduct = Db;
        }
        public ProductDTO Create(ProductDTO ProductDto)
        {
            Product pro = ProductDto.ProductDTOToProducts();
            DbProduct.product.Add(pro);
            return ProductDto;
            //return (DbProduct.product.Add(objDto.ProductDTOToProducts())).ProductToProductDTO();
        }

        public void Delete(int id)
        {
            //ProductDTO ProductDto = Retrieve(id).ProductDTOToProducts();
            DbProduct.product.Remove(Pro);
        }

        public void Delete(string id)
        {
            Product product = Retrieve(id);
            DbProduct.product.Remove(product);
        }

        public void Dispose()
        {
            DbProduct.Dispose();
        }

        public ProductDTO Retrieve(int id)
        {

            return DbProduct.product.FirstOrDefault(u => u.Id == id);
        }

        public Product Retrieve(string id)
        {
            throw new NotImplementedException();
        }

        public List<Product> RetrieveAll()
        {
            return DbProduct.product.ToList();
        }

        public void Update(Product obj)
        {
            Product product = Retrieve(obj.Id);
            product.Name = obj.Name;
            product.Price = obj.Price;
        }
    }
}
