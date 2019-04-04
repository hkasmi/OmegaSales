using Common.DTO;
using DAL.Entities;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ProductsUC
{
    public partial class Products
    {
        DbProductsContext db = new DbProductsContext();
        public List<ProductDTO> GetProducts()
        {
            //List<ProductDTO> messageDTO = new List<ProductDTO>() {
            //    new ProductDTO() {id=1, Name="Product1",Price=10 },
            //    new ProductDTO() {id=2, Name="Product2",Price=8.5 },
            //    new ProductDTO() {id=3, Name="Product3",Price=3.2 }
            //};
            
            UnitOfWork uow = new UnitOfWork(db);
            
            return uow.productRepository.RetrieveAll();

            
        }

        public ProductDTO GetProductById(int id)
        {
            UnitOfWork uow = new UnitOfWork(db);
            return uow.productRepository.Retrieve(id);
        }
        //Pourquoi ne pas faire une méthode update? Qui elle ferait le retrieve...
        //ok

        
    }
}
