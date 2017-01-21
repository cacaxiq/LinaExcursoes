﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using WebSite.Infraestrutura.DataBase.Contexto.Interfaces;
using WebSite.Infraestrutura.DataBase.Contexto.Tables;

namespace WebSite.Infraestrutura.DataBase.Contexto.Repositorio
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : TabelaBase
    {
        protected Contexto Db = new Contexto();

        public void Add(TEntity obj)
        {
            obj.DataInclusao = DateTime.Now;
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public virtual void AddList(IEnumerable<TEntity> objList)
        {
            foreach (var obj in objList)
            {
                this.Add(obj);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return Db.Set<TEntity>().Where(predicate).ToList();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList().OrderByDescending(p => p.DataInclusao);
        }

        public TEntity GetById(long id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            bool oldValidateOnSaveEnabled = Db.Configuration.ValidateOnSaveEnabled;

            try
            {
                Db.Configuration.ValidateOnSaveEnabled = false;
                Db.Entry(obj).State = EntityState.Deleted;
                Db.SaveChanges();
            }
            finally
            {
                Db.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
            }
        }

        public void RemoveList(IEnumerable<TEntity> objList)
        {
            foreach (var obj in objList)
            {
                this.Remove(obj);
            }
        }

        public void Update(TEntity obj)
        {
            obj.DataInclusao = DateTime.Now;
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void UpdateList(IEnumerable<TEntity> objList)
        {
            foreach (var obj in objList)
            {
                this.Update(obj);
            }
        }
    }
}