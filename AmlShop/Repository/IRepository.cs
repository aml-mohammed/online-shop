using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AmlShop.Repository
{
   public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetProduct();


       
      //  T GetProductById(int productId);
        IEnumerable<T> GetAllRecords();
        IQueryable<T> GetAllRecordsQuerably();
        int GetAllRecordCount();
        void Add(T entity);
        void Update(T entity);
        void UpdateWhereClause(Expression<Func<T,bool>> wherePredict,Action<T> ForEachPredict);
        T GetFirstOrDefault(int recordId);
        void Remove(T entity);
        void RemoveWhereClause(Expression<Func<T, bool>> wherePredict);
        void RemoveRangeByWhereClause(Expression<Func<T, bool>> wherePredict);
        void InActiveAndDeleteMarkByWhereClause(Expression<Func<T, bool>> wherePredict, Action<T> ForEachPredict);
        T GetFirsOrDefaultByParameter(Expression<Func<T, bool>> wherePredict);
        IEnumerable<T> GetListParameter(Expression<Func<T, bool>> wherePredict);
        IEnumerable<T> GetResultBySqlProcedure(string query, params object[] parameters);
        IEnumerable<T> GetRecordsToShow(int pagenumber,int pagesize,int currentpage,Expression<Func<T,bool>>wherpredict,Expression<Func<T,int>>orderbypredict);





    }
}
