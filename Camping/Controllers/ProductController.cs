using Camping.Models;
using Camping.Models.DTO;
using Camping.Models.Interface;
using Camping.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Camping.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProduct _context;

        public ProductController(IProduct product)
        {
            _context = product;
        }
        public async Task<IActionResult> ProductGetAll()
        {
            List<ProductDTO> products = await _context.GetAll();
            return View(products);
        }

        public async Task<IActionResult> ProductDetails(int id)
        {
            var products = await _context.GetById(id);
            return View(products);
        }

    }
}
