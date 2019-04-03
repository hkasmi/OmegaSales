using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories;

namespace DAL.UnitOfWork
{
    public class UnitOfWork
    {
        private DbProductsContext _dbContext;
        private ProductRepository _produts;

        public UnitOfWork(DbProductsContext db)
        {
            _dbContext = db;
        }

        public ProductRepository productRepository
        {
            get
            {
                if (_produts == null)
                {
                    _produts = new ProductRepository(_dbContext);
                }
                return _produts;
            }
        }




        public void save()
        {
            _dbContext.SaveChanges();
        }

    }
}
