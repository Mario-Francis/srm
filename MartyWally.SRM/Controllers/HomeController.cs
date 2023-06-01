using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MartyWally.SRM.Models;
using MartyWally.SRM.Services;

namespace MartyWally.SRM.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProductService productService;

    public HomeController(ILogger<HomeController> logger, IProductService productService)
    {
        _logger = logger;
        this.productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        //await productService.Create(new Product
        //{
        //    Name = "Santa sweet apples",
        //    UnitPrice = 1.09M,
        //    QuantityInStock = 124,
        //    DateSupplied = new DateTime(2023, 05, 31),
        //    SupplierId = new Guid("25d17a63-3bec-4409-7513-08db62d93ded")
        //});
        //await productService.Create(new Product
        //{
        //    Name = "Chicken drumsticks",
        //    UnitPrice = 2.25M,
        //    QuantityInStock = 18,
        //    DateSupplied = new DateTime(2023, 04, 10),
        //    SupplierId = new Guid("25d17a63-3bec-4409-7513-08db62d93ded")
        //});
        //await productService.Create(new Product
        //{
        //    Name = "Dole Bananas",
        //    UnitPrice = 0.55M,
        //    QuantityInStock = 1097,
        //    DateSupplied = new DateTime(2023, 05, 15),
        //    SupplierId = new Guid("4b46eb49-ca21-422e-7514-08db62d93ded")
        //});
        return await  Task.FromResult(View());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

