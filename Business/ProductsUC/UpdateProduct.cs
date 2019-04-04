using Common.DTO;
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
        public void Update(ProductDTO dto)
        {

            UnitOfWork uow = new UnitOfWork(db);
            uow.productRepository.Update(dto);
            uow.save();
        }
        
    }
}
