namespace EfCoreDatabasesTest.DataAccess.EntityFramework
{
    public class EfCoreUnitOfWork : IUnitOfWork
    {
        private readonly EfCorePostgresContext _context;

        public EfCoreUnitOfWork(EfCorePostgresContext context)
        {
            _context = context;
        }
        public void CompleteAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}