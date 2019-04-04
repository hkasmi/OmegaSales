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
        
        public void delete(int id)
        {
            UnitOfWork uow = new UnitOfWork(db);
            uow.productRepository.Delete(id);
            uow.save();

        }
    }
}
