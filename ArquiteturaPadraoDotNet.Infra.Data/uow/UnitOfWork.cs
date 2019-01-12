using One.Infra.Data.Context;
using One.Infra.Data.Interface;

namespace One.Infra.Data.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private OneContext _context;
        private bool _disposed;

        public UnitOfWork(OneContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
