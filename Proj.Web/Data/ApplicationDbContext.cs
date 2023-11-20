using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Proj.DataAccess.Data
{
    public class ApplicationDbContext:IdentityDbContext//DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {

        }

        //__________________ 1. Data Seeding ____________________________
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>().HasData(
        //        new Category { CategoryId = 1 , Name ="Mobile" , DisplayOrder = 1},
        //        new Category { CategoryId = 2 , Name ="Fruites" , DisplayOrder = 2},
        //        new Category { CategoryId = 3 , Name ="Laptops" , DisplayOrder = 2},
        //        new Category { CategoryId = 4 , Name ="Electronics" , DisplayOrder = 2},
        //        new Category { CategoryId = 5 , Name ="Dry Fruites" , DisplayOrder = 2},
        //        new Category { CategoryId = 6 , Name ="Pots" , DisplayOrder = 2},
        //        new Category { CategoryId = 7 , Name ="Vegitabes" , DisplayOrder = 2}
        //    );
        //}

        //__________________ 1. Data Seeding in Seprate Class ____________________________
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //________ Identity DbContext Required This ________________
            base.OnModelCreating(modelBuilder);

        }
    }
}
