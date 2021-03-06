namespace CleanArchitecture.Store.Application.Features.Categories.Queries.GetCategoryById
{
    public class CategoryProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public int CategoryId { get; set; }

        public string InternationalName { get; set; }
        public string InternationalUrl { get; set; }
        public decimal InternationalPrice { get; set; }
        public string InternationalCurrency { get; set; }
    }
}