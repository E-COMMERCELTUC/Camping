using Microsoft.EntityFrameworkCore;
using Camping.Models;

namespace Camping.Data
{
    public class EcommerceDb : DbContext
    {

        public EcommerceDb(DbContextOptions option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



        }


         public DbSet<Category> categories { get; set; }

        public DbSet<Product> products { get; set; }


    }
}
