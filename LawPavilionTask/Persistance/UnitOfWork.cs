namespace LawPavilionTask.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserContext _context;
        public UnitOfWork(UserContext context)
        {
            _context = context;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }

    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}