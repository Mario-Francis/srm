using MartyWally.SRM.Models;
using MartyWally.SRM.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MartyWally.SRM.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ISupplierService supplierService;
        private readonly IProductService productService;

        public ProductsController(ISupplierService supplierService, IProductService productService)
        {
            this.supplierService = supplierService;
            this.productService = productService;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var products = (await productService.GetAll()).ToList();
            return View(products);
        }

        [HttpGet("/api/product/get/supplier/{supplierId:guid}")]
        public async Task<IActionResult> GetProductsBySupplierId(Guid supplierId)
        {
            var products = await productService.GetBySupplierId(supplierId);
            var _products = products.Select(p => ProductDTO.FromProduct(p));
           
            return Ok(_products);
        }


    }
}

