using System.Collections.Generic;
using WebSite.Infraestrutura.DataBase.Contexto.Tables;

namespace WebSite.Infraestrutura.DataBase.Contexto.Interfaces
{
    public interface IRepositoryBase<TEntity>
    {
        void Add(TEntity obj);

        void AddList(IEnumerable<TEntity> objList);

        TEntity GetById(long id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
