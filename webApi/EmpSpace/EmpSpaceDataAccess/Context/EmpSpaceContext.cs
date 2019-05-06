using Microsoft.EntityFrameworkCore;
using EmpSpaceDataAccess.Models;

namespace EmpSpaceDataAccess.Context
{
    class EmpSpaceContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Position> Position { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-G9UU1O5\SQLEXPRESS;Initial Catalog=EmpSpace;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
