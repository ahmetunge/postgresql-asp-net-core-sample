namespace EfCoreDatabasesTest.DataAccess
{
    public interface IUnitOfWork
    {
         void CompleteAsync();
    }
}