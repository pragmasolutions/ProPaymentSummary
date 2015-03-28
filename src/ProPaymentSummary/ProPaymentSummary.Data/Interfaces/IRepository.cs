using System;
using System.Linq;
using System.Linq.Expressions;
using ProPaymentSummary.Data.Helpers;
using ProPaymentSummary.Entities;

namespace ProPaymentSummary.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes);
        PagedResultList<T> GetAll(PagingCriteria paging, params Expression<Func<T, object>>[] includes);
        PagedResultList<T> GetAll(PagingCriteria paging, Expression<Func<T, bool>> whereClause,
                                   params Expression<Func<T, object>>[] includes);
        T Get(int id);
        T Get(Expression<Func<T, bool>> whereClause, params Expression<Func<T, object>>[] includes);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        bool Commit();
    }
}
