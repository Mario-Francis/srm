using System;
using MartyWally.SRM.Models;

namespace MartyWally.SRM.Services
{
	public interface ISupplierService
	{
        Task Create(Supplier supplier);

        Task<IEnumerable<Supplier>> GetAll();
    }
}

