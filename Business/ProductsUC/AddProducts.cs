using Common.DTO;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ProductsUC
{
    public partial class ProductsUC
    {
        public void Create(ProductDTO proDTO)
        {
            UnitOfWork uow = new UnitOfWork(db);
            uow.productRepository.Create(proDTO);
            uow.save();
        }
    }
}
