using EfCoreDatabasesTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreDatabasesTest.DataAccess.EntityFramework
{
    public class EfBookRepository : EfCoreRepositoryBase<Book>, IBookRepository
    {
        public EfBookRepository(EfCorePostgresContext context) : base(context)
        {
        }
    }
}