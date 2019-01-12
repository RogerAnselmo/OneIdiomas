using System;
using System.Linq;

namespace One.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Salvar(TEntity obj);
        TEntity ObterPorId(int id);
        IQueryable<TEntity> ObterTodos();
        void Alterar(TEntity obj);
        void Excluir(int id);
        int SaveChanges();
    }
}
