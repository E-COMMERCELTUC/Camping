using Camping.Models;
using Camping.Models.Interface;
using Camping.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Camping.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }
        public async Task<IActionResult> GetAll()
        {
            var categorylist = await _category.GetAll();
            return View(categorylist);
        }
        public async Task<IActionResult> GetById(int Id)
        {
            var categorybyId = await _category.GetById(Id);
           
            CategoryProductsVM products = new CategoryProductsVM()
            {category= categorybyId, products= categorybyId.products}
                ;
            return View(products);
        }
        public async Task<IActionResult> Details(int Id)
        {
            var categorybyId = await _category.GetById(Id);

            CategoryProductsVM products = new CategoryProductsVM()
            { category = categorybyId, products = categorybyId.products }
                ;
            return View(products);
        }
    }
}
