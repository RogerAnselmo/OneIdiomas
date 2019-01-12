using System;
using System.Collections.Generic;
using System.Text;

namespace One.Infra.Data.Interface
{
    public interface IUnitOfWork: IDisposable
    {
        void BeginTransaction();
        void Commit();
    }
}
