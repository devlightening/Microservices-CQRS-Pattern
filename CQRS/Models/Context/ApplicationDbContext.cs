using ProductAPI.Models.Entites;

namespace ProductAPI.Models.Context
{
    public static class ApplicationDbContext
    {
        public static List<Product> ProductList { get; set; } = new();
    }
}
