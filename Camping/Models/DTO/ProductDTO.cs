using System.ComponentModel.DataAnnotations;

namespace Camping.Models.DTO
{
    public class ProductDTO
    {
        //
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Spec { get; set; }

        public int CategoryID { get; set; }

        [Display(Name = "Category")]
        public string ProductCategoryName { get; set; }
        public Category Categories { get; set; }
    }
}
