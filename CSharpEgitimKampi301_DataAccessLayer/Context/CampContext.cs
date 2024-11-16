using CSharpEgitimKampi301_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301_DataAccessLayer.Context
{
	public class CampContext: DbContext
	{
        public DbSet<Category> Categories { get; set; } // dbsetin içindeki c#da kullanılacak sınıf , categories ise sqldeki tablo ismi
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
