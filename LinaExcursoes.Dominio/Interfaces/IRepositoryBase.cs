using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LinaExcursoes.Dominio.Interfaces
{
    public interface IRepositoryBase<TEntity>
    {
        void Add(TEntity obj);

        void AddList(IEnumerable<TEntity> objList);

        TEntity GetById(long id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

        void Update(TEntity obj);

        void UpdateList(IEnumerable<TEntity> objList);

        void Remove(TEntity obj);

        void RemoveList(IEnumerable<TEntity> objList);

        void Remove(long id);

        void Dispose();
    }
}
