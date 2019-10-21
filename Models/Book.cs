using System;

namespace EfCoreDatabasesTest.Models
{
    public class Book : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

    }
}