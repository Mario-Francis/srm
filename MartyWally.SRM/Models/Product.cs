using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MartyWally.SRM.Models
{
	public class Product
	{
		public Product()
		{
		}

        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public string Name { get; set; } = default!;
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        public int QuantityInStock { get; set; }
        public DateTimeOffset DateSupplied { get; set; }


        public virtual Supplier Supplier { get; set; } = default!;
    }
}

