using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MartyWally.SRM.Models;
using MartyWally.SRM.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MartyWally.SRM.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly ISupplierService supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var suppliers = (await supplierService.GetAll()).ToList();
            return View(suppliers);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Supplier supplier)
        {
            await supplierService.Create(supplier);
            return RedirectToAction("Index");
        }

    }
}

