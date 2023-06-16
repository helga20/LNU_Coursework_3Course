using ZNO.DAL.Interface;
using ZNO.DAL.Repositories;
using ZNO.DAL.Repositories.Interface;

namespace ZNO.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DBContext _context;
        public IZmist Zmist { get; private set; }
        public ITopicRepository Topic { get; private set; }
        public ITimeRepository Time { get; private set; }

        private bool _disposed = false;

        public UnitOfWork(DBContext context)
        {
            _context = context;

            Zmist = new ZmistRepository(context);
            Topic = new TopicRepository(context);
            Time = new TimeRepository(context);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}