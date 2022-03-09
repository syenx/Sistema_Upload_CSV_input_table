using System;
using OP.PortalOncoprod.Infra.Data.Context;
using OP.PortalOncoprod.Infra.Data.Interfaces;

namespace OP.PortalOncoprod.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PortalOncoprodContext _context;
        private bool _disposed;

        public UnitOfWork(PortalOncoprodContext context)
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

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}