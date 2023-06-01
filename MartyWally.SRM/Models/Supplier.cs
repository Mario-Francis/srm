using System;
namespace MartyWally.SRM.Models
{
	public class Supplier
	{
		public Supplier()
		{
			this.Products = new HashSet<Product>();
		}

		public Guid Id { get; set; }
		public string Name { get; set; } = default!;
        public string ContactPhone { get; set; } = default!;

		public virtual ICollection<Product> Products { get; set; }
    }
}

