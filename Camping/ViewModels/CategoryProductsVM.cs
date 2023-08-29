using Camping.Models;

namespace Camping.ViewModels
{
    public class CategoryProductsVM
    {public Category category { get; set; }
        public List<Product>? products { get; set; }
    }
}
