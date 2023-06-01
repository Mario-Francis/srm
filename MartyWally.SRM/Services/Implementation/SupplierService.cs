using System;
using MartyWally.SRM.Models;

namespace MartyWally.SRM.Services.Implementation
{
	public class SupplierService: ISupplierService
    {
        private readonly AppDbContext db;

        public SupplierService(AppDbContext db)
		{
            this.db = db;
        }

        public async Task Create(Supplier supplier)
        {
            await db.Suppliers.AddAsync(supplier);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Supplier>> GetAll()
        {
            return await Task.FromResult(db.Suppliers.AsEnumerable());
        }
	}
}

