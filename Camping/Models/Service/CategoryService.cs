using Camping.Data;
using Camping.Models.Interface;
using Microsoft.EntityFrameworkCore;

namespace Camping.Models.Service
{
    public class CategoryService:ICategory
    {
        private readonly EcommerceDb _context;

        public CategoryService(EcommerceDb context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetAll()

        {
            return await _context.categories.ToListAsync();
        }
        public async Task<Category> GetById(int Id)

        {
            return await _context.categories.Where(x=>x.Id==Id).Include(x=>x.products).FirstOrDefaultAsync();
        }

    }
}
