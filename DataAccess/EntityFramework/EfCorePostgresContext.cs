using EfCoreDatabasesTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreDatabasesTest.DataAccess.EntityFramework
{
    public class EfCorePostgresContext : DbContext
    {
        public EfCorePostgresContext(DbContextOptions<EfCorePostgresContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}