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
        private CategoryRepository _categories;

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

        public CategoryRepository categoryRepository
        {
            get
            {
                if (_categories == null)
                {
                    _categories = new CategoryRepository(_dbContext);
                }
                return _categories;
            }
        }




        public void save()
        {
            _dbContext.SaveChanges();
        }

    }
}
