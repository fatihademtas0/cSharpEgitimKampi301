using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301_EntityLayer.Concrete
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public bool CategoryStatus { get; set; }
		public List<Product> Products { get; set;} // buraya çoğul çünkü bir kategoride birden çok ürün olabilir

	}
}
