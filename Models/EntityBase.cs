using System;

namespace EfCoreDatabasesTest.Models
{
    public class EntityBase<T>
    {
        public EntityBase()
        {
            CreatedDate = DateTime.Now;
        }
        public T Id { get; set; }

        public DateTime CreatedDate { get; }
    }
}