using System;

namespace EfCoreDatabasesTest.Models
{
    public class Category:EntityBase<Guid>
    {
        public string Name { get; set; }
    }
}