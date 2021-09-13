using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CoreDDDRestApi.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
