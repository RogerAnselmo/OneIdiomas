using One.Infra.Data.Interface;

namespace One.Application.UoW
{
    public class ApplicationService
    {
        private readonly IUnitOfWork _uow;

        public ApplicationService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.Commit();
        }
    }
}
