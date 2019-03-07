using One.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using One.Domain.Interfaces.Repository;

namespace One.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public OneContext Db;
        public DbSet<TEntity> DbSet;
        private string _ConnectionString = string.Empty;

        public Repository(OneContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Salvar(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual TEntity ObterPorId(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<TEntity> ObterTodos()
        {
            return DbSet;
        }

        public virtual void Alterar(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Excluir(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
