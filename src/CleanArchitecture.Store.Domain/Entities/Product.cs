using CleanArchitecture.Store.Domain.Common;

namespace CleanArchitecture.Store.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}