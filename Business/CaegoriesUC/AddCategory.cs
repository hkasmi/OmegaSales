using Common.DTO;
using DAL.Entities;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CaegoriesUC
{
    public partial class Categories
    {
        static DbProductsContext db = new DbProductsContext();
        public void AddCategory(CategoryDTO proDTO)
        {
            //UnitOfWork uow = new UnitOfWork(db);
            //uow.productRepository.Create(proDTO);
            //uow.save();
        }
    }
}
