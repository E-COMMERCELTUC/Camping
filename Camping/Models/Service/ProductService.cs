using Camping.Data;
using Camping.Models.DTO;
using Camping.Models.Interface;
using Microsoft.EntityFrameworkCore;

namespace Camping.Models.Service
{
    public class ProductService : IProduct
    {

        private readonly EcommerceDb _context;

        public ProductService(EcommerceDb context)
        {
            _context = context;
        }


        public async Task<List<ProductDTO>> GetAll()
        {
            return await _context.products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Spec = p.Spec,
                Manufacturer = p.Manufacturer,
                ProductCategoryName = _context.categories.FirstOrDefault(c => c.Id == p.CategoryID).Name

            }).ToListAsync();
        }


        public async Task<ProductDTO> GetById(int Id)

        {
            return await _context.products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Spec = p.Spec,
                Manufacturer = p.Manufacturer,
                ProductCategoryName = _context.categories.FirstOrDefault(c => c.Id == p.CategoryID).Name
            }).FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}
