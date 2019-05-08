using One.Infra.Data.Interface;

namespace One.Application.UoW
{
    public class ApplicationServiceTransaction
    {
        private readonly IUnitOfWorkTransaction _uow;
        public ApplicationServiceTransaction(IUnitOfWorkTransaction uow) => _uow = uow;
        public void BeginTransaction() => _uow.BeginTransaction();
        public void SaveChange() => _uow.SaveChange();
        public void Commit() => _uow.Commit();
        public void Rollback() => _uow.Rollback();
    }
}
