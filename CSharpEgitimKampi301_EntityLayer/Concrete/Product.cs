using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301_EntityLayer.Concrete
{
	public class Product
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int ProductStock {  get; set; }
		public decimal ProductPrice { get; set; }
		public string ProdcutDescription { get; set; }
		public int CategoryId { get; set; } // buraya tekil ekleedik çünkü her ürünün sadece 1 ıd si olabilir
		public virtual Category Category { get; set; }
		public List<Order> Orders { get; set; }
	}
}
