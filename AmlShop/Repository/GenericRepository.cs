using AmlShop.datacontext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AmlShop.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;
        private DbSet<T> _dbset = null;

        public GenericRepository(DataContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbset.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetProduct()
        {
            return _dbset.ToList();
        }

        public int GetAllRecordCount()
        {
            return _dbset.Count();
        }

        public IEnumerable<T> GetAllRecords()
        {
            return _dbset.ToList();
        }

        public IQueryable<T> GetAllRecordsQuerably()
        {
            return _dbset;
        }

        public T GetFirsOrDefaultByParameter(Expression<Func<T, bool>> wherePredict)
        {
            return _dbset.Where(wherePredict).FirstOrDefault();
        }

        public T GetFirstOrDefault(int recordId)
        {
            return _dbset.Find(recordId);
        }

        public IEnumerable<T> GetListParameter(Expression<Func<T, bool>> wherePredict)
        {
            return _dbset.Where(wherePredict).ToList();
        }

        public IEnumerable<T> GetRecordsToShow(int pagenumber, int pagesize, int currentpage, Expression<Func<T, bool>> wherpredict, Expression<Func<T, int>> orderbypredict)
        {
            if (wherpredict != null)
            {
                return _dbset.OrderBy(orderbypredict).Where(wherpredict).ToList();
            }
            else
            {
                return _dbset.OrderBy(orderbypredict).ToList();
            }
        }

        public IEnumerable<T> GetResultBySqlProcedure(string query, params object[] parameters)
        {
           
            if (parameters != null)
            {
                return _dbset.FromSqlRaw<T>(query, parameters).ToList();
           
            }
            else
                //return _context.Database.SqlQuery<T>(query).ToList();
                return _dbset.FromSqlRaw<T>(query).ToList();
        }

        public void InActiveAndDeleteMarkByWhereClause(Expression<Func<T, bool>> wherePredict, Action<T> ForEachPredict)
        {
            _dbset.Where(wherePredict).ToList().ForEach(ForEachPredict);
        }

        public void Remove(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
                _dbset.Attach(entity);
            _dbset.Remove(entity);
        }

        public void RemoveRangeByWhereClause(Expression<Func<T, bool>> wherePredict)
        {
            List<T> entity = _dbset.Where(wherePredict).ToList();
            foreach(var ent in entity)
            {
                Remove(ent);
            }

        }

        public void RemoveWhereClause(Expression<Func<T, bool>> wherePredict)
        {
            T entity = _dbset.Where(wherePredict).FirstOrDefault();
            Remove(entity);
        }

        public void Update(T entity)
        {
            _dbset.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateWhereClause(Expression<Func<T, bool>> wherePredict, Action<T> ForEachPredict)
        {
            _dbset.Where(wherePredict).ToList().ForEach(ForEachPredict);
        }

        //public T GetProductById(int productId)
        //{
        //    throw new NotImplementedException();
        //}

        
    }
}
