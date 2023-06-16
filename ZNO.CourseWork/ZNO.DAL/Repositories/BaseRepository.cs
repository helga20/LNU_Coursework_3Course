namespace ZNO.DAL.Repositories
{
    public abstract class BaseRepository
    {
        protected DBContext _context;

        public BaseRepository(DBContext context)
        {
            _context = context;
        }
    }
}
