namespace Shared.Products
{
    public static class ProductRequest
    {
        public class GetIndex
        {
            public string SearchTerm { get; set; }
            public string Category { get; set; }
            public bool OnlyActiveProducts { get; set; }
            public decimal? MinimumPrice { get; set; }
            public decimal? MaximumPrice { get; set; }
        }

        public class GetDetail
        {
            public int ProductId { get; set; }
        }

        public class Delete
        {
            public int ProductId { get; set; }
        }

        public class Create
        {
            public ProductDto.Create Product { get; set; }
        }
    }
}
