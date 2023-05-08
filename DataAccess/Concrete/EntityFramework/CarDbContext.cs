using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarDbContext:DbContext
    {
     //projenin hangi veritabanı ile ilişkili olduğunu belirttiğimiz yer(onconfiguring)


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-FMTLGB08\SQLEXPRESS;Database=CARDB;Trusted_Connection=true;TrustServerCertificate=true");
        }
        //hangi kısmın nereye bağlanacağı,
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Category> CATEGORIES { get; set; }
        public DbSet<Rentals> Rentals { get; set; }
        public DbSet<Users> Users { get; set; }
        

    
    }
}

