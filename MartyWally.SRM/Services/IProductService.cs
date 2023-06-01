using System;
using MartyWally.SRM.Models;

namespace MartyWally.SRM.Services
{
	public interface IProductService
	{
        Task Create(Product product);

        Task<IEnumerable<Product>> GetAll();

        Task<IEnumerable<Product>> GetBySupplierId(Guid supplierId);
    }
}

