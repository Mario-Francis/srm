using System;
using MartyWally.SRM.Models;
using Microsoft.EntityFrameworkCore;

namespace MartyWally.SRM.Services.Implementation
{
	public class ProductService: IProductService
    {
        private readonly AppDbContext db;

        public ProductService(AppDbContext db)
		{
            this.db = db;
        }

        public async Task Create(Product product)
        {
            await db.Products.AddAsync(product);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await Task.FromResult(
                db.Products.Include(p=>p.Supplier)
                .OrderBy(p=>p.Name)
                .AsEnumerable());
        }

        public async Task<IEnumerable<Product>> GetBySupplierId(Guid supplierId)
        {
            var products = db.Products.Include(p => p.Supplier)
                .Where(p => p.SupplierId == supplierId)
                .OrderBy(p => p.Name);
                
            return await Task.FromResult(products);
        }

    }
}

