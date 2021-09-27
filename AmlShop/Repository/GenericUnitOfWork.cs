using AmlShop.datacontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmlShop.Repository
{
    public class GenericUnitOfWork<T> where T:class
    {
        private readonly DataContext _context;

        private IRepository<T> _entity;

        public GenericUnitOfWork(DataContext context)
        {
            _context = context;
        }



        public IRepository<T> GetRepositoryInstance
        {
            get
            {
                return _entity ?? (_entity = new GenericRepository<T>(_context));
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
