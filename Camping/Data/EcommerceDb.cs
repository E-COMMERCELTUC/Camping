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

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "tables & Chairs", Description="contains all the tables and chairs you need for camping " },
                new Category() { Id = 2, Name = "tents", Description = "contains all the types of tents " },
                  new Category() { Id = 3, Name = "Accessories", Description = "contains all the types of  Accessories" }
                );
            modelBuilder.Entity<Product>().HasData(
             new Product() { Id = 1, Name = "wooden table", Manufacturer="Ikea" , Spec= "size: 2*3*1.5 m, color:black , matireal= wood" ,CategoryID=1},
               new Product() { Id = 2, Name = "steel table", Manufacturer = "Ikea", Spec = "size: 2*3*1.5 m, color:silver , matireal= steel", CategoryID = 1 },

                     new Product() { Id = 3, Name = "Armor tent ", Manufacturer = "renvate", Spec = "size: 1.5*2*3 m, color:black , matireal= wool", CategoryID = 2 },
                      new Product() { Id = 4, Name = "small tent ", Manufacturer = "renvate", Spec = "size: 2*2*2 m, color:red , matireal= wool", CategoryID = 2 },

                     new Product() { Id = 5, Name = "water bottle", Manufacturer = "nike", Spec = "size: medeum, color:black , matireal= plastic", CategoryID = 3 },
                      new Product() { Id = 6, Name = "climing wear ", Manufacturer = "nike", Spec = "size: xl, color:red , matireal= cotten", CategoryID = 3 }
             );



    }





public DbSet<Category> categories { get; set; }

        public DbSet<Product> products { get; set; }


    }
}
