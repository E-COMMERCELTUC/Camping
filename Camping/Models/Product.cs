namespace Camping.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Spec { get; set; }

        public int CategoryID { get; set; }
        public Category Categories { get; set; }

    }
}
