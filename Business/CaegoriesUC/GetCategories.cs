using Common.DTO;
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
        UnitOfWork uow = new UnitOfWork(db);
        public List<CategoryDTO> GetCategories()
        {

                

            return uow.categoryRepository.RetrieveAll();

        }

    }
}
