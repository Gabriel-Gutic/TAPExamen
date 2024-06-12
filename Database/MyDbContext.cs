using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class MyDbContext : DbContext
    {
        private readonly string _windowsConnectionString = @"Server=localhost\SQLEXPRESS;Database=TAPProject;Trusted_Connection=True;TrustServerCertificate=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_windowsConnectionString);
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);

            CreateRelations(builder);

            InsertData(builder);
        }
    }
}
