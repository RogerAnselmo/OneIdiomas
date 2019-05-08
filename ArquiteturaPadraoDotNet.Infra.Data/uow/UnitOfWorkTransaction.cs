using One.Infra.Data.Interface;
using One.Infra.Data.Context;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data.Common;

namespace One.Infra.Data.Uow
{
    public class UnitOfWorkTransaction: IUnitOfWorkTransaction
    {
        private readonly OneContext _db;
        public DbConnection DataBaseConnection { get; set; }
        public IDbContextTransaction Transaction { get; set; }
        public UnitOfWorkTransaction(OneContext db) => _db = db;
        public void BeginTransaction() => Transaction = _db.Database.BeginTransaction();
        public void SaveChange() => _db.SaveChanges();
        public void Commit() => Transaction.Commit();
        public void Rollback()
        {
            if (Transaction != null)
                Transaction.Rollback();
        }
    }
}
