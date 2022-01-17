using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сафари.Data.Models;
using Сафари.Data.Models.MaterialsModels;
using Сафари.Data.Models.UsersModels;
using Сафари.Data.Models.WorkersModels;



namespace Сафари.Data.MainData
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Workers> Workers { get; set; }
        public DbSet<UserWithWorkers> UserWithWorkers  { get; set; }     
        public DbSet<CategoryMaterials> CategoryMaterials { get; set; }
        public DbSet<UsersWithMaterials> UsersWithMaterials { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }

    }
}
