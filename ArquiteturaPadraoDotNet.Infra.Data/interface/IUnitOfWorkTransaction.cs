using System;
using System.Collections.Generic;
using System.Text;

namespace One.Infra.Data.Interface
{
    public interface IUnitOfWorkTransaction
    {
        void BeginTransaction();
        void SaveChange();
        void Commit();
        void Rollback();
    }
}
