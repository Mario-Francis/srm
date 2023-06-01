using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MartyWally.SRM.Models
{
	public class ProductDTO
	{
		public ProductDTO()
		{
		}

        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public string Name { get; set; } = default!;
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        public int QuantityInStock { get; set; }
        public DateTimeOffset DateSupplied { get; set; }
        public string SupplierName { get; set; } = default!;
        public string SupplierPhone { get; set; } = default!;

        public static ProductDTO FromProduct(Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name=product.Name,
                SupplierId = product.SupplierId,
                UnitPrice = product.UnitPrice,
                QuantityInStock = product.QuantityInStock,
                DateSupplied = product.DateSupplied,
                SupplierName = product.Supplier.Name,
                SupplierPhone = product.Supplier.ContactPhone
            };
        }
    }


}

